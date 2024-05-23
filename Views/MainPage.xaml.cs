using MauiApp1.ViewModels;

namespace MauiApp1.Views
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                CounterBtn.Text = $"Clicked {count} time";
                CounterBtn2.Text = $"Clicked {count} time";
            }
            else
            {
                CounterBtn.Text = $"Clicked {count} times";
                CounterBtn2.Text = $"Clicked {count*2} times";
            }
            
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnKeypadPageButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("KeypadPage");
        }
    }

}
