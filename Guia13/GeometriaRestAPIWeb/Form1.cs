using GeometriaClientRestAPIWeb.DTOs;
using System.Net.Http.Json;

namespace GeometriaRestAPIWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         async private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://localhost:7257/api/Geometrias2";

                using var client = new HttpClient();

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url)
                };

                var response = await client.SendAsync(request);

                listBox1.Items.Clear();
                if (response.IsSuccessStatusCode)
                {
                    var lista = response.Content.ReadFromJsonAsync<List<figuraDTO>>();
                    listBox1.DataSource = lista.Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
