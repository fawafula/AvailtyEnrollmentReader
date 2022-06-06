using AvailtyEnrollmentReader.ClassLibrary.Models;
using AvailtyEnrollmentReader.Domain.Tools;
using System;
using System.Configuration;
using System.IO;

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

            if (Directory.Exists(inputDirectoryPath))
            {
                ApplicationInstance instance = new ApplicationInstance(
                new CSVFileLocator(inputDirectoryPath, fileExtension),
                new CSVFileReader(),
                new EnrollmenRecordMapper(),
                new CSVDataSorter(new CSVCustomComparer()),
                new CSVFileWriter(outputDirectoryPath)
               );

                instance.RunApplication();
            }
            else
            {
                Console.WriteLine("The input directory path provided does not exist. Please provide a valid directory path and run application again.");
            }

            Console.WriteLine("Press any key to close application.");
            Console.ReadLine();
        }
    }
}
