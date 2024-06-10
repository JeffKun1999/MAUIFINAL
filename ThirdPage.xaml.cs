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
        var nuevaNota = new Note
        {
            Text = $"Tu orden se ha generado exitosamente a la hora: {DateTime.Now} con el número de orden: 00 {count++}",
            Date = DateTime.Now
        };

        // Cargar las notas existentes
        var notas = NoteService.LoadNotes();
        notas.Add(nuevaNota);

        // Guardar las notas actualizadas
        NoteService.SaveNotes(notas);

        // Navegar a la página AllNoteRegistro

    }
    private async void OnBtnRegresarSP(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondPage());
    }
    private async void OnBtnTerminarCompra(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FourthPage());
    }
}
