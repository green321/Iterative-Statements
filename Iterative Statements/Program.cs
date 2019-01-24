/*
 Author:   Yue Xu
 Date:     1/21/2019
 Comments: Choose to write your program with only 1 of the 3 choices of Iterative Statements: While, For, or Do While (Just choose 1)
           Ask the user to enter an integer value between 1 and 100.
          Then, have the program display the following message the number of times the user has entered for the integer value: "
          You have entered #. This is the current integer value in the loop: #"
 */


using System;

namespace Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user the input
            Console.WriteLine("Enter an integer value between 1 and 100 to execute an iterative statement: ");

            //use try catch to validate user input
            //if user use a bad input, the catch block will handle the error and a message will be displayed
            try
            {
                //this variable will gather data from user input
                string Input = Console.ReadLine();

                // this conditional will be used to perform the variable iterative statements and is parsed as an integer
                int Value_of_Input = int.Parse(Input);

                //IF/ELSE IF/ELSE
                if((Value_of_Input>0)&&(Value_of_Input<101))
                {
                    //For Loop
                    for (int i = 1; i < Value_of_Input; i++)
                    {
                        for (int a = 0; a < Value_of_Input; Value_of_Input--, i++)
                        {
                            
                            Console.WriteLine("You have entered " + Value_of_Input.ToString() + "." + "This is the current integer value in the loop: " + i.ToString());
                        }
                    }

                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }  
            
                    else
                {
                    Console.WriteLine("Please enter the integer value between 1 and 100.");
                    Console.WriteLine("Please try again later.");
                    Console.WriteLine("Please exit the program and try again...");
                    Console.ReadKey(true);
                }
            
            }//End of try

            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Please exit the program and try again...");
                Console.ReadKey(true);
            }//End of catch

        }// End of main

    }//End of class

}//End of namespace
