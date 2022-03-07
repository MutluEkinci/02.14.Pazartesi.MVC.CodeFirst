using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models.ViewModel
{
    public class Film_VM
    {
        public Film Film { get; set; }
        public SelectList Turler { get; set; }
        public SelectList Kaliteler { get; set; }
        public SelectList Kareler { get; set; }

    }
}