﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdaAku
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
                timer1.Stop();
           
        }
    }
}
