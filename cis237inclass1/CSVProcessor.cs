using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        //No Variables
        //No Properties
        //No constructor. defult is fine

        public bool ImportCsv(string pathToCSVFile, Employee[] employees)
        {
            //Declare the streamReader
            StreamReader streamReader = null;

            try
            {
                //Declare a string for the line
                string line;

                //Instanciate the stream reader
                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                //while we are still reading the line from the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    //process the line
                    processLine(line, employees, counter++);
                    

                }

                //Read through the whole file so we can return true
                return true;
                

            }
            catch (Exception e)
            {
                //output the exception and the stacktrace for the exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                //return false since it did not succeed
                return false;
            }

            finally
            {
                //finally block will always be executed no matter what

                //if stream reader was instanciated make sure it
                //if closed before exiting the reader
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }

        }

        private void processLine(string line, Employee[] employees, int index)
        {
            //Declare array of parts that will contain the results of 
            //splitting the read in string
            string[] parts = line.Split(',');

            //assign each part to a variable
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);


            //add a new employee into the array that was passed in
            //in wine item collection
            employees[index] = new Employee(firstName, lastName, salary);

        }

    }
}
