namespace appMatematicas;

public partial class ejerciciosDivision : ContentPage
{
	Random random = new Random();
	int respuestaCorrecta1, respuestaCorrecta2, respuestaCorrecta3, respuestaCorrecta4, respuestaCorrecta5, respuestaCorrecta6, respuestaCorrecta7, respuestaCorrecta8, respuestaCorrecta9, respuestaCorrecta10;
	int respuestaUsuario1, respuestaUsuario2, respuestaUsuario3, respuestaUsuario4, respuestaUsuario5, respuestaUsuario6, respuestaUsuario7, respuestaUsuario8, respuestaUsuario9, respuestaUsuario10;
	List<Button> botonesOpcion1, botonesOpcion2, botonesOpcion3, botonesOpcion4, botonesOpcion5, botonesOpcion6, botonesOpcion7, botonesOpcion8, botonesOpcion9, botonesOpcion10;
	int rangoMin, rangoMax;

	public ejerciciosDivision()
	{
		InitializeComponent();
		botonesOpcion1 = new List<Button> { buttonOpcion1, buttonOpcion2, buttonOpcion3, buttonOpcion4 };
		botonesOpcion2 = new List<Button> { buttonOpcion5, buttonOpcion6, buttonOpcion7, buttonOpcion8 };
		botonesOpcion3 = new List<Button> { buttonOpcion9, buttonOpcion10, buttonOpcion11, buttonOpcion12 };
		botonesOpcion4 = new List<Button> { buttonOpcion13, buttonOpcion14, buttonOpcion15, buttonOpcion16 };
		botonesOpcion5 = new List<Button> { buttonOpcion17, buttonOpcion18, buttonOpcion19, buttonOpcion20 };
		botonesOpcion6 = new List<Button> { buttonOpcion21, buttonOpcion22, buttonOpcion23, buttonOpcion24 };
		botonesOpcion7 = new List<Button> { buttonOpcion25, buttonOpcion26, buttonOpcion27, buttonOpcion28 };
		botonesOpcion8 = new List<Button> { buttonOpcion29, buttonOpcion30, buttonOpcion31, buttonOpcion32 };
		botonesOpcion9 = new List<Button> { buttonOpcion33, buttonOpcion34, buttonOpcion35, buttonOpcion36 };
		botonesOpcion10 = new List<Button> { buttonOpcion37, buttonOpcion38, buttonOpcion39, buttonOpcion40 };
		pickerDificultad.SelectedItem = "Baja";
	}

