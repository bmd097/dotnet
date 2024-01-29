using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics {
    internal class Car {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }

        public Car(int id,String name,String desc) {
            this.Id = id;
            this.Name = name;
            this.Description = desc;
        }

        public override string ToString() {
            return String.Concat(Id," ", Name, " ",Description);
        }

        public static Car operator + (Car A,Car B) {
            return new Car(238, "ROME", "Its a car!");
        }
    }
}
