
//week 2 lesson 2
//stała

using Warehouse;

class Program
{


    public const string FILE_NAME = @"C:\Warehouse\ImportFile.xlsx";


    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to warehouse app!");
        Console.WriteLine("Please let me know whate you want to do: ");
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Remove Item");
        Console.WriteLine("3. Check Item");
        Console.WriteLine("Press 1,2 or 3 ...");

        string operation = Console.ReadLine();

        Console.WriteLine($"You have chosen option number: {operation}");


        // zmienna

        int chosenOperation = 0;
        Int32.TryParse(operation, out chosenOperation);

        Console.WriteLine("Select item category:");
        Console.WriteLine("1. Groceery");
        Console.WriteLine("2. Clothing");
        Console.WriteLine("3. Electronics");


        string category = Console.ReadLine();
        ItemType chosenCategory;

        Enum.TryParse(category, out chosenCategory);


        string str = "napisy o dowolnej długości";
        Console.WriteLine("Select item \"category\" : \r\n1. Groceery, \r\n2. Clothing, \r\n3. Electronics ");



        //int a = 5;
        //int b = a;
        ////znienna liczbowa - stos
        //Console.WriteLine();
        //Console.WriteLine(a); // wyświetli się 5
        //Console.WriteLine(b); // wyświetli się 5  

        //b = 50;

        //Console.WriteLine(a); // wyświetli się 5
        //Console.WriteLine(b); // wyświetli się 5 

        //Item item = new Item() { Id = 1, Name = "Apple" };
        //// zmienna i obiekt item na stosie referencje, na stercie sam obiekt 
        //Item item2 = item;

        //Console.WriteLine();
        //Console.WriteLine(item.Name );
        //Console.WriteLine(item2.Name);

        //item2.Name = "Watermelon";

        //Console.WriteLine(item.Name);
        //Console.WriteLine(item2.Name);


    }

}
