
namespace Desktop_TP_Final
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarUsuario = new System.Windows.Forms.Button();
            this.btnGerenciarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarUsuario
            // 
            this.btnCriarUsuario.Location = new System.Drawing.Point(67, 12);
            this.btnCriarUsuario.Name = "btnCriarUsuario";
            this.btnCriarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCriarUsuario.TabIndex = 0;
            this.btnCriarUsuario.Text = "Criar Usuario";
            this.btnCriarUsuario.UseVisualStyleBackColor = true;
            this.btnCriarUsuario.Click += new System.EventHandler(this.criar_usuario_btn_Click);
            // 
            // btnGerenciarUsuario
            // 
            this.btnGerenciarUsuario.Location = new System.Drawing.Point(41, 55);
            this.btnGerenciarUsuario.Name = "btnGerenciarUsuario";
            this.btnGerenciarUsuario.Size = new System.Drawing.Size(130, 23);
            this.btnGerenciarUsuario.TabIndex = 1;
            this.btnGerenciarUsuario.Text = "Gerenciar Usuarios";
            this.btnGerenciarUsuario.UseVisualStyleBackColor = true;
            this.btnGerenciarUsuario.Click += new System.EventHandler(this.gerenciar_btn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 101);
            this.Controls.Add(this.btnGerenciarUsuario);
            this.Controls.Add(this.btnCriarUsuario);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar/Gerenciar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarUsuario;
        private System.Windows.Forms.Button btnGerenciarUsuario;
    }
}

