using Experimento.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experimento
{
    public partial class Form1 : Form
    {

        public ExpPrincipal elExperimento { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOrdenar_Click(object sender, EventArgs e)
        {
            listTiempos.Items.Clear();
            if (!comboAlgoritmo.Text.Equals("") && !comboTamanio.Text.Equals("") && !comboOrden.Text.Equals("") && !comboRepe.Text.Equals("")) {
                int repeticiones = int.Parse(comboRepe.Text);
                for (int i = 0; i < repeticiones; i++)
                {
                    elExperimento = new ExpPrincipal(int.Parse(comboTamanio.Text));
                    if (comboOrden.Text.Equals("Aleatorio"))
                    {
                        elExperimento.shuffle(elExperimento.arregloOrdenar);
                    }
                    else if (comboOrden.Text.Equals("Ascendente"))
                    {
                        elExperimento.orderUpward(elExperimento.arregloOrdenar);
                    }
                    else
                    {
                        elExperimento.statusDown(elExperimento.arregloOrdenar);
                    }
                    Stopwatch medidor = new Stopwatch();
                    //for (int i = 0; i < int.Parse(comboRepe.Text); i++)
                    //{
                    medidor.Restart();
                    medidor.Start();
                    if (comboAlgoritmo.Text.Equals("MergeSort"))
                    {
                        elExperimento.merge.mergeSort(elExperimento.arregloOrdenar, 0, elExperimento.arregloOrdenar.Length - 1);
                    }
                    else
                    {
                        elExperimento.insertion.insertionSort(elExperimento.arregloOrdenar);
                    }
                    medidor.Stop();
                    String tiempo = medidor.Elapsed.ToString("hh\\:mm\\:ss\\.ffffff");
                    listTiempos.Items.Add(tiempo);
                    Console.WriteLine(tiempo);
                    //}
                    Console.WriteLine(" ");
                    
                }
            }
            else {
                MessageBox.Show(string.Format("Llene todos los campos"));
            }
        }
    }
}
