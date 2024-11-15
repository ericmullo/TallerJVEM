namespace TallerJVEM;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToGridLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayoutPage());
    }

    private async void OnNavigateToStackLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayoutPage());
    }

    private async void OnNavigateToFlexLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutPage());
    }

    private async void OnNavigateToAbsoluteLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}
