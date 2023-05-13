using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_project
{
    class Program
    {
        static void Main(string[] args)
        {
            store[] s = new store[10];
            string rec;
            int count = 0;
            do
            {
                Console.Clear();
                rec = menu();
                if (rec == "1")
                {
                    if(count==10)
                    {
                        Console.Clear();
                        Console.WriteLine("Not enough space!!!!");
                    }
                    else
                    {
                        Console.Clear();
                        s[count]=addProduct();
                        count++;
                    }
                }
                else if (rec == "2")
                {
                    if(count==0)
                    {
                        Console.Clear();
                        Console.WriteLine("Nothig to show!!!!");
                    }
                    else
                    {
                        Console.Clear();
                        showproducts(s, count);
                        Console.ReadKey();
                    }
                }
                else if (rec == "3")
                {
                    Console.Clear();
                    int receive;
                    receive = totalProduct(s, count);
                    Console.WriteLine("Total sale is :{0} ", receive);
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    break;
                }

            } while (rec == "1" || rec == "2" || rec == "3");
            Console.WriteLine("Invalid input!!!!");
            Console.ReadKey();
        }
        static string menu()
        {
            string option;
            Console.WriteLine("Add produt!!!!");
            Console.WriteLine("Show products!!!!");
            Console.WriteLine("Show sales!!!!");
            option = Console.ReadLine();
            return option;
        }
        static void showproducts(store[]s2,int count)
        {
            for(int i =0; i<count;i++)
            {
                Console.WriteLine("Name:{0},Code:{1},Price:{2},Sale:{3}",s2[i].productName,s2[i].code,s2[i].price,s2[i].sale);
            }
            Console.ReadKey();
        }
         static store addProduct()
        {
            store s1 = new store();
            Console.WriteLine("Add product name!!!!");
            s1.productName = Console.ReadLine();
            Console.WriteLine("Add code of product!!!!");
            s1.code = Console.ReadLine();
            Console.WriteLine("Add price of product!!!!");
            s1.price = Console.ReadLine();
            Console.WriteLine("Add sale of the product!!!!");
            s1.sale = int.Parse(Console.ReadLine());
            return s1;
        }
        static int totalProduct(store[]s,int count)
        {
            int total=0;
            for(int i =0; i<count;i++)
            {
                total=total+s[i].sale;
            }
            return total;
        }
    }
}
