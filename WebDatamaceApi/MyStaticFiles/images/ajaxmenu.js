
var xmlHttp;function showUser(str)
{ 
xmlHttp=GetXmlHttpObject();
if (xmlHttp==null)
 {
 alert ("Browser does not support HTTP Request");
 return;
 }
var url=str;
document.getElementById("paginas").innerHTML="<img src='images/carregando.gif' border='0'>";
//alert(url.length);
//alert(url);
if(url.length<20){
	if(url=="Empresas.asp"){
		url=url+"?absolutePage=1";
	}
	else{
		url=url+"?absolutePage=1";
	}
}	
url=url+"&sid="+Math.random();
xmlHttp.onreadystatechange=stateChanged;
xmlHttp.open("GET",url,true);
xmlHttp.send(null);
}function stateChanged() 
{ 
if (xmlHttp.readyState==4 || xmlHttp.readyState=="complete")
 { 
 document.getElementById("paginas").innerHTML=xmlHttp.responseText;
 } 
}function GetXmlHttpObject()
{
var xmlHttp=null;
try
 {
 // Firefox, Opera 8.0+, Safari
 xmlHttp=new XMLHttpRequest();
 }
catch (e)
 {
 //Internet Explorer
 try
  {
  xmlHttp=new ActiveXObject("Msxml2.XMLHTTP");
  }
 catch (e)
  {
  xmlHttp=new ActiveXObject("Microsoft.XMLHTTP");
  }
 }
return xmlHttp;
}