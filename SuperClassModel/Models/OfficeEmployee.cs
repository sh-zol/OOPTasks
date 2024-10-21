using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassModel.Models
{
    public class OfficeEmployee:Employee
    {
        public OfficeEmployee()
        {
            Title = Title.OfficeEmployee;
        }
    }
}
