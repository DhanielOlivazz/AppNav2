using AppNav2.Vistas;

namespace AppNav2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LogIn();
        }
    }
}
