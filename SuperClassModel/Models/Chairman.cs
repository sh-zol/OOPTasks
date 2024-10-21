using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassModel.Models
{
    public class Chairman:Employee
    {
        public Chairman()
        {
            Title = Title.Chairman;
        }
    }
}
