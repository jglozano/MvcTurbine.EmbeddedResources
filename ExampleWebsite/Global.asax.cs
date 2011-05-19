﻿using MvcTurbine.ComponentModel;
using MvcTurbine.Unity;
using MvcTurbine.Web;

namespace ExampleWebsite
{
	public class MvcApplication : TurbineApplication
	{
		static MvcApplication()
		{
			ServiceLocatorManager.SetLocatorProvider(() => new UnityServiceLocator());
		}
	}
}