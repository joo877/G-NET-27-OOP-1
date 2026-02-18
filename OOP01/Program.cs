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
            #endregion
        }
    }
}
