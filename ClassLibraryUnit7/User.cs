using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryUnit7
{
    public abstract class Person
    {
        public int Id;
        public string Name;
        public string Address;
        public string Phone;

        public Person (int id, string Name, string Address, string phone)
        {
            this.Id = id;
            this.Name = Name;
            this.Address = Address;
            this.Phone = phone;
        }


    }

    public class Customer : Person
    {
        private string login;
        public string password;

        public Customer(int id, string Name, string Address, string phone, string Login, string Pass):base(id, Name, Address, phone)
        {
            this.login = Login;
            this.password = Pass;
        }
        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length < 3)
                { Console.WriteLine("Логин должен быть длиной от 3 символов"); }
                else
                { login = value; }
            }
        }

        public string Password { get; set; }
        
    }


    class Employee : Person
    {
        public string Post;
        public static int HourWook = 8;

        public Employee(int id, string Name, string Address, string phone, string Post) : base(id, Name, Address, phone)
        {
            this.Post = Post;
        }
        
    }


}
