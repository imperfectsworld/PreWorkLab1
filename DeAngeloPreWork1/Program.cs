using System;

public class deliverable1
{

    public static void Main()
    {
        //Variables

        int soda = 100;
        int chips = 40;
        int candy = 60;

        int restock_soda = 40;
        int restock_chips = 20;
        int restock_candy = 40;


        Console.WriteLine("Welcome to the restocking tool.");

        //Soda

        Console.WriteLine("How many sodas have been sold today? Current Stock is: " + soda);
        soda = soda - int.Parse(Console.ReadLine());
        if (soda < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted!");
            soda = 100;
        }
        else
        {
            Console.WriteLine("There are " + soda + " sodas left in stock");
        }

        //Chips

        Console.WriteLine("How many chips have been sold today? Current Stock is: " + chips);
        chips = chips - int.Parse(Console.ReadLine());
        if (chips < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted!");
            chips = 40;
        }
        else
        {
            Console.WriteLine("There are " + chips + " sodas left in stock");
        }


        //Candy

        Console.WriteLine("How many candy have been sold today? Current Stock is: " + candy);
        candy = candy - int.Parse(Console.ReadLine());
        if (candy < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted!");
            candy = 60;
        }
        else
        {
            Console.WriteLine("There are " + candy + " sodas left in stock");
        }

        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");


        //Soda restock

        if (soda <= restock_soda)
            {
            Console.WriteLine("Soda needs to be restocked Now!!!");
            }

        else
            {

            }

        // Chips restock

        if (chips <= restock_chips)
        {
            Console.WriteLine("Chips needs to be restocked Now!!!");
        }

        else
        {

        }
        // Candy Restock

        if (candy <= restock_candy)
        {
            Console.WriteLine("Candy needs to be restocked Now!!!");
        }

        else
        {

        }
    }
}

