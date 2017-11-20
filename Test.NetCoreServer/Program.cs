using System;

namespace Test.NetCoreServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FWW.Thrift.EsayRegister.NetCoreService.EsayService.Start();
                Console.WriteLine("Thrift server start!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }

    }
    internal class BusinessImpl : HelloService.Iface
    {
        int count = 0;
        public string hello(string name)
        {
            //count++;
            //System.Threading.Thread.Sleep(100);
            //Console.WriteLine(DateTime.Now.ToString());
            return string.Format("hello {0} ,I'm thrift Server!!", name);
        }
    }
}
