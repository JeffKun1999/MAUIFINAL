
namespace MJSCJR_TacoslaEnredadaInterfaz
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBtnComprar1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
            

        }
    }

}
