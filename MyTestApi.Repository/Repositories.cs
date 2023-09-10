using MyTestApi.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApi.Repository
{
    public class Repositories : IRepository 
    {
        public string getData()
        {
            return "Ok succefully Complete Configuration";
        }
 
    }
}
