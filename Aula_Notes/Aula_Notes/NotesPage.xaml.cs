namespace Aula_Notes;

public partial class NotesPage : ContentPage
{
	string path = Path.Combine(FileSystem.AppDataDirectory,"notes.txt");
	string content = "";
	public NotesPage()
	{
		InitializeComponent();
	}

	private void SaveClicked(object sender, EventArgs e)
	{
		content = Editor.Text;

		//cria um 
		File.WriteAllText(path, content);
	}

	private void DeleteClicked(object sender, EventArgs e)
	{

	}
}