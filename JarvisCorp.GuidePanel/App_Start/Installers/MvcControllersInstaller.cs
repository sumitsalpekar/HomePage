using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Mvc;

namespace JarvisCorp.GuidePanel.App_Start.Installers
{
    public class MvcControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Classes.FromAssemblyNamed("Example.Library").BasedOn<IController>().LifestyleTransient());
        }
    }
}