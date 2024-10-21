using SuperClassModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassModel.Interfaces
{
    public interface IAuthentication
    {
        public void Register(RegisterVM registerVM);
        public int Login(LoginVM loginVM);
        public bool Logout();
    }
}
