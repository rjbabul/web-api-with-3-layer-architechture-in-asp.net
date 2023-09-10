using MyTestApi.Repository.Abstraction;
using MyTestApi.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApi.Service
{
    public class MyServices : IServices
    {
        public readonly IRepository _repository;

        public MyServices(IRepository repository)
        {
            _repository = repository;
        }

       public string getData()
        {
            var data = _repository.getData();
            return (data);
        }
    }
}
