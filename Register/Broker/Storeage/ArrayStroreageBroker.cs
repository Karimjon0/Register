using Register.Models;

namespace Book.CRUD.Broker.Storeage
{
    public class ArrayStoreageBroker : IStoreageBroker
    {
        private Registers[] RegistersInfo { get; set; } = new Registers[10];

        public ArrayStoreageBroker()
        {
            RegistersInfo[0] = new Registers()
            {
                FirstName = "Karimjon",
                LastName = "Abidjonov",
                Password = "Password",
            };
        }
        public Registers ReadName(string password)
        {
            for (int itaration = 0; itaration <= RegistersInfo.Length; itaration++)
            {
                Registers bookInfoLine = RegistersInfo[itaration];
                if (bookInfoLine.Password == password)
                {
                    return bookInfoLine;
                }
            }

            return new Registers();
        }
        public Registers[] GetAllName() => RegistersInfo;

        public Registers AddName(Registers name)
        {
            for (int itaration = 0; itaration < RegistersInfo.Length; itaration++)
            {
                if (RegistersInfo[itaration] is null)
                {
                    var RegistersInfo = new Registers()
                    {
                        FirstName = name.FirstName,
                        LastName = name.LastName,
                        Password = name.Password,
                    };
                    this.RegistersInfo[itaration] = RegistersInfo;
                    return name;
                }
            }
            return new Registers();
        }

        public Registers ReadBook(string password)
        {
            throw new NotImplementedException();
        }

        public Registers[] GetAllBook()
        {
            throw new NotImplementedException();
        }

        public Registers AddBook(Registers name)
        {
            throw new NotImplementedException();
        }

        public Registers ReadBook(int password)
        {
            throw new NotImplementedException();
        }

        public Registers ReadName(int password)
        {
            throw new NotImplementedException();
        }
    }

}
