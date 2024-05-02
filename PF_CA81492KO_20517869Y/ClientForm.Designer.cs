namespace PF_CA81492KO_20517869Y
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.labeltotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncarrito = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.btnborrarcarrito = new System.Windows.Forms.Button();
            this.btnborrararticulo = new System.Windows.Forms.Button();
            this.lvcarrito = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtienda = new System.Windows.Forms.ListView();
            this.Imagen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBicicleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(1050, 95);
            this.labeltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(38, 16);
            this.labeltotal.TabIndex = 22;
            this.labeltotal.Text = "0.00€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1001, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Carrito de la compra:";
            // 
            // btncarrito
            // 
            this.btncarrito.Location = new System.Drawing.Point(475, 57);
            this.btncarrito.Margin = new System.Windows.Forms.Padding(4);
            this.btncarrito.Name = "btncarrito";
            this.btncarrito.Size = new System.Drawing.Size(116, 54);
            this.btncarrito.TabIndex = 19;
            this.btncarrito.Text = "Añadir al carrito";
            this.btncarrito.UseVisualStyleBackColor = true;
            this.btncarrito.Click += new System.EventHandler(this.btncarrito_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
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
            this.cbTipo.Location = new System.Drawing.Point(34, 73);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(160, 24);
            this.cbTipo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pieza de bicicleta";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(891, 420);
            this.btnfinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(116, 54);
            this.btnfinalizar.TabIndex = 16;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // btnborrarcarrito
            // 
            this.btnborrarcarrito.Location = new System.Drawing.Point(767, 420);
            this.btnborrarcarrito.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarcarrito.Name = "btnborrarcarrito";
            this.btnborrarcarrito.Size = new System.Drawing.Size(116, 54);
            this.btnborrarcarrito.TabIndex = 15;
            this.btnborrarcarrito.Text = "Borrar carrito";
            this.btnborrarcarrito.UseVisualStyleBackColor = true;
            this.btnborrarcarrito.Click += new System.EventHandler(this.btnborrarcarrito_Click);
            // 
            // btnborrararticulo
            // 
            this.btnborrararticulo.Location = new System.Drawing.Point(643, 420);
            this.btnborrararticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrararticulo.Name = "btnborrararticulo";
            this.btnborrararticulo.Size = new System.Drawing.Size(116, 54);
            this.btnborrararticulo.TabIndex = 14;
            this.btnborrararticulo.Text = "Borrar artículo";
            this.btnborrararticulo.UseVisualStyleBackColor = true;
            this.btnborrararticulo.Click += new System.EventHandler(this.btnborrararticulo_Click);
            // 
            // lvcarrito
            // 
            this.lvcarrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvcarrito.HideSelection = false;
            this.lvcarrito.Location = new System.Drawing.Point(643, 130);
            this.lvcarrito.Margin = new System.Windows.Forms.Padding(4);
            this.lvcarrito.Name = "lvcarrito";
            this.lvcarrito.Size = new System.Drawing.Size(477, 282);
            this.lvcarrito.TabIndex = 13;
            this.lvcarrito.UseCompatibleStateImageBehavior = false;
            this.lvcarrito.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 34;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Categoria";
            this.columnHeader5.Width = 74;
            // 
            // lvtienda
            // 
            this.lvtienda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Imagen,
            this.ID,
            this.Nombre,
            this.Cantidad,
            this.Precio});
            this.lvtienda.HideSelection = false;
            this.lvtienda.Location = new System.Drawing.Point(34, 130);
            this.lvtienda.Margin = new System.Windows.Forms.Padding(4);
            this.lvtienda.Name = "lvtienda";
            this.lvtienda.Size = new System.Drawing.Size(557, 361);
            this.lvtienda.SmallImageList = this.imageList1;
            this.lvtienda.TabIndex = 12;
            this.lvtienda.UseCompatibleStateImageBehavior = false;
            this.lvtienda.View = System.Windows.Forms.View.Details;
            // 
            // Imagen
            // 
            this.Imagen.Text = "Imagen";
            this.Imagen.Width = 78;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 43;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 103;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 57;
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
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1015, 420);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 54);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(643, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 39);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "¿Desea comprar una bicicleta completa?\r\nPulsa el botón \"Bicicleta\".";
            // 
            // btnBicicleta
            // 
            this.btnBicicleta.Location = new System.Drawing.Point(936, 19);
            this.btnBicicleta.Name = "btnBicicleta";
            this.btnBicicleta.Size = new System.Drawing.Size(106, 32);
            this.btnBicicleta.TabIndex = 25;
            this.btnBicicleta.Text = "Bicicleta";
            this.btnBicicleta.UseVisualStyleBackColor = true;
            this.btnBicicleta.Click += new System.EventHandler(this.btnBicicleta_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PF_CA81492KO_20517869Y.Properties.Resources.background_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 504);
            this.Controls.Add(this.btnBicicleta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncarrito);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btnborrarcarrito);
            this.Controls.Add(this.btnborrararticulo);
            this.Controls.Add(this.lvcarrito);
            this.Controls.Add(this.lvtienda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BikeShop.es";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncarrito;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Button btnborrarcarrito;
        private System.Windows.Forms.Button btnborrararticulo;
        private System.Windows.Forms.ListView lvcarrito;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvtienda;
        private System.Windows.Forms.ColumnHeader Imagen;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBicicleta;
    }
}