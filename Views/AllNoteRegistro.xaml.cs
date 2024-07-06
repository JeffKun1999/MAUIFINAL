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

            var notes = NoteService.LoadNotes();
            var newNote = new Note
            {
                IDRegistro = NoteService.GetNextIDRegistro(),
                Text = $"Tu orden se ha generado exitosamente a la hora: {DateTime.Now} con el número de orden: 00 {NoteService.GetNextIDRegistro()}", // Asigna el texto adecuado
                Date = DateTime.Now
            };
            notes.Add(newNote);
            NoteService.SaveNotes(notes);

            // Actualiza la colección enlazada si es necesario
            await Navigation.PushAsync(new FourthPage());
            notesCollection.ItemsSource = NoteService.LoadNotes();

        }
    }
    }

