using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMMANDER.Data
{
    public interface  ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands();
        public Command GetCommandById(int id);
        public bool SaveChanges();
        public void CreateCommand(Command cmd);
        public void UpdateCommand(Command cmd);
        public void DeleteCommand(Command cmd);
    }
}
