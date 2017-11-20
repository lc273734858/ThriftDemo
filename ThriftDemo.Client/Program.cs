using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThriftDemo.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TTransport transport = new TSocket("localhost", 2221);
            TProtocol protocol = new TBinaryProtocol(transport);
            HelloService.Client client = new HelloService.Client(protocol);
            transport.Open();
            Console.WriteLine("Client calls .....");
            Console.WriteLine(client.hello("John"));
            Console.ReadLine();
        }
    }
}
