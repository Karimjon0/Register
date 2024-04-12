using Register.Models;

namespace Book.CRUD.Broker.Storeage
{
    interface IStoreageBroker
    {
        Registers ReadName(string password);
        Registers AddName(Registers name);
        Registers ReadName(int password);
        Registers[] GetAllName();
    }
}
