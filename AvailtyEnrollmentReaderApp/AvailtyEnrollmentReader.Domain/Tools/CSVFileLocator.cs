using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.Domain.Tools
{
    /// <summary>
    /// Locates and pulls all the files with .csv extension in a given directory.
    /// </summary>
    public class CSVFileLocator : ICSVFileLocator
    {
        private string _directoryPath;

        public CSVFileLocator(string directoryPath)
        {
            _directoryPath = directoryPath;
        }
        public IEnumerable<EnrollmentFileModel> LocateCSVFiles()
        {

            // Search for only CSV files within the folder which has both CSV and EDI files.
            Console.WriteLine("Search for only CSV files within the folder which has both CSV and EDI files");

            return new List<EnrollmentFileModel>();
        }
    }
}
