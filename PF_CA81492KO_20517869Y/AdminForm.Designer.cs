namespace PF_CA81492KO_20517869Y
{
    partial class AdminForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.CBManageAdmin = new System.Windows.Forms.ComboBox();
            this.lblManageAdmin = new System.Windows.Forms.Label();
            this.CBManagePart = new System.Windows.Forms.ComboBox();
            this.lblManagePart = new System.Windows.Forms.Label();
            this.btnManageAdmin = new System.Windows.Forms.Button();
            this.btnManagePart = new System.Windows.Forms.Button();
            this.GBManagement = new System.Windows.Forms.GroupBox();
            this.btnSaveAdmin = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxRepeatNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxOldPassword = new System.Windows.Forms.TextBox();
            this.lblModifyPasswordAdmin = new System.Windows.Forms.Label();
            this.lblNameAdmin = new System.Windows.Forms.Label();
            this.TxtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.TxtBoxNombreAdmin = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.GBModifyPart = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.TxtBoxQuantity = new System.Windows.Forms.TextBox();
            this.TxtBoxManagePart = new System.Windows.Forms.TextBox();
            this.bntSavePart = new System.Windows.Forms.Button();
            this.lvtienda = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPart = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBManagement.SuspendLayout();
            this.GBModifyPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBManageAdmin
            // 
            this.CBManageAdmin.FormattingEnabled = true;
            this.CBManageAdmin.Location = new System.Drawing.Point(53, 50);
            this.CBManageAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBManageAdmin.Name = "CBManageAdmin";
            this.CBManageAdmin.Size = new System.Drawing.Size(151, 24);
            this.CBManageAdmin.TabIndex = 5;
            // 
            // lblManageAdmin
            // 
            this.lblManageAdmin.AutoSize = true;
            this.lblManageAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAdmin.Location = new System.Drawing.Point(49, 16);
            this.lblManageAdmin.Name = "lblManageAdmin";
            this.lblManageAdmin.Size = new System.Drawing.Size(119, 20);
            this.lblManageAdmin.TabIndex = 4;
            this.lblManageAdmin.Text = "Gestión Admin";
            // 
            // CBManagePart
            // 
            this.CBManagePart.FormattingEnabled = true;
            this.CBManagePart.Items.AddRange(new object[] {
            "Cuadro",
            "Cadena",
            "Cierre",
            "Disco",
            "Manillar",
            "Neumaticos",
            "Rueda",
            "Pedal",
            "Plato",
            "Sillin"});
            this.CBManagePart.Location = new System.Drawing.Point(291, 50);
            this.CBManagePart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBManagePart.Name = "CBManagePart";
            this.CBManagePart.Size = new System.Drawing.Size(151, 24);
            this.CBManagePart.TabIndex = 7;
            // 
            // lblManagePart
            // 
            this.lblManagePart.AutoSize = true;
            this.lblManagePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePart.Location = new System.Drawing.Point(293, 16);
            this.lblManagePart.Name = "lblManagePart";
            this.lblManagePart.Size = new System.Drawing.Size(121, 20);
            this.lblManagePart.TabIndex = 6;
            this.lblManagePart.Text = "Gestión Partes";
            // 
            // btnManageAdmin
            // 
            this.btnManageAdmin.Location = new System.Drawing.Point(53, 86);
            this.btnManageAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageAdmin.Name = "btnManageAdmin";
            this.btnManageAdmin.Size = new System.Drawing.Size(150, 34);
            this.btnManageAdmin.TabIndex = 8;
            this.btnManageAdmin.Text = "Gestionar Admin";
            this.btnManageAdmin.UseVisualStyleBackColor = true;
            this.btnManageAdmin.Click += new System.EventHandler(this.btnManageAdmin_Click_1);
            // 
            // btnManagePart
            // 
            this.btnManagePart.Location = new System.Drawing.Point(291, 86);
            this.btnManagePart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagePart.Name = "btnManagePart";
            this.btnManagePart.Size = new System.Drawing.Size(150, 34);
            this.btnManagePart.TabIndex = 9;
            this.btnManagePart.Text = "Gestionar Parte";
            this.btnManagePart.UseVisualStyleBackColor = true;
            this.btnManagePart.Click += new System.EventHandler(this.btnManagePart_Click);
            // 
            // GBManagement
            // 
            this.GBManagement.Controls.Add(this.btnSaveAdmin);
            this.GBManagement.Controls.Add(this.btnShowPassword);
            this.GBManagement.Controls.Add(this.label2);
            this.GBManagement.Controls.Add(this.TxtBoxRepeatNewPass);
            this.GBManagement.Controls.Add(this.label1);
            this.GBManagement.Controls.Add(this.TxtBoxOldPassword);
            this.GBManagement.Controls.Add(this.lblModifyPasswordAdmin);
            this.GBManagement.Controls.Add(this.lblNameAdmin);
            this.GBManagement.Controls.Add(this.TxtBoxNewPassword);
            this.GBManagement.Controls.Add(this.TxtBoxNombreAdmin);
            this.GBManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBManagement.Location = new System.Drawing.Point(53, 147);
            this.GBManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBManagement.Name = "GBManagement";
            this.GBManagement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBManagement.Size = new System.Drawing.Size(191, 428);
            this.GBManagement.TabIndex = 10;
            this.GBManagement.TabStop = false;
            this.GBManagement.Text = "MODIFICAR CONTRASEÑA ADMIN";
            // 
            // btnSaveAdmin
            // 
            this.btnSaveAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAdmin.Location = new System.Drawing.Point(20, 361);
            this.btnSaveAdmin.Name = "btnSaveAdmin";
            this.btnSaveAdmin.Size = new System.Drawing.Size(146, 31);
            this.btnSaveAdmin.TabIndex = 9;
            this.btnSaveAdmin.Text = "Guardar";
            this.btnSaveAdmin.UseVisualStyleBackColor = true;
            this.btnSaveAdmin.Click += new System.EventHandler(this.btnSaveAdmin_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.Location = new System.Drawing.Point(20, 310);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(147, 35);
            this.btnShowPassword.TabIndex = 8;
            this.btnShowPassword.Text = "Muestra Contraseña";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Repetir Nueva Contraseña";
            // 
            // TxtBoxRepeatNewPass
            // 
            this.TxtBoxRepeatNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxRepeatNewPass.Location = new System.Drawing.Point(20, 260);
            this.TxtBoxRepeatNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxRepeatNewPass.Name = "TxtBoxRepeatNewPass";
            this.TxtBoxRepeatNewPass.Size = new System.Drawing.Size(146, 23);
            this.TxtBoxRepeatNewPass.TabIndex = 6;
            this.TxtBoxRepeatNewPass.UseSystemPasswordChar = true;
            this.TxtBoxRepeatNewPass.TextChanged += new System.EventHandler(this.TxtBoxRepeatNewPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBoxOldPassword
            // 
            this.TxtBoxOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxOldPassword.Location = new System.Drawing.Point(19, 129);
            this.TxtBoxOldPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxOldPassword.Name = "TxtBoxOldPassword";
            this.TxtBoxOldPassword.Size = new System.Drawing.Size(146, 23);
            this.TxtBoxOldPassword.TabIndex = 4;
            this.TxtBoxOldPassword.UseSystemPasswordChar = true;
            this.TxtBoxOldPassword.TextChanged += new System.EventHandler(this.TxtBoxOldPassword_TextChanged);
            // 
            // lblModifyPasswordAdmin
            // 
            this.lblModifyPasswordAdmin.AutoSize = true;
            this.lblModifyPasswordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyPasswordAdmin.Location = new System.Drawing.Point(16, 171);
            this.lblModifyPasswordAdmin.Name = "lblModifyPasswordAdmin";
            this.lblModifyPasswordAdmin.Size = new System.Drawing.Size(126, 17);
            this.lblModifyPasswordAdmin.TabIndex = 3;
            this.lblModifyPasswordAdmin.Text = "Nueva Contraseña";
            this.lblModifyPasswordAdmin.Click += new System.EventHandler(this.lblModifyPasswordAdmin_Click);
            // 
            // lblNameAdmin
            // 
            this.lblNameAdmin.AutoSize = true;
            this.lblNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAdmin.Location = new System.Drawing.Point(16, 53);
            this.lblNameAdmin.Name = "lblNameAdmin";
            this.lblNameAdmin.Size = new System.Drawing.Size(38, 17);
            this.lblNameAdmin.TabIndex = 2;
            this.lblNameAdmin.Text = "User";
            // 
            // TxtBoxNewPassword
            // 
            this.TxtBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxNewPassword.Location = new System.Drawing.Point(19, 190);
            this.TxtBoxNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxNewPassword.Name = "TxtBoxNewPassword";
            this.TxtBoxNewPassword.Size = new System.Drawing.Size(146, 23);
            this.TxtBoxNewPassword.TabIndex = 1;
            this.TxtBoxNewPassword.UseSystemPasswordChar = true;
            this.TxtBoxNewPassword.TextChanged += new System.EventHandler(this.TxtBoxNewPassword_TextChanged);
            // 
            // TxtBoxNombreAdmin
            // 
            this.TxtBoxNombreAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxNombreAdmin.Location = new System.Drawing.Point(19, 72);
            this.TxtBoxNombreAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxNombreAdmin.Name = "TxtBoxNombreAdmin";
            this.TxtBoxNombreAdmin.Size = new System.Drawing.Size(146, 23);
            this.TxtBoxNombreAdmin.TabIndex = 0;
            this.TxtBoxNombreAdmin.TextChanged += new System.EventHandler(this.TxtBoxNombreAdmin_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(480, 86);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GBModifyPart
            // 
            this.GBModifyPart.Controls.Add(this.label5);
            this.GBModifyPart.Controls.Add(this.label4);
            this.GBModifyPart.Controls.Add(this.label3);
            this.GBModifyPart.Controls.Add(this.TxtBoxPrice);
            this.GBModifyPart.Controls.Add(this.TxtBoxQuantity);
            this.GBModifyPart.Controls.Add(this.TxtBoxManagePart);
            this.GBModifyPart.Controls.Add(this.bntSavePart);
            this.GBModifyPart.Controls.Add(this.lvtienda);
            this.GBModifyPart.Controls.Add(this.lblPart);
            this.GBModifyPart.Enabled = false;
            this.GBModifyPart.Location = new System.Drawing.Point(291, 147);
            this.GBModifyPart.Name = "GBModifyPart";
            this.GBModifyPart.Size = new System.Drawing.Size(539, 428);
            this.GBModifyPart.TabIndex = 12;
            this.GBModifyPart.TabStop = false;
            this.GBModifyPart.Text = "MODIFICAR PARTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.Location = new System.Drawing.Point(82, 361);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(53, 22);
            this.TxtBoxPrice.TabIndex = 17;
            // 
            // TxtBoxQuantity
            // 
            this.TxtBoxQuantity.Location = new System.Drawing.Point(82, 310);
            this.TxtBoxQuantity.Name = "TxtBoxQuantity";
            this.TxtBoxQuantity.Size = new System.Drawing.Size(53, 22);
            this.TxtBoxQuantity.TabIndex = 16;
            // 
            // TxtBoxManagePart
            // 
            this.TxtBoxManagePart.Location = new System.Drawing.Point(82, 252);
            this.TxtBoxManagePart.Name = "TxtBoxManagePart";
            this.TxtBoxManagePart.ReadOnly = true;
            this.TxtBoxManagePart.Size = new System.Drawing.Size(173, 22);
            this.TxtBoxManagePart.TabIndex = 15;
            // 
            // bntSavePart
            // 
            this.bntSavePart.Location = new System.Drawing.Point(386, 338);
            this.bntSavePart.Name = "bntSavePart";
            this.bntSavePart.Size = new System.Drawing.Size(110, 45);
            this.bntSavePart.TabIndex = 14;
            this.bntSavePart.Text = "Guardar";
            this.bntSavePart.UseVisualStyleBackColor = true;
            this.bntSavePart.Click += new System.EventHandler(this.bntSavePart_Click);
            // 
            // lvtienda
            // 
            this.lvtienda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre,
            this.Cantidad,
            this.Precio});
            this.lvtienda.HideSelection = false;
            this.lvtienda.Location = new System.Drawing.Point(22, 42);
            this.lvtienda.Margin = new System.Windows.Forms.Padding(4);
            this.lvtienda.Name = "lvtienda";
            this.lvtienda.Size = new System.Drawing.Size(483, 159);
            this.lvtienda.TabIndex = 13;
            this.lvtienda.UseCompatibleStateImageBehavior = false;
            this.lvtienda.View = System.Windows.Forms.View.Details;
            this.lvtienda.SelectedIndexChanged += new System.EventHandler(this.lvtienda_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 54;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 123;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 87;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 57;
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(47, 22);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(0, 16);
            this.lblPart.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.JPG");
            this.imageList1.Images.SetKeyName(1, "1.JPG");
            this.imageList1.Images.SetKeyName(2, "2.JPG");
            this.imageList1.Images.SetKeyName(3, "10.JPG");
            this.imageList1.Images.SetKeyName(4, "11.JPG");
            this.imageList1.Images.SetKeyName(5, "12.JPG");
            this.imageList1.Images.SetKeyName(6, "20.JPG");
            this.imageList1.Images.SetKeyName(7, "21.JPG");
            this.imageList1.Images.SetKeyName(8, "22.JPG");
            this.imageList1.Images.SetKeyName(9, "30.JPG");
            this.imageList1.Images.SetKeyName(10, "31.JPG");
            this.imageList1.Images.SetKeyName(11, "32.JPG");
            this.imageList1.Images.SetKeyName(12, "40.JPG");
            this.imageList1.Images.SetKeyName(13, "41.JPG");
            this.imageList1.Images.SetKeyName(14, "42.JPG");
            this.imageList1.Images.SetKeyName(15, "50.JPG");
            this.imageList1.Images.SetKeyName(16, "51.JPG");
            this.imageList1.Images.SetKeyName(17, "52.JPG");
            this.imageList1.Images.SetKeyName(18, "60.JPG");
            this.imageList1.Images.SetKeyName(19, "61.JPG");
            this.imageList1.Images.SetKeyName(20, "62.JPG");
            this.imageList1.Images.SetKeyName(21, "70.JPG");
            this.imageList1.Images.SetKeyName(22, "71.JPG");
            this.imageList1.Images.SetKeyName(23, "72.JPG");
            this.imageList1.Images.SetKeyName(24, "80.JPG");
            this.imageList1.Images.SetKeyName(25, "81.JPG");
            this.imageList1.Images.SetKeyName(26, "82.JPG");
            this.imageList1.Images.SetKeyName(27, "90.JPG");
            this.imageList1.Images.SetKeyName(28, "91.JPG");
            this.imageList1.Images.SetKeyName(29, "92.JPG");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PF_CA81492KO_20517869Y.Properties.Resources.bikeshopes_high_resolution_logo;
            this.pictureBox1.Location = new System.Drawing.Point(686, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PF_CA81492KO_20517869Y.Properties.Resources.background_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(920, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GBModifyPart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.GBManagement);
            this.Controls.Add(this.btnManagePart);
            this.Controls.Add(this.btnManageAdmin);
            this.Controls.Add(this.CBManagePart);
            this.Controls.Add(this.lblManagePart);
            this.Controls.Add(this.CBManageAdmin);
            this.Controls.Add(this.lblManageAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BikeShop.es [Management]";
            this.GBManagement.ResumeLayout(false);
            this.GBManagement.PerformLayout();
            this.GBModifyPart.ResumeLayout(false);
            this.GBModifyPart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBManageAdmin;
        private System.Windows.Forms.Label lblManageAdmin;
        private System.Windows.Forms.ComboBox CBManagePart;
        private System.Windows.Forms.Label lblManagePart;
        private System.Windows.Forms.Button btnManageAdmin;
        private System.Windows.Forms.Button btnManagePart;
        private System.Windows.Forms.GroupBox GBManagement;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblModifyPasswordAdmin;
        private System.Windows.Forms.Label lblNameAdmin;
        private System.Windows.Forms.TextBox TxtBoxNewPassword;
        private System.Windows.Forms.TextBox TxtBoxNombreAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxRepeatNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxOldPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnSaveAdmin;
        private System.Windows.Forms.GroupBox GBModifyPart;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ListView lvtienda;
        private System.Windows.Forms.Button bntSavePart;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.TextBox TxtBoxQuantity;
        private System.Windows.Forms.TextBox TxtBoxManagePart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

