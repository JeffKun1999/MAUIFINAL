using System.Collections.ObjectModel;
using MJSCJR_TacoslaEnredadaInterfaz.Models;

namespace MJSCJR_TacoslaEnredadaInterfaz
{
    public partial class AllNoteRegistro : ContentPage
    {
        public ObservableCollection<Note> Notes { get; set; }

        public AllNoteRegistro()
        {
            InitializeComponent();
            Notes = new ObservableCollection<Note>(NoteService.LoadNotes());
            BindingContext = this;
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Implementar lógica para manejar la selección de notas
        }

        private async void OnbtnRegresar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }

        private async void OnBtnTerminarCompra(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FourthPage());
        }
    }
}
