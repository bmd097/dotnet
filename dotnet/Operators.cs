using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    enum OperatorType {
        ARITHMETIC, RELATIONAL, BOOLEAN, BITWISE, EQUALITY
    }
    internal interface Operator
    {
        void handle();
    }
    class ArithmeticOperators : Operator
    {
        public void handle()
        {
            Console.WriteLine("1 + 2 = "+ (1+2) );
            Console.WriteLine("1 * 2 = " + (1 * 2));
            Console.WriteLine("1 - 2 = " + (1 - 2));
            Console.WriteLine("1 / 2 = " + (1 / 2));
            Console.WriteLine("1 % 2 = " + (1 % 2));
        }
    }
    class RelationalOperators : Operator
    {
        public void handle()
        {
            Console.WriteLine("1 < 2 = " + (1 < 2));
            Console.WriteLine("1 > 2 = " + (1 > 2));
            Console.WriteLine("1 <= 2 = " + (1 <= 2));
            Console.WriteLine("1 >= 2 = " + (1 >= 2));
            Console.WriteLine("1 != 2 = " + (1 != 2));
            Console.WriteLine("2 == 2 = " + (1 == 2));
        }
    }
    class BooleanOperators : Operator
    {
        public void handle()
        {
            Console.WriteLine("true && false = " + (true && false));
            Console.WriteLine("true && true = " + (true && true));
            Console.WriteLine("true || false = " + (true || false));
            Console.WriteLine("true || true = " + (true || true));
        }
    }
    class BitwiseOperators : Operator
    {
        public void handle()
        {
            Console.WriteLine("1 & 2 = " + (1 & 2));
            Console.WriteLine("1 | 2 = " + (1 | 2));
            Console.WriteLine("~2  = " + (~2));
        }
    }
    class EqualityOperators : Operator
    {
        public void handle()
        {
            Console.WriteLine("1 == 2 = " + (1 == 2));
            Console.WriteLine("2 == 2 = " + (2 == 2));
            Console.WriteLine("Hi == Hi"+("Hi" == "Hi"));
        }
    }
}
