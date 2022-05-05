using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threadstart_handson
{
    class Program
    {
        /* static void Main(string[] args)
         {
             Thread t1 = new Thread(DisplayNumbers); 
             t1.Start();


             Threadstart obj = new Threadstart(DisplayNumbers);
             Thread t1 = new Thread(obj);
             t1.Start();
             obj();
             Console.Read();
         }

         static void DisplayNumbers()
         {
             for (int i = 1; i <= 5; i++)
             {
                 Console.WriteLine("Method " + i);
             }
         }*/




        class DisposableEg : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Releasing all Resources..");
            }

            public void DoSomething()
            {
                Console.WriteLine("Using Various Resources..");
            }

            public DisposableEg()
            {
                Console.WriteLine("Allocating various Resources...");
            }
            static void Main()
            {
                //eg 1.
                //string multilines = @"This is line no 1.
                //This is line 2 
                //Here is line 3
                // There goes line 4
                //  This is the final and fifth line";

                //using (var reader = new StringReader(multilines))
                //{
                //    string item;
                //    do
                //    {
                //        item = reader.ReadLine();
                //        Console.WriteLine(item);
                //    } while (item != null);
                //}

                ////eg 2
                //using(var sreader= new StreamReader("E:\\Banu\\Zensar\\Batch 2\\firstgitdata.txt") )
                //{
                //    Console.WriteLine(sreader.ReadToEnd());
                //}

                ////eg 3 using try finally which is equivalent to using block with some coding
                //var streader = new StreamReader(@"E:\Banu\Zensar\Batch 2\firstgitdata.txt");
                //try
                //{
                //    Console.WriteLine(streader.ReadToEnd());
                //}
                //finally
                //{
                //    if (streader != null)
                //        streader.Dispose();
                //}

                //eg 4 using IDisposable interface
                using (var dispeg = new DisposableEg())
                {
                    dispeg.DoSomething();
                }

                Console.Read();
            }
        }
    }
}


