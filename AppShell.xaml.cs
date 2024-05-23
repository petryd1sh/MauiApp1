using MauiApp1.Views;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            _ = GoToAsync("MainPage");
            Routing.RegisterRoute("KeypadPage", typeof(KeypadPage));
            Routing.RegisterRoute("MainPage", typeof(MainPage));
        }
    }
}
