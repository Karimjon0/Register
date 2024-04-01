using Register.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Register.Broker.Service
{
    internal interface IBookService
    {
        Registers GetName(string password);
        Registers[] ReadAllName();
        Registers InsertName(Registers name);
    }
}
