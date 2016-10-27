using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.WebApi;
using Microsoft.Practices.Unity;
using ProductsApp.Models;

namespace ProductsApp.Templates
{
    public class Unity
    {
        private readonly IUnityContainer _container;

        public Unity()
        {
            _container = new UnityContainer();
        }

        // Possibly make this a singleton class
        public IUnityContainer Container { get { return _container;} }
        public void Init()
        {
            var resolver = new UnityDependencyResolver(_container);

            // New instance on DI
            _container.RegisterType<IProduct, Product>();


            // Singleton
            _container.RegisterType<IProduct, Product>(new ContainerControlledLifetimeManager());
            _container.RegisterSingleton<IProduct, Product>();


        }
    }

    public static class UnityExtentions
    {


        public static IUnityContainer RegisterSingleton<TFrom, TTo>(this IUnityContainer container) where TTo : TFrom
        {
            return container.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
        }

    }
}