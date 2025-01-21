using LibraryMangementAppBL;

internal class Program
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Enter the name of Book : ");
        string name=Console.ReadLine();
        Console.Write("Enter the PageCount : ");
        int pagecount=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the price : ");
        decimal price=Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter the publisher : ");
        string publish = Console.ReadLine();
        Magzine obj1 = new Magzine(name,pagecount,price,publish);
        Console.WriteLine("\n\t Magzine Details ");
        Console.WriteLine(obj1.GetDescription());

        Console.WriteLine("Enter the name of Magzine : ");
        string namemagzine = Console.ReadLine();
        Console.Write("Enter the PageCount : ");
        int pagecountmagzine = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the price : ");
        decimal pricemagzine = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter the Author : ");
        string author = Console.ReadLine();
        Book book1 = new Book(namemagzine, pagecountmagzine, pricemagzine, author);
        Console.WriteLine("\n\t Book Details ");
        Console.WriteLine(obj1.GetDescription());

    }
}