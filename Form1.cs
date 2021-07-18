using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubPushNotifications
{
    public partial class gpn : Form
    {
        public gpn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notificationer notifier = new notificationer();
            notifier.create_new_config_option();
        }
    }
}
