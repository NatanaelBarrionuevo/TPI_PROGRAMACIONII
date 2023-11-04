namespace Farmacia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbLogin = new GroupBox();
            btnSalir = new Button();
            btnEntrar = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(btnSalir);
            gbLogin.Controls.Add(btnEntrar);
            gbLogin.Controls.Add(label2);
            gbLogin.Controls.Add(txtPassword);
            gbLogin.Controls.Add(label1);
            gbLogin.Controls.Add(txtUsuario);
            gbLogin.Location = new Point(12, 45);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(214, 176);
            gbLogin.TabIndex = 6;
            gbLogin.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(126, 133);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(14, 133);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 10;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(58, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 20);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(58, 38);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(85, 9);
            label3.Name = "label3";
            label3.Size = new Size(73, 33);
            label3.TabIndex = 7;
            label3.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 228);
            Controls.Add(label3);
            Controls.Add(gbLogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbLogin;
        private Button btnSalir;
        private Button btnEntrar;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtUsuario;
        private Label label3;
    }
}