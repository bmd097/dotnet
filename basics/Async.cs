using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace basics {
    internal class Async {
        
        public static async Task doSomething() {
            await Task.Delay(2000);
            Console.WriteLine("Yo");
        }

        public static async Task<int> doReturnSomething() {
            await Task.Delay(5000);
            Console.WriteLine("Yo");
            return 10;
        }

        public static async void main(string[] args) {
            Console.WriteLine("Hello");
            doSomething();
            Console.WriteLine("EPAM!");
            int res = await doReturnSomething();
            Console.WriteLine(res);
            Console.WriteLine("Hydrabad!");
        }
    }
}
