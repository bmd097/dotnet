using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace basics {
    internal class Program {

        static void testMethod(String name,int age) {
            Console.WriteLine(name+age);
        }
        static void testMethodChanger(ref int age) {
            Console.WriteLine(age++);
        }
        static void printSomething(String name="Hello EPAM!") {
            Console.WriteLine(name);
        }
        static void printAnything(dynamic obji) {
            Console.WriteLine(obji);
        }
        static int findSum(params int[] arr) {
            int sum = 0;
            foreach (int i in arr) {
                sum += i;
            }
            return sum;
        }
        static void testMethod2(out int age) {
            age = 19;
        }
        static void testMethod3(in int age) {
            
        }

        static void Main(string[] args) {
            Console.WriteLine("Hello!");
            Car car = new Car(818,"BMW","It's a machine with 4 wheels.");
            Console.WriteLine(car);
            Console.WriteLine(car+car);
            List<Car> list = new List<Car>();
            list.Add(car);
            list.Add(car+car);
            Console.WriteLine("Items >> ");
            foreach(Car carr in list) {
                Console.WriteLine(carr);
            }
            int a = 10;
            object b = 10; // boxing
            int c = (int)b; // unboxing

            // Parameter types
            testMethod("jdnck,d", 78); // Value Parameters
            testMethod(age : 78, name: "dcndk"); // Named Parameters
            int z = 7;
            testMethodChanger(ref z); // Ref Parameters
            Console.WriteLine(z);
            printSomething(); // optional / default paramters
            printAnything(10); // dynamic Parameters
            printAnything("String ho!"); // dynamic Parameters
            Console.WriteLine(findSum(1, 2, 3, 4, 5)); // Params 
            testMethod2(out z);
            Console.WriteLine(z);
            testMethod3(in z);

            Async.main(args: new string[] { });

            using(DisposableUsingEx d = new DisposableUsingEx()) {
                Console.WriteLine("TRAIN");
                Thread.Sleep(1000);
                Console.WriteLine("RABBIT");
            }

            String s = "Abby";
            Console.WriteLine(Object.ReferenceEquals(s,"Abby"));
            Console.WriteLine(Object.ReferenceEquals(s,new String("Abby".ToCharArray())));

            EventsAndDelegates.test(args: new string[] { });

            Console.ReadLine();
        }
    }
}
