namespace DemoPage
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {

            //******Configurando rota para navegação com Shell
            Routing.RegisterRoute(nameof(ContentPageDemo), typeof(ContentPageDemo));
            InitializeComponent();

        }
    }
}
