using System.Runtime.Intrinsics.X86;
using Imc.Models;

namespace Imc.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		ImcLabel.Text = string.Empty;
		EstadoNutricionalLabel.Text = string.Empty;
	}
	
	private void OnCalcularButton_Clicked(object sender, EventArgs e)
	{
		try
		{
            decimal peso = decimal.Parse(PesoEntry.Text);
            decimal estatura = decimal.Parse(EstaturaEntry.Text);
			decimal imc = CalculadoraImc.IndiceMasaCorporal(peso, estatura);
			ImcLabel.Text = imc.ToString("F4");
			EstadoNutricionalLabel.Text = CalculadoraImc.EstadoNutricional(imc);
        }
		catch (Exception)
		{

			throw;
		}
		
	}

	private void OnLimpiarButton_Clicked(Object sender, EventArgs e)
	{
		PesoEntry.Text = string.Empty;
        EstaturaEntry.Text = string.Empty;
        ImcLabel.Text = string.Empty;
		EstadoNutricionalLabel.Text = string.Empty;
    }


}