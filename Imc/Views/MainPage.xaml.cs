using System.Runtime.Intrinsics.X86;
using Imc.Models;
using Imc.ViewModels;

namespace Imc.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}

}