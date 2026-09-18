using ChuckNorris.ViewModels;

namespace ChuckNorris.Views;

public partial class ChuckNorrisPage : ContentPage
{
    public ChuckNorrisPage(ChuckNorrisViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}