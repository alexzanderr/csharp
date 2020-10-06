namespace application_database
{
    partial class ApplicationDatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationDatabaseForm));
            this.app_name_label = new System.Windows.Forms.Label();
            this.v_name_label = new System.Windows.Forms.Label();
            this.time_displayer_label = new System.Windows.Forms.Label();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.event_log_listbox = new System.Windows.Forms.ListBox();
            this.old_app_db_opener_button = new System.Windows.Forms.Button();
            this.systemapp_opener_button = new System.Windows.Forms.Button();
            this.emailopener_button = new System.Windows.Forms.Button();
            this.social_opener_button = new System.Windows.Forms.Button();
            this.icalendar_button = new System.Windows.Forms.Button();
            this.accounts_button = new System.Windows.Forms.Button();
            this.cards_button = new System.Windows.Forms.Button();
            this.emailsender_button = new System.Windows.Forms.Button();
            this.injection_button = new System.Windows.Forms.Button();
            this.keylogger_button = new System.Windows.Forms.Button();
            this.musicapp_button = new System.Windows.Forms.Button();
            this.screenshot_button = new System.Windows.Forms.Button();
            this.tictactoe_button = new System.Windows.Forms.Button();
            this.wappsender_button = new System.Windows.Forms.Button();
            this.xmastree_button = new System.Windows.Forms.Button();
            this.andrewsite_button = new System.Windows.Forms.Button();
            this.ultramenuapp_button = new System.Windows.Forms.Button();
            this.open_ss_location_button = new System.Windows.Forms.Button();
            this.inspirational_text_button = new System.Windows.Forms.Button();
            this.calculator_button = new System.Windows.Forms.Button();
            this.controlpanel_button = new System.Windows.Forms.Button();
            this.initializer_button = new System.Windows.Forms.Button();
            this.newsapp_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrappy_button = new System.Windows.Forms.Button();
            this.testing_area_button = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.alexzander_files_button = new System.Windows.Forms.Button();
            this.open_downloads_button = new System.Windows.Forms.Button();
            this.supremefolder_button = new System.Windows.Forms.Button();
            this.computer_science_button = new System.Windows.Forms.Button();
            this.opening_files_label = new System.Windows.Forms.Label();
            this.opening_apps_label = new System.Windows.Forms.Label();
            this.python_scripts_button = new System.Windows.Forms.Button();
            this.appdata_button = new System.Windows.Forms.Button();
            this.local_button = new System.Windows.Forms.Button();
            this.locallow_button = new System.Windows.Forms.Button();
            this.roaming_button = new System.Windows.Forms.Button();
            this.tinderbot_button = new System.Windows.Forms.Button();
            this.humanhierarchy_button = new System.Windows.Forms.Button();
            this.time_tracker_button = new System.Windows.Forms.Button();
            this.update_shortcuts_button = new System.Windows.Forms.Button();
            this.locations_tracker_button = new System.Windows.Forms.Button();
            this.open_shortcuts_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // app_name_label
            // 
            this.app_name_label.AutoSize = true;
            this.app_name_label.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.app_name_label.Location = new System.Drawing.Point(884, 19);
            this.app_name_label.Name = "app_name_label";
            this.app_name_label.Size = new System.Drawing.Size(269, 31);
            this.app_name_label.TabIndex = 0;
            this.app_name_label.Text = "<Application Database>";
            this.app_name_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.app_name_label.UseCompatibleTextRendering = true;
            // 
            // v_name_label
            // 
            this.v_name_label.AutoSize = true;
            this.v_name_label.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_name_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.v_name_label.Location = new System.Drawing.Point(1011, 62);
            this.v_name_label.Name = "v_name_label";
            this.v_name_label.Size = new System.Drawing.Size(142, 24);
            this.v_name_label.TabIndex = 1;
            this.v_name_label.Text = "version 1.0";
            // 
            // time_displayer_label
            // 
            this.time_displayer_label.AutoSize = true;
            this.time_displayer_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.time_displayer_label.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_displayer_label.ForeColor = System.Drawing.Color.Lime;
            this.time_displayer_label.Location = new System.Drawing.Point(867, 153);
            this.time_displayer_label.Name = "time_displayer_label";
            this.time_displayer_label.Size = new System.Drawing.Size(154, 24);
            this.time_displayer_label.TabIndex = 2;
            this.time_displayer_label.Text = "current_time";
            // 
            // clock_timer
            // 
            this.clock_timer.Interval = 1000;
            this.clock_timer.Tick += new System.EventHandler(this.clock_timer_Tick);
            // 
            // event_log_listbox
            // 
            this.event_log_listbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.event_log_listbox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_log_listbox.ForeColor = System.Drawing.Color.Lime;
            this.event_log_listbox.FormattingEnabled = true;
            this.event_log_listbox.ItemHeight = 18;
            this.event_log_listbox.Items.AddRange(new object[] {
            "Event log",
            "_____________________________________________"});
            this.event_log_listbox.Location = new System.Drawing.Point(0, 1);
            this.event_log_listbox.Name = "event_log_listbox";
            this.event_log_listbox.Size = new System.Drawing.Size(327, 832);
            this.event_log_listbox.TabIndex = 3;
            // 
            // old_app_db_opener_button
            // 
            this.old_app_db_opener_button.BackColor = System.Drawing.SystemColors.Control;
            this.old_app_db_opener_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_app_db_opener_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.old_app_db_opener_button.Location = new System.Drawing.Point(333, 133);
            this.old_app_db_opener_button.Name = "old_app_db_opener_button";
            this.old_app_db_opener_button.Size = new System.Drawing.Size(143, 32);
            this.old_app_db_opener_button.TabIndex = 4;
            this.old_app_db_opener_button.Text = "old AppDb";
            this.old_app_db_opener_button.UseVisualStyleBackColor = false;
            this.old_app_db_opener_button.Click += new System.EventHandler(this.old_app_db_opener_button_Click);
            this.old_app_db_opener_button.MouseEnter += new System.EventHandler(this.old_app_db_opener_button_MouseEnter);
            this.old_app_db_opener_button.MouseLeave += new System.EventHandler(this.old_app_db_opener_button_MouseLeave);
            // 
            // systemapp_opener_button
            // 
            this.systemapp_opener_button.BackColor = System.Drawing.SystemColors.Control;
            this.systemapp_opener_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemapp_opener_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.systemapp_opener_button.Location = new System.Drawing.Point(333, 171);
            this.systemapp_opener_button.Name = "systemapp_opener_button";
            this.systemapp_opener_button.Size = new System.Drawing.Size(143, 32);
            this.systemapp_opener_button.TabIndex = 5;
            this.systemapp_opener_button.Text = "systemapp";
            this.systemapp_opener_button.UseVisualStyleBackColor = false;
            this.systemapp_opener_button.Click += new System.EventHandler(this.systemapp_opener_button_Click);
            this.systemapp_opener_button.MouseEnter += new System.EventHandler(this.systemapp_opener_button_MouseEnter);
            this.systemapp_opener_button.MouseLeave += new System.EventHandler(this.systemapp_opener_button_MouseLeave);
            // 
            // emailopener_button
            // 
            this.emailopener_button.BackColor = System.Drawing.SystemColors.Control;
            this.emailopener_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailopener_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.emailopener_button.Location = new System.Drawing.Point(333, 209);
            this.emailopener_button.Name = "emailopener_button";
            this.emailopener_button.Size = new System.Drawing.Size(143, 32);
            this.emailopener_button.TabIndex = 6;
            this.emailopener_button.Text = "emailsopener";
            this.emailopener_button.UseVisualStyleBackColor = false;
            this.emailopener_button.Click += new System.EventHandler(this.emailopener_button_Click);
            this.emailopener_button.MouseEnter += new System.EventHandler(this.emailopener_button_MouseEnter);
            this.emailopener_button.MouseLeave += new System.EventHandler(this.emailopener_button_MouseLeave);
            // 
            // social_opener_button
            // 
            this.social_opener_button.BackColor = System.Drawing.SystemColors.Control;
            this.social_opener_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.social_opener_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.social_opener_button.Location = new System.Drawing.Point(333, 248);
            this.social_opener_button.Name = "social_opener_button";
            this.social_opener_button.Size = new System.Drawing.Size(143, 32);
            this.social_opener_button.TabIndex = 7;
            this.social_opener_button.Text = "socialopener";
            this.social_opener_button.UseVisualStyleBackColor = false;
            this.social_opener_button.Click += new System.EventHandler(this.social_opener_button_Click);
            this.social_opener_button.MouseEnter += new System.EventHandler(this.social_opener_button_MouseEnter);
            this.social_opener_button.MouseLeave += new System.EventHandler(this.social_opener_button_MouseLeave);
            // 
            // icalendar_button
            // 
            this.icalendar_button.BackColor = System.Drawing.SystemColors.Control;
            this.icalendar_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icalendar_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.icalendar_button.Location = new System.Drawing.Point(333, 286);
            this.icalendar_button.Name = "icalendar_button";
            this.icalendar_button.Size = new System.Drawing.Size(143, 32);
            this.icalendar_button.TabIndex = 8;
            this.icalendar_button.Text = "iCalendar";
            this.icalendar_button.UseVisualStyleBackColor = false;
            this.icalendar_button.Click += new System.EventHandler(this.icalendar_button_Click);
            this.icalendar_button.MouseEnter += new System.EventHandler(this.icalendar_button_MouseEnter);
            this.icalendar_button.MouseLeave += new System.EventHandler(this.icalendar_button_MouseLeave);
            // 
            // accounts_button
            // 
            this.accounts_button.BackColor = System.Drawing.SystemColors.Control;
            this.accounts_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accounts_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.accounts_button.Location = new System.Drawing.Point(333, 324);
            this.accounts_button.Name = "accounts_button";
            this.accounts_button.Size = new System.Drawing.Size(143, 32);
            this.accounts_button.TabIndex = 9;
            this.accounts_button.Text = "accounts";
            this.accounts_button.UseVisualStyleBackColor = false;
            this.accounts_button.Click += new System.EventHandler(this.accounts_button_Click);
            this.accounts_button.MouseEnter += new System.EventHandler(this.accounts_button_MouseEnter);
            this.accounts_button.MouseLeave += new System.EventHandler(this.accounts_button_MouseLeave);
            // 
            // cards_button
            // 
            this.cards_button.BackColor = System.Drawing.SystemColors.Control;
            this.cards_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cards_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.cards_button.Location = new System.Drawing.Point(333, 362);
            this.cards_button.Name = "cards_button";
            this.cards_button.Size = new System.Drawing.Size(143, 32);
            this.cards_button.TabIndex = 10;
            this.cards_button.Text = "cards";
            this.cards_button.UseVisualStyleBackColor = false;
            this.cards_button.Click += new System.EventHandler(this.cards_button_Click);
            this.cards_button.MouseEnter += new System.EventHandler(this.cards_button_MouseEnter);
            this.cards_button.MouseLeave += new System.EventHandler(this.cards_button_MouseLeave);
            // 
            // emailsender_button
            // 
            this.emailsender_button.BackColor = System.Drawing.SystemColors.Control;
            this.emailsender_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailsender_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.emailsender_button.Location = new System.Drawing.Point(333, 400);
            this.emailsender_button.Name = "emailsender_button";
            this.emailsender_button.Size = new System.Drawing.Size(143, 32);
            this.emailsender_button.TabIndex = 11;
            this.emailsender_button.Text = "emailsender";
            this.emailsender_button.UseVisualStyleBackColor = false;
            this.emailsender_button.Click += new System.EventHandler(this.emailsender_button_Click);
            this.emailsender_button.MouseEnter += new System.EventHandler(this.emailsender_button_MouseEnter);
            this.emailsender_button.MouseLeave += new System.EventHandler(this.emailsender_button_MouseLeave);
            // 
            // injection_button
            // 
            this.injection_button.BackColor = System.Drawing.SystemColors.Control;
            this.injection_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injection_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.injection_button.Location = new System.Drawing.Point(477, 400);
            this.injection_button.Name = "injection_button";
            this.injection_button.Size = new System.Drawing.Size(144, 32);
            this.injection_button.TabIndex = 12;
            this.injection_button.Text = "injection";
            this.injection_button.UseVisualStyleBackColor = false;
            this.injection_button.Click += new System.EventHandler(this.injection_button_Click);
            this.injection_button.MouseEnter += new System.EventHandler(this.injection_button_MouseEnter);
            this.injection_button.MouseLeave += new System.EventHandler(this.injection_button_MouseLeave);
            // 
            // keylogger_button
            // 
            this.keylogger_button.BackColor = System.Drawing.SystemColors.Control;
            this.keylogger_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keylogger_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.keylogger_button.Location = new System.Drawing.Point(333, 438);
            this.keylogger_button.Name = "keylogger_button";
            this.keylogger_button.Size = new System.Drawing.Size(143, 32);
            this.keylogger_button.TabIndex = 13;
            this.keylogger_button.Text = "keylogger";
            this.keylogger_button.UseVisualStyleBackColor = false;
            this.keylogger_button.Click += new System.EventHandler(this.keylogger_button_Click);
            this.keylogger_button.MouseEnter += new System.EventHandler(this.keylogger_button_MouseEnter);
            this.keylogger_button.MouseLeave += new System.EventHandler(this.keylogger_button_MouseLeave);
            // 
            // musicapp_button
            // 
            this.musicapp_button.BackColor = System.Drawing.SystemColors.Control;
            this.musicapp_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicapp_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.musicapp_button.Location = new System.Drawing.Point(477, 438);
            this.musicapp_button.Name = "musicapp_button";
            this.musicapp_button.Size = new System.Drawing.Size(144, 32);
            this.musicapp_button.TabIndex = 14;
            this.musicapp_button.Text = "musicapp";
            this.musicapp_button.UseVisualStyleBackColor = false;
            this.musicapp_button.Click += new System.EventHandler(this.musicapp_button_Click);
            this.musicapp_button.MouseEnter += new System.EventHandler(this.musicapp_button_MouseEnter);
            this.musicapp_button.MouseLeave += new System.EventHandler(this.musicapp_button_MouseLeave);
            // 
            // screenshot_button
            // 
            this.screenshot_button.BackColor = System.Drawing.SystemColors.Control;
            this.screenshot_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshot_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.screenshot_button.Location = new System.Drawing.Point(1015, 191);
            this.screenshot_button.Name = "screenshot_button";
            this.screenshot_button.Size = new System.Drawing.Size(138, 31);
            this.screenshot_button.TabIndex = 15;
            this.screenshot_button.Text = "screenshot";
            this.screenshot_button.UseVisualStyleBackColor = false;
            this.screenshot_button.Click += new System.EventHandler(this.screenshot_button_Click);
            this.screenshot_button.MouseEnter += new System.EventHandler(this.screenshot_button_MouseEnter);
            this.screenshot_button.MouseLeave += new System.EventHandler(this.screenshot_button_MouseLeave);
            // 
            // tictactoe_button
            // 
            this.tictactoe_button.BackColor = System.Drawing.SystemColors.Control;
            this.tictactoe_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tictactoe_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.tictactoe_button.Location = new System.Drawing.Point(477, 133);
            this.tictactoe_button.Name = "tictactoe_button";
            this.tictactoe_button.Size = new System.Drawing.Size(144, 32);
            this.tictactoe_button.TabIndex = 16;
            this.tictactoe_button.Text = "TicTacToe";
            this.tictactoe_button.UseVisualStyleBackColor = false;
            this.tictactoe_button.Click += new System.EventHandler(this.tictactoe_button_Click);
            this.tictactoe_button.MouseEnter += new System.EventHandler(this.tictactoe_button_MouseEnter);
            this.tictactoe_button.MouseLeave += new System.EventHandler(this.tictactoe_button_MouseLeave);
            // 
            // wappsender_button
            // 
            this.wappsender_button.BackColor = System.Drawing.SystemColors.Control;
            this.wappsender_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wappsender_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.wappsender_button.Location = new System.Drawing.Point(477, 171);
            this.wappsender_button.Name = "wappsender_button";
            this.wappsender_button.Size = new System.Drawing.Size(144, 32);
            this.wappsender_button.TabIndex = 17;
            this.wappsender_button.Text = "wappsender";
            this.wappsender_button.UseVisualStyleBackColor = false;
            this.wappsender_button.Click += new System.EventHandler(this.wappsender_button_Click);
            this.wappsender_button.MouseEnter += new System.EventHandler(this.wappsender_button_MouseEnter);
            this.wappsender_button.MouseLeave += new System.EventHandler(this.wappsender_button_MouseLeave);
            // 
            // xmastree_button
            // 
            this.xmastree_button.BackColor = System.Drawing.SystemColors.Control;
            this.xmastree_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmastree_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.xmastree_button.Location = new System.Drawing.Point(477, 209);
            this.xmastree_button.Name = "xmastree_button";
            this.xmastree_button.Size = new System.Drawing.Size(144, 32);
            this.xmastree_button.TabIndex = 18;
            this.xmastree_button.Text = "xmastree";
            this.xmastree_button.UseVisualStyleBackColor = false;
            this.xmastree_button.Click += new System.EventHandler(this.xmastree_button_Click);
            this.xmastree_button.MouseEnter += new System.EventHandler(this.xmastree_button_MouseEnter);
            this.xmastree_button.MouseLeave += new System.EventHandler(this.xmastree_button_MouseLeave);
            // 
            // andrewsite_button
            // 
            this.andrewsite_button.BackColor = System.Drawing.SystemColors.Control;
            this.andrewsite_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.andrewsite_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.andrewsite_button.Location = new System.Drawing.Point(477, 248);
            this.andrewsite_button.Name = "andrewsite_button";
            this.andrewsite_button.Size = new System.Drawing.Size(144, 32);
            this.andrewsite_button.TabIndex = 19;
            this.andrewsite_button.Text = "andrewsite";
            this.andrewsite_button.UseVisualStyleBackColor = false;
            this.andrewsite_button.Click += new System.EventHandler(this.andrewsite_button_Click);
            this.andrewsite_button.MouseEnter += new System.EventHandler(this.andrewsite_button_MouseEnter);
            this.andrewsite_button.MouseLeave += new System.EventHandler(this.andrewsite_button_MouseLeave);
            // 
            // ultramenuapp_button
            // 
            this.ultramenuapp_button.BackColor = System.Drawing.SystemColors.Control;
            this.ultramenuapp_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultramenuapp_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.ultramenuapp_button.Location = new System.Drawing.Point(477, 286);
            this.ultramenuapp_button.Name = "ultramenuapp_button";
            this.ultramenuapp_button.Size = new System.Drawing.Size(144, 32);
            this.ultramenuapp_button.TabIndex = 20;
            this.ultramenuapp_button.Text = "ultramenuapp";
            this.ultramenuapp_button.UseVisualStyleBackColor = false;
            this.ultramenuapp_button.Click += new System.EventHandler(this.ultramenuapp_button_Click);
            this.ultramenuapp_button.MouseEnter += new System.EventHandler(this.ultramenuapp_button_MouseEnter);
            this.ultramenuapp_button.MouseLeave += new System.EventHandler(this.ultramenuapp_button_MouseLeave);
            // 
            // open_ss_location_button
            // 
            this.open_ss_location_button.BackColor = System.Drawing.SystemColors.Control;
            this.open_ss_location_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_ss_location_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.open_ss_location_button.Location = new System.Drawing.Point(973, 228);
            this.open_ss_location_button.Name = "open_ss_location_button";
            this.open_ss_location_button.Size = new System.Drawing.Size(180, 34);
            this.open_ss_location_button.TabIndex = 21;
            this.open_ss_location_button.Text = "open ss location";
            this.open_ss_location_button.UseVisualStyleBackColor = false;
            this.open_ss_location_button.Click += new System.EventHandler(this.open_ss_location_button_Click);
            this.open_ss_location_button.MouseEnter += new System.EventHandler(this.open_ss_location_button_MouseEnter);
            this.open_ss_location_button.MouseLeave += new System.EventHandler(this.open_ss_location_button_MouseLeave);
            // 
            // inspirational_text_button
            // 
            this.inspirational_text_button.BackColor = System.Drawing.SystemColors.Control;
            this.inspirational_text_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspirational_text_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.inspirational_text_button.Location = new System.Drawing.Point(333, 82);
            this.inspirational_text_button.Name = "inspirational_text_button";
            this.inspirational_text_button.Size = new System.Drawing.Size(238, 45);
            this.inspirational_text_button.TabIndex = 22;
            this.inspirational_text_button.Text = "Inspirational Content";
            this.inspirational_text_button.UseVisualStyleBackColor = false;
            this.inspirational_text_button.Click += new System.EventHandler(this.inspirational_text_button_Click);
            this.inspirational_text_button.MouseEnter += new System.EventHandler(this.inspirational_text_button_MouseEnter);
            this.inspirational_text_button.MouseLeave += new System.EventHandler(this.inspirational_text_button_MouseLeave);
            // 
            // calculator_button
            // 
            this.calculator_button.BackColor = System.Drawing.SystemColors.Control;
            this.calculator_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculator_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.calculator_button.Location = new System.Drawing.Point(1015, 268);
            this.calculator_button.Name = "calculator_button";
            this.calculator_button.Size = new System.Drawing.Size(138, 32);
            this.calculator_button.TabIndex = 23;
            this.calculator_button.Text = "calculator";
            this.calculator_button.UseVisualStyleBackColor = false;
            this.calculator_button.Click += new System.EventHandler(this.calculator_button_Click);
            this.calculator_button.MouseEnter += new System.EventHandler(this.calculator_button_MouseEnter);
            this.calculator_button.MouseLeave += new System.EventHandler(this.calculator_button_MouseLeave);
            // 
            // controlpanel_button
            // 
            this.controlpanel_button.BackColor = System.Drawing.SystemColors.Control;
            this.controlpanel_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlpanel_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.controlpanel_button.Location = new System.Drawing.Point(1003, 306);
            this.controlpanel_button.Name = "controlpanel_button";
            this.controlpanel_button.Size = new System.Drawing.Size(150, 30);
            this.controlpanel_button.TabIndex = 24;
            this.controlpanel_button.Text = "control panel";
            this.controlpanel_button.UseVisualStyleBackColor = false;
            this.controlpanel_button.Click += new System.EventHandler(this.controlpanel_button_Click);
            this.controlpanel_button.MouseEnter += new System.EventHandler(this.controlpanel_button_MouseEnter);
            this.controlpanel_button.MouseLeave += new System.EventHandler(this.controlpanel_button_MouseLeave);
            // 
            // initializer_button
            // 
            this.initializer_button.BackColor = System.Drawing.SystemColors.Control;
            this.initializer_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializer_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.initializer_button.Location = new System.Drawing.Point(333, 44);
            this.initializer_button.Name = "initializer_button";
            this.initializer_button.Size = new System.Drawing.Size(138, 32);
            this.initializer_button.TabIndex = 25;
            this.initializer_button.Text = "INITIALIZE";
            this.initializer_button.UseVisualStyleBackColor = false;
            this.initializer_button.Click += new System.EventHandler(this.initializer_button_Click);
            this.initializer_button.MouseEnter += new System.EventHandler(this.initializer_button_MouseEnter);
            this.initializer_button.MouseLeave += new System.EventHandler(this.initializer_button_MouseLeave);
            // 
            // newsapp_button
            // 
            this.newsapp_button.BackColor = System.Drawing.SystemColors.Control;
            this.newsapp_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsapp_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.newsapp_button.Location = new System.Drawing.Point(477, 324);
            this.newsapp_button.Name = "newsapp_button";
            this.newsapp_button.Size = new System.Drawing.Size(144, 32);
            this.newsapp_button.TabIndex = 26;
            this.newsapp_button.Text = "newsopener";
            this.newsapp_button.UseVisualStyleBackColor = false;
            this.newsapp_button.Click += new System.EventHandler(this.newsapp_button_Click);
            this.newsapp_button.MouseEnter += new System.EventHandler(this.newsapp_button_MouseEnter);
            this.newsapp_button.MouseLeave += new System.EventHandler(this.newsapp_button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(927, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Andrew\'s Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(881, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "product created with";
            // 
            // scrappy_button
            // 
            this.scrappy_button.BackColor = System.Drawing.SystemColors.Control;
            this.scrappy_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrappy_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.scrappy_button.Location = new System.Drawing.Point(477, 362);
            this.scrappy_button.Name = "scrappy_button";
            this.scrappy_button.Size = new System.Drawing.Size(144, 32);
            this.scrappy_button.TabIndex = 29;
            this.scrappy_button.Text = "webscrapper";
            this.scrappy_button.UseVisualStyleBackColor = false;
            this.scrappy_button.Click += new System.EventHandler(this.scrappy_button_Click);
            this.scrappy_button.MouseEnter += new System.EventHandler(this.scrappy_button_MouseEnter);
            this.scrappy_button.MouseLeave += new System.EventHandler(this.scrappy_button_MouseLeave);
            // 
            // testing_area_button
            // 
            this.testing_area_button.BackColor = System.Drawing.SystemColors.Control;
            this.testing_area_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testing_area_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.testing_area_button.Location = new System.Drawing.Point(993, 537);
            this.testing_area_button.Name = "testing_area_button";
            this.testing_area_button.Size = new System.Drawing.Size(160, 33);
            this.testing_area_button.TabIndex = 30;
            this.testing_area_button.Text = "open test area";
            this.testing_area_button.UseVisualStyleBackColor = false;
            this.testing_area_button.Click += new System.EventHandler(this.testing_area_button_Click);
            this.testing_area_button.MouseEnter += new System.EventHandler(this.testing_area_button_MouseEnter);
            this.testing_area_button.MouseLeave += new System.EventHandler(this.testing_area_button_MouseLeave);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.Location = new System.Drawing.Point(926, 348);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 31;
            // 
            // alexzander_files_button
            // 
            this.alexzander_files_button.BackColor = System.Drawing.SystemColors.Control;
            this.alexzander_files_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alexzander_files_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.alexzander_files_button.Location = new System.Drawing.Point(333, 516);
            this.alexzander_files_button.Name = "alexzander_files_button";
            this.alexzander_files_button.Size = new System.Drawing.Size(287, 32);
            this.alexzander_files_button.TabIndex = 32;
            this.alexzander_files_button.Text = "open __Alexzander_Files__";
            this.alexzander_files_button.UseVisualStyleBackColor = false;
            this.alexzander_files_button.Click += new System.EventHandler(this.alexzander_files_button_Click);
            this.alexzander_files_button.MouseEnter += new System.EventHandler(this.alexzander_files_button_MouseEnter);
            this.alexzander_files_button.MouseLeave += new System.EventHandler(this.alexzander_files_button_MouseLeave);
            // 
            // open_downloads_button
            // 
            this.open_downloads_button.BackColor = System.Drawing.SystemColors.Control;
            this.open_downloads_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_downloads_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.open_downloads_button.Location = new System.Drawing.Point(333, 554);
            this.open_downloads_button.Name = "open_downloads_button";
            this.open_downloads_button.Size = new System.Drawing.Size(101, 28);
            this.open_downloads_button.TabIndex = 33;
            this.open_downloads_button.Text = "downloads";
            this.open_downloads_button.UseVisualStyleBackColor = false;
            this.open_downloads_button.Click += new System.EventHandler(this.open_downloads_button_Click);
            this.open_downloads_button.MouseEnter += new System.EventHandler(this.open_downloads_button_MouseEnter);
            this.open_downloads_button.MouseLeave += new System.EventHandler(this.open_downloads_button_MouseLeave);
            // 
            // supremefolder_button
            // 
            this.supremefolder_button.BackColor = System.Drawing.SystemColors.Control;
            this.supremefolder_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supremefolder_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.supremefolder_button.Location = new System.Drawing.Point(440, 588);
            this.supremefolder_button.Name = "supremefolder_button";
            this.supremefolder_button.Size = new System.Drawing.Size(180, 27);
            this.supremefolder_button.TabIndex = 34;
            this.supremefolder_button.Text = "supreme_folder";
            this.supremefolder_button.UseVisualStyleBackColor = false;
            this.supremefolder_button.Click += new System.EventHandler(this.supremefolder_button_Click);
            this.supremefolder_button.MouseEnter += new System.EventHandler(this.supremefolder_button_MouseEnter);
            this.supremefolder_button.MouseLeave += new System.EventHandler(this.supremefolder_button_MouseLeave);
            // 
            // computer_science_button
            // 
            this.computer_science_button.BackColor = System.Drawing.SystemColors.Control;
            this.computer_science_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_science_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.computer_science_button.Location = new System.Drawing.Point(440, 554);
            this.computer_science_button.Name = "computer_science_button";
            this.computer_science_button.Size = new System.Drawing.Size(180, 28);
            this.computer_science_button.TabIndex = 35;
            this.computer_science_button.Text = "computer_science";
            this.computer_science_button.UseVisualStyleBackColor = false;
            this.computer_science_button.Click += new System.EventHandler(this.computer_science_button_Click);
            this.computer_science_button.MouseEnter += new System.EventHandler(this.computer_science_button_MouseEnter);
            this.computer_science_button.MouseLeave += new System.EventHandler(this.computer_science_button_MouseLeave);
            // 
            // opening_files_label
            // 
            this.opening_files_label.AutoSize = true;
            this.opening_files_label.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opening_files_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.opening_files_label.Location = new System.Drawing.Point(331, 482);
            this.opening_files_label.Name = "opening_files_label";
            this.opening_files_label.Size = new System.Drawing.Size(198, 31);
            this.opening_files_label.TabIndex = 36;
            this.opening_files_label.Text = "<Managing files>";
            this.opening_files_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.opening_files_label.UseCompatibleTextRendering = true;
            // 
            // opening_apps_label
            // 
            this.opening_apps_label.AutoSize = true;
            this.opening_apps_label.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opening_apps_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.opening_apps_label.Location = new System.Drawing.Point(333, 9);
            this.opening_apps_label.Name = "opening_apps_label";
            this.opening_apps_label.Size = new System.Drawing.Size(186, 31);
            this.opening_apps_label.TabIndex = 37;
            this.opening_apps_label.Text = "<Managing apps>";
            this.opening_apps_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.opening_apps_label.UseCompatibleTextRendering = true;
            // 
            // python_scripts_button
            // 
            this.python_scripts_button.BackColor = System.Drawing.SystemColors.Control;
            this.python_scripts_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.python_scripts_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.python_scripts_button.Location = new System.Drawing.Point(441, 621);
            this.python_scripts_button.Name = "python_scripts_button";
            this.python_scripts_button.Size = new System.Drawing.Size(180, 27);
            this.python_scripts_button.TabIndex = 38;
            this.python_scripts_button.Text = "python_scripts";
            this.python_scripts_button.UseVisualStyleBackColor = false;
            this.python_scripts_button.Click += new System.EventHandler(this.python_scripts_button_Click);
            this.python_scripts_button.MouseEnter += new System.EventHandler(this.python_scripts_button_MouseEnter);
            this.python_scripts_button.MouseLeave += new System.EventHandler(this.python_scripts_button_MouseLeave);
            // 
            // appdata_button
            // 
            this.appdata_button.BackColor = System.Drawing.SystemColors.Control;
            this.appdata_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appdata_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.appdata_button.Location = new System.Drawing.Point(333, 587);
            this.appdata_button.Name = "appdata_button";
            this.appdata_button.Size = new System.Drawing.Size(101, 28);
            this.appdata_button.TabIndex = 39;
            this.appdata_button.Text = "appdata";
            this.appdata_button.UseVisualStyleBackColor = false;
            this.appdata_button.Click += new System.EventHandler(this.appdata_button_Click);
            this.appdata_button.MouseEnter += new System.EventHandler(this.appdata_button_MouseEnter);
            this.appdata_button.MouseLeave += new System.EventHandler(this.appdata_button_MouseLeave);
            // 
            // local_button
            // 
            this.local_button.BackColor = System.Drawing.SystemColors.Control;
            this.local_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.local_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.local_button.Location = new System.Drawing.Point(333, 620);
            this.local_button.Name = "local_button";
            this.local_button.Size = new System.Drawing.Size(101, 28);
            this.local_button.TabIndex = 40;
            this.local_button.Text = "local";
            this.local_button.UseVisualStyleBackColor = false;
            this.local_button.Click += new System.EventHandler(this.local_button_Click);
            this.local_button.MouseEnter += new System.EventHandler(this.local_button_MouseEnter);
            this.local_button.MouseLeave += new System.EventHandler(this.local_button_MouseLeave);
            // 
            // locallow_button
            // 
            this.locallow_button.BackColor = System.Drawing.SystemColors.Control;
            this.locallow_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locallow_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.locallow_button.Location = new System.Drawing.Point(333, 654);
            this.locallow_button.Name = "locallow_button";
            this.locallow_button.Size = new System.Drawing.Size(101, 28);
            this.locallow_button.TabIndex = 41;
            this.locallow_button.Text = "locallow";
            this.locallow_button.UseVisualStyleBackColor = false;
            this.locallow_button.Click += new System.EventHandler(this.locallow_button_Click);
            this.locallow_button.MouseEnter += new System.EventHandler(this.locallow_button_MouseEnter);
            this.locallow_button.MouseLeave += new System.EventHandler(this.locallow_button_MouseLeave);
            // 
            // roaming_button
            // 
            this.roaming_button.BackColor = System.Drawing.SystemColors.Control;
            this.roaming_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roaming_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.roaming_button.Location = new System.Drawing.Point(333, 688);
            this.roaming_button.Name = "roaming_button";
            this.roaming_button.Size = new System.Drawing.Size(101, 28);
            this.roaming_button.TabIndex = 42;
            this.roaming_button.Text = "roaming";
            this.roaming_button.UseVisualStyleBackColor = false;
            this.roaming_button.Click += new System.EventHandler(this.roaming_button_Click);
            this.roaming_button.MouseEnter += new System.EventHandler(this.roaming_button_MouseEnter);
            this.roaming_button.MouseLeave += new System.EventHandler(this.roaming_button_MouseLeave);
            // 
            // tinderbot_button
            // 
            this.tinderbot_button.BackColor = System.Drawing.SystemColors.Control;
            this.tinderbot_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinderbot_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.tinderbot_button.Location = new System.Drawing.Point(627, 133);
            this.tinderbot_button.Name = "tinderbot_button";
            this.tinderbot_button.Size = new System.Drawing.Size(144, 32);
            this.tinderbot_button.TabIndex = 43;
            this.tinderbot_button.Text = "TinderBot";
            this.tinderbot_button.UseVisualStyleBackColor = false;
            this.tinderbot_button.Click += new System.EventHandler(this.tinderbot_button_Click);
            this.tinderbot_button.MouseEnter += new System.EventHandler(this.tinderbot_button_MouseEnter);
            this.tinderbot_button.MouseLeave += new System.EventHandler(this.tinderbot_button_MouseLeave);
            // 
            // humanhierarchy_button
            // 
            this.humanhierarchy_button.BackColor = System.Drawing.SystemColors.Control;
            this.humanhierarchy_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanhierarchy_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.humanhierarchy_button.Location = new System.Drawing.Point(627, 171);
            this.humanhierarchy_button.Name = "humanhierarchy_button";
            this.humanhierarchy_button.Size = new System.Drawing.Size(144, 32);
            this.humanhierarchy_button.TabIndex = 44;
            this.humanhierarchy_button.Text = "HumansTree";
            this.humanhierarchy_button.UseVisualStyleBackColor = false;
            this.humanhierarchy_button.Click += new System.EventHandler(this.humanhierarchy_button_Click);
            this.humanhierarchy_button.MouseEnter += new System.EventHandler(this.humanhierarchy_button_MouseEnter);
            this.humanhierarchy_button.MouseLeave += new System.EventHandler(this.humanhierarchy_button_MouseLeave);
            // 
            // time_tracker_button
            // 
            this.time_tracker_button.BackColor = System.Drawing.SystemColors.Control;
            this.time_tracker_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_tracker_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.time_tracker_button.Location = new System.Drawing.Point(627, 209);
            this.time_tracker_button.Name = "time_tracker_button";
            this.time_tracker_button.Size = new System.Drawing.Size(144, 32);
            this.time_tracker_button.TabIndex = 46;
            this.time_tracker_button.Text = "TimeTracker";
            this.time_tracker_button.UseVisualStyleBackColor = false;
            this.time_tracker_button.Click += new System.EventHandler(this.time_tracker_button_Click);
            this.time_tracker_button.MouseEnter += new System.EventHandler(this.time_tracker_button_MouseEnter);
            this.time_tracker_button.MouseLeave += new System.EventHandler(this.time_tracker_button_MouseLeave);
            // 
            // update_shortcuts_button
            // 
            this.update_shortcuts_button.BackColor = System.Drawing.SystemColors.Control;
            this.update_shortcuts_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_shortcuts_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.update_shortcuts_button.Location = new System.Drawing.Point(600, 44);
            this.update_shortcuts_button.Name = "update_shortcuts_button";
            this.update_shortcuts_button.Size = new System.Drawing.Size(171, 32);
            this.update_shortcuts_button.TabIndex = 47;
            this.update_shortcuts_button.Text = "UPDATE SHORCUTS";
            this.update_shortcuts_button.UseVisualStyleBackColor = false;
            this.update_shortcuts_button.Click += new System.EventHandler(this.update_shortcuts_button_Click);
            this.update_shortcuts_button.MouseEnter += new System.EventHandler(this.update_shortcuts_button_MouseEnter);
            this.update_shortcuts_button.MouseLeave += new System.EventHandler(this.update_shortcuts_button_MouseLeave);
            // 
            // locations_tracker_button
            // 
            this.locations_tracker_button.BackColor = System.Drawing.SystemColors.Control;
            this.locations_tracker_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locations_tracker_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.locations_tracker_button.Location = new System.Drawing.Point(627, 247);
            this.locations_tracker_button.Name = "locations_tracker_button";
            this.locations_tracker_button.Size = new System.Drawing.Size(180, 32);
            this.locations_tracker_button.TabIndex = 48;
            this.locations_tracker_button.Text = "LocationsTracker";
            this.locations_tracker_button.UseVisualStyleBackColor = false;
            this.locations_tracker_button.Click += new System.EventHandler(this.locations_tracker_button_Click);
            this.locations_tracker_button.MouseEnter += new System.EventHandler(this.locations_tracker_button_MouseEnter);
            this.locations_tracker_button.MouseLeave += new System.EventHandler(this.locations_tracker_button_MouseLeave);
            // 
            // open_shortcuts_button
            // 
            this.open_shortcuts_button.BackColor = System.Drawing.SystemColors.Control;
            this.open_shortcuts_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_shortcuts_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.open_shortcuts_button.Location = new System.Drawing.Point(612, 81);
            this.open_shortcuts_button.Name = "open_shortcuts_button";
            this.open_shortcuts_button.Size = new System.Drawing.Size(159, 32);
            this.open_shortcuts_button.TabIndex = 49;
            this.open_shortcuts_button.Text = "open shortcuts";
            this.open_shortcuts_button.UseVisualStyleBackColor = false;
            this.open_shortcuts_button.Click += new System.EventHandler(this.open_shortcuts_button_Click);
            this.open_shortcuts_button.MouseEnter += new System.EventHandler(this.open_shortcuts_button_MouseEnter);
            this.open_shortcuts_button.MouseLeave += new System.EventHandler(this.open_shortcuts_button_MouseLeave);
            // 
            // ApplicationDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1153, 836);
            this.Controls.Add(this.open_shortcuts_button);
            this.Controls.Add(this.locations_tracker_button);
            this.Controls.Add(this.update_shortcuts_button);
            this.Controls.Add(this.time_tracker_button);
            this.Controls.Add(this.humanhierarchy_button);
            this.Controls.Add(this.tinderbot_button);
            this.Controls.Add(this.roaming_button);
            this.Controls.Add(this.locallow_button);
            this.Controls.Add(this.local_button);
            this.Controls.Add(this.appdata_button);
            this.Controls.Add(this.python_scripts_button);
            this.Controls.Add(this.opening_apps_label);
            this.Controls.Add(this.opening_files_label);
            this.Controls.Add(this.computer_science_button);
            this.Controls.Add(this.supremefolder_button);
            this.Controls.Add(this.open_downloads_button);
            this.Controls.Add(this.alexzander_files_button);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.testing_area_button);
            this.Controls.Add(this.scrappy_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newsapp_button);
            this.Controls.Add(this.initializer_button);
            this.Controls.Add(this.controlpanel_button);
            this.Controls.Add(this.calculator_button);
            this.Controls.Add(this.inspirational_text_button);
            this.Controls.Add(this.open_ss_location_button);
            this.Controls.Add(this.ultramenuapp_button);
            this.Controls.Add(this.andrewsite_button);
            this.Controls.Add(this.xmastree_button);
            this.Controls.Add(this.wappsender_button);
            this.Controls.Add(this.tictactoe_button);
            this.Controls.Add(this.screenshot_button);
            this.Controls.Add(this.musicapp_button);
            this.Controls.Add(this.keylogger_button);
            this.Controls.Add(this.injection_button);
            this.Controls.Add(this.emailsender_button);
            this.Controls.Add(this.cards_button);
            this.Controls.Add(this.accounts_button);
            this.Controls.Add(this.icalendar_button);
            this.Controls.Add(this.social_opener_button);
            this.Controls.Add(this.emailopener_button);
            this.Controls.Add(this.systemapp_opener_button);
            this.Controls.Add(this.old_app_db_opener_button);
            this.Controls.Add(this.event_log_listbox);
            this.Controls.Add(this.time_displayer_label);
            this.Controls.Add(this.v_name_label);
            this.Controls.Add(this.app_name_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationDatabaseForm";
            this.Text = "<Application Database Program>";
            this.Load += new System.EventHandler(this.applicatondb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label app_name_label;
        private System.Windows.Forms.Label v_name_label;
        private System.Windows.Forms.Label time_displayer_label;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.ListBox event_log_listbox;
        private System.Windows.Forms.Button old_app_db_opener_button;
        private System.Windows.Forms.Button systemapp_opener_button;
        private System.Windows.Forms.Button emailopener_button;
        private System.Windows.Forms.Button social_opener_button;
        private System.Windows.Forms.Button icalendar_button;
        private System.Windows.Forms.Button accounts_button;
        private System.Windows.Forms.Button cards_button;
        private System.Windows.Forms.Button emailsender_button;
        private System.Windows.Forms.Button injection_button;
        private System.Windows.Forms.Button keylogger_button;
        private System.Windows.Forms.Button musicapp_button;
        private System.Windows.Forms.Button screenshot_button;
        private System.Windows.Forms.Button tictactoe_button;
        private System.Windows.Forms.Button wappsender_button;
        private System.Windows.Forms.Button xmastree_button;
        private System.Windows.Forms.Button andrewsite_button;
        private System.Windows.Forms.Button ultramenuapp_button;
        private System.Windows.Forms.Button open_ss_location_button;
        private System.Windows.Forms.Button inspirational_text_button;
        private System.Windows.Forms.Button calculator_button;
        private System.Windows.Forms.Button controlpanel_button;
        private System.Windows.Forms.Button initializer_button;
        private System.Windows.Forms.Button newsapp_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button scrappy_button;
        private System.Windows.Forms.Button testing_area_button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button alexzander_files_button;
        private System.Windows.Forms.Button open_downloads_button;
        private System.Windows.Forms.Button supremefolder_button;
        private System.Windows.Forms.Button computer_science_button;
        private System.Windows.Forms.Label opening_files_label;
        private System.Windows.Forms.Label opening_apps_label;
        private System.Windows.Forms.Button python_scripts_button;
        private System.Windows.Forms.Button appdata_button;
        private System.Windows.Forms.Button local_button;
        private System.Windows.Forms.Button locallow_button;
        private System.Windows.Forms.Button roaming_button;
        private System.Windows.Forms.Button tinderbot_button;
        private System.Windows.Forms.Button humanhierarchy_button;
        private System.Windows.Forms.Button time_tracker_button;
        private System.Windows.Forms.Button update_shortcuts_button;
        private System.Windows.Forms.Button locations_tracker_button;
        private System.Windows.Forms.Button open_shortcuts_button;
    }
}

