﻿
namespace Restaurant
{
    partial class FormIzmenaNaplataStavke
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
            this.label9 = new System.Windows.Forms.Label();
            this.labelUkupnaCena = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBrojPorcija = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStavkaMenija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSto = new System.Windows.Forms.ComboBox();
            this.buttonDodajStavkuUPorudzbinu = new System.Windows.Forms.Button();
            this.buttonIzbrisiIzabranuStavku = new System.Windows.Forms.Button();
            this.dataGridViewStavkeUPorudzbini = new System.Windows.Forms.DataGridView();
            this.buttonSmanjiBrojPorcija = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStavkeUPorudzbini)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(554, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "RSD";
            // 
            // labelUkupnaCena
            // 
            this.labelUkupnaCena.AutoSize = true;
            this.labelUkupnaCena.BackColor = System.Drawing.Color.Snow;
            this.labelUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUkupnaCena.ForeColor = System.Drawing.Color.Red;
            this.labelUkupnaCena.Location = new System.Drawing.Point(454, 364);
            this.labelUkupnaCena.Name = "labelUkupnaCena";
            this.labelUkupnaCena.Size = new System.Drawing.Size(71, 32);
            this.labelUkupnaCena.TabIndex = 58;
            this.labelUkupnaCena.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Ukupno za plaćanje:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, -70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Kreiraj novu porudzbinu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.comboBoxBrojPorcija);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxStavkaMenija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxKategorija);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxSto);
            this.groupBox1.Controls.Add(this.buttonDodajStavkuUPorudzbinu);
            this.groupBox1.Location = new System.Drawing.Point(244, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 321);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxBrojPorcija
            // 
            this.comboBoxBrojPorcija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrojPorcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrojPorcija.FormattingEnabled = true;
            this.comboBoxBrojPorcija.Location = new System.Drawing.Point(181, 174);
            this.comboBoxBrojPorcija.Name = "comboBoxBrojPorcija";
            this.comboBoxBrojPorcija.Size = new System.Drawing.Size(168, 30);
            this.comboBoxBrojPorcija.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Broj Porcija";
            // 
            // comboBoxStavkaMenija
            // 
            this.comboBoxStavkaMenija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStavkaMenija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStavkaMenija.FormattingEnabled = true;
            this.comboBoxStavkaMenija.Location = new System.Drawing.Point(181, 122);
            this.comboBoxStavkaMenija.Name = "comboBoxStavkaMenija";
            this.comboBoxStavkaMenija.Size = new System.Drawing.Size(168, 30);
            this.comboBoxStavkaMenija.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Stavka Menija";
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(181, 71);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(168, 30);
            this.comboBoxKategorija.TabIndex = 39;
            this.comboBoxKategorija.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategorija_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Kategorija";
            // 
            // comboBoxSto
            // 
            this.comboBoxSto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSto.FormattingEnabled = true;
            this.comboBoxSto.Location = new System.Drawing.Point(181, 15);
            this.comboBoxSto.Name = "comboBoxSto";
            this.comboBoxSto.Size = new System.Drawing.Size(168, 30);
            this.comboBoxSto.TabIndex = 20;
            // 
            // buttonDodajStavkuUPorudzbinu
            // 
            this.buttonDodajStavkuUPorudzbinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajStavkuUPorudzbinu.Location = new System.Drawing.Point(54, 222);
            this.buttonDodajStavkuUPorudzbinu.Name = "buttonDodajStavkuUPorudzbinu";
            this.buttonDodajStavkuUPorudzbinu.Size = new System.Drawing.Size(295, 63);
            this.buttonDodajStavkuUPorudzbinu.TabIndex = 23;
            this.buttonDodajStavkuUPorudzbinu.Text = "Dodaj novu stavku u porudzbinu";
            this.buttonDodajStavkuUPorudzbinu.UseVisualStyleBackColor = true;
            this.buttonDodajStavkuUPorudzbinu.Click += new System.EventHandler(this.buttonDodajStavkuUPorudzbinu_Click);
            // 
            // buttonIzbrisiIzabranuStavku
            // 
            this.buttonIzbrisiIzabranuStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzbrisiIzabranuStavku.Location = new System.Drawing.Point(638, 345);
            this.buttonIzbrisiIzabranuStavku.Name = "buttonIzbrisiIzabranuStavku";
            this.buttonIzbrisiIzabranuStavku.Size = new System.Drawing.Size(190, 62);
            this.buttonIzbrisiIzabranuStavku.TabIndex = 54;
            this.buttonIzbrisiIzabranuStavku.Text = "Izbrisi izabranu stavku";
            this.buttonIzbrisiIzabranuStavku.UseVisualStyleBackColor = true;
            this.buttonIzbrisiIzabranuStavku.Click += new System.EventHandler(this.buttonIzbrisiIzabranuStavku_Click);
            // 
            // dataGridViewStavkeUPorudzbini
            // 
            this.dataGridViewStavkeUPorudzbini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStavkeUPorudzbini.Location = new System.Drawing.Point(126, 427);
            this.dataGridViewStavkeUPorudzbini.Name = "dataGridViewStavkeUPorudzbini";
            this.dataGridViewStavkeUPorudzbini.RowHeadersWidth = 51;
            this.dataGridViewStavkeUPorudzbini.RowTemplate.Height = 24;
            this.dataGridViewStavkeUPorudzbini.Size = new System.Drawing.Size(702, 229);
            this.dataGridViewStavkeUPorudzbini.TabIndex = 53;
            // 
            // buttonSmanjiBrojPorcija
            // 
            this.buttonSmanjiBrojPorcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSmanjiBrojPorcija.Location = new System.Drawing.Point(133, 352);
            this.buttonSmanjiBrojPorcija.Name = "buttonSmanjiBrojPorcija";
            this.buttonSmanjiBrojPorcija.Size = new System.Drawing.Size(130, 62);
            this.buttonSmanjiBrojPorcija.TabIndex = 60;
            this.buttonSmanjiBrojPorcija.Text = "Smanji Broj Porcija";
            this.buttonSmanjiBrojPorcija.UseVisualStyleBackColor = true;
            this.buttonSmanjiBrojPorcija.Click += new System.EventHandler(this.buttonSmanjiBrojPorcija_Click);
            // 
            // FormIzmenaNaplataStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 655);
            this.Controls.Add(this.buttonSmanjiBrojPorcija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelUkupnaCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonIzbrisiIzabranuStavku);
            this.Controls.Add(this.dataGridViewStavkeUPorudzbini);
            this.Name = "FormIzmenaNaplataStavke";
            this.Text = "FormIzmenaNaplataStavke";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStavkeUPorudzbini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelUkupnaCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBrojPorcija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStavkaMenija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSto;
        private System.Windows.Forms.Button buttonDodajStavkuUPorudzbinu;
        private System.Windows.Forms.Button buttonIzbrisiIzabranuStavku;
        private System.Windows.Forms.DataGridView dataGridViewStavkeUPorudzbini;
        private System.Windows.Forms.Button buttonSmanjiBrojPorcija;
    }
}