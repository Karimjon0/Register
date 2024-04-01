using Register.Models;

namespace Book.CRUD.Broker.Storeage
{
    interface IStoreageBroker
    {
        Registers ReadBook(string password);
        Registers[] GetAllBook();
        Registers AddBook(Registers name);
        Registers AddName(Registers name);
        Registers[] GetAllName();
        Registers ReadBook(int password);
        Registers ReadName(int password);
    }
}
