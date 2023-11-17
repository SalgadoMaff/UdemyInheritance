using System.Globalization;
using UdemyInheritance.Entities;

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
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        switch (op)
        {
            case 'c':
                
                //constructor

                break;
            case 'u':
                Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                string[] dates = Console.ReadLine().Split('/');
                DateTime date = new DateTime(int.Parse(dates[2]), int.Parse(dates[1]), int.Parse(dates[0]));

                //constructor
                break;
            case 'i':
                Console.Write("Customs fee: ");
                double fee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                //constructor
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
//pricetag()