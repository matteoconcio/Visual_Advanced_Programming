namespace PF_CA81492KO_20517869Y
{
    partial class BiciForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.labelTotalBici = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncarrito = new System.Windows.Forms.Button();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.btnborrarcarrito = new System.Windows.Forms.Button();
            this.btnborrararticulo = new System.Windows.Forms.Button();
            this.lvCarritoBicicleta = new System.Windows.Forms.ListView();
            this.columnPiezoBiciNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPiezoBiciPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvModelo = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1008, 421);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 54);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // labelTotalBici
            // 
            this.labelTotalBici.AutoSize = true;
            this.labelTotalBici.Location = new System.Drawing.Point(1043, 96);
            this.labelTotalBici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalBici.Name = "labelTotalBici";
            this.labelTotalBici.Size = new System.Drawing.Size(38, 16);
            this.labelTotalBici.TabIndex = 36;
            this.labelTotalBici.Text = "0.00€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(994, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Carrito de la compra:";
            // 
            // btncarrito
            // 
            this.btncarrito.Location = new System.Drawing.Point(468, 58);
            this.btncarrito.Margin = new System.Windows.Forms.Padding(4);
            this.btncarrito.Name = "btncarrito";
            this.btncarrito.Size = new System.Drawing.Size(116, 54);
            this.btncarrito.TabIndex = 33;
            this.btncarrito.Text = "Añadir al carrito";
            this.btncarrito.UseVisualStyleBackColor = true;
            this.btncarrito.Click += new System.EventHandler(this.btncarrito_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
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
            this.cbModelo.Location = new System.Drawing.Point(27, 74);
            this.cbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(160, 24);
            this.cbModelo.TabIndex = 32;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Modelo de Bicicleta";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(884, 421);
            this.btnfinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(116, 54);
            this.btnfinalizar.TabIndex = 30;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            // 
            // btnborrarcarrito
            // 
            this.btnborrarcarrito.Location = new System.Drawing.Point(760, 421);
            this.btnborrarcarrito.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarcarrito.Name = "btnborrarcarrito";
            this.btnborrarcarrito.Size = new System.Drawing.Size(116, 54);
            this.btnborrarcarrito.TabIndex = 29;
            this.btnborrarcarrito.Text = "Borrar carrito";
            this.btnborrarcarrito.UseVisualStyleBackColor = true;
            // 
            // btnborrararticulo
            // 
            this.btnborrararticulo.Location = new System.Drawing.Point(636, 421);
            this.btnborrararticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrararticulo.Name = "btnborrararticulo";
            this.btnborrararticulo.Size = new System.Drawing.Size(116, 54);
            this.btnborrararticulo.TabIndex = 28;
            this.btnborrararticulo.Text = "Borrar artículo";
            this.btnborrararticulo.UseVisualStyleBackColor = true;
            // 
            // lvCarritoBicicleta
            // 
            this.lvCarritoBicicleta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPiezoBiciNombre,
            this.ColumnPiezoBiciPrecio});
            this.lvCarritoBicicleta.HideSelection = false;
            this.lvCarritoBicicleta.Location = new System.Drawing.Point(636, 131);
            this.lvCarritoBicicleta.Margin = new System.Windows.Forms.Padding(4);
            this.lvCarritoBicicleta.Name = "lvCarritoBicicleta";
            this.lvCarritoBicicleta.Size = new System.Drawing.Size(477, 282);
            this.lvCarritoBicicleta.TabIndex = 27;
            this.lvCarritoBicicleta.UseCompatibleStateImageBehavior = false;
            this.lvCarritoBicicleta.View = System.Windows.Forms.View.Details;
            // 
            // columnPiezoBiciNombre
            // 
            this.columnPiezoBiciNombre.Text = "Nombre";
            this.columnPiezoBiciNombre.Width = 90;
            // 
            // ColumnPiezoBiciPrecio
            // 
            this.ColumnPiezoBiciPrecio.Text = "Precio";
            this.ColumnPiezoBiciPrecio.Width = 73;
            // 
            // lvModelo
            // 
            this.lvModelo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.precio});
            this.lvModelo.HideSelection = false;
            this.lvModelo.Location = new System.Drawing.Point(27, 131);
            this.lvModelo.Margin = new System.Windows.Forms.Padding(4);
            this.lvModelo.Name = "lvModelo";
            this.lvModelo.Size = new System.Drawing.Size(557, 361);
            this.lvModelo.TabIndex = 26;
            this.lvModelo.UseCompatibleStateImageBehavior = false;
            this.lvModelo.View = System.Windows.Forms.View.Details;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 103;
            // 
            // precio
            // 
            this.precio.Text = "Precio";
            this.precio.Width = 57;
            // 
            // BiciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PF_CA81492KO_20517869Y.Properties.Resources.background_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 504);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelTotalBici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncarrito);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btnborrarcarrito);
            this.Controls.Add(this.btnborrararticulo);
            this.Controls.Add(this.lvCarritoBicicleta);
            this.Controls.Add(this.lvModelo);
            this.Name = "BiciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BikeShop.es";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelTotalBici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncarrito;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Button btnborrarcarrito;
        private System.Windows.Forms.Button btnborrararticulo;
        private System.Windows.Forms.ListView lvCarritoBicicleta;
        private System.Windows.Forms.ColumnHeader columnPiezoBiciNombre;
        private System.Windows.Forms.ColumnHeader ColumnPiezoBiciPrecio;
        private System.Windows.Forms.ListView lvModelo;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader precio;
    }
}