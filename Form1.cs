using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        static int index = -1;
        List<Car> cars = new List<Car>();
        string path = $@"{Directory.GetCurrentDirectory()}\Images\";
        public Form1()
        {
            InitializeComponent();
            cars.Add(new Car { Vendor = "BMW", Model = "X5", Color = "Black", Year = 2014, CarImage = path + "X5.png" });
            cars.Add(new Car { Vendor = "Mercedes", Model = "GT", Color = "Yellow", Year = 2020, CarImage = path + "GT.png" });
            cars.Add(new Car { Vendor = "Audi", Model = "S4", Color = "Yellow", Year = 2009, CarImage = path + "S4.png" });
            cars.Add(new Car { Vendor = "Explorer", Model = "Ford", Color = "Silver", Year = 2011, CarImage = path + "Explorer.png" });
            cars.Add(new Car { Vendor = "Fit", Model = "Honda", Color = "Red", Year = 2016, CarImage = path + "Fit.png" });
            cars.Add(new Car { Vendor = "6", Model = "Mazda", Color = "Blue", Year = 2016, CarImage = path + "6.png" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            prev.Enabled = true;
            if (index != cars.Count() - 1)
            {
                index++;
                PictureChangeAndInfo(index);
            }
            else
            {
                next.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            prev.Enabled = true;
            if (index > 0)
            {
                index--;
                PictureChangeAndInfo(index);
            }
            else
            {
                prev.Enabled = false;
            }
        }

        private void PictureChangeAndInfo(int index)
        {
            pictureBox1.Image = Image.FromFile(cars[index].CarImage);
            model.Text = $"Model: {cars[index].Model}";
            vendor.Text = $"Vendor: {cars[index].Vendor}";
            year.Text = $"Year: {cars[index].Year}";
            color.Text = $"Color: {cars[index].Color}";
        }

    }
}
