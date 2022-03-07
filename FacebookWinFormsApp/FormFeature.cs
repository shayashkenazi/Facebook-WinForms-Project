using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormFeature : Form
    {
        public User User { get; set; }

        internal FormFeature()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (User == null)
            {
                string vMessage = $"Can't start feature without a user.";

                MessageBox.Show(vMessage);
                Close();
            }
        }
    }
}
