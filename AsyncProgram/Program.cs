using System;
using System.Timers;
using System.Threading.Tasks;

namespace AsyncProgram
{    
    public class Coffee
    {
        public static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }

    public class Egg
    {
        public static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs");
            Task.Delay(3000).Wait();

            return new Egg();
        }
    }

    public class Bacon
    {
        public static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }
    }

    public class Toast
    {
        public static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        public static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        public static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }
    }

    public class Juice
    {
        public static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

    }

    class Program
    {
        static async Task Main(string[] args)
        {
            DateTime initTime = DateTime.Now;
            Console.WriteLine(initTime);

            Coffee cup = Coffee.PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = Egg.FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = Bacon.FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = Toast.ToastBread(2);
            Toast.ApplyButter(toast);
            Toast.ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = Juice.PourOJ();
            Console.WriteLine("Orange juice is ready");
            Console.WriteLine("Breakfast is ready!");

            DateTime finalTime = DateTime.Now;
            Console.WriteLine(finalTime);

            TimeSpan breakfastPreparation = finalTime.Subtract(initTime);
            Console.WriteLine($"Breakfast prepared in {breakfastPreparation.TotalSeconds} seconds.");
        }
    }
}

