namespace LibraryMangementAppBL
{
    public class Publication
    {
        private string _name;
        public string Name {  get { return _name; }
            set { _name = value; }
        }
        public int PageCount {  get; set; }
        public decimal Price { get; set; }

        public Publication(string name,int pageCount,decimal price)
        {
            _name = name;
            PageCount = pageCount;
            Price = price;
        }

        public virtual string GetDescription()
        {
            return $"Name:{Name},Pages : {PageCount},Price : {Price}";
        }
    }
}
