using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace OperacionesApp.ViewModels
{
    public partial class AreaCuadradoViewModel : ObservableObject
    {
        [ObservableProperty]
        private double lado;

        [ObservableProperty]
        private string resultado;

        public AreaCuadradoViewModel()
        {
            CalcularAreaCommand = new RelayCommand(CalcularArea);
        }

        public ICommand CalcularAreaCommand { get; }

        private void CalcularArea()
        {
            if (Lado > 0)
            {
                double area = Lado * Lado;
                Resultado = $"El área del cuadrado es: {area}";
            }
            else
            {
                Resultado = "Por favor, ingresa un valor válido para el lado.";
            }
        }
    }
}