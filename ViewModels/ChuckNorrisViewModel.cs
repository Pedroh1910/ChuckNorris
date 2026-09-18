using ChuckNorris.Models;
using ChuckNorris.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ChuckNorris.ViewModels
{
    public partial class ChuckNorrisViewModel : ObservableObject
    {
        [ObservableProperty]
        private ChuckNorrisJoke _piada;

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private bool _isNotBusy = true;

        [ObservableProperty]
        private bool _temResultado;

        private readonly IChuckNorrisService _chuckNorrisService;

        public ChuckNorrisViewModel(IChuckNorrisService chuckNorrisService)
        {
            _chuckNorrisService = chuckNorrisService;
        }

        [RelayCommand]
        private async Task ObterPiada()
        {
            IsBusy = true;
            IsNotBusy = false;
            TemResultado = false;
            Piada = null;

            var dadosPiada = await _chuckNorrisService.ObterPiadaAleatoriaAsync();

            if (dadosPiada != null)
            {
                Piada = dadosPiada;
                TemResultado = true;
            }
            else
            {
                await Shell.Current.DisplayAlert("Ops!", "Não foi possível carregar o fato sobre Chuck Norris.", "Ok");
            }

            IsBusy = false;
            IsNotBusy = true;
        }
    }
}