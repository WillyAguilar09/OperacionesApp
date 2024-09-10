using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace OperacionesApp.ViewModels
{
    public partial class AreaCirculoViewModel : ObservableObject
    {
        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private string resultado;

        public AreaCirculoViewModel()
        {
            CalcularAreaCommand = new RelayCommand(CalcularArea);
        }

        public ICommand CalcularAreaCommand { get; }

        private void CalcularArea()
        {
            if (Radio > 0)
            {
                double area = Math.PI * Radio * Radio;
                Resultado = $"El área del círculo es: {area:F2}";
            }
            else
            {
                Resultado = "Por favor, ingresa un valor válido para el radio.";
            }
        }
    }
}
