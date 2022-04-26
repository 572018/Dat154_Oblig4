using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningSystem.Entities
{
    internal class Employe
    {
        public int Room { get; set; }
        public bool CheckedIn { get; set; }
        public string? Cleaning { get; set; }
        public string? Service { get; set; }
        public string? Maintenance { get; set; }

    }
}
