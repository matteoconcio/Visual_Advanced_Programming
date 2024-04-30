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
            this.lblModifyNameAdmin = new System.Windows.Forms.Label();
            this.TxtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.TxtBoxNombreAdmin = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.GBManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBManageAdmin
            // 
            this.CBManageAdmin.FormattingEnabled = true;
            this.CBManageAdmin.Location = new System.Drawing.Point(476, 50);
            this.CBManageAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBManageAdmin.Name = "CBManageAdmin";
            this.CBManageAdmin.Size = new System.Drawing.Size(151, 24);
            this.CBManageAdmin.TabIndex = 5;
            // 
            // lblManageAdmin
            // 
            this.lblManageAdmin.AutoSize = true;
            this.lblManageAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAdmin.Location = new System.Drawing.Point(472, 16);
            this.lblManageAdmin.Name = "lblManageAdmin";
            this.lblManageAdmin.Size = new System.Drawing.Size(157, 20);
            this.lblManageAdmin.TabIndex = 4;
            this.lblManageAdmin.Text = "Admin Management";
            // 
            // CBManagePart
            // 
            this.CBManagePart.FormattingEnabled = true;
            this.CBManagePart.Location = new System.Drawing.Point(705, 50);
            this.CBManagePart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBManagePart.Name = "CBManagePart";
            this.CBManagePart.Size = new System.Drawing.Size(151, 24);
            this.CBManagePart.TabIndex = 7;
            // 
            // lblManagePart
            // 
            this.lblManagePart.AutoSize = true;
            this.lblManagePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePart.Location = new System.Drawing.Point(707, 16);
            this.lblManagePart.Name = "lblManagePart";
            this.lblManagePart.Size = new System.Drawing.Size(141, 20);
            this.lblManagePart.TabIndex = 6;
            this.lblManagePart.Text = "Part Management";
            // 
            // btnManageAdmin
            // 
            this.btnManageAdmin.Location = new System.Drawing.Point(476, 86);
            this.btnManageAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageAdmin.Name = "btnManageAdmin";
            this.btnManageAdmin.Size = new System.Drawing.Size(150, 34);
            this.btnManageAdmin.TabIndex = 8;
            this.btnManageAdmin.Text = "Manage Admin";
            this.btnManageAdmin.UseVisualStyleBackColor = true;
            this.btnManageAdmin.Click += new System.EventHandler(this.btnManageAdmin_Click_1);
            // 
            // btnManagePart
            // 
            this.btnManagePart.Location = new System.Drawing.Point(705, 86);
            this.btnManagePart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagePart.Name = "btnManagePart";
            this.btnManagePart.Size = new System.Drawing.Size(150, 34);
            this.btnManagePart.TabIndex = 9;
            this.btnManagePart.Text = "Manage Part";
            this.btnManagePart.UseVisualStyleBackColor = true;
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
            this.GBManagement.Controls.Add(this.lblModifyNameAdmin);
            this.GBManagement.Controls.Add(this.TxtBoxNewPassword);
            this.GBManagement.Controls.Add(this.TxtBoxNombreAdmin);
            this.GBManagement.Location = new System.Drawing.Point(11, 211);
            this.GBManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBManagement.Name = "GBManagement";
            this.GBManagement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBManagement.Size = new System.Drawing.Size(192, 377);
            this.GBManagement.TabIndex = 10;
            this.GBManagement.TabStop = false;
            this.GBManagement.Text = "MODIFY ADMIN";
            // 
            // btnSaveAdmin
            // 
            this.btnSaveAdmin.Location = new System.Drawing.Point(16, 293);
            this.btnSaveAdmin.Name = "btnSaveAdmin";
            this.btnSaveAdmin.Size = new System.Drawing.Size(133, 23);
            this.btnSaveAdmin.TabIndex = 9;
            this.btnSaveAdmin.Text = "Save";
            this.btnSaveAdmin.UseVisualStyleBackColor = true;
            this.btnSaveAdmin.Click += new System.EventHandler(this.btnSaveAdmin_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(15, 249);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(134, 23);
            this.btnShowPassword.TabIndex = 8;
            this.btnShowPassword.Text = "Show Password";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Repeat New Password";
            // 
            // TxtBoxRepeatNewPass
            // 
            this.TxtBoxRepeatNewPass.Location = new System.Drawing.Point(16, 200);
            this.TxtBoxRepeatNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxRepeatNewPass.Name = "TxtBoxRepeatNewPass";
            this.TxtBoxRepeatNewPass.Size = new System.Drawing.Size(133, 22);
            this.TxtBoxRepeatNewPass.TabIndex = 6;
            this.TxtBoxRepeatNewPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old Password";
            // 
            // TxtBoxOldPassword
            // 
            this.TxtBoxOldPassword.Location = new System.Drawing.Point(16, 93);
            this.TxtBoxOldPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxOldPassword.Name = "TxtBoxOldPassword";
            this.TxtBoxOldPassword.Size = new System.Drawing.Size(133, 22);
            this.TxtBoxOldPassword.TabIndex = 4;
            this.TxtBoxOldPassword.UseSystemPasswordChar = true;
            // 
            // lblModifyPasswordAdmin
            // 
            this.lblModifyPasswordAdmin.AutoSize = true;
            this.lblModifyPasswordAdmin.Location = new System.Drawing.Point(12, 127);
            this.lblModifyPasswordAdmin.Name = "lblModifyPasswordAdmin";
            this.lblModifyPasswordAdmin.Size = new System.Drawing.Size(97, 16);
            this.lblModifyPasswordAdmin.TabIndex = 3;
            this.lblModifyPasswordAdmin.Text = "New Password";
            // 
            // lblModifyNameAdmin
            // 
            this.lblModifyNameAdmin.AutoSize = true;
            this.lblModifyNameAdmin.Location = new System.Drawing.Point(12, 22);
            this.lblModifyNameAdmin.Name = "lblModifyNameAdmin";
            this.lblModifyNameAdmin.Size = new System.Drawing.Size(113, 16);
            this.lblModifyNameAdmin.TabIndex = 2;
            this.lblModifyNameAdmin.Text = "Modify Username";
            // 
            // TxtBoxNewPassword
            // 
            this.TxtBoxNewPassword.Location = new System.Drawing.Point(16, 146);
            this.TxtBoxNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxNewPassword.Name = "TxtBoxNewPassword";
            this.TxtBoxNewPassword.Size = new System.Drawing.Size(133, 22);
            this.TxtBoxNewPassword.TabIndex = 1;
            this.TxtBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // TxtBoxNombreAdmin
            // 
            this.TxtBoxNombreAdmin.Location = new System.Drawing.Point(16, 41);
            this.TxtBoxNombreAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBoxNombreAdmin.Name = "TxtBoxNombreAdmin";
            this.TxtBoxNombreAdmin.Size = new System.Drawing.Size(133, 22);
            this.TxtBoxNombreAdmin.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(730, 554);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PF_CA81492KO_20517869Y.Properties.Resources.background_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(920, 626);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.GBManagement);
            this.Controls.Add(this.btnManagePart);
            this.Controls.Add(this.btnManageAdmin);
            this.Controls.Add(this.CBManagePart);
            this.Controls.Add(this.lblManagePart);
            this.Controls.Add(this.CBManageAdmin);
            this.Controls.Add(this.lblManageAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BikeShop.es [Management]";
            this.GBManagement.ResumeLayout(false);
            this.GBManagement.PerformLayout();
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
        private System.Windows.Forms.Label lblModifyNameAdmin;
        private System.Windows.Forms.TextBox TxtBoxNewPassword;
        private System.Windows.Forms.TextBox TxtBoxNombreAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxRepeatNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxOldPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnSaveAdmin;
    }
}

