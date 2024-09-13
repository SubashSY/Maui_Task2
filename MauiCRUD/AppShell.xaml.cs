using MauiCRUD.Views;

namespace MauiCRUD
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CarDetailsPage), typeof(CarDetailsPage));
        }
    }
}
