using System;
using static ClassLibraryUnit7.Delivery;


namespace ClassLibraryUnit7
{
    public class Order<TNum, TDel> where TDel:Delivery
    {
        protected TNum Number { get; }
        protected Customer OCustomer;
        public string Description;
        public string Phone;
        public string Address;
        public Product product;
        public TDel Delivery;

       
        public Order(TNum id, Customer customer, string description, string phone, string Address, Product product, TDel Delivery)
        {
            this.Number = id;
            this.OCustomer = customer;
            this.Description = description;
            this.Phone = phone;
            this.Address = Address;
            this.product = product;
            this.Delivery = Delivery;
        }

        public void CustNameAndAdressOnConcole()
        {
            Console.WriteLine("Адрес: " + this.Address + "\nПокупатель: " + this.OCustomer.Name);
        }
    }

   
}
