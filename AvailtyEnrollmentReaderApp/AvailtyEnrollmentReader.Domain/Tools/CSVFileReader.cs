using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using System;
using System.IO;

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

            // Read content of each CSV file.
            Console.WriteLine("Read content of each CSV file.");
            var fileData = File.ReadAllLines(filePath);
            for (int i = 1; i < fileData.Length; i++)
            {
                Console.WriteLine(fileData[i]);

            }

            return fileData;
        }
        #endregion

    }
}
