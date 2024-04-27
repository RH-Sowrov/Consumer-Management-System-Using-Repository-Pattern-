using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL
{
    public interface IConsumer
    {
        List<Consumer> Get();
        Consumer Get(int id);
        bool Add(Consumer model);
        bool update (Consumer model);
        bool Delete(int id);
    }
}
