using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementAppBL
{
    public class Magzine : Publication

    {
        private string _publisher;
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public Magzine(string name, int pagecount, decimal price, string publisher) : base(name, pagecount, price)
        {
            _publisher = publisher;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Publisher: {Publisher}";
        }
    }
}
