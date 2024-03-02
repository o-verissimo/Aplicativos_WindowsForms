namespace CursoWindowsForms
{
    partial class Frm_MouseCursor
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
            this.Btn_MouseCursor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_MouseCursor
            // 
            this.Btn_MouseCursor.Location = new System.Drawing.Point(103, 71);
            this.Btn_MouseCursor.Name = "Btn_MouseCursor";
            this.Btn_MouseCursor.Size = new System.Drawing.Size(197, 87);
            this.Btn_MouseCursor.TabIndex = 0;
            this.Btn_MouseCursor.UseVisualStyleBackColor = true;
            this.Btn_MouseCursor.Click += new System.EventHandler(this.Btn_MouseCursor_Click);
            // 
            // Frm_MouseCursor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 231);
            this.Controls.Add(this.Btn_MouseCursor);
            this.Name = "Frm_MouseCursor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MouseCursor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_MouseCursor;
    }
}