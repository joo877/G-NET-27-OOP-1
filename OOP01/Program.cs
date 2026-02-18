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
            #endregion
        }
    }
}
