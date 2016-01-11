namespace CSDemoGDI
{
    partial class Form1
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
            this.picPantalla = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // picPantalla
            // 
            this.picPantalla.BackColor = System.Drawing.Color.Black;
            this.picPantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPantalla.Location = new System.Drawing.Point(12, 12);
            this.picPantalla.Name = "picPantalla";
            this.picPantalla.Size = new System.Drawing.Size(494, 362);
            this.picPantalla.TabIndex = 0;
            this.picPantalla.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 386);
            this.Controls.Add(this.picPantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPantalla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPantalla;
        private System.Windows.Forms.Timer timer1;
    }
}

