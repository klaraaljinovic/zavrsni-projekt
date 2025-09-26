namespace projekt_KA
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.Label();
            this.pasmina = new System.Windows.Forms.Label();
            this.vrsta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.musko = new System.Windows.Forms.RadioButton();
            this.zensko = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dob = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(40, 62);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(29, 13);
            this.ime.TabIndex = 1;
            this.ime.Text = "IME:";
            // 
            // pasmina
            // 
            this.pasmina.AutoSize = true;
            this.pasmina.Location = new System.Drawing.Point(40, 159);
            this.pasmina.Name = "pasmina";
            this.pasmina.Size = new System.Drawing.Size(58, 13);
            this.pasmina.TabIndex = 2;
            this.pasmina.Text = "PASMINA:";
            this.pasmina.Click += new System.EventHandler(this.pasmina_Click);
            // 
            // vrsta
            // 
            this.vrsta.AutoSize = true;
            this.vrsta.Location = new System.Drawing.Point(40, 111);
            this.vrsta.Name = "vrsta";
            this.vrsta.Size = new System.Drawing.Size(46, 13);
            this.vrsta.TabIndex = 3;
            this.vrsta.Text = "VRSTA:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // musko
            // 
            this.musko.AutoSize = true;
            this.musko.Location = new System.Drawing.Point(43, 223);
            this.musko.Name = "musko";
            this.musko.Size = new System.Drawing.Size(64, 17);
            this.musko.TabIndex = 6;
            this.musko.TabStop = true;
            this.musko.Text = "MUŠKO";
            this.musko.UseVisualStyleBackColor = true;
            // 
            // zensko
            // 
            this.zensko.AutoSize = true;
            this.zensko.Location = new System.Drawing.Point(144, 223);
            this.zensko.Name = "zensko";
            this.zensko.Size = new System.Drawing.Size(69, 17);
            this.zensko.TabIndex = 7;
            this.zensko.TabStop = true;
            this.zensko.Text = "ŽENSKO";
            this.zensko.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 275);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(51, 277);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(30, 13);
            this.dob.TabIndex = 9;
            this.dob.Text = "DOB";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 353);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "DATUM DOLASKA:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 409);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "CIJEPLJEN";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(144, 409);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "KASTRIRAN";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 451);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 20);
            this.textBox4.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "NAPOMENA:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.zensko);
            this.Controls.Add(this.musko);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.vrsta);
            this.Controls.Add(this.pasmina);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.Label pasmina;
        private System.Windows.Forms.Label vrsta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton musko;
        private System.Windows.Forms.RadioButton zensko;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
    }
}