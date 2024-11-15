namespace TallerJVEM;

public partial class FlexLayoutPage : ContentPage
{
    public FlexLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToAbsoluteLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}
