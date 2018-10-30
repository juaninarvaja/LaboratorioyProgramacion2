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

namespace Ejercicio56
{
    public partial class Form1 : Form
    {
        string path = "empty";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void CmbOpcionElegida_Click(object sender, EventArgs e)
        {
            if(tsmArchivo.Text == "Abrir")
            {


            }
        }

      

        private void toolStripCantidadCaracteres_EnabledChanged(object sender, EventArgs e)
        {

            int largo = rtbTexto.TextLength;
            toolStripCantidadCaracteres.Text = largo.ToString() + "Caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                path = openFileDialog1.FileName;
                //StreamReader sr = new StreamReader(path);
                
                StringBuilder sb = new StringBuilder();

                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(line);
                        
                    }
                    sr.Close();
                }
               
                rtbTexto.Text = sb.ToString();

            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != "empty")
            {
                StreamWriter archivo;
                archivo = File.CreateText(openFileDialog1.FileName);
                archivo.WriteLine(rtbTexto.Text.ToString());
                archivo.Close();
            }
            else guardarComoToolStripMenuItem_Click(sender, e);
          
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                saveFileDialog1.InitialDirectory = saveFileDialog1.FileName;

            StreamWriter archivo;
            archivo = File.CreateText(saveFileDialog1.FileName);
            archivo.Write(rtbTexto.Text.ToString());
            archivo.Close();
            openFileDialog1.FileName = saveFileDialog1.FileName;
        }

     
    }
}
