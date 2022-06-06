using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.Domain.Tools
{
    /// <summary>
    /// Locates and pulls all the file paths with the provided extension. from a given directory path.
    /// </summary>
    public class CSVFileLocator : ICSVFileLocator
    {
        #region Fields
        private string _directoryPath;
        private string _fileExtension;
        #endregion


        public CSVFileLocator(string directoryPath, string fileExtension)
        {
            _directoryPath = directoryPath;
            _fileExtension = fileExtension;
        }
        public string[] LocateCSVFiles()
        {
            try
            {
                Console.WriteLine("Searching for only CSV files within the folder which has both CSV and EDI files...");

                var csvFilePaths = Directory.GetFiles(_directoryPath, _fileExtension, SearchOption.AllDirectories);
                foreach (var path in csvFilePaths)
                {
                    Console.WriteLine(path);
                }

                return csvFilePaths;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Application could not locate csv files from the provided directory path.");
                throw new Exception(ex.InnerException.Message);
            }
           

        }
    }
}
