namespace appMatematicas;

public partial class ejerciciosOperaciones : ContentPage
{
	public ejerciciosOperaciones()
	{
		InitializeComponent();
	}

	private async void btnEjSuma_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ejerciciosSuma());
	}

	private async void btnEjResta_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ejerciciosResta());
	}

	private async void btnEjMultiplicacion_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ejerciciosMultiplicacion());
	}

	private async void btnEjDivision_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ejerciciosDivision());
	}
}