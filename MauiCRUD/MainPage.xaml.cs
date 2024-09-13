
using MauiCRUD.ViewModels;

namespace MauiCRUD
{
    public partial class MainPage : ContentPage
    {
        public MainPage(CarListViewModel carListViewModel)
        {
            InitializeComponent();
            BindingContext = carListViewModel;
        }
    }

}
