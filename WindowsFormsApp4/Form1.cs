using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Presentation;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZXing.BarcodeWriter writer = new ZXing.BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pictureBox1.Image = writer.Write(textBox1.Text);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZXing.BarcodeReader reader = new ZXing.BarcodeReader();
            var result = reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null)
                textBox2.Text = result.Text;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
