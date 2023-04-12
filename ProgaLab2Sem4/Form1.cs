using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgaLab2Sem4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            string filePath = "C://Users//user//Desktop//Users.txt";
            FileInfo f = new FileInfo(filePath);
            using (StreamReader sr = new StreamReader(f.OpenRead(), Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(new char[] { ' ' });
                    
                    string name = splitLine[0];
                    string password = splitLine[1];
                    string newFilePath = splitLine[2];

                    if (name == txtBoxUserName.Text && password == txtBoxPassword.Text)
                    {
                        Form2 form2 = new Form2(newFilePath);
                        form2.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}
