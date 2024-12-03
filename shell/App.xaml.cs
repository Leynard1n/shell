using Microsoft.Maui.Controls;
using shell;

namespace shell
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); // Указываем на AppShell
        }
    }
}