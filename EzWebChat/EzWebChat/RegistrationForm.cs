using System;
using System.Windows.Forms;
using ChatEngine.Model;
using ChatEngine.Service;

namespace EzWebChat
{
    public partial class RegistrationForm : Form
    {
        private RequestService requestService;

        public RegistrationForm()
        {
            InitializeComponent();
            requestService = new RequestService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Пример того, что тебе надо сделать:

            string passwordHash = CryptService.GetMD5Hash("ISuckDicksPassword");

            RegistrationRequest req = new RegistrationRequest()
            {
                FirstName = "Egor",
                LastName = "kalmikov",
                UserName = "Ejoktank",
                PassworHash = passwordHash, //"dd848732fe4428c201390eb429435ce3"
                CreateDate = new DateTime(1999,8,23, 4, 14 , 22)
            };

            if (requestService.Registration(req))
                MessageBox.Show("Registration", "Success");
            else
                MessageBox.Show("Error");


            //Здесь должны быть реальные данные с формы
            //TODO: Егор - это за тобой

            if (textBox1.Text == "")
                label1.Text = "Error";
                //MessageBox.Show("Error","Wrong name");
            button1.Text = textBox1.Text;
        }
    }
}
