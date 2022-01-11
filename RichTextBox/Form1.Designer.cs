
namespace RichTextBox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.buttonCitaj = new System.Windows.Forms.Button();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.buttonMapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(748, 283);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(663, 12);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(106, 52);
            this.buttonBrisi.TabIndex = 1;
            this.buttonBrisi.Text = "Brisi";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            // 
            // buttonCitaj
            // 
            this.buttonCitaj.Location = new System.Drawing.Point(21, 12);
            this.buttonCitaj.Name = "buttonCitaj";
            this.buttonCitaj.Size = new System.Drawing.Size(110, 52);
            this.buttonCitaj.TabIndex = 2;
            this.buttonCitaj.Text = "Citaj";
            this.buttonCitaj.UseVisualStyleBackColor = true;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(21, 383);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(110, 55);
            this.buttonSpremi.TabIndex = 3;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMapa
            // 
            this.buttonMapa.Location = new System.Drawing.Point(663, 383);
            this.buttonMapa.Name = "buttonMapa";
            this.buttonMapa.Size = new System.Drawing.Size(106, 55);
            this.buttonMapa.TabIndex = 4;
            this.buttonMapa.Text = "&Mapa";
            this.buttonMapa.UseVisualStyleBackColor = true;
            this.buttonMapa.Click += new System.EventHandler(this.buttonMapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMapa);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.buttonCitaj);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Upotreba RichBox Kontrole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.Button buttonCitaj;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Button buttonMapa;
    }
}

