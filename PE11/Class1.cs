using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PE11
{
    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }
    }

    public abstract class Car : Vehicle
    {

    }

    public abstract class Train : Vehicle
    {

    }

    public interface IPassengerCarrier
    {
        void LoadPassenger()
        {

        }
    }

    public interface IHeavyLoadCarrier
    {
    }

    public abstract class Compact : Car, IPassengerCarrier
    {

    }

    public abstract class SUV : Car, IPassengerCarrier
    {

    }
    public abstract class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {

    }
    public abstract class PassengerTrain : Train, IPassengerCarrier
    {

    }
    public abstract class FreightTrain : Train, IHeavyLoadCarrier
    {

    }
    public abstract class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }
}
