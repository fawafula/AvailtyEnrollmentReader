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
    public class CSVFileWriter : ICSVFileWriter
    {
        private string _outputDirectoryPath;

        public CSVFileWriter(string outputDirectoryPath)
        {
            _outputDirectoryPath = outputDirectoryPath;
        }
        public void WriteCsvFile(string fileHeaderRow, string fileName, InsuranceCompanyFileModel dataToWrite)
        {
            try
            {
                Console.WriteLine("Writing to a new csv file belonging to an insurance company.");

                Directory.CreateDirectory(_outputDirectoryPath);

                var filePath = Path.Combine(_outputDirectoryPath, fileName);

                using (StreamWriter file = new StreamWriter(@filePath, false))
                {
                    file.WriteLine(fileHeaderRow);
                    foreach (var record in dataToWrite.EnrollmentRecords)
                    {
                        file.WriteLine($"{record.UserId},{record.FirstName},{record.LastName},{record.Version},{record.InsuranceCompany}");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Application could not Write to a new csv file.");
                throw new Exception(ex.InnerException.Message);
            }
            
        }

        public string CreateHeader(List<string> columnTitles)
        {
            try
            {
                return string.Join(",", columnTitles);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not Create Header with provided column titles.");

                throw new Exception(ex.InnerException.Message);
            }
           
        }
    }
}
