using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.ClassLibrary.Models
{
    public class InsuranceCompanyFileModel : IInsuranceCompanyFileModel
    {
        public string InsuranceCompanyName { get; set; }
        public List<EnrollmentRecordModel> EnrollmentRecords { get; set; }

        public InsuranceCompanyFileModel()
        {
            EnrollmentRecords = new List<EnrollmentRecordModel>();
        }

    }
}
