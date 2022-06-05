using AvailtyEnrollmentReader.ClassLibrary.Interfaces;
using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;

namespace AvailtyEnrollmentReader.Domain.Tools
{
    public class CSVCustomComparer : ICSVCustomComparer
    {
        public bool Equals(EnrollmentRecordModel oneRecord, EnrollmentRecordModel otherRecord)
        {
            return  oneRecord.UserId == otherRecord.UserId &&  oneRecord.Version == otherRecord.Version;
        }

        public int GetHashCode(EnrollmentRecordModel record)
        {
            if (Object.ReferenceEquals(record, null)) 
            {
                return 0;
            }

            int hashName = record.UserId == null ? 0 : record.UserId.GetHashCode();
            int hashVersion = record.Version == 0 ? 0 : record.Version.GetHashCode();
            return hashName ^ hashVersion;
        }
    }
}
