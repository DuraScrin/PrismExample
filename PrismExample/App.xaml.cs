using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismExample.ViewModel;
using PrismExample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//#80
//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismExample 
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base (initializer)
        {
            
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //#82
            NavigationService.NavigateAsync("NavigationPage/BooksPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //#81 link model to viewModel
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<BookPage, BooksVM>();
            containerRegistry.RegisterForNavigation<NewBookPage, NewBookVM>();
            containerRegistry.RegisterForNavigation<BookDetailsPage, BookDetailsVM>();
        }
    }
}
