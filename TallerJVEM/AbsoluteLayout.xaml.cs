namespace TallerJVEM;

public partial class AbsoluteLayoutPage : ContentPage
{
    public AbsoluteLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToGridLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayoutPage());
    }
}
