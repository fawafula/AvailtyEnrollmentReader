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
                throw new Exception(ex.Message);
            }
            
        }

        public string CreateHeader(List<string> columnTitles)
        {
            return string.Join(",", columnTitles);
        }
    }
}
