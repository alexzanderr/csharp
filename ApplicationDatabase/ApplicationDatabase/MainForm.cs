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
    public partial class ApplicationDatabaseForm : Form
    {   
        public int event_log_counter = 0;

        // <paths
        public String screenshotcounter_path = "D:\\__Alexzander_files__\\__computer_science__\\see_sharp_stuff\\application_database\\screenshot_counter.txt";
        public String screenshots_path = "D:\\__Alexzander_files__\\__supreme_folder__\\__photos__\\screenshots\\";
        public String origin = "D:\\__Alexzander_files__\\__computer_science__\\see_sharp_stuff\\application_database\\applications_exes\\";
        public String old_appdb_path;
        public String systemapp_path;
        public String emailsopener_path;
        public String socialopener_path;
        public String icalendar_path;
        public String accounts_path;
        public String cards_path;
        public String emailsender_path;
        public String injection_path;
        public String keylogger_path;
        public String musicapp_path;
        public String wappsender_path;
        public String xmastree_path;
        public String andrewsite_path;
        public String ultramenuapp_path;
        public String newsapp_path;
        public String scrappy_path;
        public String tinderbot_path;
        public String humanhierarchy_path;
        public String examtimer_path;
        public String updater_path;
        public String locations_tracker_path;
        public String shortcuts_path;
        public String suffix = ".py - Shortcut";
        // </paths>
        
        // information form
        public AppsInformation appinfo;

        // <information strings>
        public String old_appdb_info;
        public String systemapp_info;
        public String emailsopener_info;
        public String socialopener_info;
        public String icalendar_info;
        public String accounts_info;
        public String cards_info;
        public String emailsender_info;
        public String injection_info;
        public String keylogger_info;
        public String musicapp_info;
        public String tictactoe_info;
        public String wappsender_info;
        public String xmastree_info;
        public String andrewsite_info;
        public String ultramenuapp_info;
        public String newsapp_info;
        public String scrappy_info;
        public String initializer_button_info;
        // </information strings>

        String username;

        // mouse enter colors => WARNING
        public Color mouse_enter_color_fore_warning = Color.Black;
        public Color mouse_enter_color_back_warning = Color.Red;

        // mouse enter colors => NORMAL ACTIVITY
        public Color mouse_enter_color_fore = Color.LimeGreen;
        public Color mouse_enter_color_back = Color.Black;

        // mouse leave colors
        public Color mouse_leave_color_fore = Color.OrangeRed;
        public System.Drawing.Color mouse_leave_color_back = SystemColors.Control;

        public ApplicationDatabaseForm() { 
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 300;
            this.Top = 100;
        }

        private void InitPaths()
        {
            old_appdb_path = origin + "[Application Database Form].exe";
            systemapp_path = origin + "systemapp" + suffix;
            emailsopener_path = origin + "emailsopener" + suffix;
            socialopener_path = origin + "socialopener" + suffix;
            icalendar_path = origin + "icalendar" + suffix;
            accounts_path = origin + "accounts" + suffix;
            cards_path = origin + "cards" + suffix;
            emailsender_path = origin + "emailsender" + suffix;
            injection_path = origin + "injection" + suffix;
            keylogger_path = origin + "keylogger" + suffix;
            musicapp_path = origin + "musicapp" + suffix;
            wappsender_path = origin + "wappsender" + suffix;
            xmastree_path = origin + "xmastree" + suffix;
            andrewsite_path = origin + "run_andrewsite" + suffix;
            ultramenuapp_path = origin + "ultramenuapp" + suffix;
            newsapp_path = origin + "newsopener" + suffix;
            scrappy_path = origin + "webscrapper" + suffix;
            tinderbot_path = origin + "tinderbot" + suffix;
            humanhierarchy_path = origin + "humanstree" + suffix;
            examtimer_path = origin + "run_examtimer" + suffix;
            updater_path = origin + "update_shortcuts" + suffix;
            locations_tracker_path = origin + "locations_tracker" + suffix;
            shortcuts_path = "D:\\__Alexzander_files__\\__computer_science__\\see_sharp_stuff\\application_database\\applications_exes";
        }

        private void InitInfoLabels()
        {
            old_appdb_info = "This is your old application that is \nsimilar to this one" +
                " and its called Old Application Database.";
            systemapp_info = "";
            emailsopener_info = "";
            socialopener_info = "";
            icalendar_info = "";
            accounts_info = "";
            cards_info = "";
            emailsender_info = "";
            injection_info = "";
            keylogger_info = "";
            musicapp_info = "";
            tictactoe_info = "";
            wappsender_info = "";
            xmastree_info = "";
            andrewsite_info = "";
            ultramenuapp_info = "";
            newsapp_info = "";
            initializer_button_info = "This button will open 5 of your python apps \n" +
                "and besides that will open task manager, brave browser, \n" +
                "vs code and pycharm with a little time delay between synchronizations.";
        }

        private void Init()
        {
            String machine_user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            username = machine_user.Substring(machine_user.IndexOf('\\') + 1);
        }

        private void InitNotification()
        {
            System.Diagnostics.Process.Start("D:\\__Alexzander_files__\\__computer_science__\\python_stuff\\andrew_packages\\application_database\\initializer.pyw");
        }

        private void applicatondb_Load(object sender, EventArgs e)
        {
            //Thread initnotif = new Thread(InitNotification);
            //initnotif.Start();
            ThreadPool.QueueUserWorkItem(delegate {
                System.Diagnostics.Process.Start("D:\\__Alexzander_files__\\__computer_science__\\python_stuff\\andrew_packages\\application_database\\initializer.pyw");
            });

            InitPaths();
            InitInfoLabels();
            Init();
            clock_timer.Start();
            CreateAddItem("application", "loaded");
        }

        public void CreateAddItem(String event_name, String action="opened")
        {
            String item = String.Format(
                "[ {0} ]. {1} {2}.", 
                ++event_log_counter, 
                event_name,
                action
            );
            event_log_listbox.Items.Add(item);
        }

        private void clock_timer_Tick(object sender, EventArgs e)
        {
            time_displayer_label.Text = 
                DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void old_app_db_opener_button_MouseEnter(object sender, EventArgs e)
        {   
            old_app_db_opener_button.BackColor = mouse_enter_color_back;
            old_app_db_opener_button.ForeColor = mouse_enter_color_fore;
            appinfo = new AppsInformation(old_appdb_info);
            appinfo.Show();
        }

        private void old_app_db_opener_button_MouseLeave(object sender, EventArgs e)
        {
            old_app_db_opener_button.BackColor = mouse_leave_color_back;
            old_app_db_opener_button.ForeColor = mouse_leave_color_fore;
            appinfo.Close();
        }

        private void old_app_db_opener_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("old appdb");
            System.Diagnostics.Process.Start(old_appdb_path);
        }

        private void systemapp_opener_button_MouseEnter(object sender, EventArgs e)
        {
            systemapp_opener_button.BackColor = mouse_enter_color_back;
            systemapp_opener_button.ForeColor = mouse_enter_color_fore;
        }

        private void systemapp_opener_button_MouseLeave(object sender, EventArgs e)
        {
            systemapp_opener_button.BackColor = mouse_leave_color_back;
            systemapp_opener_button.ForeColor = mouse_leave_color_fore;
        }

        private void systemapp_opener_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("systemapp");
            System.Diagnostics.Process.Start(systemapp_path);
        }

        private void emailopener_button_MouseEnter(object sender, EventArgs e)
        {
            emailopener_button.BackColor = mouse_enter_color_back;
            emailopener_button.ForeColor = mouse_enter_color_fore;
        }

        private void emailopener_button_MouseLeave(object sender, EventArgs e)
        {
            emailopener_button.BackColor = mouse_leave_color_back;
            emailopener_button.ForeColor = mouse_leave_color_fore;
        }

        private void emailopener_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("emailsopener");
            System.Diagnostics.Process.Start(emailsopener_path);
        }

        private void social_opener_button_MouseEnter(object sender, EventArgs e)
        {
            social_opener_button.BackColor = mouse_enter_color_back;
            social_opener_button.ForeColor = mouse_enter_color_fore;
        }

        private void social_opener_button_MouseLeave(object sender, EventArgs e)
        {
            social_opener_button.BackColor = mouse_leave_color_back;
            social_opener_button.ForeColor = mouse_leave_color_fore;
        }

        private void social_opener_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("socialopener");
            System.Diagnostics.Process.Start(socialopener_path);
        }

        private void icalendar_button_MouseEnter(object sender, EventArgs e)
        {
            icalendar_button.BackColor = mouse_enter_color_back;
            icalendar_button.ForeColor = mouse_enter_color_fore;
        }

        private void icalendar_button_MouseLeave(object sender, EventArgs e)
        {
            icalendar_button.BackColor = mouse_leave_color_back;
            icalendar_button.ForeColor = mouse_leave_color_fore;
        }

        private void icalendar_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("icalendar");
            System.Diagnostics.Process.Start(icalendar_path);
        }

        private void accounts_button_MouseEnter(object sender, EventArgs e)
        {
            accounts_button.BackColor = mouse_enter_color_back;
            accounts_button.ForeColor = mouse_enter_color_fore;
        }

        private void accounts_button_MouseLeave(object sender, EventArgs e)
        {
            accounts_button.BackColor = mouse_leave_color_back;
            accounts_button.ForeColor = mouse_leave_color_fore;
        }

        private void accounts_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("accounts");
            System.Diagnostics.Process.Start(accounts_path);
        }

        private void cards_button_MouseEnter(object sender, EventArgs e)
        {
            cards_button.BackColor = mouse_enter_color_back;
            cards_button.ForeColor = mouse_enter_color_fore;
        }

        private void cards_button_MouseLeave(object sender, EventArgs e)
        {
            cards_button.BackColor = mouse_leave_color_back;
            cards_button.ForeColor = mouse_leave_color_fore;
        }

        private void cards_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("cards");
            System.Diagnostics.Process.Start(cards_path);
        }

        private void emailsender_button_MouseEnter(object sender, EventArgs e)
        {
            emailsender_button.BackColor = mouse_enter_color_back;
            emailsender_button.ForeColor = mouse_enter_color_fore;
        }

        private void emailsender_button_MouseLeave(object sender, EventArgs e)
        {
            emailsender_button.BackColor = mouse_leave_color_back;
            emailsender_button.ForeColor = mouse_leave_color_fore;
        }

        private void emailsender_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("emailsender");
            System.Diagnostics.Process.Start(emailsender_path);
        }

        private void injection_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("injection");
            System.Diagnostics.Process.Start(injection_path);
        }

        private void keylogger_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("keylogger");
            System.Diagnostics.Process.Start(keylogger_path);
        }

        private void musicapp_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("musicapp");
            System.Diagnostics.Process.Start(musicapp_path);
        }

        private void screenshot_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Thread.Sleep(1000);

            Bitmap bitmap = new Bitmap(
                Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height
            );
            Graphics graph = Graphics.FromImage(bitmap);
            graph.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

            String file_content = "";

            // here i get the counter from the file
            using (FileStream fs = File.OpenRead(screenshotcounter_path))
            {
                byte[] barray = new byte[1024];
                UTF8Encoding utf8_text = new UTF8Encoding(true);
                while (fs.Read(barray, 0, barray.Length) > 0)
                {
                    file_content = utf8_text.GetString(barray);
                }
            }

            // i create temporary counter and i incremenet it
            int temp_counter = Int32.Parse(file_content);

            String path = String.Format(screenshots_path + "screenshot{0}.png", ++temp_counter);

            // here i open the file again the overwrite the old content with the incremented value
            using (FileStream fs = File.OpenWrite(screenshotcounter_path))
            {
                Byte[] barray = new UTF8Encoding(true).GetBytes(temp_counter.ToString());
                fs.Write(barray, 0, barray.Length);
            }

            bitmap.Save(path);
            this.WindowState = FormWindowState.Normal;
        }

        private void tictactoe_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("tictactoe button", "pressed");
            TicTacToeForm choose_game = new TicTacToeForm(this);
            choose_game.Show();
        }

        private void wappsender_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("wapp sender");
            System.Diagnostics.Process.Start(wappsender_path);
        }

        private void xmastree_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("xmastree");
            System.Diagnostics.Process.Start(xmastree_path);
        }

        private void andrewsite_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("andrew's website");
            System.Diagnostics.Process.Start(andrewsite_path);
        }

        private void ultramenuapp_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("ultramenuapp");
            System.Diagnostics.Process.Start(ultramenuapp_path);
        }

        private void open_ss_location_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("screenshots location");
            System.Diagnostics.Process.Start(screenshots_path);
        }

        private void inspirational_text_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("inspirational text", "loaded");
            InspirationalContentForm insp_text = new InspirationalContentForm();
            insp_text.Show();
        }

        private void calculator_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("windows calculator");
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        private void controlpanel_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("windows control panel");
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\control.exe");
        }

        public readonly int big_apps_loadtime = 10000; // 10 seconds
        public readonly int small_apps_loadtime = 3000; // 3 seconds

        public void InitializeSystem()
        {
            // deactivating the button
            initializer_button.Enabled = false;
            initializer_button.Visible = false;

            CreateAddItem("initializer", "pressed");
            System.Diagnostics.Process.Start(systemapp_path);
            Thread.Sleep(500); // 0.5 seconds
            System.Diagnostics.Process.Start(emailsopener_path);
            Thread.Sleep(500);
            System.Diagnostics.Process.Start(socialopener_path);
            Thread.Sleep(500);
            System.Diagnostics.Process.Start(icalendar_path);
            Thread.Sleep(500);
            System.Diagnostics.Process.Start(musicapp_path);
            Thread.Sleep(500);
            System.Diagnostics.Process.Start(newsapp_path);
            Thread.Sleep(500);
            System.Diagnostics.Process.Start(tinderbot_path);
            Thread.Sleep(500);

            CreateAddItem("__Alexzander_Files__");
            System.Diagnostics.Process.Start("D:\\__Alexzander_Files__\\");
            Thread.Sleep(500);

            String taskmgr_exe_path = "C:\\Windows\\System32\\Taskmgr.exe";
            String brave_exe_path = "C:\\Program Files (x86)\\BraveSoftware\\Brave-Browser\\Application\\brave.exe";
            String vscode_exe_path = "D:\\Applications\\Visual Studio Code\\Microsoft VS Code\\Code.exe";
            String pycharm_exe_path = "D:\\Applications\\PyCharm JetBrains IDE\\PyCharm Community Edition 2019.2.1\\bin\\pycharm64.exe";
            String notepadplusplus_exe_path = "D:\\Applications\\Notepad++ Installation\\Notepad++\\notepad++.exe";

            System.Diagnostics.Process.Start(notepadplusplus_exe_path);
            Thread.Sleep(small_apps_loadtime);

            CreateAddItem("task manager");
            System.Diagnostics.Process.Start(taskmgr_exe_path);
            Thread.Sleep(small_apps_loadtime);

            CreateAddItem("brave browser");
            System.Diagnostics.Process.Start(brave_exe_path);
            Thread.Sleep(big_apps_loadtime);

            CreateAddItem("vs code");
            System.Diagnostics.Process.Start(vscode_exe_path);
            Thread.Sleep(big_apps_loadtime);

            CreateAddItem("pycharm");
            System.Diagnostics.Process.Start(pycharm_exe_path);
            Thread.Sleep(big_apps_loadtime);
        }

        private void initializer_button_Click(object sender, EventArgs e)
        {
            int loading_seconds = 5;
            SystemForm system_form_initializer = new SystemForm(loading_seconds, this);
            system_form_initializer.Show();
        }

        private void newsapp_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("news opener");
            System.Diagnostics.Process.Start(newsapp_path);
        }

        private void scrappy_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("scrappy");
            System.Diagnostics.Process.Start(scrappy_path);
        }

        private void injection_button_MouseEnter(object sender, EventArgs e)
        {
            injection_button.BackColor = mouse_enter_color_back;
            injection_button.ForeColor = mouse_enter_color_fore;
        }

        private void injection_button_MouseLeave(object sender, EventArgs e)
        {
            injection_button.BackColor = mouse_leave_color_back;
            injection_button.ForeColor = mouse_leave_color_fore;
        }

        private void keylogger_button_MouseEnter(object sender, EventArgs e)
        {
            keylogger_button.BackColor = mouse_enter_color_back;
            keylogger_button.ForeColor = mouse_enter_color_fore;
        }

        private void keylogger_button_MouseLeave(object sender, EventArgs e)
        {
            keylogger_button.BackColor = mouse_leave_color_back;
            keylogger_button.ForeColor = mouse_leave_color_fore;
        }

        private void musicapp_button_MouseEnter(object sender, EventArgs e)
        {
            musicapp_button.BackColor = mouse_enter_color_back;
            musicapp_button.ForeColor = mouse_enter_color_fore;
        }

        private void musicapp_button_MouseLeave(object sender, EventArgs e)
        {
            musicapp_button.BackColor = mouse_leave_color_back;
            musicapp_button.ForeColor = mouse_leave_color_fore;
        }

        private void tictactoe_button_MouseEnter(object sender, EventArgs e)
        {
            tictactoe_button.BackColor = mouse_enter_color_back;
            tictactoe_button.ForeColor = mouse_enter_color_fore;
        }

        private void tictactoe_button_MouseLeave(object sender, EventArgs e)
        {
            tictactoe_button.BackColor = mouse_leave_color_back;
            tictactoe_button.ForeColor = mouse_leave_color_fore;
        }

        private void wappsender_button_MouseEnter(object sender, EventArgs e)
        {
            wappsender_button.BackColor = mouse_enter_color_back;
            wappsender_button.ForeColor = mouse_enter_color_fore;
        }

        private void wappsender_button_MouseLeave(object sender, EventArgs e)
        {
            wappsender_button.BackColor = mouse_leave_color_back;
            wappsender_button.ForeColor = mouse_leave_color_fore;
        }

        private void xmastree_button_MouseEnter(object sender, EventArgs e)
        {
            xmastree_button.BackColor = mouse_enter_color_back;
            xmastree_button.ForeColor = mouse_enter_color_fore;
        }

        private void xmastree_button_MouseLeave(object sender, EventArgs e)
        {
            xmastree_button.BackColor = mouse_leave_color_back;
            xmastree_button.ForeColor = mouse_leave_color_fore;
        }

        private void andrewsite_button_MouseEnter(object sender, EventArgs e)
        {
            andrewsite_button.BackColor = mouse_enter_color_back;
            andrewsite_button.ForeColor = mouse_enter_color_fore;
        }

        private void andrewsite_button_MouseLeave(object sender, EventArgs e)
        {
            andrewsite_button.BackColor = mouse_leave_color_back;
            andrewsite_button.ForeColor = mouse_leave_color_fore;
        }

        private void ultramenuapp_button_MouseEnter(object sender, EventArgs e)
        {
            ultramenuapp_button.BackColor = mouse_enter_color_back;
            ultramenuapp_button.ForeColor = mouse_enter_color_fore;
        }

        private void ultramenuapp_button_MouseLeave(object sender, EventArgs e)
        {
            ultramenuapp_button.BackColor = mouse_leave_color_back;
            ultramenuapp_button.ForeColor = mouse_leave_color_fore;
        }

        private void newsapp_button_MouseEnter(object sender, EventArgs e)
        {
            newsapp_button.BackColor = mouse_enter_color_back;
            newsapp_button.ForeColor = mouse_enter_color_fore;
        }

        private void newsapp_button_MouseLeave(object sender, EventArgs e)
        {
            newsapp_button.BackColor = mouse_leave_color_back;
            newsapp_button.ForeColor = mouse_leave_color_fore;
        }

        private void scrappy_button_MouseEnter(object sender, EventArgs e)
        {
            scrappy_button.BackColor = mouse_enter_color_back;
            scrappy_button.ForeColor = mouse_enter_color_fore;
        }

        private void scrappy_button_MouseLeave(object sender, EventArgs e)
        {
            scrappy_button.BackColor = mouse_leave_color_back;
            scrappy_button.ForeColor = mouse_leave_color_fore;
        }

        private void screenshot_button_MouseEnter(object sender, EventArgs e)
        {
            screenshot_button.BackColor = mouse_enter_color_back;
            screenshot_button.ForeColor = mouse_enter_color_fore;
        }

        private void screenshot_button_MouseLeave(object sender, EventArgs e)
        {
            screenshot_button.BackColor = mouse_leave_color_back;
            screenshot_button.ForeColor = mouse_leave_color_fore;
        }

        private void open_ss_location_button_MouseEnter(object sender, EventArgs e)
        {
            open_ss_location_button.BackColor = mouse_enter_color_back;
            open_ss_location_button.ForeColor = mouse_enter_color_fore;
        }

        private void open_ss_location_button_MouseLeave(object sender, EventArgs e)
        {
            open_ss_location_button.BackColor = mouse_leave_color_back;
            open_ss_location_button.ForeColor = mouse_leave_color_fore;
        }

        private void calculator_button_MouseEnter(object sender, EventArgs e)
        {
            calculator_button.BackColor = mouse_enter_color_back;
            calculator_button.ForeColor = mouse_enter_color_fore;
        }

        private void calculator_button_MouseLeave(object sender, EventArgs e)
        {
            calculator_button.BackColor = mouse_leave_color_back;
            calculator_button.ForeColor = mouse_leave_color_fore;
        }

        private void inspirational_text_button_MouseEnter(object sender, EventArgs e)
        {
            inspirational_text_button.BackColor = mouse_enter_color_back;
            inspirational_text_button.ForeColor = mouse_enter_color_fore;
        }

        private void inspirational_text_button_MouseLeave(object sender, EventArgs e)
        {
            inspirational_text_button.BackColor = mouse_leave_color_back;
            inspirational_text_button.ForeColor = mouse_leave_color_fore;
        }

        private void initializer_button_MouseEnter(object sender, EventArgs e)
        {
            initializer_button.BackColor = mouse_enter_color_back_warning;
            initializer_button.ForeColor = mouse_enter_color_fore_warning;
            appinfo = new AppsInformation(initializer_button_info);
            appinfo.Show();
        }

        private void initializer_button_MouseLeave(object sender, EventArgs e)
        {
            initializer_button.BackColor = mouse_leave_color_back;
            initializer_button.ForeColor = mouse_leave_color_fore;
            appinfo.Close();
        }

        private void controlpanel_button_MouseEnter(object sender, EventArgs e)
        {
            controlpanel_button.BackColor = mouse_enter_color_back;
            controlpanel_button.ForeColor = mouse_enter_color_fore;
        }

        private void controlpanel_button_MouseLeave(object sender, EventArgs e)
        {
            controlpanel_button.BackColor = mouse_leave_color_back;
            controlpanel_button.ForeColor = mouse_leave_color_fore;
        }

        private void testing_area_button_Click(object sender, EventArgs e)
        {
            TestingForm testapp = new TestingForm();
            testapp.Show();
        }

        private void alexzander_files_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("__Alexzander_Files__");
            System.Diagnostics.Process.Start("D:\\");
        }

        private void alexzander_files_button_MouseEnter(object sender, EventArgs e)
        {
            alexzander_files_button.BackColor = mouse_enter_color_back;
            alexzander_files_button.ForeColor = mouse_enter_color_fore;
        }

        private void alexzander_files_button_MouseLeave(object sender, EventArgs e)
        {
            alexzander_files_button.BackColor = mouse_leave_color_back;
            alexzander_files_button.ForeColor = mouse_leave_color_fore;
        }

        private void open_downloads_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("downloads");
            String path1 = String.Format("C:\\Users\\{0}\\Downloads\\", username);
            System.Diagnostics.Process.Start(path1);

            CreateAddItem("alexzander downloads");
            String path2 = "D:\\__downloads__";
            System.Diagnostics.Process.Start(path2);
        }

        private void open_downloads_button_MouseEnter(object sender, EventArgs e)
        {
            open_downloads_button.BackColor = mouse_enter_color_back;
            open_downloads_button.ForeColor = mouse_enter_color_fore;
        }

        private void open_downloads_button_MouseLeave(object sender, EventArgs e)
        {
            open_downloads_button.BackColor = mouse_leave_color_back;
            open_downloads_button.ForeColor = mouse_leave_color_fore;
        }

        private void computer_science_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("computer_science folder");
            System.Diagnostics.Process.Start("D:\\__Alexzander_files__\\__computer_science__\\");
        }

        private void computer_science_button_MouseEnter(object sender, EventArgs e)
        {
            computer_science_button.BackColor = mouse_enter_color_back;
            computer_science_button.ForeColor = mouse_enter_color_fore;
        }

        private void computer_science_button_MouseLeave(object sender, EventArgs e)
        {
            computer_science_button.BackColor = mouse_leave_color_back;
            computer_science_button.ForeColor = mouse_leave_color_fore;
        }

        private void supremefolder_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("supreme_folder folder");
            System.Diagnostics.Process.Start("D:\\__Alexzander_files__\\__supreme_folder__\\");
        }

        private void supremefolder_button_MouseEnter(object sender, EventArgs e)
        {
            supremefolder_button.BackColor = mouse_enter_color_back;
            supremefolder_button.ForeColor = mouse_enter_color_fore;
        }

        private void supremefolder_button_MouseLeave(object sender, EventArgs e)
        {
            supremefolder_button.BackColor = mouse_leave_color_back;
            supremefolder_button.ForeColor = mouse_leave_color_fore;
        }

        private void testing_area_button_MouseEnter(object sender, EventArgs e)
        {
            testing_area_button.BackColor = mouse_enter_color_back;
            testing_area_button.ForeColor = mouse_enter_color_fore;
        }

        private void testing_area_button_MouseLeave(object sender, EventArgs e)
        {
            testing_area_button.BackColor = mouse_leave_color_back;
            testing_area_button.ForeColor = mouse_leave_color_fore;
        }

        private void python_scripts_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("python_scripts_andrew");
            String scripts_path = String.Format("C:\\Users\\{0}\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\python_scripts_andrew\\", username);
            if (!System.IO.Directory.Exists(scripts_path))
            {
                System.IO.Directory.CreateDirectory(scripts_path);
            }
            System.Diagnostics.Process.Start(scripts_path);
        }

        private void python_scripts_button_MouseEnter(object sender, EventArgs e)
        {
            python_scripts_button.BackColor = mouse_enter_color_back;
            python_scripts_button.ForeColor = mouse_enter_color_fore;
        }

        private void python_scripts_button_MouseLeave(object sender, EventArgs e)
        {
            python_scripts_button.BackColor = mouse_leave_color_back;
            python_scripts_button.ForeColor = mouse_leave_color_fore;
        }

        private void appdata_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("appdata");
            String path = String.Format("C:\\Users\\{0}\\AppData", username);
            System.Diagnostics.Process.Start(path);
        }

        private void appdata_button_MouseEnter(object sender, EventArgs e)
        {
            appdata_button.BackColor = mouse_enter_color_back;
            appdata_button.ForeColor = mouse_enter_color_fore;
        }

        private void appdata_button_MouseLeave(object sender, EventArgs e)
        {
            appdata_button.BackColor = mouse_leave_color_back;
            appdata_button.ForeColor = mouse_leave_color_fore;
        }

        private void local_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("appdata local");
            String path = String.Format("C:\\Users\\{0}\\AppData\\Local", username);
            System.Diagnostics.Process.Start(path);
        }

        private void local_button_MouseEnter(object sender, EventArgs e)
        {
            local_button.BackColor = mouse_enter_color_back;
            local_button.ForeColor = mouse_enter_color_fore;
        }

        private void local_button_MouseLeave(object sender, EventArgs e)
        {
            local_button.BackColor = mouse_leave_color_back;
            local_button.ForeColor = mouse_leave_color_fore;
        }

        private void locallow_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("appdata locallow");
            String path = String.Format("C:\\Users\\{0}\\AppData\\LocalLow", username);
            System.Diagnostics.Process.Start(path);
        }

        private void locallow_button_MouseEnter(object sender, EventArgs e)
        {
            locallow_button.BackColor = mouse_enter_color_back;
            locallow_button.ForeColor = mouse_enter_color_fore;
        }

        private void locallow_button_MouseLeave(object sender, EventArgs e)
        {
            locallow_button.BackColor = mouse_leave_color_back;
            locallow_button.ForeColor = mouse_leave_color_fore;
        }

        private void roaming_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("appdata roaming");
            String path = String.Format("C:\\Users\\{0}\\AppData\\Roaming", username);
            System.Diagnostics.Process.Start(path);
        }

        private void roaming_button_MouseEnter(object sender, EventArgs e)
        {
            roaming_button.BackColor = mouse_enter_color_back;
            roaming_button.ForeColor = mouse_enter_color_fore;
        }

        private void roaming_button_MouseLeave(object sender, EventArgs e)
        {
            roaming_button.BackColor = mouse_leave_color_back;
            roaming_button.ForeColor = mouse_leave_color_fore;
        }

        private void tinderbot_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("tinderbot");
            System.Diagnostics.Process.Start(tinderbot_path);
        }

        private void tinderbot_button_MouseEnter(object sender, EventArgs e)
        {
            tinderbot_button.BackColor = mouse_enter_color_back;
            tinderbot_button.ForeColor = mouse_enter_color_fore;
        }

        private void tinderbot_button_MouseLeave(object sender, EventArgs e)
        {
            tinderbot_button.BackColor = mouse_leave_color_back;
            tinderbot_button.ForeColor = mouse_leave_color_fore;
        }

        private void humanhierarchy_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("human hierarchy");
            System.Diagnostics.Process.Start(humanhierarchy_path);
        }

        private void humanhierarchy_button_MouseEnter(object sender, EventArgs e)
        {
            humanhierarchy_button.BackColor = mouse_enter_color_back;
            humanhierarchy_button.ForeColor = mouse_enter_color_fore;
        }

        private void humanhierarchy_button_MouseLeave(object sender, EventArgs e)
        {
            humanhierarchy_button.BackColor = mouse_leave_color_back;
            humanhierarchy_button.ForeColor = mouse_leave_color_fore;
        }

        private void time_tracker_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("TimeTracker");
            System.Diagnostics.Process.Start(examtimer_path);
        }

        private void update_shortcuts_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("updater");
            System.Diagnostics.Process.Start(updater_path);
        }

        private void time_tracker_button_MouseEnter(object sender, EventArgs e)
        {
            time_tracker_button.BackColor = mouse_enter_color_back;
            time_tracker_button.ForeColor = mouse_enter_color_fore;
        }

        private void time_tracker_button_MouseLeave(object sender, EventArgs e)
        {
            time_tracker_button.BackColor = mouse_leave_color_back;
            time_tracker_button.ForeColor = mouse_leave_color_fore;
        }

        private void update_shortcuts_button_MouseEnter(object sender, EventArgs e)
        {
            update_shortcuts_button.BackColor = mouse_enter_color_back_warning;
            update_shortcuts_button.ForeColor = mouse_enter_color_fore_warning;
        }

        private void update_shortcuts_button_MouseLeave(object sender, EventArgs e)
        {
            update_shortcuts_button.BackColor = mouse_leave_color_back;
            update_shortcuts_button.ForeColor = mouse_leave_color_fore;
        }

        private void locations_tracker_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("locations tracker");
            System.Diagnostics.Process.Start(locations_tracker_path);
        }

        private void locations_tracker_button_MouseEnter(object sender, EventArgs e)
        {
            locations_tracker_button.BackColor = mouse_enter_color_back;
            locations_tracker_button.ForeColor = mouse_enter_color_fore;
        }

        private void locations_tracker_button_MouseLeave(object sender, EventArgs e)
        {
            locations_tracker_button.BackColor = mouse_leave_color_back;
            locations_tracker_button.ForeColor = mouse_leave_color_fore;
        }

        private void open_shortcuts_button_Click(object sender, EventArgs e)
        {
            CreateAddItem("shortcuts path");
            System.Diagnostics.Process.Start(shortcuts_path);
        }

        private void open_shortcuts_button_MouseEnter(object sender, EventArgs e)
        {
            open_shortcuts_button.BackColor = mouse_enter_color_back;
            open_shortcuts_button.ForeColor = mouse_enter_color_fore;
        }

        private void open_shortcuts_button_MouseLeave(object sender, EventArgs e)
        {
            open_shortcuts_button.BackColor = mouse_leave_color_back;
            open_shortcuts_button.ForeColor = mouse_leave_color_fore;
        }
    }
}