using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvailtyEnrollmentReaderApp
{
    internal class ApplicationInstance
    {
        #region Fields

        private ICSVFileLocator _fileLocator;
        private ICSVFileReader _fileReader;
        private ICSVDataSorter _dataSorter;
        private ICSVFileWriter _fileWriter;
        private List<string> _csvFileDataRowsFromAllCsvFiles;
        #endregion


        #region Properties
        public List<string> CsvFileDataRowsFromAllCsvFiles { get => _csvFileDataRowsFromAllCsvFiles; }
        public List<string> SortedCSVData { get; set; }
        #endregion

        #region Constructors
        public ApplicationInstance(ICSVFileLocator fileLocator, ICSVFileReader fileReader, ICSVDataSorter dataSorter, ICSVFileWriter fileWriter)
        {
            _csvFileDataRowsFromAllCsvFiles = new List<string>();
            _fileLocator = fileLocator;
            _fileReader = fileReader;
            _dataSorter = dataSorter;
            _fileWriter = fileWriter;
        }
        #endregion

        #region Methods
        public void RunApplication()
        {
            // Locate csv files.
            var csvFiles = _fileLocator.LocateCSVFiles();

            // Read Data from each CSV file and add to csv data list form all files.
            foreach (var csvFile in csvFiles)
            {
                var csvFileData = _fileReader.ReadCSVFile(csvFile).ToList();
                _csvFileDataRowsFromAllCsvFiles.AddRange(csvFileData);
            }

            foreach (var row in _csvFileDataRowsFromAllCsvFiles)
            {
                Console.WriteLine(row);
            }
            // Sort the data from all csv files.                           
            SortedCSVData = _dataSorter.SortCSVData(CsvFileDataRowsFromAllCsvFiles);

            // Save the separated enrollees to its own file.
            Console.WriteLine(" Save the separated enrollees to its own file.");

            _fileWriter.WriteCsvFile();
            // Complete application process.
            Console.WriteLine("Application process complete.");
        }
        #endregion



    }
}
