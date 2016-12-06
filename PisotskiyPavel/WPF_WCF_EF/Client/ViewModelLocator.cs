using Client.Common;
using Client.ViewModels;
using DomainModel;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ViewModelLocator
    {
        private static IKernel container;
        static ViewModelLocator()
        {
            ConfigureContainer();
        }

        private static void ConfigureContainer()
        {
            container = new StandardKernel();
            
            if (IsInDesignMode)
            {
                container.Bind<ProductService.IProductService>().To<Design.DesignProductService>();
            }
            else
            {
                container.Bind<ProductService.IProductService>().To<ProductService.ProductServiceClient>();
            }
            
        }

        protected static bool IsInDesignMode
        {
            get
            {
                return DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject());
            }
        }

        public ProductsViewModel ProductsViewModel
        {
            get { return container.Get<ProductsViewModel>(); }
        }
        
        public AddProductViewModel AddProductViewModel
        {
            get { return container.Get<AddProductViewModel>(); }
        }

        public EditProductViewModel EditProductViewModel
        {
            get { return container.Get<EditProductViewModel>(); }
        }

    }
}
