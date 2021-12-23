using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using WebDatamaceApi.Interface;
using WebDatamaceApi.Models;
using WebDatamaceApi.Models.Entity;

namespace WebDatamaceApi.Core
{
    public class BackgroundWorkerEmail : BackgroundService
    {
        private readonly IBackgroundQueue<MailControle> _queue;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly ILogger<BackgroundWorker> _logger;

        public BackgroundWorkerEmail(IBackgroundQueue<MailControle> queue, IServiceScopeFactory scopeFactory,
            ILogger<BackgroundWorker> logger)
        {
            _queue = queue;
            _scopeFactory = scopeFactory;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("{Type} is now running in the background.", nameof(BackgroundWorker));

            await BackgroundProcessing(stoppingToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogCritical(
                "The {Type} is stopping due to a host shutdown, queued items might not be processed anymore.",
                nameof(BackgroundWorker)
            );

            return base.StopAsync(cancellationToken);
        }



        private async Task BackgroundProcessing(CancellationToken stoppingToken)
        {
            CoreDbContext _context = null;
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await Task.Delay(1000, stoppingToken);

                    MailControle mailControle = _queue.Dequeue();

                    if (mailControle == null) continue;

                    _logger.LogInformation("Controle found! Starting to process ..");

                    using (var scope = _scopeFactory.CreateScope())
                    {
                        var context = scope.ServiceProvider.GetRequiredService<CoreDbContext>();
                        var _notificationMetadata = scope.ServiceProvider.GetRequiredService<NotificationMetadata>();

                        await Task.Delay(5000, stoppingToken);
                        string text = string.Empty;

                        mailControle.IdControle = 0;
                        context.MailControle.Add(mailControle);


                        await DispararEnvioAsync(mailControle, _notificationMetadata);
                        await context.SaveChangesAsync();


                    }
                }
                catch (Exception ex)
                {
                    _logger.LogCritical("Error: " + ex.Message);
                    var stList = ex.StackTrace.ToString().Split('\\');
                    _logger.LogCritical("Exception occurred at " + stList[stList.Count() - 1]);

                    _logger.LogCritical("An error occurred when publishing a book. Exception: {@Exception}", ex);
                }
            }
        }

        private async Task DispararEnvioAsync(MailControle mailControle, NotificationMetadata _notificationMetadata)
        {
            string from = _notificationMetadata.Sender; // E-mail de remetente cadastrado no painel
            string to = mailControle.EmailDestinatario;   // E-mail do destinatário
            string user = _notificationMetadata.UserName; // Usuário de autenticação do servidor SMTP
            string pass = _notificationMetadata.Password;  // Senha de autenticação do servidor SMTP
            string conteudo = mailControle.Conteudo;
            if (!mailControle.Template.Equals("sem_template.bmp"))
            {

                using (var sr = new StreamReader("templates/" + mailControle.Template.Replace(".bmp", ".html")))
                {
                    // Read the stream as a string, and write the string to the console.
                    string templateHtml = sr.ReadToEnd();
                    if (!String.IsNullOrEmpty(templateHtml))
                    {

                        conteudo = templateHtml.Replace("{texto_noticia}", conteudo);
                    }
                }
            }



            MailMessage message = new MailMessage(from, to, mailControle.Tema, conteudo);
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient(_notificationMetadata.SmtpServer, _notificationMetadata.Port);

            //using (SmtpClient smtp = new SmtpClient(_notificationMetadata.SmtpServer, _notificationMetadata.Port))
            //{
            smtp.Credentials = new NetworkCredential(user, pass);
            await smtp.SendMailAsync(message);
        }
    }
}