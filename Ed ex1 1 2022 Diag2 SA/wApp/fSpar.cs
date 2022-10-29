using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cApp;

namespace wApp
{
    public partial class fSpar : Form
    {
        public fSpar()
        {
            InitializeComponent();
        }

        int[,] Z = {
                     { 0, 0, 0 , 0, 0, 0 , 3},           
                     { 0, 0, 1 , 0, 0, 1 , 0}, 
                     { 0, 0, 0 , 3, 0, 0 , 1},
                     { 8, 0, 0 , 0, 0, 0 , 2},
                     { 0, 0, 1 , 5, 0, 0 , 0},
                     { 0, 5, 0 , 0, 0, 1 , 0},
                     { 2, 0, 0 , 0, 0, 0 , 0},
                   };

        clsSpar S = new clsSpar();
        clsPila P = new clsPila();
        private void fSpar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            S.n = 7;       // Fila de la matriz
            S.m = 7;       // Columna la matriz
            label1.Text=S.MostraArreglo(Z);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S=S.CopyZtoPS(Z);     
            label2.Text = S.MostrarVector();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            P = S.DiagonalSegunda(S.PS);
            label3.Text = P.Imprimir(); ;
        }
    }
}
