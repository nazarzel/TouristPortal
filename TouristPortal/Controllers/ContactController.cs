using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TouristPortal.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TouristPortal.Controllers
{
    public class ContactController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            try { 
                NetworkCredential loginInfo = new NetworkCredential("tourist@tourist.com", "tourist");//informacja zmieniona
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("tourist@tourist.com");//informacja zmieniona
                msg.To.Add(new MailAddress("tourist@tourist.com"));//informacja zmieniona
                msg.Subject = "Prośba o kontakt";
                msg.Body = "Otrzymano prośbę o kontakt od użytkownika " + contact.Name + "\nJego email: " + contact.Email + "\nWiadomość:" + contact.Message;
                msg.IsBodyHtml = false;
                SmtpClient client = new SmtpClient("mail.cba.pl", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = loginInfo;
                client.Send(msg);
                TempData["Success"] = "Twoja wiadomość została wysłana";
                ModelState.Clear();
            } 
            catch
            {
                TempData["Error"] = "Nieoczekiwany błąd. Spróbuj ponownie";
            }

            return View();
        }
    }
}
