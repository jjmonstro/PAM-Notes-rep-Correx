namespace Aula_Notes;

public partial class NotesPage : ContentPage
{
    string path = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    string content = "";

    public NotesPage()
    {
        InitializeComponent();
        if (File.Exists(path))
        {
            Editor.Text = File.ReadAllText(path);
        }

    }

    private void SaveClicked(object sender, EventArgs e)
    {
        content = Editor.Text;

        //cria um 
        File.WriteAllText(path, content);
        DisplayAlert("Receba", "Arquivo criado", "OK");
    }

    private void DeleteClicked(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Editor.Text = "";
            DisplayAlert("Pereça", "Arquivo deletado", "OK");
        }
    }
}