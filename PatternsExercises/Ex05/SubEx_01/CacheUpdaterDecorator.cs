using Patterns.Ex05.ExternalLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.SubEx_01
{
    public class CacheUpdaterDecorator : DatabaseSaverDecorator
    {
        private readonly CacheUpdater _cacheUpdater;
        public CacheUpdaterDecorator(IDatabaseSaver saver, CacheUpdater cacheUpdater)
            : base(saver)
        {
            _cacheUpdater = cacheUpdater;
        }

        public new void SaveData(object data)
        {
            base.SaveData(data);
            _cacheUpdater.UpdateCache();
        }
    }
}
