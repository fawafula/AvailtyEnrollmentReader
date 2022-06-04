using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.ClassLibrary.Interfaces
{
    public interface IEnrollmentRecord
    {
        string UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Version { get; set; }
        string InsuranceCompany { get; set; }
    }
}
