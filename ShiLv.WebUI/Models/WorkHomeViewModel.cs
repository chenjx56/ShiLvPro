using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace ShiLv.WebUI.Models
{
    public class WorkHomeViewModel
    {
        public IEnumerable<Artefacts> HandArtefacts { get; set; }
        public IEnumerable<Artefacts> AnimalArtefacts { get; set; }
        public IEnumerable<Artefacts> NatureArtefacts { get; set; }
        public IEnumerable<UserInfo> UserInfo { get; set; }
    }
}