using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace application_database
{
    public partial class InspirationalContentForm : Form
    {
        public InspirationalContentForm()
        {
            InitializeComponent();
        }

        public String inspirational_images_path = "D:\\__Alexzander_files__\\__computer_science__\\see_sharp_stuff\\application_database\\photos\\inspirational_text\\";
        System.Collections.Generic.List<Image> images_array;
        System.Collections.Generic.List<String> paths_array;
        public int index = 0;
        public int max_size;
        public int start_index = 8;

        public void InitImagePaths()
        {
            paths_array = new System.Collections.Generic.List<String>();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(inspirational_images_path);
            int folder_size = dir.GetFiles().Length;
            for(int i = 1; i <= folder_size; i++)
            {
                String path = inspirational_images_path + String.Format("{0}.png", i.ToString());
                paths_array.Add(path);
            }
        }

        public void InitCollections()
        {
            images_array = new System.Collections.Generic.List<Image>();
            foreach(String path in paths_array) 
            {
                images_array.Add(Image.FromFile(path));
            }
            max_size = images_array.Count;
        }

        private void InspirationalTextForm_Load(object sender, EventArgs e)
        {
            index = 0;
            InitImagePaths();
            InitCollections();
            inspirational_image_label.Text = "";
            inspirational_image_label.Image = images_array[start_index];
            inspirational_image_label.Size = new Size(images_array[start_index].Width,
                                                      images_array[start_index].Height);
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (index == max_size - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            inspirational_image_label.Image = images_array[index];
            inspirational_image_label.Size = new Size(images_array[index].Width,
                                                      images_array[index].Height);
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = max_size - 1;
            }
            else
            {
                index--;
            }
            inspirational_image_label.Image = images_array[index];
            inspirational_image_label.Size = new Size(images_array[index].Width,
                                                      images_array[index].Height);
        }

        public Color enter_background_color = Color.Black;
        public Color enter_foreground_color = Color.OrangeRed;

        public System.Drawing.Color leave_background_color = SystemColors.Control;
        public Color leave_foreground_color = Color.IndianRed;

        private void prev_button_MouseEnter(object sender, EventArgs e)
        {
            prev_button.BackColor = enter_background_color;
            prev_button.ForeColor = enter_foreground_color;
        }

        private void prev_button_MouseLeave(object sender, EventArgs e)
        {
            prev_button.BackColor = leave_background_color;
            prev_button.ForeColor = leave_foreground_color;
        }

        private void next_button_MouseEnter(object sender, EventArgs e)
        {
            next_button.BackColor = enter_background_color;
            next_button.ForeColor = enter_foreground_color;
        }

        private void next_button_MouseLeave(object sender, EventArgs e)
        {
            next_button.BackColor = leave_background_color;
            next_button.ForeColor = leave_foreground_color;
        }
    }
}
