using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, nota5,promedio;

            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            nota4 = Convert.ToDouble(txtnota4.Text);
            nota5 = Convert.ToDouble(txtnota5.Text);

            promedio = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5);

            txtpromedio.Text = Convert.ToString(promedio);

            if (promedio <= 1)
            {
                MessageBox.Show ("Reprueba la materia sin lograr realizar proceso de recuperación.");
            }
            else
            {
                if (promedio<=2.9)
                {
                    MessageBox.Show("Reprueba la materia y puede hacer la habilitación.");
                }
                else
                {
                    if (promedio<=3.9)
                    {
                        MessageBox.Show("Aprueba la materia con plan de mejora.");
                    }
                    else
                    {
                        if (promedio<=4.5)
                        {
                            MessageBox.Show("Buen rendimiento.");
                        }
                        else
                        {
                            if (promedio<=4.9)
                            {
                                MessageBox.Show("Excelente.");
                            }
                            else
                            {
                                MessageBox.Show("Graduado con honores.");
                            }
                        }
                    }
                }

            }
        }
    }
}
