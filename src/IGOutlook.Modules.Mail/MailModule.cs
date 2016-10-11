using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGOutlook.Infrastructure;
using IGOutlook.Infrastructure.Prism;
using IGOutlook.Modules.Mail.Menus;
//using Prism.Mef.Modularity;
using Prism.Regions;

namespace IGOutlook.Modules.Mail
{
    // [ModuleExport(typeof(ModuleA), DependsOnModuleNames = new string[] { "ModuleD" })]

    // [ModuleExport(typeof(ModuleB), InitializationMode = InitializationMode.OnDemand)]
    //[ModuleExport(typeof(MailModule))]
    public class MailModule :ModuleBase
    {
        //[ImportingConstructor]
        public MailModule(CompositionContainer container, IRegionManager regionManager) 
            : base(container, regionManager)
        {
        }

        public override void RegistreTypes()
        {
        }

        public override void ResolveOutlookGroup()
        {
       //       RegionManager.Regions[RegionNames.OutlookBarGroupRegion].Add(Container.Resolve<MailGroup>());
          RegionManager.Regions[RegionNames.OutlookBarGroupRegion].Add(Container.GetExportedValue<MailGroup>());
        }
    }
}
