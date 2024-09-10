using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace OperacionesApp.ViewModels
{
    public partial class AreaRectanguloViewModel : ObservableObject
    {
        [ObservableProperty]
        private double @base;

        [ObservableProperty]
        private double altura;

        [ObservableProperty]
        private string resultado;

        public AreaRectanguloViewModel()
        {
            CalcularAreaCommand = new RelayCommand(CalcularArea);
        }

        public ICommand CalcularAreaCommand { get; }

        private void CalcularArea()
        {
            if (Base > 0 && Altura > 0)
            {
                double area = Base * Altura;
                Resultado = $"El área del rectángulo es: {area}";
            }
            else
            {
                Resultado = "Por favor, ingresa valores válidos para la base y la altura.";
            }
        }
    }
}
