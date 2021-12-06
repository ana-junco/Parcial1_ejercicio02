using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_ejercicio02
{
    public partial class FrmEjercicio02 : Form
    {
        public FrmEjercicio02()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //valido si el usuario ingreso una frase
            if(this.TxtFrase.Text.Length==0)
            {
                MessageBox.Show("Por favor ingresa una frase..");
                this.TxtFrase.Focus();
            }
            //Crea el array de palabras
            string[] palabras = this.TxtFrase.Text.Split(' ');
            this.LstPalabras.Items.Clear();
            //lleno el listbox con las palabras
            for (int i=0; i<=palabras.Length;i++)
            {
                if(palabras[i].Length > 0)
                this.LstPalabras.Items.Add(palabras[i]+"-->"+palabras[i].Length+"caracteres...");
            }
        }
    }
}
