using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.ClassLibrary.Models
{
    public class EnrollmentRecordModel : IEnrollmentRecord
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Version { get; set; }
        public string InsuranceCompany { get; set; }
    }
}
