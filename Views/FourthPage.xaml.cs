namespace MJSCJR_TacoslaEnredadaInterfaz;

public partial class FourthPage : ContentPage
{
    public FourthPage()
    {
        InitializeComponent();

    }

    private async void OnBtnRegresarHome(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}