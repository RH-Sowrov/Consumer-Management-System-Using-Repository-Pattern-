using project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BL
{
    public class ConsumerBusiness
    {
        IConsumer _repository;
        public ConsumerBusiness(IConsumer repository)
        {
            _repository = repository;
        }
        public List<Consumer> Get() 
        { 
            return _repository.Get();
        }
        public Consumer Get(int id)
        {
            return _repository.Get(id);
        }
        public bool Add(Consumer model)
        {
            return _repository.Add(model);
        }
        public bool Update (Consumer model)
        {
            return _repository.update(model);
        }
        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
