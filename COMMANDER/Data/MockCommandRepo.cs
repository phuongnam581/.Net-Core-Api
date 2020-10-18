using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMMANDER.Data
{
    public class MockCommandRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
               new Command { Id=0, HowTo = "Boild an egg", Line = "Boil water", Platform = "Kettle & Pan" },
               new Command { Id=1, HowTo = "Cut bread", Line = "Get knife", Platform = "Knife & Chopping board" },
               new Command { Id=2, HowTo = "Make up of tea", Line = "Place tea bag in cup", Platform = "Kettle & Cup" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id=0, HowTo = "Boild an egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
