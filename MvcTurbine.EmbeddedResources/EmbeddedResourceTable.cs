using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcTurbine.EmbeddedResources
{
	[Serializable]
	public class EmbeddedResourceTable
	{
		private static readonly object Lock = new object();
		private readonly Dictionary<string, EmbeddedResource> cache;

		public EmbeddedResourceTable()
		{
			cache = new Dictionary<string, EmbeddedResource>(StringComparer.InvariantCultureIgnoreCase);
		}

		public void AddResource(string resourceName, string assemblyName)
		{
			lock (Lock)
				cache[resourceName] = new EmbeddedResource {Name = resourceName, AssemblyFullName = assemblyName};
		}

		public IList<EmbeddedResource> Resources
		{
			get
			{
				return cache.Values.ToList();
			}
		}

		public bool ContainsEmbeddedResource(string resourcePath)
		{
			var foundResource = FindEmbeddedResource(resourcePath);
			return (foundResource != null);
		}

		public EmbeddedResource FindEmbeddedResource(string resourcePath)
		{
			var name = GetNameFromPath(resourcePath);
			if (string.IsNullOrEmpty(name)) 
				return null;

			return Resources
				.Where(resource => resource.Name.ToLowerInvariant().Contains(name.ToLowerInvariant()))
				.SingleOrDefault();
		}

		protected string GetNameFromPath(string resourcePath)
		{
			if (string.IsNullOrEmpty(resourcePath))
				return null;
			var name = resourcePath.Replace("/", ".");
			return name.Replace("~", "");
		}
	}
}