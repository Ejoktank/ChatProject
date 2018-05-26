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

        async private void button1_Click(object sender, EventArgs e)
        {
            //Пример того, что тебе надо сделать:

            string passwordHash = CryptService.GetMD5Hash("ISuckDicksPassword");

            RegistrationRequest req = new RegistrationRequest()
            {
                FirstName = "Egor",
                LastName = "kalmikov",
                UserName = "Ejoktank",
                PassworHash = passwordHash, //"dd848732fe4428c201390eb429435ce3"
                CreateDate = new DateTime(1999, 8, 23, 4, 14, 22)
            };

            var response = requestService.Registration(req);
            if (response.IsRegistred)
                MessageBox.Show("Registration", "Success");
            else
                MessageBox.Show(response.ErrorReason);


            //Здесь должны быть реальные данные с формы
            //TODO: Егор - это за тобой

            if (name.Text == "" || name.Text == "Имя" )
                //label1.Text = "Error";
                MessageBox.Show("Wrong name", "Error");
                //button1.Text = name.Text;

            if (surname.Text == "" || surname.Text == "Фамилия")
            {
                MessageBox.Show("Wrong surname", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
