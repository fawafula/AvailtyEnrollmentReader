using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvailtyEnrollmentReader.Domain.Tools
{
    /// <summary>
    /// Sorts the data in a CSV file.
    /// </summary>
    public class CSVDataSorter : ICSVDataSorter
    {

        #region Fields
        private ICSVCustomComparer _customComparer;
        #endregion

        #region Properties

        #endregion

        #region Constructors
        public CSVDataSorter(ICSVCustomComparer customComparer)
        {
            _customComparer = customComparer;
        }
        #endregion

        #region Methods
        public List<EnrollmentRecordModel> SortCSVData(List<EnrollmentRecordModel> dataToSort)
        {
            try
            {
                Console.WriteLine("Sorting data in each csv file:");
                var sortedData = dataToSort.OrderBy(x => x.LastName).Distinct(_customComparer).ToList();

                return sortedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Application could not sort the CSV data from the given file.");
                throw new Exception(ex.InnerException.Message);
            }
           
            
        }
        #endregion

    }
}
