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

        public static Coffee PourCoffeeAsync()
        {
            Console.WriteLine("Pouring coffee Asynchronously");
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

        public static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan Asynchronously...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs");
            await Task.Delay(3000);

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

        public static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan Asynchronously");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
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

        public static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster Asynchronously");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
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

        public static Juice PourOJAsync()
        {
            Console.WriteLine("Pouring orange juice Asynchronously");
            return new Juice();
        }

    }

    class Program
    {
        static async Task Main(string[] args)
        {
            DateTime initTime = DateTime.Now;
            Console.WriteLine(initTime);

            Task<Egg> eggsTask = Egg.FryEggsAsync(2);
            Task<Bacon> baconTask = Bacon.FryBaconAsync(3);
            Task<Toast> toastTask = Toast.ToastBreadAsync(2);

            Coffee cup = Coffee.PourCoffeeAsync();
            Console.WriteLine("coffee is ready");
            
            Egg eggs = await eggsTask;
            Console.WriteLine("eggs are ready");
            
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");
            
            Toast toast = await toastTask;
            Toast.ApplyButter(toast);
            Toast.ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = Juice.PourOJAsync();
            Console.WriteLine("Orange juice is ready");
            Console.WriteLine("Breakfast is ready!");

            DateTime finalTime = DateTime.Now;
            Console.WriteLine(finalTime);

            TimeSpan breakfastPreparation = finalTime.Subtract(initTime);
            Console.WriteLine($"Breakfast prepared in {breakfastPreparation.TotalSeconds} seconds.");
        }
    }
}

