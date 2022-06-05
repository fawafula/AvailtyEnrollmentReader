using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.ClassLibrary.Interfaces
{
    public interface IEnrollmentRecordMapper
    {

        EnrollmentRecordModel MapData(string dataRow);

        List<EnrollmentRecordModel> MapDataToList(List<string> dataRows);
    }
}
