namespace Ronda_de_Suerte
{
    partial class FRM_RONDA_DE_SUERTE
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_RONDA_DE_SUERTE));
            this.BTO_PARTICIPANTE = new System.Windows.Forms.Button();
            this.TXT_PARTICIPANTE = new System.Windows.Forms.TextBox();
            this.BTO_MOSTRAR = new System.Windows.Forms.Button();
            this.LST_PARTICIPANTES = new System.Windows.Forms.ListBox();
            this.LBL_DADO = new System.Windows.Forms.Label();
            this.BTO_SALIR = new System.Windows.Forms.Button();
            this.BTO_JUGAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTO_PARTICIPANTE
            // 
            this.BTO_PARTICIPANTE.Location = new System.Drawing.Point(85, 71);
            this.BTO_PARTICIPANTE.Name = "BTO_PARTICIPANTE";
            this.BTO_PARTICIPANTE.Size = new System.Drawing.Size(117, 45);
            this.BTO_PARTICIPANTE.TabIndex = 0;
            this.BTO_PARTICIPANTE.Text = "PARTICIPANTE";
            this.BTO_PARTICIPANTE.UseVisualStyleBackColor = true;
            this.BTO_PARTICIPANTE.Click += new System.EventHandler(this.BTO_PARTICIPANTE_Click);
            // 
            // TXT_PARTICIPANTE
            // 
            this.TXT_PARTICIPANTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PARTICIPANTE.Location = new System.Drawing.Point(313, 88);
            this.TXT_PARTICIPANTE.Name = "TXT_PARTICIPANTE";
            this.TXT_PARTICIPANTE.Size = new System.Drawing.Size(142, 26);
            this.TXT_PARTICIPANTE.TabIndex = 1;
            this.TXT_PARTICIPANTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PARTICIPANTE_KeyPress);
            // 
            // BTO_MOSTRAR
            // 
            this.BTO_MOSTRAR.Location = new System.Drawing.Point(325, 199);
            this.BTO_MOSTRAR.Name = "BTO_MOSTRAR";
            this.BTO_MOSTRAR.Size = new System.Drawing.Size(117, 45);
            this.BTO_MOSTRAR.TabIndex = 2;
            this.BTO_MOSTRAR.Text = "MOSTRAR";
            this.BTO_MOSTRAR.UseVisualStyleBackColor = true;
            this.BTO_MOSTRAR.Click += new System.EventHandler(this.BTO_MOSTRAR_Click);
            // 
            // LST_PARTICIPANTES
            // 
            this.LST_PARTICIPANTES.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LST_PARTICIPANTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LST_PARTICIPANTES.ForeColor = System.Drawing.Color.Yellow;
            this.LST_PARTICIPANTES.FormattingEnabled = true;
            this.LST_PARTICIPANTES.ItemHeight = 18;
            this.LST_PARTICIPANTES.Location = new System.Drawing.Point(68, 199);
            this.LST_PARTICIPANTES.Name = "LST_PARTICIPANTES";
            this.LST_PARTICIPANTES.Size = new System.Drawing.Size(197, 166);
            this.LST_PARTICIPANTES.TabIndex = 3;
            // 
            // LBL_DADO
            // 
            this.LBL_DADO.AutoSize = true;
            this.LBL_DADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DADO.Location = new System.Drawing.Point(493, 327);
            this.LBL_DADO.Name = "LBL_DADO";
            this.LBL_DADO.Size = new System.Drawing.Size(27, 20);
            this.LBL_DADO.TabIndex = 5;
            this.LBL_DADO.Text = "---";
            // 
            // BTO_SALIR
            // 
            this.BTO_SALIR.Location = new System.Drawing.Point(102, 401);
            this.BTO_SALIR.Name = "BTO_SALIR";
            this.BTO_SALIR.Size = new System.Drawing.Size(117, 45);
            this.BTO_SALIR.TabIndex = 6;
            this.BTO_SALIR.Text = "SALIR";
            this.BTO_SALIR.UseVisualStyleBackColor = true;
            this.BTO_SALIR.Click += new System.EventHandler(this.BTO_SALIR_Click_1);
            // 
            // BTO_JUGAR
            // 
            this.BTO_JUGAR.BackColor = System.Drawing.Color.Gainsboro;
            this.BTO_JUGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTO_JUGAR.Image = ((System.Drawing.Image)(resources.GetObject("BTO_JUGAR.Image")));
            this.BTO_JUGAR.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTO_JUGAR.Location = new System.Drawing.Point(290, 250);
            this.BTO_JUGAR.Name = "BTO_JUGAR";
            this.BTO_JUGAR.Size = new System.Drawing.Size(184, 219);
            this.BTO_JUGAR.TabIndex = 7;
            this.BTO_JUGAR.UseVisualStyleBackColor = false;
            this.BTO_JUGAR.Click += new System.EventHandler(this.BTO_JUGAR_Click);
            // 
            // FRM_RONDA_DE_SUERTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(564, 513);
            this.Controls.Add(this.BTO_JUGAR);
            this.Controls.Add(this.BTO_SALIR);
            this.Controls.Add(this.LBL_DADO);
            this.Controls.Add(this.LST_PARTICIPANTES);
            this.Controls.Add(this.BTO_MOSTRAR);
            this.Controls.Add(this.TXT_PARTICIPANTE);
            this.Controls.Add(this.BTO_PARTICIPANTE);
            this.Name = "FRM_RONDA_DE_SUERTE";
            this.Text = "RONDA DE SUERTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTO_PARTICIPANTE;
        private System.Windows.Forms.TextBox TXT_PARTICIPANTE;
        private System.Windows.Forms.Button BTO_MOSTRAR;
        private System.Windows.Forms.ListBox LST_PARTICIPANTES;
        private System.Windows.Forms.Label LBL_DADO;
        private System.Windows.Forms.Button BTO_SALIR;
        private System.Windows.Forms.Button BTO_JUGAR;
    }
}

