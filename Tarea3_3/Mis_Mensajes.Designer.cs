namespace Tarea3_3
{
    partial class Mis_Mensajes
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
            this.grvMisMensajes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDesenc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvMisMensajes)).BeginInit();
            this.SuspendLayout();
            // 
            // grvMisMensajes
            // 
            this.grvMisMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMisMensajes.Location = new System.Drawing.Point(12, 45);
            this.grvMisMensajes.Name = "grvMisMensajes";
            this.grvMisMensajes.Size = new System.Drawing.Size(400, 311);
            this.grvMisMensajes.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(339, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDesenc
            // 
            this.btnDesenc.Location = new System.Drawing.Point(190, 12);
            this.btnDesenc.Name = "btnDesenc";
            this.btnDesenc.Size = new System.Drawing.Size(75, 23);
            this.btnDesenc.TabIndex = 2;
            this.btnDesenc.Text = "Desencriptar";
            this.btnDesenc.UseVisualStyleBackColor = true;
            this.btnDesenc.Click += new System.EventHandler(this.btnDesenc_Click);
            // 
            // Mis_Mensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 410);
            this.Controls.Add(this.btnDesenc);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grvMisMensajes);
            this.Name = "Mis_Mensajes";
            this.Text = "Mis_Mensajes";
            this.Load += new System.EventHandler(this.Mis_Mensajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvMisMensajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvMisMensajes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDesenc;
    }
}