	private void pickerDificultad_SelectedIndexChanged(object sender, EventArgs e)
	{
		// Reiniciar todas las respuestas a cero al cambiar la dificultad
		respuestaUsuario1 = 0;
		respuestaUsuario2 = 0;
		respuestaUsuario3 = 0;
		respuestaUsuario4 = 0;
		respuestaUsuario5 = 0;
		respuestaUsuario6 = 0;
		respuestaUsuario7 = 0;
		respuestaUsuario8 = 0;
		respuestaUsuario9 = 0;
		respuestaUsuario10 = 0;

		// Obtener la dificultad seleccionada
		string dificultad = pickerDificultad.SelectedItem.ToString();

		switch (dificultad)
		{
			case "Baja":
				rangoMin = 1;
				rangoMax = 10;
				break;
			case "Media":
				rangoMin = 10;
				rangoMax = 50;
				break;
			case "Alta":
				rangoMin = 50;
				rangoMax = 100;
				break;
		}

		// Generar los problemas con los rangos ajustados
		GenerarProblemas();
	}
	void GenerarProblemas()
	{
		// Primer problema
		int amigosHanna = random.Next(rangoMin, rangoMax); // Número aleatorio de amigos que tiene Ana
		int caramelosHanna = amigosHanna * random.Next(rangoMin, rangoMax); // Asegurar que el dividendo sea un múltiplo del divisor
		caramelosHanna += caramelosHanna % amigosHanna; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta1 = caramelosHanna / amigosHanna;
		problemLabel1.Text = $"1. Hanna tiene {caramelosHanna} caramelos y quiere repartirlos equitativamente entre sus {amigosHanna} amigos. ¿Cuántos caramelos recibirá cada amigo?";
		// Generar opciones de respuesta para el primer problema
		GenerarOpcionesRespuesta(respuestaCorrecta1, botonesOpcion1);

		// Segundo problema
		int ninosFiesta = random.Next(rangoMin, rangoMax); // Número aleatorio de niños en la fiesta
		int rebanadasPastel = ninosFiesta * random.Next(rangoMin, rangoMax); // Asegurar que el dividendo sea un múltiplo del divisor
		rebanadasPastel += rebanadasPastel % ninosFiesta; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta2 = rebanadasPastel / ninosFiesta;
		problemLabel2.Text = $"2. En una fiesta, hay {rebanadasPastel} rebanadas de pastel y se quieren repartir equitativamente entre {ninosFiesta} niños. ¿Cuántas rebanadas de pastel recibirá cada niño?";
		// Generar opciones de respuesta para el segundo problema
		GenerarOpcionesRespuesta(respuestaCorrecta2, botonesOpcion2);

		// Tercer problema
		int cestas = random.Next(rangoMin, rangoMax); // Número aleatorio de cestas
		int manzanas = cestas * random.Next(rangoMin, rangoMax); // Asegurar que el número de manzanas sea un múltiplo del número de cestas
		manzanas += manzanas % cestas; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta3 = manzanas / cestas;
		problemLabel3.Text = $"3. Un granjero tiene {manzanas} manzanas y quiere distribuirlas por igual entre sus {cestas} cestas. ¿Cuántas manzanas colocará en cada cesta?";
		// Generar opciones de respuesta para el tercer problema
		GenerarOpcionesRespuesta(respuestaCorrecta3, botonesOpcion3);

		// Cuarto problema
		int ninosCaja = random.Next(rangoMin, rangoMax); // Número aleatorio de niños en la caja
		int crayonesCaja = ninosCaja * random.Next(rangoMin, rangoMax); // Asegurar que el dividendo sea un múltiplo del divisor
		crayonesCaja += crayonesCaja % ninosCaja; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta4 = crayonesCaja / ninosCaja;
		problemLabel4.Text = $"4. En una caja hay {crayonesCaja} crayones y se quieren dividir equitativamente entre {ninosCaja} niños. ¿Cuántos crayones recibirá cada niño?";
		// Generar opciones de respuesta para el tercer problema
		GenerarOpcionesRespuesta(respuestaCorrecta4, botonesOpcion4);


		// Quinto problema
		int cuadernosAna = random.Next(rangoMin, rangoMax); // Número aleatorio de cuadernos de Ana
		int pegatinasAna = cuadernosAna * random.Next(rangoMin, rangoMax); // Asegurar que el dividendo sea un múltiplo del divisor
		pegatinasAna += pegatinasAna % cuadernosAna; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta5 = pegatinasAna / cuadernosAna;
		problemLabel5.Text = $"5. Ana tiene {pegatinasAna} pegatinas y quiere colocarlas en sus {cuadernosAna} cuadernos de manera equitativa. ¿Cuántas pegatinas colocará en cada cuaderno?";
		// Generar opciones de respuesta para el quinto problema
		GenerarOpcionesRespuesta(respuestaCorrecta5, botonesOpcion5);

		// Sexto problema
		int globosPorBolsa = random.Next(rangoMin, rangoMax); // Número aleatorio de globos por bolsa
		int globosVendedor = globosPorBolsa * random.Next(rangoMin, rangoMax); // Número aleatorio de globos que tiene el vendedor
		globosVendedor += globosVendedor % globosPorBolsa;
		respuestaCorrecta6 = globosVendedor / globosPorBolsa;
		problemLabel6.Text = $"6. Un vendedor tiene {globosVendedor} globos y quiere empaquetarlos en bolsas de {globosPorBolsa} globos cada una. ¿Cuántas bolsas necesitará para empaquetar todos los globos?";
		// Generar opciones de respuesta para el sexto problema
		GenerarOpcionesRespuesta(respuestaCorrecta6, botonesOpcion6);

		// Séptimo problema
		int jugadores = random.Next(rangoMin, rangoMax); // Número aleatorio de jugadores
		int fichasJuego = jugadores * random.Next(rangoMin, rangoMax); // Número aleatorio de fichas en el juego
		fichasJuego += fichasJuego % jugadores; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta7 = fichasJuego / jugadores;
		problemLabel7.Text = $"7. En un juego de mesa, hay {fichasJuego} fichas y se quieren repartir equitativamente entre {jugadores} jugadores. ¿Cuántas fichas recibirá cada jugador?";
		// Generar opciones de respuesta para el séptimo problema
		GenerarOpcionesRespuesta(respuestaCorrecta7, botonesOpcion7);

		// Octavo problema
		int ninos = random.Next(rangoMin, rangoMax); // Número aleatorio de niños
		int bloquesJuguete = ninos * random.Next(rangoMin, rangoMax); // Número aleatorio de bloques en la caja de juguetes
		bloquesJuguete += bloquesJuguete % ninos; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta8 = bloquesJuguete / ninos;
		problemLabel8.Text = $"8. En una caja de juguetes, hay {bloquesJuguete} bloques de construcción y se quieren distribuir de manera equitativa entre {ninos} niños. ¿Cuántos bloques de construcción recibirá cada niño?";
		// Generar opciones de respuesta para el octavo problema
		GenerarOpcionesRespuesta(respuestaCorrecta8, botonesOpcion8);

		// Noveno problema
		int ninosFeria = random.Next(rangoMin, rangoMax); // Número aleatorio de niños en la feria
		int globosFeria = ninosFeria * random.Next(rangoMin, rangoMax); // Número aleatorio de globos en la feria
		globosFeria += globosFeria % ninosFeria; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta9 = globosFeria / ninosFeria;
		problemLabel9.Text = $"9. En una feria, hay {globosFeria} globos y se quieren repartir equitativamente entre {ninosFeria} niños. ¿Cuántos globos recibirá cada niño?";
		// Generar opciones de respuesta para el noveno problema
		GenerarOpcionesRespuesta(respuestaCorrecta9, botonesOpcion9);

		// Décimo problema
		int equiposCampo = random.Next(rangoMin, rangoMax); // Número aleatorio de equipos en el campo de juegos
		int pelotasCampo = equiposCampo * random.Next(rangoMin, rangoMax); // Número aleatorio de pelotas en el campo de juegos
		pelotasCampo += pelotasCampo % equiposCampo; // Asegurar que el dividendo sea un múltiplo del divisor
		respuestaCorrecta10 = pelotasCampo / equiposCampo;
		problemLabel10.Text = $"10. En un campo de juegos, hay {pelotasCampo} pelotas y se quieren distribuir equitativamente entre {equiposCampo} equipos. ¿Cuántas pelotas recibirá cada equipo?";
		// Generar opciones de respuesta para el decimo problema
		GenerarOpcionesRespuesta(respuestaCorrecta10, botonesOpcion10);

	}

