using System;

namespace Factory
{
    public interface Transport {
        void Deliver();
    }

    public class Truck : Transport {
        public void Deliver() {
            Console.WriteLine("Delivered with truck");
        }
    }

    public class Ship : Transport {
        public void Deliver() {
            Console.WriteLine("Delivered with ship");
        }
    }
}