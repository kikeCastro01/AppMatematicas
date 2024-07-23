namespace appMatematicas;

public partial class calcularOperaciones : ContentPage
{
	public calcularOperaciones()
	{
		InitializeComponent();
	}

	private void operacionPicker_SelectedIndexChanged(object sender, EventArgs e)
	{
		// Obtener el �ndice de la operaci�n seleccionada en el ComboBox
		int selectedIndex = operacionPicker.SelectedIndex;
		// Asignar el signo de la operaci�n al Label
		switch (selectedIndex)
		{
			case 0:
				operationLabel.Text = "+"; // Suma
				break;
			case 1:
				operationLabel.Text = "-"; // Resta
				break;
			case 2:
				operationLabel.Text = "�"; // Multiplicaci�n
				break;
			case 3:
				operationLabel.Text = "�"; // Divisi�n
				break;
		}
	}

	private void btnCalcular_Clicked(object sender, EventArgs e)
	{
		// Validar que ambos n�meros y la operaci�n est�n seleccionados
		if (string.IsNullOrWhiteSpace(tbPrimerNumero.Text) || string.IsNullOrWhiteSpace(tbSegundoNumero.Text))
		{
			// Mostrar mensaje de error si falta alg�n n�mero
			DisplayAlert("Error", "Por favor ingresa ambos n�meros antes de calcular.", "OK");
		}
		else if (operacionPicker.SelectedIndex == -1)
		{
			// Mostrar mensaje de error si no se ha seleccionado una operaci�n
			DisplayAlert("Error", "Por favor selecciona una operaci�n antes de calcular.", "OK");
		}
		else
		{
			// Obtener los n�meros ingresados por el usuario desde los TextBox
			double primerNumero = double.Parse(tbPrimerNumero.Text);
			double segundoNumero = double.Parse(tbSegundoNumero.Text);

			// Realizar la operaci�n seleccionada
			double resultado = 0;
			switch (operacionPicker.SelectedIndex)
			{
				case 0: // Suma
					resultado = primerNumero + segundoNumero;
					break;
				case 1: // Resta
					resultado = primerNumero - segundoNumero;
					break;
				case 2: // Multiplicaci�n
					resultado = primerNumero * segundoNumero;
					break;
				case 3: // Divisi�n
					if (segundoNumero != 0)
						resultado = primerNumero / segundoNumero;
					else
						lbResultado.Text = "Error: Divisi�n por cero";
					break;
			}
			// Mostrar el resultado en el Label
			lbResultado.Text = resultado.ToString();
		}
	}
}