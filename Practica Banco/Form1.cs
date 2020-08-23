using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Banco
    {
    public partial class Form1 : Form
        {
        clientes cl1 = new clientes("Manuel");
        clientes cl2 = new clientes("David");
        clientes cl3 = new clientes("Fernando");
       
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private void cliente1_Click(object sender, EventArgs e)
        {
            clientetxt.Text = "" + cl1.nombre;
            cantidad.Text = "0";
            
           
        }

        private void cliente2_Click(object sender, EventArgs e)
        {
            clientetxt.Text = "" + cl2.nombre;
            cantidad.Text = "0";
        }

        private void cliente3_Click(object sender, EventArgs e)
        {
            clientetxt.Text = "" + cl3.nombre;
            cantidad.Text = "0";
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void deposito_Click(object sender, EventArgs e)
        {
            
            if (clientetxt.Text == "")
            {
                MessageBox.Show("Por favor selecciona el cliente");
            }
            else
            if (clientetxt.Text == ""+cl1.nombre)
            {
              cl1.monto = int.Parse (cantidad.Text);
              cl1.depositar();
            }
            else
            if (clientetxt.Text == "" + cl2.nombre)
            {
                cl2.monto = int.Parse(cantidad.Text);
                cl2.depositar();
            }
            else
            if (clientetxt.Text == "" + cl3.nombre)
            {
                cl3.monto = int.Parse(cantidad.Text);
                cl3.depositar();
            }
        }
        private void cantidad_TextChanged(object sender, EventArgs e)
        { }
        private void retirar_Click(object sender, EventArgs e)
        {
            if (clientetxt.Text == "")
            {
                MessageBox.Show("Por favor selecciona el cliente");
            }
            else
            if (clientetxt.Text == "" + cl1.nombre)
            {
                cl1.monto = int.Parse(cantidad.Text);
                cl1.retirar();
            }
            else
            if (clientetxt.Text == "" + cl2.nombre)
            {
                cl2.monto = int.Parse(cantidad.Text);
                cl2.retirar();
            }
            else
            if (clientetxt.Text == "" + cl3.nombre)
            {
                cl3.monto = int.Parse(cantidad.Text);
                cl3.retirar();
             }

        }

        private void saldo_Click(object sender, EventArgs e)
        {
            if (clientetxt.Text == "")
            {
                MessageBox.Show("Por favor selecciona el cliente");
            }
            else
           if (clientetxt.Text == "" + cl1.nombre)
            {
                cl1.total();
               
            }
            else
           if (clientetxt.Text == "" + cl2.nombre)
            {
                cl2.total();
            }
            else
           if (clientetxt.Text == "" + cl3.nombre)
            {
                cl3.total();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
