using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.ClassLibrary.Interfaces
{
    public interface ICSVCustomComparer : IEqualityComparer<EnrollmentRecordModel>
    {
        new bool Equals(EnrollmentRecordModel oneRecord, EnrollmentRecordModel otherRecord);
        new int GetHashCode(EnrollmentRecordModel record);
    }
}
