using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        
        private double CalculateWater(double km, double kg)
        {
            return (km * 1.0) + (kg * 0.2);
        }

        
        private double CalculateLand(double km, double kg)
        {
            return (km * 2.0) + (kg * 0.4);
        }

        
        private double CalculateAir(double km, double kg)
        {
            return (km * 4.0) + (kg * 1.0);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtKm.Text, out double km) || !double.TryParse(txtKg.Text, out double kg))
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для километров и килограммов.");
                return;
            }

            double cost = 0.0;

            
            if (rbWater.Checked)
            {
                cost = CalculateWater(km, kg);
            }
            else if (rbLand.Checked)
            {
                cost = CalculateLand(km, kg);
            }
            else if (rbAir.Checked)
            {
                cost = CalculateAir(km, kg);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите тип транспортировки.");
                return;
            }

            
            lblResult.Text = $"Стоимость: {cost:F2} рублей";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа версии 1.0 \nРазработчик: Муртаза Али \nГод выпуска: 2024");
        }
    }
}
