using Patterns.Ex05.ExternalLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.SubEx_01
{
    public class DatabaseSaverDecorator : IDatabaseSaver
    {
        protected IDatabaseSaver Wrappee;

        public DatabaseSaverDecorator(IDatabaseSaver saver)
        {
            Wrappee = saver;
        }

        public void SaveData(object data)
        {
            Wrappee.SaveData(data);
        }
    }
}
