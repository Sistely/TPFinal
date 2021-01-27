
namespace Desktop_TP_Final
{
    partial class FormGerenciar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listUsuarios = new System.Windows.Forms.ListBox();
            this.btnDeletarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsuarios
            // 
            this.listUsuarios.FormattingEnabled = true;
            this.listUsuarios.Location = new System.Drawing.Point(97, 55);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(152, 199);
            this.listUsuarios.TabIndex = 0;
            // 
            // btnDeletarUsuario
            // 
            this.btnDeletarUsuario.Location = new System.Drawing.Point(228, 12);
            this.btnDeletarUsuario.Name = "btnDeletarUsuario";
            this.btnDeletarUsuario.Size = new System.Drawing.Size(109, 23);
            this.btnDeletarUsuario.TabIndex = 6;
            this.btnDeletarUsuario.Text = "Deletar Usuario";
            this.btnDeletarUsuario.UseVisualStyleBackColor = true;
            this.btnDeletarUsuario.Click += new System.EventHandler(this.deletar_btn_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(109, 23);
            this.btnEditarUsuario.TabIndex = 7;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.editar_btn_Click);
            // 
            // FormGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 266);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnDeletarUsuario);
            this.Controls.Add(this.listUsuarios);
            this.Name = "FormGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuários";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listUsuarios;
        private System.Windows.Forms.Button btnDeletarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
    }
}