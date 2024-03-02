namespace CursoWindowsForms
{
    partial class Frm_MouseCaptura
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
            this.Btn_MouseCaptura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_MouseCaptura
            // 
            this.Btn_MouseCaptura.Location = new System.Drawing.Point(118, 69);
            this.Btn_MouseCaptura.Name = "Btn_MouseCaptura";
            this.Btn_MouseCaptura.Size = new System.Drawing.Size(236, 103);
            this.Btn_MouseCaptura.TabIndex = 0;
            this.Btn_MouseCaptura.UseVisualStyleBackColor = true;
            this.Btn_MouseCaptura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseCaptura_MouseDown);
            // 
            // Frm_MouseCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 271);
            this.Controls.Add(this.Btn_MouseCaptura);
            this.Name = "Frm_MouseCaptura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CapturaMouse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_MouseCaptura;
    }
}