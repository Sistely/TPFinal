
namespace Desktop_TP_Final
{
    partial class FormEdit
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.chkStatusEditar = new System.Windows.Forms.CheckBox();
            this.txtSenhaEditar = new System.Windows.Forms.TextBox();
            this.txtNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 84);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.editar_ok_btn_Click);
            // 
            // chkStatusEditar
            // 
            this.chkStatusEditar.AutoSize = true;
            this.chkStatusEditar.Location = new System.Drawing.Point(163, 88);
            this.chkStatusEditar.Name = "chkStatusEditar";
            this.chkStatusEditar.Size = new System.Drawing.Size(56, 17);
            this.chkStatusEditar.TabIndex = 11;
            this.chkStatusEditar.Text = "Status";
            this.chkStatusEditar.UseVisualStyleBackColor = true;
            // 
            // txtSenhaEditar
            // 
            this.txtSenhaEditar.Location = new System.Drawing.Point(53, 51);
            this.txtSenhaEditar.Name = "txtSenhaEditar";
            this.txtSenhaEditar.Size = new System.Drawing.Size(166, 20);
            this.txtSenhaEditar.TabIndex = 10;
            // 
            // txtNomeEditar
            // 
            this.txtNomeEditar.Location = new System.Drawing.Point(53, 11);
            this.txtNomeEditar.Name = "txtNomeEditar";
            this.txtNomeEditar.Size = new System.Drawing.Size(166, 20);
            this.txtNomeEditar.TabIndex = 9;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(12, 14);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(35, 13);
            this.lblNomeEditar.TabIndex = 13;
            this.lblNomeEditar.Text = "Nome";
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(9, 54);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaEditar.TabIndex = 14;
            this.lblSenhaEditar.Text = "Senha";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 167);
            this.Controls.Add(this.lblSenhaEditar);
            this.Controls.Add(this.lblNomeEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.chkStatusEditar);
            this.Controls.Add(this.txtSenhaEditar);
            this.Controls.Add(this.txtNomeEditar);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox chkStatusEditar;
        private System.Windows.Forms.TextBox txtSenhaEditar;
        private System.Windows.Forms.TextBox txtNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
    }
}