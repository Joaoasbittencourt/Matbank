using System.Windows;
using Caliburn.Micro;
using Matbank.ViewModels;

namespace Matbank
{
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // Our launch point is our view model.
            // Here we need to pass a view model to start
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
