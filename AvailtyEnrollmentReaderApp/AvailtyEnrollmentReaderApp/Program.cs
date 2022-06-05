using AvailtyEnrollmentReader.ClassLibrary.Models;
using AvailtyEnrollmentReader.Domain.Tools;
using System;
using System.Configuration;

namespace AvailtyEnrollmentReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EnrollmentReader Application starting...");

            var inputDirectoryPath = ConfigurationManager.AppSettings["InputFolder"];
            var outputDirectoryPath = ConfigurationManager.AppSettings["OutputFolder"];
            var fileExtension = ConfigurationManager.AppSettings["FileTypeExtension"];

            ApplicationInstance instance = new ApplicationInstance(
                new CSVFileLocator(inputDirectoryPath, fileExtension), 
                new CSVFileReader(),
                new EnrollmenRecordMapper(),
                new CSVDataSorter(new CSVCustomComparer()), 
                new CSVFileWriter(outputDirectoryPath)
               );

            instance.RunApplication();
            
            Console.WriteLine("Press any key to close application.");
            Console.ReadLine();

        }

        
    }
}
