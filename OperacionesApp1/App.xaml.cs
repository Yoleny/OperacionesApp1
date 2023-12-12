using Application = Microsoft.Maui.Controls.Application;

namespace OperacionesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OperacionesApp1.MainPage();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}