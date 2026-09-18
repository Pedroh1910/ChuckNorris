using ChuckNorris.Models;
using ChuckNorris.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChuckNorris.ViewModels
{
    public partial class HarryPotterViewModel : ObservableObject
    {
        [ObservableProperty]
        private HarryPotterCharacter _personagem;

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private bool _isNotBusy = true;

        [ObservableProperty]
        private bool _temResultado;

        private readonly IHarryPotterService _harryPotterService;

        public HarryPotterViewModel(IHarryPotterService harryPotterService)
        {
            _harryPotterService = harryPotterService;
        }

        [RelayCommand]
        private async Task ObterPersonagem()
        {
            IsBusy = true;
            IsNotBusy = false;
            TemResultado = false;
            Personagem = null;

            var dadosPersonagem = await _harryPotterService.ObterPersonagemAleatorioAsync();

            if (dadosPersonagem != null)
            {
                Personagem = dadosPersonagem;
                TemResultado = true;
            }
            else
            {
                await Shell.Current.DisplayAlert("Ops!", "Não foi possível carregar o personagem de Harry Potter.", "Ok");
            }

            IsBusy = false;
            IsNotBusy = true;
        }
    }
}