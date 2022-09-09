namespace TPWinForm_Presentacion
{
    partial class frmArticulos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregarART = new System.Windows.Forms.Button();
            this.btnModificarART = new System.Windows.Forms.Button();
            this.btnEliminarART = new System.Windows.Forms.Button();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(355, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VENTANA PRINCIPAL DEL GESTOR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarART
            // 
            this.btnAgregarART.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarART.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarART.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarART.Location = new System.Drawing.Point(12, 432);
            this.btnAgregarART.Name = "btnAgregarART";
            this.btnAgregarART.Size = new System.Drawing.Size(175, 40);
            this.btnAgregarART.TabIndex = 1;
            this.btnAgregarART.Text = "Agregar Articulo";
            this.btnAgregarART.UseVisualStyleBackColor = false;
            this.btnAgregarART.Click += new System.EventHandler(this.btnAgregarART_Click);
            // 
            // btnModificarART
            // 
            this.btnModificarART.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarART.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnModificarART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarART.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarART.Location = new System.Drawing.Point(421, 432);
            this.btnModificarART.Name = "btnModificarART";
            this.btnModificarART.Size = new System.Drawing.Size(178, 39);
            this.btnModificarART.TabIndex = 2;
            this.btnModificarART.Text = "Modificar Articulo";
            this.btnModificarART.UseVisualStyleBackColor = false;
            // 
            // btnEliminarART
            // 
            this.btnEliminarART.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarART.BackColor = System.Drawing.Color.Salmon;
            this.btnEliminarART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarART.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarART.Location = new System.Drawing.Point(821, 432);
            this.btnEliminarART.Name = "btnEliminarART";
            this.btnEliminarART.Size = new System.Drawing.Size(174, 39);
            this.btnEliminarART.TabIndex = 3;
            this.btnEliminarART.Text = "Eliminar Articulo";
            this.btnEliminarART.UseVisualStyleBackColor = false;
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Location = new System.Drawing.Point(12, 98);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.Size = new System.Drawing.Size(727, 285);
            this.dgvArticulo.TabIndex = 4;
            this.dgvArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxArticulo.Location = new System.Drawing.Point(745, 98);
            this.pictureBoxArticulo.MaximumSize = new System.Drawing.Size(275, 285);
            this.pictureBoxArticulo.MinimumSize = new System.Drawing.Size(275, 285);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(275, 285);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulo.TabIndex = 5;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // frmArticulos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1021, 481);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.btnEliminarART);
            this.Controls.Add(this.btnModificarART);
            this.Controls.Add(this.btnAgregarART);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1037, 643);
            this.MinimumSize = new System.Drawing.Size(605, 508);
            this.Name = "frmArticulos";
            this.RightToLeftLayout = true;
            this.Text = "Gestor para Articulos de Catálogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregarART;
        private System.Windows.Forms.Button btnModificarART;
        private System.Windows.Forms.Button btnEliminarART;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
    }
}

