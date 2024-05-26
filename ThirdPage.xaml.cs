namespace MJSCJR_TacoslaEnredadaInterfaz;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
    {
        InitializeComponent();
    }

    private async void OnBtnRegresarHome(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
