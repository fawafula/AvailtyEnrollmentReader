using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;

namespace AvailtyEnrollmentReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Search for only CSV files within the folder which has both CSV and EDI files.
            // Read content of each CSV file.
            //Sort the data as below;
            // Separate enrollees by Insurance company.
            // sort the names in ascending alphabetical order.
            // If there are duplicate Ids, for same insurance company, then only record the highest version.
            // Save the separated enrollees to its own file.

        }
    }
}
