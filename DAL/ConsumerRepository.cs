using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL
{
    public class ConsumerRepository : IConsumer
    {
        List<Consumer> listConsumer = new List<Consumer>()
        {
            new Consumer(1, "Najmul","MOhakhali"),
            new Consumer(2,"Kamran","Jigatola"),
            new Consumer(3,"Shanto","Bujoy Sarani"),
            new Consumer(4,"Tuhin","Raja Bazar")
        };
        public List<Consumer> Get()
        {
            return listConsumer.OrderBy(x => x.Name).ToList();
        }
        public Consumer Get(int id)
        {
            Consumer consumer = listConsumer.Where(x => x.Id == id).FirstOrDefault();
            return consumer;
        }
        public bool Add (Consumer model)
        {
            listConsumer.Add(model);
            return true;
        }
        public bool Update (Consumer model)
        {
            bool isExecuted = false;
            Consumer consumer = listConsumer.Where(x=>x.Id== model.Id).FirstOrDefault();
            if (consumer != null)
            {
                listConsumer.Remove(consumer);
                listConsumer.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }
        public bool Delete (int id)
        {
            bool isExecuted =false;
            Consumer consumer = listConsumer.Where(x=>x.Id==id).FirstOrDefault();
            if (consumer != null)
            {
                listConsumer.Remove(consumer);
                isExecuted=true;
            }
            return isExecuted;
        }

        public bool update(Consumer model)
        {
            throw new NotImplementedException();
        }
    }
}
