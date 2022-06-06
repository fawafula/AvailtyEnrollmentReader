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
        private IEnrollmentRecordMapper _recordMapper;
        private ICSVDataSorter _dataSorter;
        private ICSVFileWriter _fileWriter;
        private List<string> _unmappedCsvRecordsFromAllFiles;
        private List<EnrollmentRecordModel> _csvFileDataRecordsFromAllCsvFiles;
        private List<EnrollmentRecordModel> _sortedData;
        private List<InsuranceCompanyFileModel> _insuranceCompanyFiles;
        private List<string> _fileHeaderRows;

        #endregion


        #region Properties
        public List<EnrollmentRecordModel> CsvFileDataRecordsFromAllCsvFiles { get => _csvFileDataRecordsFromAllCsvFiles; }
        public List<EnrollmentRecordModel> SortedCSVData { get => _sortedData; }
        public List<InsuranceCompanyFileModel> InsuranceCompanyFiles { get => _insuranceCompanyFiles; }
        #endregion


        #region Constructors
        public ApplicationInstance(ICSVFileLocator fileLocator, ICSVFileReader fileReader, IEnrollmentRecordMapper recordMapper, ICSVDataSorter dataSorter, ICSVFileWriter fileWriter)
        {
            _unmappedCsvRecordsFromAllFiles = new List<string>();
            _csvFileDataRecordsFromAllCsvFiles = new List<EnrollmentRecordModel>();
            _insuranceCompanyFiles = new List<InsuranceCompanyFileModel>();
            _fileHeaderRows = new List<string>();   
            _sortedData = new List<EnrollmentRecordModel>();
            _fileLocator = fileLocator;
            _fileReader = fileReader;
            _recordMapper = recordMapper;
            _dataSorter = dataSorter;
            _fileWriter = fileWriter;
        }
        #endregion

        #region Methods
        public void RunApplication()
        {
            try
            {
                Console.WriteLine("Reading all .csv files from input diectory path...");
                var csvFiles = _fileLocator.LocateCSVFiles();

                foreach (var csvFile in csvFiles)
                {
                    var csvFileData = _fileReader.ReadCSVFile(csvFile).ToList();
                    var csvFileHeaderRow = _fileReader.CSVFileHeaderRow;
                    _fileHeaderRows.Add(csvFileHeaderRow);
                    _unmappedCsvRecordsFromAllFiles.AddRange(csvFileData);
                }

                _csvFileDataRecordsFromAllCsvFiles = _recordMapper.MapDataToList(_unmappedCsvRecordsFromAllFiles);


                Console.WriteLine("Sorting: Grouping enrollees by insurance company, Ordering each group alphabetically and removing duplicates....");

                var groupedData = _csvFileDataRecordsFromAllCsvFiles.GroupBy(x => x.InsuranceCompany).ToList();
                foreach (var group in groupedData)
                {
                    var insuranceCompanyFile = new InsuranceCompanyFileModel
                    {
                        InsuranceCompanyName = group.Key,
                        EnrollmentRecords = _dataSorter.SortCSVData(group.ToList())
                    };
                    _insuranceCompanyFiles.Add(insuranceCompanyFile);
                }


                Console.WriteLine(" Writing each insurance company enrollee group to its own file...");


                foreach (var insuranceCompanyFile in _insuranceCompanyFiles)
                {
                    var fileName = $"{String.Concat(insuranceCompanyFile.InsuranceCompanyName.Where( c=> !Char.IsWhiteSpace(c)))}File.csv";
                    _fileWriter.WriteCsvFile(_fileHeaderRows.FirstOrDefault(), fileName, insuranceCompanyFile);
                }
               
                // Complete application process.
                Console.WriteLine("Application process complete.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Application process failed: Something went wrong...");
                throw new Exception(ex.InnerException.Message);
            }




        }
        #endregion



    }
}
