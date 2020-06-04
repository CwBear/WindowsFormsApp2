using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string tipopizza, tamano, bebida;
        //iniciamos array
        ArrayList pedido = new ArrayList();



        public Form1()
        {
            InitializeComponent();

        }
        // combobox
        private void cmbTipoPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipopizza =cmbTipoPizza.SelectedItem.ToString();
        }

        private void cmbTamanoPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            tamano = cmbTamanoPizza.SelectedItem.ToString();
        }

        private void cmbTipoBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            bebida = cmbTipoBebida.SelectedItem.ToString();
        }
        //boton ingreso
        private void btnIngresoPedido_Click(object sender, EventArgs e)
        {
            Pizza pizza1 = new Pizza(tipopizza, tamano, bebida);
            pedido.Add(pizza1);
        }



        //label que muestra las selecciones del combo box
        private void lblPrueba_Click(object sender, EventArgs e)
        {
            foreach (object item in pedido)
            {
                Pizza pizza2 = (Pizza)item;
                lblPrueba.Text = pizza2.Tipopizza.ToString();
            }
        }

        private void lblTamanoPizza_Click(object sender, EventArgs e)
        {
            foreach (object item in pedido)
            {
                Pizza x = (Pizza)item;
                lblTamanoPizza.Text = x.Tamanopizza.ToString();
            }
        }


    }
}
