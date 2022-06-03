using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.ClassLibrary.Models;
using AvailtyEnrollmentReader.Domain.ProcessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.Domain.Tools
{
    /// <summary>
    /// Reads content of a CSV file.
    /// </summary>
    public class CSVFileReader : ICSVFileReader
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructor

        #endregion

        #region Methods

        public List<string> ReadCSVFile(EnrollmentFileModel file)
        {
            var listOfRowsFromFile = new List<string>();

            // Read content of each CSV file.
            Console.WriteLine("Read content of each CSV file.");

            return listOfRowsFromFile;
        }
        #endregion

    }
}
