namespace PF_CA81492KO_20517869Y
{
    partial class RegisterClient
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
            this.lblRegistar = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.TxtBoxRegisterUser = new System.Windows.Forms.TextBox();
            this.TxtBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistar
            // 
            this.lblRegistar.AutoSize = true;
            this.lblRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistar.Location = new System.Drawing.Point(46, 9);
            this.lblRegistar.Name = "lblRegistar";
            this.lblRegistar.Size = new System.Drawing.Size(203, 24);
            this.lblRegistar.TabIndex = 0;
            this.lblRegistar.Text = "Registro Nuevo Cliente";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(65, 44);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(36, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(65, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña";
            // 
            // TxtBoxRegisterUser
            // 
            this.TxtBoxRegisterUser.Location = new System.Drawing.Point(68, 62);
            this.TxtBoxRegisterUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxRegisterUser.Name = "TxtBoxRegisterUser";
            this.TxtBoxRegisterUser.Size = new System.Drawing.Size(136, 22);
            this.TxtBoxRegisterUser.TabIndex = 3;
            // 
            // TxtBoxRegisterPassword
            // 
            this.TxtBoxRegisterPassword.Location = new System.Drawing.Point(68, 116);
            this.TxtBoxRegisterPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxRegisterPassword.Name = "TxtBoxRegisterPassword";
            this.TxtBoxRegisterPassword.Size = new System.Drawing.Size(136, 22);
            this.TxtBoxRegisterPassword.TabIndex = 4;
            this.TxtBoxRegisterPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(68, 184);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 26);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(68, 214);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.Location = new System.Drawing.Point(68, 153);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(136, 26);
            this.btnShowPassword.TabIndex = 12;
            this.btnShowPassword.Text = "Muestra Contraseña";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            this.btnShowPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnShowPassword_KeyDown);
            // 
            // RegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 296);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.TxtBoxRegisterPassword);
            this.Controls.Add(this.TxtBoxRegisterUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRegistar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TxtBoxRegisterUser;
        private System.Windows.Forms.TextBox TxtBoxRegisterPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowPassword;
    }
}