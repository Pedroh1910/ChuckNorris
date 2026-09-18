using ChuckNorris.ViewModels;

namespace ChuckNorris.Views;

public partial class HarryPotterPage : ContentPage
{
    public HarryPotterPage(HarryPotterViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}