using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Landrys.ThePostOak_EpiServer.Business
{
    public class StructureMapDependencyResolver : System.Web.Mvc.IDependencyResolver
    {
        readonly StructureMap.IContainer _container;

        public StructureMapDependencyResolver(StructureMap.IContainer container)
        {
            _container = container;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType.IsInterface || serviceType.IsAbstract)
            {
                return GetInterfaceService(serviceType);
            }
            return GetConcreteService(serviceType);
        }

        private object GetConcreteService(Type serviceType)
        {
            try
            {
                // Can't use TryGetInstance here because it won’t create concrete types
                return _container.GetInstance(serviceType);
            }
            catch (StructureMapException)
            {
                return null;
            }
        }

        private object GetInterfaceService(Type serviceType)
        {
            return _container.TryGetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAllInstances(serviceType).Cast<object>();
        }

    }
}