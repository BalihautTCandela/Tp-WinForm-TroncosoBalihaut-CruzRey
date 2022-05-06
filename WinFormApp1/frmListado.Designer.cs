
namespace WinFormApp1
{
    partial class frmListado
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.listadotxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 73);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(658, 313);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.SelectionChanged += new System.EventHandler(this.dgvListado_SelectionChanged);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(690, 73);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(325, 313);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            // 
            // listadotxt
            // 
            this.listadotxt.AutoSize = true;
            this.listadotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadotxt.Location = new System.Drawing.Point(12, 26);
            this.listadotxt.Name = "listadotxt";
            this.listadotxt.Size = new System.Drawing.Size(201, 25);
            this.listadotxt.TabIndex = 2;
            this.listadotxt.Text = "Listado de Articulos";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 407);
            this.Controls.Add(this.listadotxt);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvListado);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Label listadotxt;
    }
}