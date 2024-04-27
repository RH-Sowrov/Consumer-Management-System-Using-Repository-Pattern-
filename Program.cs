using project.BL;
using project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerBusiness oc = new ConsumerBusiness(new ConsumerRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'T' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'X' for Clear, 'E' for Exit");
                    string command = Console.ReadLine();
                    if (command == "T")
                    {
                        List<Consumer> _listConsumer = oc.Get();
                        Console.WriteLine("List of Consumer:");
                        Console.WriteLine("ID   |   Name    |   Address");
                        foreach (Consumer _consumer in _listConsumer)
                        {
                            Console.WriteLine(_consumer.Id + "  |   " + _consumer.Name + "  |   " + _consumer.Address);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a Consumer:");
                        string id = Console.ReadLine();
                        Consumer aConsumer = oc.Get(Convert.ToInt32(id));
                        Console.WriteLine(aConsumer.Id + ". " + aConsumer.Name + " -- " + aConsumer.Address);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Consumer aConsumer = new Consumer();
                        aConsumer.Id = Convert.ToInt32(id);
                        aConsumer.Name = name;
                        aConsumer.Address = address;
                        bool isExecuted = oc.Add(aConsumer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Consumer aConsumer = new Consumer();
                        aConsumer.Id = Convert.ToInt32(id);
                        aConsumer.Name = name;
                        aConsumer.Address = address;
                        bool isExecuted = oc.Update(aConsumer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = oc.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "X")
                    {
                        Console.Clear();
                    }
                    else if (command == "E")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }



        }
    }
}
