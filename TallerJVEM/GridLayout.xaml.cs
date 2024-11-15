namespace TallerJVEM;

public partial class GridLayoutPage : ContentPage
{
    public GridLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToStackLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayoutPage());
    }
}
