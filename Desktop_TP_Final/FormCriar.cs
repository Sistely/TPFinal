using Desktop_TP_Final.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_TP_Final
{
    public partial class FormCriar : Form
    {
        public FormCriar()
        {          
            InitializeComponent();
        }


        private async void AddUsuario()
        {
            String URI = "https://localhost:5001/api/v1/usuarios";
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Status = chkStatus.Checked;
            using (var client = new HttpClient())
            {
                var serializedUsuario = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(serializedUsuario, Encoding.UTF8, "application/json");
     
                HttpResponseMessage responseMessage = await client.PostAsync(URI, content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuário Criado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao criar o usuário : " + responseMessage.StatusCode);
                }
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            AddUsuario();
        }
    }
}
