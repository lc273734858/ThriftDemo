namespace csharp Thrift.HelloTest

service HelloService {
    string hello(1:string name);
}