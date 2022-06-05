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
        private string _csvFileHeaderRow;
        #endregion

        #region Properties
        public string CSVFileHeaderRow { get => _csvFileHeaderRow; }
        #endregion

        #region Constructor

        #endregion

        #region Methods

        public string[] ReadCSVFile(string filePath)
        {
            try
            {
                Console.WriteLine("Reading content of CSV file.");
                var fileDataRows = File.ReadAllLines(filePath);

                _csvFileHeaderRow =fileDataRows.First();
                
                return fileDataRows.Skip(1).ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
