using Microsoft.WindowsAPICodePack.Dialogs;

using Spire.Pdf.Graphics;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpLib;

namespace PdfCompress
{
    public partial class Form1 : Form
    {

        private double TamanhoOriginal;
        private double NovoTamanho;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            MostraEscondelabel(false);
        }

        private void MostraEscondelabel(bool valor)
        {
            label_tamanhoOriginal.Visible = valor;
            txt_tamanho.Visible = valor;
            label_taxa.Visible = valor;
            label_novoTamanho.Visible = valor;
            txt_novoTamanho.Visible = valor;
            txt_taxa.Visible = valor;
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            
            MostraEscondelabel(false);
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = false;
            
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_path.Text = dialog.FileName;
                FileInfo info = new FileInfo(dialog.FileName);
                txt_tamanho.Text = info.FormatBytes();
                TamanhoOriginal = info.Length;
                label_tamanhoOriginal.Visible = true;
                txt_tamanho.Visible = true;
            }
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txt_path.Text))
            {
                CompressPdf(txt_path.Text);
                return;
            }
            MessageBox.Show("Selecione o caminho do pdf");
        }

     

        public  void CompressPdf(string targetPath)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 25;
            PdfDocument doc = new PdfDocument(targetPath);
            doc.FileInfo.IncrementalUpdate = false;
            doc.CompressionLevel = PdfCompressionLevel.Best;
            progressBar1.Value = 35;

            foreach (PdfPageBase page in doc.Pages)
            {
                Image[] images = page.ExtractImages();
                if (images != null && images.Length > 0)
                {
                    for (int j = 0; j < images.Length; j++)
                    {
                        Image image = images[j];
                        PdfBitmap bp = new PdfBitmap(image);
                        bp.Quality = 20;
                        page.ReplaceImage(j, bp);
                    }
                }
            }
            progressBar1.Value = 65;
            var NovoNome = targetPath.Replace(".pdf", "").Replace(".PDF", "") + "-compress.pdf";
            doc.SaveToFile(NovoNome);
            doc.Close();
            FileInfo info = new FileInfo(NovoNome);
            txt_novoTamanho.Text = info.FormatBytes();
            NovoTamanho = info.Length;
            var CalculoTamanho = (int)(((NovoTamanho * 100 / TamanhoOriginal) - 100) * -1);
            txt_taxa.Text = CalculoTamanho.ToString()+"%";
            progressBar1.Value = 100;
            MostraEscondelabel(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
