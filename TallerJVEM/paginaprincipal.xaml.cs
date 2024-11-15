namespace TallerJVEM;

public partial class paginaprincipal : ContentPage
{
	public paginaprincipal()
	{
		InitializeComponent();
	}

    private void Boton2_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();

    }
}