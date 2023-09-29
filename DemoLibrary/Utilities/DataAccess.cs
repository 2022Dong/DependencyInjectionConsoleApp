using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        //public void LoadData()
        //{
        //    Console.WriteLine("Loading Data");
        //}

        //public void SaveData(string name)
        //{
        //    Console.WriteLine($"Saving {name}");
        //}

        ILogger _logger;
        public DataAccess(ILogger logger) // if ctor needs pass in an object(ILogger)
        {
            _logger = logger;                
        }

        public void LoadData()
        {
            Console.WriteLine("Loading Data");
            _logger.Log("Loading data");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
            _logger.Log("Saving data");
        }
    }
}
