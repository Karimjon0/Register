
using Book.CRUD.Broker.Logging;
using Book.CRUD.Broker.Storeage;
using Register.Broker.Logging;
using Register.Models;

namespace Book.CRUD.Service
{
    internal class RegisterService : IRegisterService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStoreageBroker storeageBroker;
        private object name;

        public RegisterService()
        {
            this.loggingBroker = new LoggingBroker();
            this.storeageBroker = new ArrayStoreageBroker();
        }
        public Registers GetName(int password)
        {
            Registers name = this.storeageBroker.ReadName(password);
            return name;
        }

        public Registers InsertName(Registers password)
        {
            return name is null
                    ? InsertBookIsInvalid()
                    : ValidationAndInsertName((Registers)name);
        }

        private Registers InsertBookIsInvalid()
        {
            throw new NotImplementedException();
        }

        private Registers ValidationAndInsertName(object name)
        {
            throw new NotImplementedException();
        }

        public Registers[] ReadAllName()
        {
            var nameInfo = this.storeageBroker.GetAllName();
            if (nameInfo.Length is 0)
            {
                this.loggingBroker.LogError("Information not available.");
            }
            else
            {
                for (int itaration = 0; itaration < nameInfo.Length; itaration++)
                {
                    if (nameInfo[itaration] is not null)
                    {
                        this.loggingBroker.LogInformation($"{nameInfo[itaration].FirstName}. {nameInfo[itaration].LastName} {nameInfo[itaration].Password}");
                    }
                }
            }

            return nameInfo;

        }


        private Registers ValidationAndInsertBook(Registers name)
        {
            if (name.FirstName is null
                || string.IsNullOrWhiteSpace(name.FirstName)
                || String.IsNullOrWhiteSpace(name.LastName)
                || String.IsNullOrWhiteSpace(name.Password))
            {
                this.loggingBroker.LogError("Invalid books inforamtion.");
                return new Registers();
            }
            else
            {
                var nameInfo = this.storeageBroker.AddName(name);

                if (nameInfo is null)
                {
                    this.loggingBroker.LogInformation("Not Added name Info.");
                }
                else
                {
                    this.loggingBroker.LogInformation("Secssesfull.");
                }
                return nameInfo;
            }
        }

        private Registers InsertNameIsInvalid()
        {
            this.loggingBroker.LogError("Name info is null.");
            return new Registers();
        }
    }
}
