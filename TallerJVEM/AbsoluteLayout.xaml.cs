namespace TallerJVEM;

public partial class AbsoluteLayoutPage : ContentPage
{
    public AbsoluteLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToStore(object sender, EventArgs e)
    {
        await DisplayAlert("Navegación", "Redirigiendo a Tienda Liguista...", "OK");
    }
}
