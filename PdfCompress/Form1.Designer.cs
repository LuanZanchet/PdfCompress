
namespace PdfCompress
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_converter = new System.Windows.Forms.Button();
            this.label_tamanhoOriginal = new System.Windows.Forms.Label();
            this.txt_tamanho = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_novoTamanho = new System.Windows.Forms.Label();
            this.label_novoTamanho = new System.Windows.Forms.Label();
            this.label_taxa = new System.Windows.Forms.Label();
            this.txt_taxa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o PDF:";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(41, 55);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(364, 23);
            this.txt_path.TabIndex = 1;
            this.txt_path.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // btn_converter
            // 
            this.btn_converter.Location = new System.Drawing.Point(189, 126);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(75, 23);
            this.btn_converter.TabIndex = 2;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // label_tamanhoOriginal
            // 
            this.label_tamanhoOriginal.AutoSize = true;
            this.label_tamanhoOriginal.Location = new System.Drawing.Point(41, 81);
            this.label_tamanhoOriginal.Name = "label_tamanhoOriginal";
            this.label_tamanhoOriginal.Size = new System.Drawing.Size(104, 15);
            this.label_tamanhoOriginal.TabIndex = 3;
            this.label_tamanhoOriginal.Text = "Tamanho Original:";
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.AutoSize = true;
            this.txt_tamanho.Location = new System.Drawing.Point(151, 81);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(38, 15);
            this.txt_tamanho.TabIndex = 4;
            this.txt_tamanho.Text = "label3";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(110, 155);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 31);
            this.progressBar1.TabIndex = 5;
            // 
            // txt_novoTamanho
            // 
            this.txt_novoTamanho.AutoSize = true;
            this.txt_novoTamanho.Location = new System.Drawing.Point(152, 96);
            this.txt_novoTamanho.Name = "txt_novoTamanho";
            this.txt_novoTamanho.Size = new System.Drawing.Size(38, 15);
            this.txt_novoTamanho.TabIndex = 7;
            this.txt_novoTamanho.Text = "label3";
            // 
            // label_novoTamanho
            // 
            this.label_novoTamanho.AutoSize = true;
            this.label_novoTamanho.Location = new System.Drawing.Point(44, 96);
            this.label_novoTamanho.Name = "label_novoTamanho";
            this.label_novoTamanho.Size = new System.Drawing.Size(91, 15);
            this.label_novoTamanho.TabIndex = 6;
            this.label_novoTamanho.Text = "Novo Tamanho:";
            // 
            // label_taxa
            // 
            this.label_taxa.AutoSize = true;
            this.label_taxa.Location = new System.Drawing.Point(256, 81);
            this.label_taxa.Name = "label_taxa";
            this.label_taxa.Size = new System.Drawing.Size(104, 15);
            this.label_taxa.TabIndex = 8;
            this.label_taxa.Text = "Taxa Comprensão:";
            // 
            // txt_taxa
            // 
            this.txt_taxa.AutoSize = true;
            this.txt_taxa.Location = new System.Drawing.Point(357, 81);
            this.txt_taxa.Name = "txt_taxa";
            this.txt_taxa.Size = new System.Drawing.Size(38, 15);
            this.txt_taxa.TabIndex = 9;
            this.txt_taxa.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 201);
            this.Controls.Add(this.txt_taxa);
            this.Controls.Add(this.label_taxa);
            this.Controls.Add(this.txt_novoTamanho);
            this.Controls.Add(this.label_novoTamanho);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txt_tamanho);
            this.Controls.Add(this.label_tamanhoOriginal);
            this.Controls.Add(this.btn_converter);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PDF Reduce ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_converter;
        private System.Windows.Forms.Label label_tamanhoOriginal;
        private System.Windows.Forms.Label txt_tamanho;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txt_novoTamanho;
        private System.Windows.Forms.Label label_novoTamanho;
        private System.Windows.Forms.Label label_taxa;
        private System.Windows.Forms.Label txt_taxa;
    }
}

