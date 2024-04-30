namespace PF_CA81492KO_20517869Y
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.TxtBoxUser = new System.Windows.Forms.TextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bntRegisterClient = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbUserType = new System.Windows.Forms.ComboBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.pFDataSetDiccionario = new PF_CA81492KO_20517869Y.PFDataSetDiccionario();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new PF_CA81492KO_20517869Y.PFDataSetDiccionarioTableAdapters.AdminsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFDataSetDiccionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(315, 124);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(315, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(314, 7);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "LOGIN";
            // 
            // TxtBoxUser
            // 
            this.TxtBoxUser.Location = new System.Drawing.Point(302, 142);
            this.TxtBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxUser.Name = "TxtBoxUser";
            this.TxtBoxUser.Size = new System.Drawing.Size(98, 22);
            this.TxtBoxUser.TabIndex = 3;
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Location = new System.Drawing.Point(302, 194);
            this.TxtBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.Size = new System.Drawing.Size(98, 22);
            this.TxtBoxPassword.TabIndex = 4;
            this.TxtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(302, 248);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bntRegisterClient
            // 
            this.bntRegisterClient.Location = new System.Drawing.Point(302, 292);
            this.bntRegisterClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntRegisterClient.Name = "bntRegisterClient";
            this.bntRegisterClient.Size = new System.Drawing.Size(98, 29);
            this.bntRegisterClient.TabIndex = 6;
            this.bntRegisterClient.Text = "New Client";
            this.bntRegisterClient.UseVisualStyleBackColor = true;
            this.bntRegisterClient.Click += new System.EventHandler(this.bntRegisterClient_Click);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(302, 355);
            this.bntExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(98, 29);
            this.bntExit.TabIndex = 7;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PF_CA81492KO_20517869Y.Properties.Resources.login_image;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CbUserType
            // 
            this.CbUserType.FormattingEnabled = true;
            this.CbUserType.Items.AddRange(new object[] {
            "Admin",
            "Client"});
            this.CbUserType.Location = new System.Drawing.Point(302, 90);
            this.CbUserType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbUserType.Name = "CbUserType";
            this.CbUserType.Size = new System.Drawing.Size(98, 24);
            this.CbUserType.TabIndex = 9;
            this.CbUserType.SelectedIndexChanged += new System.EventHandler(this.CbUserType_SelectedIndexChanged);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(299, 63);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(112, 16);
            this.lblUserType.TabIndex = 10;
            this.lblUserType.Text = "Select User Type";
            // 
            // pFDataSetDiccionario
            // 
            this.pFDataSetDiccionario.DataSetName = "PFDataSetDiccionario";
            this.pFDataSetDiccionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.pFDataSetDiccionario;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 394);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.CbUserType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntRegisterClient);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.TxtBoxUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFDataSetDiccionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox TxtBoxUser;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button bntRegisterClient;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserType;
        private PFDataSetDiccionario pFDataSetDiccionario;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private PFDataSetDiccionarioTableAdapters.AdminsTableAdapter adminsTableAdapter;
        public System.Windows.Forms.ComboBox CbUserType;
    }
}