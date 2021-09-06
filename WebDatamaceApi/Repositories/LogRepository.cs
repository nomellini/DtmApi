using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDatamaceApi.Models;

namespace WebDatamaceApi.Repositories
{
    public class LogRepository
    {
        private readonly CoreDbContext _context;

        public LogRepository(CoreDbContext context)
        {
            _context = context;
        }


        public void InserLog(int idUsuario, string log)
        {
            try
            {
                CurUsuariosLog curUsuariosLog = new CurUsuariosLog()
                {
                    DataLog = DateTime.UtcNow,
                    Log = log,
                    CurUsuariosIdUsuario = idUsuario
                };

                _context.CurUsuariosLog.Add(curUsuariosLog);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
