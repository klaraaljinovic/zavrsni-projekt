namespace projekt_KA
{
    partial class PregledŽivotinje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledŽivotinje));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.prikaz = new System.Windows.Forms.Button();
            this.izlaz2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(503, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 121);
            this.listBox1.TabIndex = 0;
            // 
            // prikaz
            // 
            this.prikaz.Location = new System.Drawing.Point(503, 192);
            this.prikaz.Name = "prikaz";
            this.prikaz.Size = new System.Drawing.Size(133, 32);
            this.prikaz.TabIndex = 1;
            this.prikaz.Text = "prikaži životinju";
            this.prikaz.UseVisualStyleBackColor = true;
            // 
            // izlaz2
            // 
            this.izlaz2.Location = new System.Drawing.Point(713, 12);
            this.izlaz2.Name = "izlaz2";
            this.izlaz2.Size = new System.Drawing.Size(75, 23);
            this.izlaz2.TabIndex = 2;
            this.izlaz2.Text = "izlaz";
            this.izlaz2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-189, -36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1009, 601);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // PregledŽivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izlaz2);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "PregledŽivotinje";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button prikaz;
        private System.Windows.Forms.Button izlaz2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}