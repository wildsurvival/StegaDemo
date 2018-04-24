using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

using StegaDemo.SteganographyMethods;

namespace StegaDemo
{
    public partial class MainWindow : Form
    {
        public void PopulateMethods()
        {
            IEnumerable<Type> methods = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.IsClass && t.Namespace == "StegaDemo.SteganographyMethods"
                          select t;

            foreach (Type method in methods)
                if (method.IsPublic)
                    methodBox.Items.Add(Activator.CreateInstance(method));
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            PopulateMethods();

            methodBox.SelectedIndex = 0;
        }

        private void selectImage_Click(object sender, EventArgs e)
        {
            if (selectImageDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = selectImageDialog.FileName;
                Bitmap img = new Bitmap(fileName);

                imageBox.Image = img;
            }
        }
    }
}
