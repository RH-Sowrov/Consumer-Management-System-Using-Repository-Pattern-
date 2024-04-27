using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DAL
{
    public class Consumer
    {
        public int Id;
        public string Name;
        public string Address;
        public Consumer()
        {
            
        }
        public Consumer(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
