
using System.Xml;

namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{
    int dadosLados = 0;
    int quantidadeDados = 0;
    int valordDado = 0;
    public DiceView()
	{
		InitializeComponent();
	}

    private void rolarBtn_Clicked(object sender, EventArgs e)
    {
        float dadoAnterior = 0.0f;
        float dadoResultado = 0.0f;
        dadosInfo();
        teste02.Text = "";
        for (int i = 0; i < quantidadeDados; i++)
        {
            teste02.Text += valordDado.ToString() + "  ";
            dadoResultado = dadoAnterior + rolarDado(dadosLados);
            dadoAnterior = rolarDado(dadosLados);

        }
        teste01.Text = dadoResultado.ToString();
    }
    private void dadosInfo() 
    {

        dadosLados = int.Parse((string)dadosLadosPicker.SelectedItem);
        quantidadeDados = int.Parse((string)quantidadeDadosPicker.SelectedItem);
        
    }

    private int rolarDado(int valorDado)
    {
        valordDado = new Random().Next(1, valorDado + 1);
        return valordDado;
    }
}