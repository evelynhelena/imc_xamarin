using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                float peso = float.Parse(text_peso.Text);
                float altura = float.Parse(text_altura.Text);

                float resultado = peso / (altura * altura);

                if (resultado >= 25.0 && resultado <= 29.9)
                {
                    text_resultado.Text = "Sobrepeso " + resultado.ToString("F");
                }
                else if (resultado >= 30.0 && resultado <= 34.9)
                {
                    text_resultado.Text = "Obesidade Grau I " + resultado.ToString("F");
                }
                else if (resultado >= 35.0 && resultado <= 39.9)
                {
                    text_resultado.Text = "Obesidade Grau II " + resultado.ToString("F");
                }
                else if (resultado > 40.0)
                {
                    text_resultado.Text = "Obesidade Grau III " + resultado.ToString("F");
                }
                else
                {
                    text_resultado.Text = "Peso Ideal " + resultado.ToString("F");
                }
            }
            catch (Exception ex)
            {
                text_resultado.Text = "Ocorreu um erro!\n" + ex.Message;
            }
            
        }
    }
}