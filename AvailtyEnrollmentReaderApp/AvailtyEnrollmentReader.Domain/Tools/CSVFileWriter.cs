using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
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
        public void WriteCsvFile()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
