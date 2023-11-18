using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;
using UdemyInheritance.Entities;

Product registerCommon()
{
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    return new Product(name, price);
}

Product registerUsed()
{
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
    string[] dates = Console.ReadLine().Split('/');
    DateTime date = new DateTime(int.Parse(dates[2]), int.Parse(dates[1]), int.Parse(dates[0]));
    return new UsedProduct(date, name, price);
}

Product registerImported()
{
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Customs fee: ");
    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    return new ImportedProduct(fee, name, price);
}

Console.Write("Enter the number of products:");
int num = int.Parse(Console.ReadLine());
List<Product> products = new List<Product>();
for (int i = 0; i < num; i++)
{
    try
    {
        Console.WriteLine($"Product #{i + 1} data:");
        Console.Write("Common, used or imported (c/u/i)? ");
        char op = Console.ReadLine()[0];
        switch (op)
        {
            case 'c':

                products.Add(registerCommon());

                break;
            case 'u':

                products.Add(registerUsed());

                break;
            case 'i':

                products.Add(registerImported());

                break;
            default:
                throw new Exception();
        }


    }
    catch (Exception)
    {

        throw;
    }
}

Console.WriteLine("PRICE TAGS:");
foreach (Product product in products)
{
    Console.WriteLine(product.priceTag());
}