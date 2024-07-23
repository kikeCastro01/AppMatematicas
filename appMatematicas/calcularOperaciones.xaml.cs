namespace appMatematicas;

public partial class calcularOperaciones : ContentPage
{
	public calcularOperaciones()
	{
		InitializeComponent();
	}

	private void operacionPicker_SelectedIndexChanged(object sender, EventArgs e)
	{
		// Obtener el índice de la operación seleccionada en el ComboBox
		int selectedIndex = operacionPicker.SelectedIndex;
		// Asignar el signo de la operación al Label
		switch (selectedIndex)
		{
			case 0:
				operationLabel.Text = "+"; // Suma
				break;
			case 1:
				operationLabel.Text = "-"; // Resta
				break;
			case 2:
				operationLabel.Text = "×"; // Multiplicación
				break;
			case 3:
				operationLabel.Text = "÷"; // División
				break;
		}
	}

	private void btnCalcular_Clicked(object sender, EventArgs e)
	{
		// Validar que ambos números y la operación estén seleccionados
		if (string.IsNullOrWhiteSpace(tbPrimerNumero.Text) || string.IsNullOrWhiteSpace(tbSegundoNumero.Text))
		{
			// Mostrar mensaje de error si falta algún número
			DisplayAlert("Error", "Por favor ingresa ambos números antes de calcular.", "OK");
		}
		else if (operacionPicker.SelectedIndex == -1)
		{
			// Mostrar mensaje de error si no se ha seleccionado una operación
			DisplayAlert("Error", "Por favor selecciona una operación antes de calcular.", "OK");
		}
		else
		{
			// Obtener los números ingresados por el usuario desde los TextBox
			double primerNumero = double.Parse(tbPrimerNumero.Text);
			double segundoNumero = double.Parse(tbSegundoNumero.Text);

			// Realizar la operación seleccionada
			double resultado = 0;
			switch (operacionPicker.SelectedIndex)
			{
				case 0: // Suma
					resultado = primerNumero + segundoNumero;
					break;
				case 1: // Resta
					resultado = primerNumero - segundoNumero;
					break;
				case 2: // Multiplicación
					resultado = primerNumero * segundoNumero;
					break;
				case 3: // División
					if (segundoNumero != 0)
						resultado = primerNumero / segundoNumero;
					else
						lbResultado.Text = "Error: División por cero";
					break;
			}
			// Mostrar el resultado en el Label
			lbResultado.Text = resultado.ToString();
		}
	}
}