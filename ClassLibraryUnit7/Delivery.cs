using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryUnit7
{
    public abstract class Delivery
    {
        public string Address;

        public Delivery (string Address)
            {
            this.Address = Address;
              }


        public virtual void DisplayAddress()
        {
            Console.WriteLine("Адрес: " +this.Address);
        }
    }

    class HomeDelivery : Delivery
    {
        protected Employee employee { get; }
        public DateTime DateDelivery;

        public HomeDelivery(string Address, Employee employee, DateTime DateDelivery) : base( Address)
        {
            this.employee = employee;
            this.DateDelivery = DateDelivery;
        }

        public override void DisplayAddress()
        {
            Console.WriteLine("Адрес: "+this.Address +"\n Курьер: "+ this.employee +"\n Время доставки: " + DateDelivery);
        }
    }

    class PickPointDelivery<T> : Delivery 
    { 
        protected T NumberPickPoint;
        protected int DaySave;

        public PickPointDelivery(string Address, T pickPoint, int Daysave) : base(Address)
        {
            this.NumberPickPoint = pickPoint;
            this.DaySave = Daysave;
        }

        public override void DisplayAddress()
        {
            Console.WriteLine("Адрес: " + this.Address + "\n Точка доставки: " + this.NumberPickPoint);
        }
    }

    class ShopDelivery : Delivery 
    {
        protected int DaySave;
        public ShopDelivery(string Address, int Daysave) : base(Address)
        {
            this.DaySave = Daysave;
        }

        public override void DisplayAddress()
        {
            Console.WriteLine("Адрес: " + this.Address + "\n Срок хранения " + this.DaySave + " дней.");
        }
    }


}
