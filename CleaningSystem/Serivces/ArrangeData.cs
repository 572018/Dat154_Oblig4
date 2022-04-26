using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningSystem.Serivces
{
    internal class ArrangeData
    {

        List<Service> _Services;

        public ArrangeData(List<Service> Services)
        {
            _Serivces = Services;
        }

        public List<Service> _Serivces { get; }

        public List<Service> Cleaning()
        {
            foreach(var item in _Services)
            {
                item.Description = item.Cleaning;
            }
            return _Serivces;
        }
    }
}
