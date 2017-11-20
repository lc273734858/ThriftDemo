using System;
using Thrift.Server;
using Thrift.Transport;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TServerSocket serverTransport = new TServerSocket(7911, 0, false);
            HelloService.Processor processor = new HelloService.Processor(new BusinessImpl());
            TServer server = new TSimpleServer(processor, serverTransport);
            
            Console.WriteLine("Starting server on port 7911 ...");
            server.Serve();
            //exe -gen csharp xxx.thrift
            Console.ReadLine();
        }
    }

    internal class BusinessImpl : HelloService.Iface
    {
        public string hello(string name)
        {
            return string.Format("hello {0} ,I'm thrift Server!!", name);
        }
    }
}