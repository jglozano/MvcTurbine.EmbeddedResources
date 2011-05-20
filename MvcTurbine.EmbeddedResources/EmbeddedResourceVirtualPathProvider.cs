using System;
using System.Collections;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;

namespace MvcTurbine.EmbeddedResources
{
	public class EmbeddedResourceVirtualPathProvider : VirtualPathProvider
	{
		private readonly EmbeddedResourceTable embeddedResources;

		public EmbeddedResourceVirtualPathProvider(EmbeddedResourceTable table)
		{
			if (table == null)
				throw new ArgumentNullException("table", "EmbeddedResourceTable cannot be null.");

			embeddedResources = table;
		}

		private bool IsEmbeddedResource(string virtualPath)
		{
			string checkPath = VirtualPathUtility.ToAppRelative(virtualPath);

			var isContent = checkPath.Contains("/Content/");
			var isScript = checkPath.Contains("/Scripts/");
			var isEmbedded = embeddedResources.ContainsEmbeddedResource(checkPath);

			return (isContent || isScript) && isEmbedded;
		}

		public override bool FileExists(string virtualPath)
		{
			var found = IsEmbeddedResource(virtualPath) || base.FileExists(virtualPath);
			return found;
		}

		public override VirtualFile GetFile(string virtualPath)
		{
			if (IsEmbeddedResource(virtualPath))
			{
				var embeddedResource = embeddedResources.FindEmbeddedResource(virtualPath);
				return new AssemblyResourceFile(embeddedResource, virtualPath);
			}

			return base.GetFile(virtualPath);
		}

		public override CacheDependency GetCacheDependency(string virtualPath, IEnumerable virtualPathDependencies, DateTime utcStart)
		{
			return IsEmbeddedResource(virtualPath) ? null : base.GetCacheDependency(virtualPath, virtualPathDependencies, utcStart);
		}
	}
}