using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Interfaces
{
    public interface IAuthentication
    {
        void Register(RegisterVM registerVM);
        bool Login(LoginVM loginVM);
        void Logout();
    }
}
