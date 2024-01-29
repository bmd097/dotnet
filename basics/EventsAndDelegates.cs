using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics {
    internal class EventsAndDelegates {
        public delegate void doSomething(int a);
        public event doSomething doSomethingEvent;

        public static void someMethod(int xyz) {
            Console.WriteLine(xyz);
        }

        public void ExampleMethod(doSomething doSomethingMethod) {
            doSomethingMethod(234566666);
        }

        public static void test(string[] args) {
            EventsAndDelegates events = new EventsAndDelegates();
            events.doSomethingEvent += someMethod;
            events.doSomethingEvent(2345);
            events.doSomethingEvent?.Invoke(680);
            events.ExampleMethod((s) => { // Anonymous Method
                   Console.WriteLine(s);
            });
            events.ExampleMethod(EventsAndDelegates.someMethod); // only this callback
            events.ExampleMethod(events.doSomethingEvent); // it will call this event 
                                                           // means all callbacks subscribed will be called
            Func<int, int, int> someMethodInternal = (a, b) => {
                return a + b;
            };
            Console.WriteLine(someMethodInternal(10, 28));
        
        }
    }
}
