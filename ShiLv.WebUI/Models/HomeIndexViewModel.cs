using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace ShiLv.WebUI.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<News> Newlist1 { get; set; }
        public IEnumerable<Artefacts> Artefacts1 { get; set; }
        public IEnumerable<Emergencys> Emergencys1 { get; set; }
    }
}