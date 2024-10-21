using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassModel.Models
{
    public class Manager:Employee
    {
        public Manager()
        {
            Title = Title.Manager;
        }
    }
}
