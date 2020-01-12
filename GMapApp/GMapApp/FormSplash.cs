using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMapApp
{
    public partial class FormSplash : Form
    {
        Form1 frm_map = new Form1();
        public FormSplash()
        {
            InitializeComponent();
        }

        private void tmr_splash_Tick(object sender, EventArgs e)
        {
            tmr_splash.Stop();
            frm_map.Show();
            this.Hide();
        }
    }
}
