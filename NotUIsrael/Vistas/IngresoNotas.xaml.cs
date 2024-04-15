﻿namespace NotUIsrael.Vistas;

public partial class IngresoNotas : ContentPage
{
	public IngresoNotas()
	{
		InitializeComponent();
	}
    public bool ValidarNumero(int numero)
    {
        if (numero < 0 || numero > 10)
        {
            return true; //  falla  condición
        }
        else
        {
            return false; // No  falla condición
        }
    }

    void CalcularNotFinal_Clicked(System.Object sender, System.EventArgs e)
    {
        int notaSeguimiento1 = int.Parse(notSeguimiento1.Text);
        int notaExamen1 = int.Parse(notExamen1.Text);

        int notaSeguimiento2 = int.Parse(notSeguimiento2.Text);
        int notaExamen2 = int.Parse(notExamen2.Text);

        bool evaluar = false;
        string mensaje = "";
        if (ValidarNumero(notaSeguimiento1))
        {
            mensaje += "\n Error: La Nota Seguimiento 1 no cumple con la condición (0 <= número <= 10)";
            evaluar = true;
        }
        if (ValidarNumero(notaExamen1))
        {
            mensaje += "\n Error: La Nota Examen 1 no cumple con la condición (0 <= número <= 10)";
            evaluar = true;
        }
        if (ValidarNumero(notaSeguimiento2))
        {
            mensaje += "\n Error: La Nota Seguimiento 2 no cumple con la condición (0 <= número <= 10)";
            evaluar = true;
        }
        if (ValidarNumero(notaExamen2))
        {
            mensaje += "\n Error: La Nota Examen 2 no cumple con la condición (0 <= número <= 10)";
            evaluar = true;
        }
        if (!evaluar) {
            notaFinal1.Text = ((notaSeguimiento1*0.3) + (notaExamen1*0.2)).ToString();
            notaFinal2.Text = ((notaSeguimiento2 * 0.3) + (notaExamen2 * 0.2)).ToString();
            double total = ((notaSeguimiento1 * 0.3) + (notaExamen1 * 0.2)) + ((notaSeguimiento2 * 0.3) + (notaExamen2 * 0.2));
            DisplayAlert(
                "Tu Nota Es",
                total.ToString(),
                "OK"

                );
        }
        else {
            DisplayAlert(
                "Verificar Data",
                mensaje,
                "OK"

                );
        }
        


    }
}
