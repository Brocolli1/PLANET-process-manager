using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Views;

namespace PrismApp
{
    public class MainModule : IModule 
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("ContentRegion", typeof(Processes));
        }
    }
}
