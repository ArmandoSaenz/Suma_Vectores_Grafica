using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Annotations;
namespace Suma_Vectores_Grafica
{
    public partial class Form1 : Form
    {
        private void Sumar()
        {
            int v11, v12, v21, v22, v31, v32;
            bool success = true;
            success = success & int.TryParse(textBox1.Text, out v11);
            success = success & int.TryParse(textBox2.Text, out v12);
            success = success & int.TryParse(textBox3.Text, out v21);
            success = success & int.TryParse(textBox4.Text, out v22);
            if(success)
            {
                v31 = v11 + v21;
                v32 = v12 + v22;
                PlotModel modelo = new PlotModel { Title = "Suma de vectores" };
                ArrowAnnotation v1 = new ArrowAnnotation()
                {
                    StartPoint = new DataPoint(0, 0),
                    EndPoint = new DataPoint(v11, v12),
                    Color = OxyColor.FromRgb(0, 255, 0),
                };
                modelo.Annotations.Add(v1);
                ArrowAnnotation v2 = new ArrowAnnotation()
                {
                    StartPoint = new DataPoint(v11, v12),
                    EndPoint = new DataPoint(v31, v32),
                    Color = OxyColor.FromRgb(0, 0, 255),
                };
                modelo.Annotations.Add(v2);
                LineSeries v3 = new LineSeries();
                v3.Points.Add(new DataPoint(0, 0));
                v3.Points.Add(new DataPoint(v31, v32));
                modelo.Series.Add(v3);
                plotView1.Model = modelo;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Sumar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Sumar();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Sumar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Sumar();
        }
    }
}
