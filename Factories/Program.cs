using System.Threading.Tasks;
using static System.Console;

namespace Factories
{
    public class Foo
    {
        public Foo()
        {
            
        }

        public async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            var foo = new Foo();
            await foo.InitAsync();
        }
    }
}
