// See https://aka.ms/new-console-template for more information
using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter item : ");
            string item1 = Console.ReadLine();

            Console.Write("enter Price (note: price should be above 50) : ");
            int price = Convert.ToInt32(Console.ReadLine());

            if (price <= 50)
            {
                Console.WriteLine("Incorrect amount");
            }
            else
            {
                int discount = price - (5 / 100) * price;
                int GST = (5 / 100) * price;
                int Fprice = price - 15 + 45;
                Console.WriteLine("Final Price = " + Fprice + " (applied GST)");

                Console.Write("Would you like to buy another item(type yes or no): ");
                string ys = Console.ReadLine();
                if (ys == "yes")
                {
                    Console.Write("enter item : ");
                    string item2 = Console.ReadLine();
                    if (item2 == item1)
                    {
                        Console.WriteLine("already in cart");
                    }
                    else
                    {
                        Console.Write("enter Price (note: price should be above 50) : ");
                        int price2 = Convert.ToInt32(Console.ReadLine());

                        if (price2 < 50)
                        {
                            Console.WriteLine("Incorrect amount");
                        }
                        else
                        {
                            int discount1 = price2 - (5 / 100) * price2;
                            int GST1 = (5 / 100) * price2;
                            int Fprice2 = price2 - 15 + 45;
                            Console.WriteLine("Final Price = " + Fprice2);
                            Console.WriteLine("Would you like to buy items for " + (Fprice + Fprice2));
                            string ys1 = Console.ReadLine();
                            if (ys1 == "yes")
                            {
                                Console.WriteLine("Thank you for purchasing ");
                            }
                            else
                            {
                                Console.WriteLine("Purchase canceled");
                            }
                        }
                    }
                }
                else
                {
                    Console.Write("Would you like to buy item for " + Fprice + " : ");
                    string ys1 = Console.ReadLine();

                    if (ys1 == "yes")
                    {
                        Console.WriteLine("Thank you for purchasing ");
                    }
                    else
                    {
                        Console.WriteLine("Purchase canceled");
                    }
                }

            }



        }

    }

}