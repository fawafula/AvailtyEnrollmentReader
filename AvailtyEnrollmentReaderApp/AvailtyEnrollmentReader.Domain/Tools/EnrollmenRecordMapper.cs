using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.Domain.Tools
{
    public class EnrollmenRecordMapper : IEnrollmentRecordMapper
    {
        #region Fields
        private List<EnrollmentRecordModel> _records;
        #endregion

        #region Properties
        public List<EnrollmentRecordModel> MappedEnrollmentModels { get => _records; } 
        #endregion

        #region Constructor
        public EnrollmenRecordMapper()
        {
            _records = new List<EnrollmentRecordModel>();
        }
        #endregion

        #region Methods
        public EnrollmentRecordModel MapData(string dataRow)
        {
            try
            {
                var record = new EnrollmentRecordModel();

                var data = dataRow.Split(",");
                int value;
                record.UserId = data[0];
                record.FirstName = data[1];
                record.LastName = data[2];
                if (Int32.TryParse(data[3], out value))
                {
                    record.Version = Int32.Parse(data[3]);
                }
               
                record.InsuranceCompany = data[4];

                return record;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }

        public List<EnrollmentRecordModel> MapDataToList(List<string> dataRows)
        {
            try
            {
                foreach (var dataRow in dataRows)
                {
                    var mappedData = MapData(dataRow);
                    _records.Add(mappedData);
                }

                return MappedEnrollmentModels;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        #endregion


    }
}
