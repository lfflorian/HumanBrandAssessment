using client_form.Models;
using client_form.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace client_form.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            ClientService service = new ClientService();
            var clients = service.GetClients();
            ViewBag.Clients = clients;
            return View();
        }
        public ActionResult Delete(int id)
        {
            ClientService service = new ClientService();
            service.deleteClient(id);
            return RedirectToAction("Index");
        }
    }
}