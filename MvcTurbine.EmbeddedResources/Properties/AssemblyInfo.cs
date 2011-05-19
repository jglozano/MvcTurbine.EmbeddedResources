using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;
using MvcTurbine.EmbeddedResources;

[assembly: AssemblyTitle("MvcTurbine.EmbeddedResources")]
[assembly: AssemblyDescription("Compliments MvcTurbine.EmbeddedViews by allowing embedded resources as well.")]
[assembly: AssemblyCompany("Jared McGuire")]
[assembly: AssemblyProduct("MvcTurbine.EmbeddedResources")]
[assembly: AssemblyCopyright("Copyright Jared McGuire")]
[assembly: ComVisible(false)]
[assembly: Guid("9d1b1dc1-0c3c-47de-ac1c-8183f1542c01")]
[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyFileVersion("0.1.0.0")]

[assembly: PreApplicationStartMethod(typeof(PreApplicationStarter), "Start")]