namespace DemoPage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);

            //Abordagem antiga de navegação
            //Navigation.PushAsync(new ContentPageDemo());

            //**Forma mais moderna de navegação com Shell, ao inves do Push. As rotas foram configuradas no AppShell.xaml.cs
            await Shell.Current.GoToAsync(nameof(ContentPageDemo));
        }
    }
}
