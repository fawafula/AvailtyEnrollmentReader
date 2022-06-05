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
                //Sort the data as below;
                Console.WriteLine("Sorting the data:");

                // sort the names in ascending alphabetical order.
                Console.WriteLine("sort the names in ascending alphabetical order and removing duplicates.");
                var sortedData = dataToSort.OrderBy(x => x.LastName).Distinct(_customComparer).ToList();

                return sortedData;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
            
        }
        #endregion

    }
}
