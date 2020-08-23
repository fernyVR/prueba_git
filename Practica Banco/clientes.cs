using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Banco
{
    class clientes
    {
        public String nombre;
        public int saldo;
        public int monto;

        public clientes(String c_nombre)
        {
            nombre = c_nombre;
        }
        public void depositar()
        {
            if (monto > 0)
            { 
            saldo = saldo + monto;
            MessageBox.Show("Gracias " + nombre + " su deposito fue " + monto);
            }else
            {
                MessageBox.Show("Digite un monto mayor a 0");
            }
        }

        public void retirar()
        {
            if (monto <= 0)
            {
               
                MessageBox.Show("Digite un monto mayor a 0");
            }else
            if (monto > saldo)
                {
                MessageBox.Show("Su saldo es insuficiente");
            }
            else
            {
                saldo = saldo - monto;
                MessageBox.Show("Gracias " + nombre + " su retiro fue " + monto);
            }
        }

        public void total()
        {

            MessageBox.Show("su saldo es: " + saldo);
        }
    }
}
