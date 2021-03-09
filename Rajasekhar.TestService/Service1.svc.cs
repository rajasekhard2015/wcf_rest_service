﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Rajasekhar.TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(string number1)
        {
            return string.Format("You entered: {0}", number1);
        }
        public List<string> GetAllJsonData()
        {
            return new List<string>() { "test1","test2","test3","test4","test5","test6","test7"};
        }
    }
}
