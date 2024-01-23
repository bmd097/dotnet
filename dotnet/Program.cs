using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Earth!");
            Dictionary<OperatorType, Operator> strategies = new Dictionary<OperatorType, Operator>();
            strategies.Add(OperatorType.ARITHMETIC,new ArithmeticOperators());
            strategies.Add(OperatorType.RELATIONAL,new RelationalOperators());
            strategies.Add(OperatorType.BOOLEAN,new BooleanOperators());
            strategies.Add(OperatorType.BITWISE,new BitwiseOperators());
            strategies.Add(OperatorType.EQUALITY,new EqualityOperators());
            foreach (OperatorType operatorType in Enum.GetValues(typeof(OperatorType)))
                if (strategies.ContainsKey(operatorType))
                {
                    Console.WriteLine(operatorType);
                    strategies[operatorType].handle();
                }
            Console.ReadLine();
        }
    }
}
