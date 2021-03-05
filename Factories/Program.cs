using System.Threading.Tasks;
using static System.Console;

namespace Factories
{
    public class Foo
    {
        private Foo()
        {
            //
        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        // factory method
        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            //var foo = new Foo();
            //await foo.InitAsync();
            Foo x = await Foo.CreateAsync();
        }
    }
}
