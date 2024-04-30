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
            this.lblUser.Location = new System.Drawing.Point(354, 155);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(354, 220);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(353, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(87, 29);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "LOGIN";
            // 
            // TxtBoxUser
            // 
            this.TxtBoxUser.Location = new System.Drawing.Point(340, 178);
            this.TxtBoxUser.Name = "TxtBoxUser";
            this.TxtBoxUser.Size = new System.Drawing.Size(110, 26);
            this.TxtBoxUser.TabIndex = 3;
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Location = new System.Drawing.Point(340, 243);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.Size = new System.Drawing.Size(110, 26);
            this.TxtBoxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(340, 301);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bntRegisterClient
            // 
            this.bntRegisterClient.Location = new System.Drawing.Point(340, 343);
            this.bntRegisterClient.Name = "bntRegisterClient";
            this.bntRegisterClient.Size = new System.Drawing.Size(110, 36);
            this.bntRegisterClient.TabIndex = 6;
            this.bntRegisterClient.Text = "New Client";
            this.bntRegisterClient.UseVisualStyleBackColor = true;
            this.bntRegisterClient.Click += new System.EventHandler(this.bntRegisterClient_Click);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(340, 444);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(110, 36);
            this.bntExit.TabIndex = 7;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PF_CA81492KO_20517869Y.Properties.Resources.login_image;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 525);
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
            this.CbUserType.Location = new System.Drawing.Point(340, 113);
            this.CbUserType.Name = "CbUserType";
            this.CbUserType.Size = new System.Drawing.Size(110, 28);
            this.CbUserType.TabIndex = 9;
            this.CbUserType.SelectedIndexChanged += new System.EventHandler(this.CbUserType_SelectedIndexChanged);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(336, 79);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(130, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 492);
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