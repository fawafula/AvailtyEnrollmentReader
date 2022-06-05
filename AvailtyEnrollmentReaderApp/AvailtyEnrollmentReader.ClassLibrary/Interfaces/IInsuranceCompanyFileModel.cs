using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.ClassLibrary.Interfaces
{
    public interface IInsuranceCompanyFileModel
    {
        string InsuranceCompanyName { get; set; }

        List<EnrollmentRecordModel> EnrollmentRecords { get; set; }
        
    }
}
