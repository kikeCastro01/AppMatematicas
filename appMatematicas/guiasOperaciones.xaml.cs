namespace appMatematicas;

public partial class guiasOperaciones : ContentPage
{
	public guiasOperaciones()
	{
		InitializeComponent();
	}

	private async void btnGuiaSuma_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new guiaSuma());
	}

	private async void btnGuiaResta_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new guiaResta());
	}

	private async void btnGuiaMultiplicacion_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new guiaMultiplicacion());
	}

	private async void btnGuiaDivision_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new guiaDivision());
	}
}