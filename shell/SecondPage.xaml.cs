using Microsoft.Maui.Controls;

namespace shell
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void OnThirdPageButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ThirdPage");
        }
    }
}