using Desktop_TP_Final.Models;
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
    public partial class FormEdit : Form
    {
        String URI = "https://localhost:5001/api/v1/usuarios";
        Usuario usuarioParaEditar = null;
        public FormEdit(Usuario usuario)
        {
            InitializeComponent();
            usuarioParaEditar = usuario;
            txtNomeEditar.Text = usuario.Nome;
            txtSenhaEditar.Text = usuario.Senha;
            chkStatusEditar.Checked = usuario.Status;
        }

        private async void EditUsuarioById()
        {
            URI = URI + "/" + usuarioParaEditar.Id.ToString();
            Usuario prod = new Usuario();
            prod.Nome = txtNomeEditar.Text;
            prod.Senha = txtSenhaEditar.Text;
            prod.Status = chkStatusEditar.Checked;
            using (var client = new HttpClient())
            {


                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI, prod);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuário atualizado");
                    this.Close();
                    var gerenciar = new FormGerenciar();
                    gerenciar.Show();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o usuário : " + responseMessage.StatusCode);
                }

            }
        }

        private void editar_ok_btn_Click(object sender, EventArgs e)
        {
            EditUsuarioById();            
        }
    }
}
