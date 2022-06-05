using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using System;
using System.IO;
using System.Linq;

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

        public string[] ReadCSVFile(string filePath)
        {
            try
            {
                Console.WriteLine("Reading content of CSV file.");
                return File.ReadAllLines(filePath).Skip(1).ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
