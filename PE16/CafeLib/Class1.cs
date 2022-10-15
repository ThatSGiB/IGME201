using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        byte sugar;
        public string customer;
        public byte amount;
        public void AddSugar(byte amount)
        {

        }

        public void Steam()
        {

        }
    }

    public interface IMood
    {
        public string Mood;
    }

    public interface ITakeOrder
    {
        public void TakeOrder()
        {

        }
    }

    public class Waiter: IMood
    {
        public string name;

        public void ServeCustomer()
        {
            
        }

    }

    public class Customer: IMood
    {
        public string name;
        public string creditCardNumber;
    }

    public class CupOfCoffee: HotDrink, ITakeOrder
    {
        public string beanType;

        public Object Steam()
        {
            return beanType;
        }

        public void TakeOrder()
        {

        }
    }

    public class CupOfTea: HotDrink, ITakeOrder
    {
        public string leafType;

        public Object Steam()
        {
            return leafType;
        }

        public void TakeOrder()
        {
            
        }

        public bool customerIsWealthy;
    }

    public class CupOfCocoa: HotDrink, ITakeOrder
    {
        public int numCups;
        public bool marshmallows;
        string source;

        public string Source;
        public Object Steam()
        {
            return source;
        }

        

        public Object AddSugar()
        {
            
            return HotDrink.amount;
        }

        public void TakeOrder()
        {

        }
    }
}
