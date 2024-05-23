using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class KeypadPage : ContentPage
{
	public KeypadPage(KeypadViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}