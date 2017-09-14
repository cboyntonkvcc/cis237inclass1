using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            //lets make a new ui class that we can use below
            //commented to use the Static version
            //UserInterface ui = new UserInterface();





            //Here is new Employee being created just to make sure 
            //that our Employee class works
            Employee myEmployee = new Employee("David", "Barnes", 835.00m);


            Console.WriteLine(myEmployee);
            Console.WriteLine(myEmployee.FirstAndLastName());

            //lets make an array to hold a of instances of the employee class
            //we have the new keyword that means memory allocation
            //the array is going to be in the heap
            Employee[] employees = new Employee[10];


            //commented since we are using the CSV now
            //employees[0] = new Employee("James", "Kirk", 1701.00m);
            //employees[1] = new Employee("Jean-Luc", "Picard", 1701.00m);
            //employees[2] = new Employee("Benjamin", "Sisko", 587.00m);
            //employees[3] = new Employee("Kathryn", "Janeway", 287.00m);
            //employees[4] = new Employee("Johnathan", "Archer", 127.00m);

            //make the string for the path to the csv file
            string pathtoCSV = "employees.csv";

            //make instance of the csvProcessor

            CSVProcessor csvProcessor = new CSVProcessor();

            //call the imporCSV method sending over the path and 
            //the array to the store the read in records too
            csvProcessor.ImportCsv(pathtoCSV, employees);


            //get some inpur from the user
            int choice = StaticUserInterface.GetUserInput();

            //while the user has chosen somthing other than 2
            //which for us is only 1
            while (choice != 2)
            {




                //Create a string that can be concated to 
                string outputString = "";

                //Print our the employees in the array
                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        //concat the employee to the outputString
                        outputString += employee.ToString() + Environment.NewLine;
                    }
                }
                //Outpur the ourputString to the console
                StaticUserInterface.Output(outputString);

                //reprompt the user for some input
                choice = StaticUserInterface.GetUserInput();
            }

        }
    }
}
