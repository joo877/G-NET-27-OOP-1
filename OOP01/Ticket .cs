using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal class Ticket
    {

        public string MovieName { get; set; }
        public Type Ticket_Type { get; set; }
        public Seat Seat_location { get; set; }

        private double _price;

        public Ticket(string Name , Type type , Seat seat , double price   )
        {
            MovieName= Name;
            Ticket_Type= type;
            Seat_location= seat;
            _price= price;

        }

       private static Seat defult = new Seat('A',1);
        public Ticket(string Name) : this(Name, Type.Standard, defult, 50)
        {
        }


        //another way to write the constructor without using static variable
        //   public Ticket(string Name) : this( Name, Type.Standard,  new Seat { Row = 'A', Number = 1 } , 50)
        //{
        //}

        public double CalcTotal()
        {
            double taxPercent = 14;
            double totalPrice =  _price + (_price * taxPercent / 100);
            return totalPrice;
        }
        public void ApplyDiscount(double discountAmount  )
        {
            if (discountAmount > 0 && discountAmount < _price )
            {
                
                double currentPrice = _price - discountAmount; 
                Console.WriteLine($"Discount Before : {discountAmount}");
                discountAmount = 0.00;
                Console.WriteLine($"Discount After   : {discountAmount}");

                Console.WriteLine($"Movie    : {MovieName}");
                Console.WriteLine($"Type : {Ticket_Type}");




            }



        }

        public void PrintTicket()
        {

            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {Ticket_Type}");
            Console.WriteLine($"Seat     : {Seat_location.Row}{Seat_location.Number}");
            Console.WriteLine($"Price    : {_price}");
            Console.WriteLine($"Total (14% tax)  : {CalcTotal()}");
            




        }


    }
}
