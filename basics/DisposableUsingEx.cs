using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics {
    internal class DisposableUsingEx : IDisposable {
        public void Dispose() {
            Console.WriteLine("Ho Ho Disposed!");
        }
    }
}
