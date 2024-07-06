using MJSCJR_TacoslaEnredadaInterfaz.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MJSCJR_TacoslaEnredadaInterfaz;

public partial class ThirdPage : ContentPage
{
    private static int count = 0;
    public ThirdPage()
    {
        InitializeComponent();


    }


    private async void OnbtnComprar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AllNoteRegistro());
       
    }
    private async void OnBtnRegresarSP(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondPage());
    }
    
}
