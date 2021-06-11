using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EjercicioWinform5Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(metodo1);
            a.Start();
            Thread b = new Thread(metodo2);
            b.Start();
        }
        public void metodo1()
        {
            for (int i = 1; i <= 20; i++)
            {
                this.Tabla11.Items.Add("11 * " + i + " = " + 11 * i);
                Thread.Sleep(200);
            }
        }
        public void metodo2()
        {
            for (int i = 1; i <= 20; i++)
            {
                this.Tabla12.Items.Add("12 * " + i + " = " + 12 * i);
                Thread.Sleep(150);
            }
        }
    }
}
