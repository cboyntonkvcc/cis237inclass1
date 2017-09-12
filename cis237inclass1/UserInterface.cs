using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {

        // No Variables
        //No Properties
        // No Constructor will just use the default


        //********************
        //Public Methods
        //*******************

        public int GetUserInput()
        {
            //print out a menu
            this.Printmenu();
            //get inpur from the user
            String input = Console.ReadLine();


            //While the input is not valid re-get the input 
            //validation
            while(input != "1" && input != "2")
            {
                //print error message 
                this.PrintErrorMessage();

                //reprint the menu
                this.Printmenu();

                //getinput from the console again
                input = Console.ReadLine(); 
            }

            // at this point I know inpur is a valid number of either
            // a 1 or a 2
            return Int32.Parse(input);

        }


        //I realixe this looks silly but now i know
        // any interaction that uses the console will be in this 
        // file i wont have to look through my code
        //to find it anywhere else

        public void Output(string outputString)
        {

            Console.WriteLine(outputString);

        }

        //************************
        //Private methods
        //************************
        private void Printmenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("this is not a Valid entry");
            Console.WriteLine("please make a valid choice");
            Console.WriteLine();
        }




    }
}