	void GenerarOpcionesRespuesta(int respuestaCorrecta, List<Button> botonesOpcion)
	{
		List<int> opciones = new List<int>();
		opciones.Add(respuestaCorrecta);
		int rangoMinOpciones = 1;  // Valor por defecto
		int rangoMaxOpciones = 50; // Valor por defecto

		switch (pickerDificultad.SelectedItem.ToString())
		{
			case "Baja":
				rangoMinOpciones = 1;
				rangoMaxOpciones = 15;
				break;
			case "Media":
				rangoMinOpciones = 10;
				rangoMaxOpciones = 75;
				break;
			case "Alta":
				rangoMinOpciones = 50;
				rangoMaxOpciones = 150;
				break;
		}

		while (opciones.Count < 4) // Genera 3 opciones incorrectas
		{
			int opcionIncorrecta = random.Next(rangoMinOpciones, rangoMaxOpciones); // Utiliza los rangos de la dificultad
			if (!opciones.Contains(opcionIncorrecta) && opcionIncorrecta != respuestaCorrecta)
			{
				opciones.Add(opcionIncorrecta);
			}
		}
		opciones = opciones.OrderBy(x => random.Next()).ToList(); // Baraja las opciones

		// Asignar opciones a los botones
		for (int i = 0; i < botonesOpcion.Count; i++)
		{
			botonesOpcion[i].Text = opciones[i].ToString();
			botonesOpcion[i].BackgroundColor = Colors.White; // Restaurar el color blanco
		}
	}

