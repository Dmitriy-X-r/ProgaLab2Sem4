using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgaLab2Sem4
{
    class MenuCommands
    {
        public void Others(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли разное");
        }
        public void Stuff(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли информацию о сотрудниках");
        }
        public void Orders(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли приказы");
        }
        public void Docs(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли документы");
        }
        public void Departs(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли Отделы");
        }
        public void Towns(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли информацию о городах");
        }
        public void Posts(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли информацию о должниках");
        }
        public void Window(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли окна");
        }
        public void Content(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли оглавление");
        }
        public void About(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли информацию о программе");
        }
        public void Help(object sender, EventArgs e)
        {
            MessageBox.Show("Вы октрыли помощь");
        }      
    }
}
