using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.Domain.Tools
{
    /// <summary>
    /// Sorts the data in a CSV file.
    /// </summary>
    public class CSVDataSorter : ICSVDataSorter
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructors
        public CSVDataSorter()
        {

        }
        #endregion

        #region Methods
        public List<string> SortCSVData(List<string> dataToSort)
        {
            var sortedData = new List<string>();
            //Sort the data as below;
            Console.WriteLine("Sorting the data:");

            // sort the names in ascending alphabetical order.
            Console.WriteLine("sort the names in ascending alphabetical order");

            // If there are duplicate Ids, for same insurance company, then only record the highest version.
            Console.WriteLine("If there are duplicate Ids, for same insurance company, then only record the highest version");

            // Separate enrollees by Insurance company.
            Console.WriteLine("Separate enrollees by Insurance company");

            return sortedData;
        }
        #endregion

    }
}
