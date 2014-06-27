using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF
            Console.WriteLine("Begin IF examples");

            var x = true;

            if (x)
            {
                Console.WriteLine("X is true");
            }

            x = false;

            if (!x)
            {
                Console.WriteLine("X is NOT true");
            }

            var y = 5;

            if (y == 5)
            {
                Console.WriteLine("y is equal to 5");
            }
            else
            {
                Console.WriteLine("y is NOT equal to 5");
            }

            y = 3;

            if (y == 5)
            {
                Console.WriteLine("Y is equal to 5");
            }
            else if (y == 3)
            {
                Console.WriteLine("Y is equal to 3");
            }
            else
            {
                Console.WriteLine("Y is not equal to 3 or 5");
            }

            Console.WriteLine();
            
            //Switch
            Console.WriteLine("Begin SWITCH examples");

            y = 3;
            switch (y)
            {
                case 1:
                    Console.WriteLine("Y is equal to 1");
                    break;
                case 2:
                    Console.WriteLine("Y is equal to 2");
                    break;
                case 3:
                    Console.WriteLine("Y is equal to 3");
                    break;
                case 4:
                    Console.WriteLine("Y is equal to 4");
                    break;
                case 5:
                    Console.WriteLine("Y is equal to 5");
                    break;
                default:
                    Console.WriteLine("Y is not 1, 2, 3, 4 or 5");
                    break;
            }

            Console.WriteLine();

            //For loops
            Console.WriteLine("Begin FOR loop examples");
            Console.WriteLine("Forwards...");
            for (var idx = 0; idx <= 10; idx++ ) // remember; idx++ is the same as idx = idx + 1
            {
                Console.WriteLine("Current number is " + idx);
            }

            Console.WriteLine();
            Console.WriteLine("Backwards...");
            for (var idx = 10; idx >= 0; idx--)
            {
                Console.WriteLine("Current number is " + idx);
            }

            Console.WriteLine();
            Console.WriteLine("By threes....");
            for (var idx = 0; idx <= 15; idx = idx + 3)
            {
                Console.WriteLine("Current number is " + idx);
            }

            //ForEach
            Console.WriteLine();
            Console.WriteLine("Begin ForEach examples");

            //with strings...
            var list = new List<string>();
            list.Add("Fred");
            list.Add("Wilma");
            list.Add("Barney");
            list.Add("Betty");
            list.Add("Pebbles");
            list.Add("Bam Bam");
            list.Add("Dino");

            Console.WriteLine();
            Console.WriteLine("Meet the Flintones...");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            //With classes - see the Widget class at the bottom of this file
            var widgets = new List<Widget>();
            widgets.Add(new Widget { Id = 1 });
            widgets.Add(new Widget { Id = 2 });
            widgets.Add(new Widget { Id = 3 });
            widgets.Add(new Widget { Id = 4 });
            widgets.Add(new Widget { Id = 5 });

            foreach (var widget in widgets)
            {
                var widgetName = widget.WhoAmI();
                Console.WriteLine("Current widget Id: " + widgetName);
            }
            
            //Do examples
            Console.WriteLine();
            Console.WriteLine("Begin DO loop examples");

            var counter = 0;

            do
            {
                Console.WriteLine("Doing stuff...");
                counter++;

            } while (counter < 5);

            Console.WriteLine();
            //Remember; with the Do loop you are guaranteed that your loop will
            //execute AT LEAST once
            counter = 0;

            do
            {
                Console.WriteLine("Do Stuff"); //This happens first

            } while (counter != 0); //then the condition is evaluted

            //While
            Console.WriteLine();
            Console.WriteLine("Beging While examples");

            counter = 0;

            while (counter < 5)
            {
                Console.WriteLine("Doing stuff...");
                counter++;

            }

            Console.WriteLine();
            //Remember; with the WHILE loop you are NOT guaranteed that your loop will
            //execute AT LEAST once
            counter = 0;

            while (counter != 0) // The condition is evaluted first
            {
                Console.WriteLine("Do Stuff"); //This ONLY happens if the condition is true

            } 




                Console.ReadKey();
        }
    }

    public class Widget
    {
        public int Id { get; set; }

        public int WhoAmI()
        {
            return Id;
        }
    }
}
