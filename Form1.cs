using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ConversorDeMoedaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbMoeda.SelectedIndex = 0; // Define o valor padrão para USD
            AtualizarTaxaDeCambio();
        }

        private async void btnConverter_Click(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(txtValor.Text, out valor))
            {
                string? fromCurrency = cmbMoeda.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(fromCurrency))
                {
                    decimal taxaDeCambio = await ObterTaxaDeCambioAsync(fromCurrency, "BRL");
                    decimal valorBRL = valor * taxaDeCambio;
                    lblResultado.Text = $"Valor em BRL: {valorBRL:F2}";
                }
                else
                {
                    lblResultado.Text = "Selecione uma moeda.";
                }
            }
            else
            {
                lblResultado.Text = "Por favor, digite um valor válido.";
            }
        }

        private async void AtualizarTaxaDeCambio()
        {
            string? fromCurrency = cmbMoeda.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fromCurrency))
            {
                decimal taxaDeCambio = await ObterTaxaDeCambioAsync(fromCurrency, "BRL");
                lblTaxaDeCambio.Text = $"Taxa de câmbio atual: 1 {fromCurrency} = {taxaDeCambio:F2} BRL";
            }
            else
            {
                lblTaxaDeCambio.Text = "Selecione uma moeda.";
            }
        }

        private async Task<decimal> ObterTaxaDeCambioAsync(string fromCurrency, string toCurrency)
        {
            if (string.IsNullOrEmpty(fromCurrency) || string.IsNullOrEmpty(toCurrency))
            {
                throw new ArgumentNullException(nameof(fromCurrency), "A moeda não pode ser nula ou vazia.");
            }

            string url = $"https://api.exchangerate-api.com/v4/latest/{fromCurrency}";
            using HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            JObject json = JObject.Parse(response);
            JToken? rateToken = json["rates"]?[toCurrency];

            if (rateToken == null || !decimal.TryParse(rateToken.ToString(), out decimal rate))
            {
                throw new Exception("Erro ao obter a taxa de câmbio.");
            }

            return rate;
        }

        private void cmbMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTaxaDeCambio();
        }
    }
}