	void ButtonOpcion_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del primer problema
		foreach (Button btn in botonesOpcion1)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del primer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario1 = Convert.ToInt32(button.Text);
	}

	void ButtonOpcion2_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del segundo problema
		foreach (Button btn in botonesOpcion2)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del segundo problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario2 = Convert.ToInt32(button.Text);
	}

	void ButtonOpcion3_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del tercer problema
		foreach (Button btn in botonesOpcion3)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del tercer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario3 = Convert.ToInt32(button.Text);
	}

	void ButtonOpcion4_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del tercer problema
		foreach (Button btn in botonesOpcion4)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del tercer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario4 = Convert.ToInt32(button.Text);
	}

	void ButtonOpcion5_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del tercer problema
		foreach (Button btn in botonesOpcion5)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del tercer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario5 = Convert.ToInt32(button.Text);
	}
	void ButtonOpcion6_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del tercer problema
		foreach (Button btn in botonesOpcion6)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del tercer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario6 = Convert.ToInt32(button.Text);
	}
	void ButtonOpcion7_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del tercer problema
		foreach (Button btn in botonesOpcion7)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del tercer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario7 = Convert.ToInt32(button.Text);
	}
	void ButtonOpcion8_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del tercer problema
		foreach (Button btn in botonesOpcion8)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del tercer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario8 = Convert.ToInt32(button.Text);
	}
	void ButtonOpcion9_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del tercer problema
		foreach (Button btn in botonesOpcion9)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del tercer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario9 = Convert.ToInt32(button.Text);
	}
	void ButtonOpcion10_Clicked(object sender, EventArgs e)
	{
		// Desmarcar todas las opciones del tercer problema
		foreach (Button btn in botonesOpcion10)
		{
			btn.BackgroundColor = Colors.White;
		}

		// Marcar la opción seleccionada del tercer problema
		Button button = (Button)sender;
		button.BackgroundColor = Colors.LightBlue;
		respuestaUsuario10 = Convert.ToInt32(button.Text);
	}
	void ButtonEvaluar_Clicked(object sender, EventArgs e)
	{
		if (TodasLasRespuestasCompletas())
		{
			bool respuesta1Correcta = respuestaUsuario1 == respuestaCorrecta1;
			bool respuesta2Correcta = respuestaUsuario2 == respuestaCorrecta2;
			bool respuesta3Correcta = respuestaUsuario3 == respuestaCorrecta3;
			bool respuesta4Correcta = respuestaUsuario4 == respuestaCorrecta4;
			bool respuesta5Correcta = respuestaUsuario5 == respuestaCorrecta5;
			bool respuesta6Correcta = respuestaUsuario6 == respuestaCorrecta6;
			bool respuesta7Correcta = respuestaUsuario7 == respuestaCorrecta7;
			bool respuesta8Correcta = respuestaUsuario8 == respuestaCorrecta8;
			bool respuesta9Correcta = respuestaUsuario9 == respuestaCorrecta9;
			bool respuesta10Correcta = respuestaUsuario10 == respuestaCorrecta10;

			// Desmarcar todas las opciones
			foreach (Button btn in botonesOpcion1.Concat(botonesOpcion2).Concat(botonesOpcion3).Concat(botonesOpcion4).Concat(botonesOpcion5).Concat(botonesOpcion6).Concat(botonesOpcion7).Concat(botonesOpcion8).Concat(botonesOpcion9).Concat(botonesOpcion10))
			{
				btn.BackgroundColor = Colors.White;
			}

			// Marcar las respuestas correctas en verde
			if (respuesta1Correcta)
			{
				foreach (Button btn in botonesOpcion1)
				{
					if (btn.Text == respuestaCorrecta1.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta2Correcta)
			{
				foreach (Button btn in botonesOpcion2)
				{
					if (btn.Text == respuestaCorrecta2.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta3Correcta)
			{
				foreach (Button btn in botonesOpcion3)
				{
					if (btn.Text == respuestaCorrecta3.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta4Correcta)
			{
				foreach (Button btn in botonesOpcion4)
				{
					if (btn.Text == respuestaCorrecta4.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta5Correcta)
			{
				foreach (Button btn in botonesOpcion5)
				{
					if (btn.Text == respuestaCorrecta5.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta6Correcta)
			{
				foreach (Button btn in botonesOpcion6)
				{
					if (btn.Text == respuestaCorrecta6.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta7Correcta)
			{
				foreach (Button btn in botonesOpcion7)
				{
					if (btn.Text == respuestaCorrecta7.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta8Correcta)
			{
				foreach (Button btn in botonesOpcion8)
				{
					if (btn.Text == respuestaCorrecta8.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta9Correcta)
			{
				foreach (Button btn in botonesOpcion9)
				{
					if (btn.Text == respuestaCorrecta9.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			if (respuesta10Correcta)
			{
				foreach (Button btn in botonesOpcion10)
				{
					if (btn.Text == respuestaCorrecta10.ToString())
						btn.BackgroundColor = Colors.Green;
				}
			}

			// Marcar las respuestas incorrectas en rojo
			if (!respuesta1Correcta)
			{
				foreach (Button btn in botonesOpcion1)
				{
					if (btn.Text == respuestaUsuario1.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta2Correcta)
			{
				foreach (Button btn in botonesOpcion2)
				{
					if (btn.Text == respuestaUsuario2.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta3Correcta)
			{
				foreach (Button btn in botonesOpcion3)
				{
					if (btn.Text == respuestaUsuario3.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta4Correcta)
			{
				foreach (Button btn in botonesOpcion4)
				{
					if (btn.Text == respuestaUsuario4.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta5Correcta)
			{
				foreach (Button btn in botonesOpcion5)
				{
					if (btn.Text == respuestaUsuario5.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta6Correcta)
			{
				foreach (Button btn in botonesOpcion6)
				{
					if (btn.Text == respuestaUsuario6.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta7Correcta)
			{
				foreach (Button btn in botonesOpcion7)
				{
					if (btn.Text == respuestaUsuario7.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta8Correcta)
			{
				foreach (Button btn in botonesOpcion8)
				{
					if (btn.Text == respuestaUsuario8.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta9Correcta)
			{
				foreach (Button btn in botonesOpcion9)
				{
					if (btn.Text == respuestaUsuario9.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			if (!respuesta10Correcta)
			{
				foreach (Button btn in botonesOpcion10)
				{
					if (btn.Text == respuestaUsuario10.ToString())
						btn.BackgroundColor = Colors.Red;
				}
			}

			// Calcular la calificación
			int respuestasCorrectas = (respuesta1Correcta ? 1 : 0) + (respuesta2Correcta ? 1 : 0) + (respuesta3Correcta ? 1 : 0) + (respuesta4Correcta ? 1 : 0) + (respuesta5Correcta ? 1 : 0) + (respuesta6Correcta ? 1 : 0) + (respuesta7Correcta ? 1 : 0) + (respuesta8Correcta ? 1 : 0) + (respuesta9Correcta ? 1 : 0) + (respuesta10Correcta ? 1 : 0);

			// Mostrar mensaje con la calificación obtenida
			string mensajeCalificacion = ObtenerMensajeCalificacion(respuestasCorrectas);
			DisplayAlert($"Calificación: {respuestasCorrectas}/10.", mensajeCalificacion, "OK");
		}
		else
		{
			DisplayAlert("Error", "Por favor selecciona una opción para cada problema antes de evaluar.", "OK");
		}

		bool TodasLasRespuestasCompletas()
		{
			return respuestaUsuario1 != 0 && respuestaUsuario2 != 0 && respuestaUsuario3 != 0 &&
				   respuestaUsuario4 != 0 && respuestaUsuario5 != 0 && respuestaUsuario6 != 0 &&
				   respuestaUsuario7 != 0 && respuestaUsuario8 != 0 && respuestaUsuario9 != 0 &&
				   respuestaUsuario10 != 0;
		}

		string ObtenerMensajeCalificacion(int respuestasCorrectas)
		{
			string mensajeCalificacion;
			switch (respuestasCorrectas)
			{
				case 10:
					mensajeCalificacion = "¡Excelente trabajo! Eres un genio de las matemáticas.";
					break;
				case 9:
					mensajeCalificacion = "¡Casi perfecto! Solo una respuesta incorrecta. ¡Sigue así!";
					break;
				case 8:
				case 7:
					mensajeCalificacion = "¡Muy bien! Has mostrado un buen dominio de las sumas.";
					break;
				case 6:
				case 5:
				case 4:
					mensajeCalificacion = "¡Buen esfuerzo! Sigue practicando para mejorar tus habilidades.";
					break;
				default:
					mensajeCalificacion = "¡Ups! Parece que necesitas practicar un poco más.";
					break;
			}
			return mensajeCalificacion;
		}
	}
}