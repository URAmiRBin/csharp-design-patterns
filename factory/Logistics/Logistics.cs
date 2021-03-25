using System;

namespace Factory
{
    abstract class Logistics
    {
        private Transport t;
        public abstract Transport createTransport();

        public void planDelivery() {
            this.t = createTransport();
        }

        public void Deliver() {
            t.Deliver();
        }
    }

    class RoadLogistics : Logistics {
        public override Transport createTransport()
        {
            return new Truck();
        }
    }

    class SeaLogistics : Logistics {
        public override Transport createTransport()
        {
            return new Ship();
        }
    }    
}