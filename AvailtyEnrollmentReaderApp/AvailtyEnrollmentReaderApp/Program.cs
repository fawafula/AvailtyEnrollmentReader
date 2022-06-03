using AvailtyEnrollmentReader.ClassLibrary.Models;
using AvailtyEnrollmentReader.Domain.Tools;
using System;

namespace AvailtyEnrollmentReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EnrollmentReared Application starting...");

            var inputDirectoryPath = @"C:\Users\waful\source\repos\fawafula\AvailityHomework\AvailtyEnrollmentReader\SampleDocuments";
            var outputDirectoryPath = @"C:\Users\waful\source\repos\fawafula\AvailityHomework\AvailtyEnrollmentReader\SampleOutputs";
            
            ApplicationInstance instance = new ApplicationInstance(new CSVFileLocator(inputDirectoryPath), new CSVFileReader(), new CSVDataSorter(), new CSVFileWriter(outputDirectoryPath));

            instance.RunApplication();
            
            Console.WriteLine("Press any key to close application.");
            Console.ReadLine();

            

        }

        
    }
}
