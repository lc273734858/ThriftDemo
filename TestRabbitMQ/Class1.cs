using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestRabbitMQ
{
    public class Class1 : EventBus2RMQ.IResumer
    {
        public void ErrorHandler(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void ProcessData(string jsondata)
        {
            throw new NotImplementedException();
        }
    }
}
