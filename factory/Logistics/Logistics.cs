using System;

namespace Factory
{
    abstract class Logistics
    {
        public abstract Transport createTransport();

        public void planDelivery() {
            Transport t = createTransport();
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