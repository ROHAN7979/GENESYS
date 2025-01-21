using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementAppBL
{
    public class Book : Publication
    {
        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public Book (string name,int pagecount,decimal price,string author):base(name,pagecount,price)
        {
            _author = author;
        }
        public override string GetDescription()
        {
            return base.GetDescription()+ $",Author : {Author}";

        }
    }
}
