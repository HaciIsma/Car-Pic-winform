using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        static int index = default;
        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
            cars.Add(new Car { Vendor = "BMW", Model = "X5", Color = "Black", Year = 2014, CarImage = $@"{Directory.GetCurrentDirectory() + "X5.jpg"}" });
            //pictureBox1.ImageLocation = @"C:\Users\Haci\source\repos\WindowsFormsApp18\WindowsFormsApp18\bin\Debug\CarPictures\BMW-X5.jpg";
            MessageBox.Show(Directory.GetCurrentDirectory());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if  cars.Count()  = max;
            pictureBox1.ImageLocation = cars[0].CarImage;
            //index++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if (0)
            index--;
        }
    }
}
