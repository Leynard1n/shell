using Microsoft.Maui.Controls;

namespace shell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSecondPageButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SecondPage");
        }
    }
}