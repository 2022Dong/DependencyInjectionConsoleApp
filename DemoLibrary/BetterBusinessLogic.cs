﻿using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BetterBusinessLogic: IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        //ctor
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess) // change name
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            _logger.Log("Starting the processing of data.");
            Console.WriteLine(); // add
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine(); // add
            _logger.Log("Finished processing of the data");
            Console.WriteLine(); // add
        }
    }
}
