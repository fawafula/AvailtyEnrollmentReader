using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.Domain.ProcessObjects
{
    public class EnrollmentInputRecord : EnrollmentRecordModel, IEnrollmentRecord
    {
        private string _dataRow;

        public EnrollmentInputRecord(string dataRow)
        {
            _dataRow = dataRow;
        }

        public void MapData()
        {
            var data = _dataRow.Split(",");
            this.UserId = data[0];
            this.FirstName = data[1];
            this.LastName = data[2];
            this.Version = Int32.Parse(data[3]);
            this.InsuranceCompany = data[4];

        }
    }
}
