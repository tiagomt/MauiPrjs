namespace DemoPage;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {

        //****Voltando para a página anterior na pilha de navegação
        await Shell.Current.GoToAsync("..");

    }
}