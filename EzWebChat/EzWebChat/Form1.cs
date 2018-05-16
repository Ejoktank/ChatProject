using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatEngine.Model;

namespace EzWebChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Пример того, что тебе надо сделать:
            RegistrationRequest req = new RegistrationRequest()
            {
                FirstName = "",
                LastName = "",
                PassworHash = "",
                CreateDate = new DateTime(1999,8,23)
            };
            //Здесь должны быть реальные данные с формы
            //TODO: Егор - это за тобой

            if (textBox1.Text == "")
                label1.Text = "Error";
                //MessageBox.Show("Error","Wrong name");
            button1.Text = textBox1.Text;
        }
    }
}
