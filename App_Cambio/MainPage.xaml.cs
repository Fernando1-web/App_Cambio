namespace App_Cambio;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
		double Total, Pago, Cambio;

		Total = Convert.ToDouble(EntryTotal.Text);
		Pago = Convert.ToDouble(EntryPago.Text);

		Cambio = Pago - Total;

		LblResultado.Text = "$" + Cambio.ToString();
    }
}

