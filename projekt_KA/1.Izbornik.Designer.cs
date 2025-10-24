namespace projekt_KA
{
    partial class Izbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izbornik));
            this.unos_životinje = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pregled = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.udomljavanje = new System.Windows.Forms.Button();
            this.statistika = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // unos_životinje
            // 
            this.unos_životinje.Location = new System.Drawing.Point(36, 80);
            this.unos_životinje.Margin = new System.Windows.Forms.Padding(4);
            this.unos_životinje.Name = "unos_životinje";
            this.unos_životinje.Size = new System.Drawing.Size(187, 85);
            this.unos_životinje.TabIndex = 0;
            this.unos_životinje.Text = "UNOS ŽIVOTINJE";
            this.unos_životinje.UseVisualStyleBackColor = true;
            this.unos_životinje.Click += new System.EventHandler(this.button1_Click);
            // 
            // pregled
            // 
            this.pregled.Location = new System.Drawing.Point(245, 80);
            this.pregled.Margin = new System.Windows.Forms.Padding(4);
            this.pregled.Name = "pregled";
            this.pregled.Size = new System.Drawing.Size(187, 85);
            this.pregled.TabIndex = 1;
            this.pregled.Text = "PREGLED";
            this.pregled.UseVisualStyleBackColor = true;
            this.pregled.Click += new System.EventHandler(this.pregled_Click);
            // 
            // izlaz
            // 
            this.izlaz.Location = new System.Drawing.Point(948, 15);
            this.izlaz.Margin = new System.Windows.Forms.Padding(4);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(100, 28);
            this.izlaz.TabIndex = 3;
            this.izlaz.Text = "IZLAZ";
            this.izlaz.UseVisualStyleBackColor = true;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // udomljavanje
            // 
            this.udomljavanje.Location = new System.Drawing.Point(701, 80);
            this.udomljavanje.Margin = new System.Windows.Forms.Padding(4);
            this.udomljavanje.Name = "udomljavanje";
            this.udomljavanje.Size = new System.Drawing.Size(187, 85);
            this.udomljavanje.TabIndex = 4;
            this.udomljavanje.Text = "UDOMLJAVANJE";
            this.udomljavanje.UseVisualStyleBackColor = true;
            this.udomljavanje.Click += new System.EventHandler(this.udomljavanje_Click);
            // 
            // statistika
            // 
            this.statistika.Location = new System.Drawing.Point(464, 80);
            this.statistika.Margin = new System.Windows.Forms.Padding(4);
            this.statistika.Name = "statistika";
            this.statistika.Size = new System.Drawing.Size(187, 85);
            this.statistika.TabIndex = 5;
            this.statistika.Text = "STATISTIKA";
            this.statistika.UseVisualStyleBackColor = true;
            this.statistika.Click += new System.EventHandler(this.statistika_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-864, -406);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2116, 1168);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 609);
            this.Controls.Add(this.statistika);
            this.Controls.Add(this.udomljavanje);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.pregled);
            this.Controls.Add(this.unos_životinje);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Izbornik";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unos_životinje;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button pregled;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.Button udomljavanje;
        private System.Windows.Forms.Button statistika;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

