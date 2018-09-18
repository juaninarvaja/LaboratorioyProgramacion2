using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(1,"Monitor 21'",900);
            Producto productoDos = new Producto(2, "Monitor 17'",100);
            Factura factura = new Factura();
            factura.productos.Add(producto);
            factura.productos.Add(productoDos);
            MessageBox.Show(factura.Total.ToString());
            producto.Identificador = 50;
           // producto.Identificador();




        }
    }
}
