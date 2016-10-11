using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;

namespace IGOutlook.Infrastructure.Prism
{
    /// <summary>
    /// Register Types and views
    /// </summary>
    public abstract class ModuleBase :IModule
    {
        protected CompositionContainer Container { get; private set; }
        protected IRegionManager RegionManager { get; private set; }
        // container for mef is CompositionContainer
       // [ImportingConstructor]
        public ModuleBase(CompositionContainer container, IRegionManager regionManager)
        {
            RegionManager = regionManager;
            Container = container;
        }
        public void Initialize()
        {
            RegistreTypes();
            ResolveOutlookGroup();
        }

        public abstract void RegistreTypes();
        public abstract void ResolveOutlookGroup();
    
    }
}
