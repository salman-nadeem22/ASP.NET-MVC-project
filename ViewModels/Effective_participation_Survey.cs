using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechProject.Models;

namespace AptechProject.ViewModels
{
    public class Effective_participation_Survey
    {
        public Effective_Participation effective { get; set; }
        public IEnumerable<Survey> survey { get; set; }
    }
}