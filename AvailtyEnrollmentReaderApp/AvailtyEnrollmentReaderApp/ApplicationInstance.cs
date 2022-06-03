using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.Domain.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReaderApp
{
    internal class ApplicationInstance
    {
        #region Fields
        
        private ICSVFileLocator _fileLocator;
        private ICSVFileReader _fileReader;
        private ICSVDataSorter _dataSorter;
        private ICSVFileWriter _fileWriter;
        #endregion


        #region Properties
        public List<string> CsvFileDataRowsFromAllCsvFiles { get; set; }
        public List<string> SortedCSVData { get; set; }
        #endregion

        #region Constructors
        public ApplicationInstance(ICSVFileLocator fileLocator, ICSVFileReader fileReader, ICSVDataSorter dataSorter, ICSVFileWriter fileWriter)
        {
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
            var csvFiles = _fileLocator.LocateCSVFiles().ToList();

            
            // Read Data from each CSV file and add to csv data list form all files.
            foreach (var csvFile in csvFiles) 
            {
                var csvFileData = _fileReader.ReadCSVFile(csvFile);
                CsvFileDataRowsFromAllCsvFiles.AddRange(csvFileData);
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
