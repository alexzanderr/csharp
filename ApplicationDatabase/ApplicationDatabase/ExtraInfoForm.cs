using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_database
{
    public partial class AppsInformation : Form
    {
        public Color background_label_color = Color.Black;
        public Color foreground_label_color = Color.OrangeRed;

        public AppsInformation(string text)
        {
            InitializeComponent();
            information_label.Text = text;
            information_label.BackColor = background_label_color;
            information_label.ForeColor = foreground_label_color;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 300;
            this.Top = 0;
        }
    }
}
