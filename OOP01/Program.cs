using System.Diagnostics.Metrics;

namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region part01
            #region Q1
            /*
                 calss                                           VS                            struct
            1. reference type                                                                value type
            2. supports inheritance                                                  does not support inheritance
            3.using to represent complex data types                                  using to represent simple data types
            4. access modifire with calss members ,                                   access modifire with struct members 
            (public, private, protected, internal,                                      (public, private, internal.)
            protected internal, private protected.)

             */
            #endregion
            #region Q2
            /*
             public                                              Vs                             private
            1. accessible from anywhere in the program.                            1. accessible only where it is defined.
                                                                 EX:
             class MyClass{                                                           calss MyClass{
                                                                                        
            public int slalary;                                                    private int salary ;                                        
            can be accessed from anywhere in the program                         can only be accessed within the MyClass class.
            }                                                                     }
             
             */
            #endregion

            #region Q3
            /*
            1- create new project with type (class library ) , create  datatypes in this project which you want to use in another project
            2- make sure access modifire of the datatypes is public to be able to use it in another project. (by defualt internal)
            3- build it to generate dll file. 
            4- create new project with type (console application ) and add reference to the first project (class library ) to use its datatypes in this project.
            5- must import the namespace of calss library project in console application project to be able to use its datatypes,
            by using (using (namespaceName of   calss library ); ) at the top of the console application project.
             
             */
            #endregion
            #region Q4
            /*
             A Class Library is a separate project that contains reusable classes,
            but has no Main method and cannot run on its own. It compiles into a .dll file 
            class library is used to create reusable code that can be shared across multiple projects. (conseder toolbox)
             
            make code more organized and reusable, and it allows you to share code across multiple projects without duplicating it.
            if you modify the code in the class library, you only need to update it in one place, 
            and all projects that reference it will automatically use the updated version when they are recompiled. (Maintenance )
             */
            #endregion
            #endregion

            #region part02
            //Console.Write("Enter Movie Name: ");
            //string movieNameInput = Console.ReadLine();

            //Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ):");
            //Type Ticket_type_input = (Type)int.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Row (A, B, C...): ");
            //char seatRowInput = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //Console.Write("Enter Seat Number:");
            //int seatNumberInput = int.Parse(Console.ReadLine());

            //Console.Write("Enter Price:");
            //int priceInput = int.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount: ");
            //double discountAmountInput = double.Parse(Console.ReadLine());

            //Seat seat = new Seat(seatRowInput, seatNumberInput);

            //Console.WriteLine();
            //Console.WriteLine(" ::::::::  Ticket Info  ::::::::  ");

            //Ticket ticket01 = new Ticket(movieNameInput, Ticket_type_input, seat, priceInput);


            //ticket01.PrintTicket();

            //Console.WriteLine();
            //Console.WriteLine(":::::: After Discount :::::");

            //ticket01.ApplyDiscount(discountAmountInput);

            //////////////////////////////////////////////////////////////////////////

            //Console.Write("Enter Movie Name: ");
            //string movieNameInput = Console.ReadLine();

            //Ticket ticket02 = new Ticket(movieNameInput);

            //Console.WriteLine();
            //Console.WriteLine("::::::::  Ticket Info  ::::::::  ");
            //ticket02.PrintTicket();




            #endregion
        }
    }
}
