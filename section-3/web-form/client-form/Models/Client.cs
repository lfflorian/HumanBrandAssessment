using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace client_form.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string DPI { get; set; }
        public DateTime Fecha { get; set; }

    }
}