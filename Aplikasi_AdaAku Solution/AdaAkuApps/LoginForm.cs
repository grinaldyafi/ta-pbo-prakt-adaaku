using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdaAku

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread myThread = new Thread(new ThreadStart(startScreenSplash));
            myThread.Start();
            Thread.Sleep(7000);
            InitializeComponent();
           
            myThread.Abort();

        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Pengguna user = new Pengguna(tbUsername.Text,tbPassword.Text);
            
            if(user.Login( user.LoginName, user.Password))
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Gagal! " +
                    "Coba Login Sebagai Guest");
            }
        }

       

        public void startScreenSplash()
        {
            Application.Run(new SplashScreen());
        }

        
    }
}
