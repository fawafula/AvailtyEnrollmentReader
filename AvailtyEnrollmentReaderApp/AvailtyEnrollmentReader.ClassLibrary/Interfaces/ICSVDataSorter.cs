﻿using AvailtyEnrollmentReader.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvailtyEnrollmentReader.ClassLibrary.Interfaces
{
    public interface ICSVDataSorter
    {
        List<EnrollmentRecordModel> SortCSVData(List<EnrollmentRecordModel> dataToSort);

    }
}
