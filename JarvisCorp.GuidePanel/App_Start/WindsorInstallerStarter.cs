//using Sitecore.ContentSearch.SolrProvider.CastleWindsorIntegration;
using Sitecore.DependencyInjection.ContainerContexts;
using JarvisCorp.GuidePanel.App_Start;
using JarvisCorp.GuidePanel.App_Start.Installers;
using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(WindsorInstallerStarter), "Start")]

namespace JarvisCorp.GuidePanel.App_Start
{
    public class WindsorInstallerStarter
    {
        public static void Start()
        {
            //Register Controllers with WindsorContainer
            WindsorContainerContext.Instance.Install(new MvcControllersInstaller());
            //Register Services with WindsorContainer
            WindsorContainerContext.Instance.Install(new ServicesInstaller());
            //Initialise Solr with WindsorContainer
            //new WindsorSolrStartUp(WindsorContainerContext.Instance).Initialize();
        }
    }
}