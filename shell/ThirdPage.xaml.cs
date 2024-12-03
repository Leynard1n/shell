using Microsoft.Maui.Controls;

namespace shell
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage"); 
        }
    }
}