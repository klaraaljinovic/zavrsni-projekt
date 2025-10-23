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
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(393, 51);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(633, 356);
            this.listBox1.TabIndex = 0;
            // 
            // prikaz
            // 
            this.prikaz.Location = new System.Drawing.Point(393, 423);
            this.prikaz.Margin = new System.Windows.Forms.Padding(4);
            this.prikaz.Name = "prikaz";
            this.prikaz.Size = new System.Drawing.Size(177, 39);
            this.prikaz.TabIndex = 1;
            this.prikaz.Text = "prikaži životinju";
            this.prikaz.UseVisualStyleBackColor = true;
            // 
            // izlaz2
            // 
            this.izlaz2.Location = new System.Drawing.Point(926, 13);
            this.izlaz2.Margin = new System.Windows.Forms.Padding(4);
            this.izlaz2.Name = "izlaz2";
            this.izlaz2.Size = new System.Drawing.Size(100, 28);
            this.izlaz2.TabIndex = 2;
            this.izlaz2.Text = "izlaz";
            this.izlaz2.UseVisualStyleBackColor = true;
            this.izlaz2.Click += new System.EventHandler(this.izlaz2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-160, -42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1345, 740);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // PregledŽivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.izlaz2);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
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