namespace projekt_KA
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
            this.unos_životinje = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pregled = new System.Windows.Forms.Button();
            this.filteri = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.udomljavanje = new System.Windows.Forms.Button();
            this.statistika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // unos_životinje
            // 
            this.unos_životinje.Location = new System.Drawing.Point(79, 99);
            this.unos_životinje.Name = "unos_životinje";
            this.unos_životinje.Size = new System.Drawing.Size(140, 69);
            this.unos_životinje.TabIndex = 0;
            this.unos_životinje.Text = "UNOS ŽIVOTINJE";
            this.unos_životinje.UseVisualStyleBackColor = true;
            this.unos_životinje.Click += new System.EventHandler(this.button1_Click);
            // 
            // pregled
            // 
            this.pregled.Location = new System.Drawing.Point(252, 99);
            this.pregled.Name = "pregled";
            this.pregled.Size = new System.Drawing.Size(140, 69);
            this.pregled.TabIndex = 1;
            this.pregled.Text = "PREGLED";
            this.pregled.UseVisualStyleBackColor = true;
            // 
            // filteri
            // 
            this.filteri.Location = new System.Drawing.Point(672, 195);
            this.filteri.Name = "filteri";
            this.filteri.Size = new System.Drawing.Size(75, 40);
            this.filteri.TabIndex = 2;
            this.filteri.Text = "FILTERI";
            this.filteri.UseVisualStyleBackColor = true;
            // 
            // izlaz
            // 
            this.izlaz.Location = new System.Drawing.Point(672, 49);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(75, 23);
            this.izlaz.TabIndex = 3;
            this.izlaz.Text = "IZLAZ";
            this.izlaz.UseVisualStyleBackColor = true;
            // 
            // udomljavanje
            // 
            this.udomljavanje.Location = new System.Drawing.Point(607, 99);
            this.udomljavanje.Name = "udomljavanje";
            this.udomljavanje.Size = new System.Drawing.Size(140, 69);
            this.udomljavanje.TabIndex = 4;
            this.udomljavanje.Text = "UDOMLJAVANJE";
            this.udomljavanje.UseVisualStyleBackColor = true;
            // 
            // statistika
            // 
            this.statistika.Location = new System.Drawing.Point(419, 99);
            this.statistika.Name = "statistika";
            this.statistika.Size = new System.Drawing.Size(140, 69);
            this.statistika.TabIndex = 5;
            this.statistika.Text = "STATISTIKA";
            this.statistika.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 495);
            this.Controls.Add(this.statistika);
            this.Controls.Add(this.udomljavanje);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.filteri);
            this.Controls.Add(this.pregled);
            this.Controls.Add(this.unos_životinje);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unos_životinje;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button pregled;
        private System.Windows.Forms.Button filteri;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.Button udomljavanje;
        private System.Windows.Forms.Button statistika;
    }
}

