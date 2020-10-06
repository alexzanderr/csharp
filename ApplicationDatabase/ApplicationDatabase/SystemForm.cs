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
    public partial class SystemForm : Form
    {
        public int loading_seconds;
        private ApplicationDatabaseForm application_database = null;

        public SystemForm(int loading_seconds, Form parent)
        {
            InitializeComponent();
            application_database = parent as ApplicationDatabaseForm;
            this.loading_seconds = loading_seconds;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 300;
            this.Top = 150;
            loading_timer.Start();
        }

        private void loading_timer_Tick(object sender, EventArgs e)
        {
            timer_label.Text = loading_seconds--.ToString() + " seconds remaining...";
            if (loading_seconds == -2)
            {
                application_database.InitializeSystem();
                this.Close();
            }
        }
    }
}
