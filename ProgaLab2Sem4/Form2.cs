using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgaLab2Sem4
{
    public partial class Form2 : Form
    {
        public Form2(string filePath)
        {
            InitializeComponent();
            Menu menu = new Menu(filePath, menuStrip1);
            menu.CreateMenu();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
