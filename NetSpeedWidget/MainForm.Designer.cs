namespace NetSpeedWidget
{
    partial class MainForm
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.totalDllbl = new System.Windows.Forms.Label();
            this.totalUplbl = new System.Windows.Forms.Label();
            this.selectNetworklbl = new System.Windows.Forms.Label();
            this.dataLimitlbl = new System.Windows.Forms.Label();
            this.currentDllbl = new System.Windows.Forms.Label();
            this.currentUplbl = new System.Windows.Forms.Label();
            this.configBtn = new System.Windows.Forms.Label();
            this.totalDataBtn = new System.Windows.Forms.Label();
            this.totalUpDataLbl = new System.Windows.Forms.Label();
            this.totalDlDataLbl = new System.Windows.Forms.Label();
            this.currentDlSpeedLbl = new System.Windows.Forms.Label();
            this.currentUpSpeedLbl = new System.Windows.Forms.Label();
            this.totalDataGrpBox = new System.Windows.Forms.GroupBox();
            this.configurationsCmbBox = new System.Windows.Forms.ComboBox();
            this.refreshDataTimer = new System.Windows.Forms.Timer(this.components);
            this.topmostChkBox = new System.Windows.Forms.CheckBox();
            this.dataLimitValueBox = new System.Windows.Forms.NumericUpDown();
            this.resetBtn = new System.Windows.Forms.Button();
            this.currentDataGrpBox = new System.Windows.Forms.GroupBox();
            this.dataLimitProgressBar = new System.Windows.Forms.ProgressBar();
            this.dataLimitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.selectNetworkTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.stayOnTopToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.maxGroupBox = new System.Windows.Forms.GroupBox();
            this.maxDllbl = new System.Windows.Forms.Label();
            this.maxUplbl = new System.Windows.Forms.Label();
            this.maxUpSpeedlbl = new System.Windows.Forms.Label();
            this.maxDlSpeedlbl = new System.Windows.Forms.Label();
            this.autoStartWithWindowsChkBox = new System.Windows.Forms.CheckBox();
            this.displayTrayIconChkBox = new System.Windows.Forms.CheckBox();
            this.themeCmbBox = new System.Windows.Forms.ComboBox();
            this.themelbl = new System.Windows.Forms.Label();
            this.displayTotalDataInTitleBar = new System.Windows.Forms.CheckBox();
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.appHeaderTitleBar = new System.Windows.Forms.Label();
            this.appHeaderIcon = new System.Windows.Forms.PictureBox();
            this.exitlblBtn = new System.Windows.Forms.Label();
            this.minimizelblBtn = new System.Windows.Forms.Label();
            this.aboutlblBtn = new System.Windows.Forms.Label();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.resetStaticsEveryDay = new System.Windows.Forms.CheckBox();
            this.resetStaticsBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.totalDataGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLimitValueBox)).BeginInit();
            this.currentDataGrpBox.SuspendLayout();
            this.maxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appHeaderIcon)).BeginInit();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalDllbl
            // 
            this.totalDllbl.AutoSize = true;
            this.totalDllbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDllbl.ForeColor = System.Drawing.Color.White;
            this.totalDllbl.Location = new System.Drawing.Point(4, 16);
            this.totalDllbl.Name = "totalDllbl";
            this.totalDllbl.Size = new System.Drawing.Size(17, 12);
            this.totalDllbl.TabIndex = 6;
            this.totalDllbl.Text = "D :";
            // 
            // totalUplbl
            // 
            this.totalUplbl.AutoSize = true;
            this.totalUplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUplbl.ForeColor = System.Drawing.Color.White;
            this.totalUplbl.Location = new System.Drawing.Point(4, 28);
            this.totalUplbl.Name = "totalUplbl";
            this.totalUplbl.Size = new System.Drawing.Size(17, 12);
            this.totalUplbl.TabIndex = 7;
            this.totalUplbl.Text = "U :";
            // 
            // selectNetworklbl
            // 
            this.selectNetworklbl.AutoSize = true;
            this.selectNetworklbl.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.selectNetworklbl.ForeColor = System.Drawing.Color.White;
            this.selectNetworklbl.Location = new System.Drawing.Point(106, 18);
            this.selectNetworklbl.Name = "selectNetworklbl";
            this.selectNetworklbl.Size = new System.Drawing.Size(88, 16);
            this.selectNetworklbl.TabIndex = 19;
            this.selectNetworklbl.Text = "Select Network:";
            // 
            // dataLimitlbl
            // 
            this.dataLimitlbl.AutoSize = true;
            this.dataLimitlbl.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.dataLimitlbl.ForeColor = System.Drawing.Color.White;
            this.dataLimitlbl.Location = new System.Drawing.Point(106, 58);
            this.dataLimitlbl.Margin = new System.Windows.Forms.Padding(0);
            this.dataLimitlbl.Name = "dataLimitlbl";
            this.dataLimitlbl.Size = new System.Drawing.Size(89, 16);
            this.dataLimitlbl.TabIndex = 20;
            this.dataLimitlbl.Text = "Data Limit (Mb):";
            // 
            // currentDllbl
            // 
            this.currentDllbl.AutoSize = true;
            this.currentDllbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDllbl.ForeColor = System.Drawing.Color.White;
            this.currentDllbl.Location = new System.Drawing.Point(3, 16);
            this.currentDllbl.Name = "currentDllbl";
            this.currentDllbl.Size = new System.Drawing.Size(17, 12);
            this.currentDllbl.TabIndex = 6;
            this.currentDllbl.Text = "D :";
            // 
            // currentUplbl
            // 
            this.currentUplbl.AutoSize = true;
            this.currentUplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUplbl.ForeColor = System.Drawing.Color.White;
            this.currentUplbl.Location = new System.Drawing.Point(3, 28);
            this.currentUplbl.Name = "currentUplbl";
            this.currentUplbl.Size = new System.Drawing.Size(17, 12);
            this.currentUplbl.TabIndex = 7;
            this.currentUplbl.Text = "U :";
            // 
            // configBtn
            // 
            this.configBtn.AutoSize = true;
            this.configBtn.BackColor = System.Drawing.Color.DimGray;
            this.configBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configBtn.ForeColor = System.Drawing.Color.White;
            this.configBtn.Location = new System.Drawing.Point(75, 11);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(15, 15);
            this.configBtn.TabIndex = 15;
            this.configBtn.Text = "<";
            this.configBtn.Click += new System.EventHandler(this.ShowConfigurationPanel);
            this.configBtn.MouseEnter += new System.EventHandler(this.configBtn_MouseEnter);
            this.configBtn.MouseLeave += new System.EventHandler(this.configBtn_MouseLeave);
            // 
            // totalDataBtn
            // 
            this.totalDataBtn.BackColor = System.Drawing.Color.DimGray;
            this.totalDataBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalDataBtn.Font = new System.Drawing.Font("Wingdings 3", 8F);
            this.totalDataBtn.ForeColor = System.Drawing.Color.White;
            this.totalDataBtn.Location = new System.Drawing.Point(75, 28);
            this.totalDataBtn.Margin = new System.Windows.Forms.Padding(0);
            this.totalDataBtn.Name = "totalDataBtn";
            this.totalDataBtn.Size = new System.Drawing.Size(15, 15);
            this.totalDataBtn.TabIndex = 16;
            this.totalDataBtn.Text = "o";
            this.totalDataBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalDataBtn.Visible = false;
            this.totalDataBtn.Click += new System.EventHandler(this.ShowTotalDataPanel);
            this.totalDataBtn.MouseEnter += new System.EventHandler(this.totalDataBtn_MouseEnter);
            this.totalDataBtn.MouseLeave += new System.EventHandler(this.totalDataBtn_MouseLeave);
            // 
            // totalUpDataLbl
            // 
            this.totalUpDataLbl.AutoSize = true;
            this.totalUpDataLbl.Font = new System.Drawing.Font("Trebuchet MS", 7.5F);
            this.totalUpDataLbl.ForeColor = System.Drawing.Color.White;
            this.totalUpDataLbl.Location = new System.Drawing.Point(18, 28);
            this.totalUpDataLbl.Margin = new System.Windows.Forms.Padding(0);
            this.totalUpDataLbl.Name = "totalUpDataLbl";
            this.totalUpDataLbl.Size = new System.Drawing.Size(30, 15);
            this.totalUpDataLbl.TabIndex = 10;
            this.totalUpDataLbl.Text = "0.0 B";
            this.totalUpDataLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalDlDataLbl
            // 
            this.totalDlDataLbl.AutoSize = true;
            this.totalDlDataLbl.Font = new System.Drawing.Font("Trebuchet MS", 7.5F);
            this.totalDlDataLbl.ForeColor = System.Drawing.Color.White;
            this.totalDlDataLbl.Location = new System.Drawing.Point(18, 15);
            this.totalDlDataLbl.Margin = new System.Windows.Forms.Padding(0);
            this.totalDlDataLbl.Name = "totalDlDataLbl";
            this.totalDlDataLbl.Size = new System.Drawing.Size(30, 15);
            this.totalDlDataLbl.TabIndex = 9;
            this.totalDlDataLbl.Text = "0.0 B";
            this.totalDlDataLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentDlSpeedLbl
            // 
            this.currentDlSpeedLbl.AutoSize = true;
            this.currentDlSpeedLbl.Font = new System.Drawing.Font("Trebuchet MS", 7.5F);
            this.currentDlSpeedLbl.ForeColor = System.Drawing.Color.White;
            this.currentDlSpeedLbl.Location = new System.Drawing.Point(17, 15);
            this.currentDlSpeedLbl.Margin = new System.Windows.Forms.Padding(0);
            this.currentDlSpeedLbl.Name = "currentDlSpeedLbl";
            this.currentDlSpeedLbl.Size = new System.Drawing.Size(39, 15);
            this.currentDlSpeedLbl.TabIndex = 2;
            this.currentDlSpeedLbl.Text = "0.0 B/s";
            this.currentDlSpeedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentUpSpeedLbl
            // 
            this.currentUpSpeedLbl.AutoSize = true;
            this.currentUpSpeedLbl.Font = new System.Drawing.Font("Trebuchet MS", 7.5F);
            this.currentUpSpeedLbl.ForeColor = System.Drawing.Color.White;
            this.currentUpSpeedLbl.Location = new System.Drawing.Point(17, 28);
            this.currentUpSpeedLbl.Margin = new System.Windows.Forms.Padding(0);
            this.currentUpSpeedLbl.Name = "currentUpSpeedLbl";
            this.currentUpSpeedLbl.Size = new System.Drawing.Size(39, 15);
            this.currentUpSpeedLbl.TabIndex = 3;
            this.currentUpSpeedLbl.Text = "0.0 B/s";
            this.currentUpSpeedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalDataGrpBox
            // 
            this.totalDataGrpBox.Controls.Add(this.totalDllbl);
            this.totalDataGrpBox.Controls.Add(this.totalUplbl);
            this.totalDataGrpBox.Controls.Add(this.totalUpDataLbl);
            this.totalDataGrpBox.Controls.Add(this.totalDlDataLbl);
            this.totalDataGrpBox.ForeColor = System.Drawing.Color.White;
            this.totalDataGrpBox.Location = new System.Drawing.Point(4, 68);
            this.totalDataGrpBox.Name = "totalDataGrpBox";
            this.totalDataGrpBox.Size = new System.Drawing.Size(92, 48);
            this.totalDataGrpBox.TabIndex = 8;
            this.totalDataGrpBox.TabStop = false;
            this.totalDataGrpBox.Text = "Total Data";
            // 
            // configurationsCmbBox
            // 
            this.configurationsCmbBox.BackColor = System.Drawing.Color.White;
            this.configurationsCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.configurationsCmbBox.DropDownWidth = 200;
            this.configurationsCmbBox.FormattingEnabled = true;
            this.configurationsCmbBox.Location = new System.Drawing.Point(109, 34);
            this.configurationsCmbBox.Name = "configurationsCmbBox";
            this.configurationsCmbBox.Size = new System.Drawing.Size(112, 21);
            this.configurationsCmbBox.Sorted = true;
            this.configurationsCmbBox.TabIndex = 17;
            this.configurationsCmbBox.SelectedIndexChanged += new System.EventHandler(this.Configurations_Changed);
            // 
            // refreshDataTimer
            // 
            this.refreshDataTimer.Interval = 1000;
            this.refreshDataTimer.Tick += new System.EventHandler(this.RefreshDataTimer_Tick);
            // 
            // topmostChkBox
            // 
            this.topmostChkBox.AutoSize = true;
            this.topmostChkBox.Checked = true;
            this.topmostChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topmostChkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topmostChkBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topmostChkBox.Location = new System.Drawing.Point(8, 19);
            this.topmostChkBox.Name = "topmostChkBox";
            this.topmostChkBox.Size = new System.Drawing.Size(131, 17);
            this.topmostChkBox.TabIndex = 18;
            this.topmostChkBox.Text = "Stay on top of all apps";
            this.stayOnTopToolTip.SetToolTip(this.topmostChkBox, "If Checked: Application will stay on top of all application.");
            this.topmostChkBox.UseVisualStyleBackColor = true;
            this.topmostChkBox.CheckedChanged += new System.EventHandler(this.StayOnTopChkBox_CheckedChanged);
            // 
            // dataLimitValueBox
            // 
            this.dataLimitValueBox.BackColor = System.Drawing.Color.White;
            this.dataLimitValueBox.Location = new System.Drawing.Point(109, 73);
            this.dataLimitValueBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.dataLimitValueBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dataLimitValueBox.Name = "dataLimitValueBox";
            this.dataLimitValueBox.Size = new System.Drawing.Size(112, 20);
            this.dataLimitValueBox.TabIndex = 21;
            this.dataLimitValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dataLimitValueBox.ThousandsSeparator = true;
            this.dataLimitValueBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dataLimitValueBox.ValueChanged += new System.EventHandler(this.SetDataLimitValue);
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSize = true;
            this.resetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetBtn.BackColor = System.Drawing.Color.DimGray;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(124, 143);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(80, 23);
            this.resetBtn.TabIndex = 23;
            this.resetBtn.Text = "Reset Statics";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            this.resetBtn.MouseHover += new System.EventHandler(this.resetBtn_MouseHover);
            // 
            // currentDataGrpBox
            // 
            this.currentDataGrpBox.Controls.Add(this.totalDataBtn);
            this.currentDataGrpBox.Controls.Add(this.configBtn);
            this.currentDataGrpBox.Controls.Add(this.currentDllbl);
            this.currentDataGrpBox.Controls.Add(this.currentUplbl);
            this.currentDataGrpBox.Controls.Add(this.currentUpSpeedLbl);
            this.currentDataGrpBox.Controls.Add(this.currentDlSpeedLbl);
            this.currentDataGrpBox.ForeColor = System.Drawing.Color.White;
            this.currentDataGrpBox.Location = new System.Drawing.Point(4, 16);
            this.currentDataGrpBox.Name = "currentDataGrpBox";
            this.currentDataGrpBox.Size = new System.Drawing.Size(93, 48);
            this.currentDataGrpBox.TabIndex = 11;
            this.currentDataGrpBox.TabStop = false;
            this.currentDataGrpBox.Text = "Current Rate";
            // 
            // dataLimitProgressBar
            // 
            this.dataLimitProgressBar.BackColor = System.Drawing.Color.Black;
            this.dataLimitProgressBar.ForeColor = System.Drawing.Color.Transparent;
            this.dataLimitProgressBar.Location = new System.Drawing.Point(110, 88);
            this.dataLimitProgressBar.Name = "dataLimitProgressBar";
            this.dataLimitProgressBar.RightToLeftLayout = true;
            this.dataLimitProgressBar.Size = new System.Drawing.Size(95, 4);
            this.dataLimitProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dataLimitProgressBar.TabIndex = 25;
            this.dataLimitProgressBar.Visible = false;
            // 
            // dataLimitToolTip
            // 
            this.dataLimitToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dataLimitToolTip.ToolTipTitle = "Data Limit";
            this.dataLimitToolTip.UseFading = false;
            // 
            // selectNetworkTooltip
            // 
            this.selectNetworkTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.selectNetworkTooltip.ToolTipTitle = "Select Network";
            // 
            // stayOnTopToolTip
            // 
            this.stayOnTopToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.stayOnTopToolTip.ToolTipTitle = "Stay on top";
            // 
            // maxGroupBox
            // 
            this.maxGroupBox.Controls.Add(this.maxDllbl);
            this.maxGroupBox.Controls.Add(this.maxUplbl);
            this.maxGroupBox.Controls.Add(this.maxUpSpeedlbl);
            this.maxGroupBox.Controls.Add(this.maxDlSpeedlbl);
            this.maxGroupBox.ForeColor = System.Drawing.Color.White;
            this.maxGroupBox.Location = new System.Drawing.Point(4, 119);
            this.maxGroupBox.Name = "maxGroupBox";
            this.maxGroupBox.Size = new System.Drawing.Size(92, 48);
            this.maxGroupBox.TabIndex = 11;
            this.maxGroupBox.TabStop = false;
            this.maxGroupBox.Text = "Max Speed";
            // 
            // maxDllbl
            // 
            this.maxDllbl.AutoSize = true;
            this.maxDllbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDllbl.ForeColor = System.Drawing.Color.White;
            this.maxDllbl.Location = new System.Drawing.Point(4, 16);
            this.maxDllbl.Name = "maxDllbl";
            this.maxDllbl.Size = new System.Drawing.Size(17, 12);
            this.maxDllbl.TabIndex = 6;
            this.maxDllbl.Text = "D :";
            // 
            // maxUplbl
            // 
            this.maxUplbl.AutoSize = true;
            this.maxUplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxUplbl.ForeColor = System.Drawing.Color.White;
            this.maxUplbl.Location = new System.Drawing.Point(4, 28);
            this.maxUplbl.Name = "maxUplbl";
            this.maxUplbl.Size = new System.Drawing.Size(17, 12);
            this.maxUplbl.TabIndex = 7;
            this.maxUplbl.Text = "U :";
            // 
            // maxUpSpeedlbl
            // 
            this.maxUpSpeedlbl.AutoSize = true;
            this.maxUpSpeedlbl.Font = new System.Drawing.Font("Trebuchet MS", 7.5F);
            this.maxUpSpeedlbl.ForeColor = System.Drawing.Color.White;
            this.maxUpSpeedlbl.Location = new System.Drawing.Point(18, 27);
            this.maxUpSpeedlbl.Margin = new System.Windows.Forms.Padding(0);
            this.maxUpSpeedlbl.Name = "maxUpSpeedlbl";
            this.maxUpSpeedlbl.Size = new System.Drawing.Size(30, 15);
            this.maxUpSpeedlbl.TabIndex = 10;
            this.maxUpSpeedlbl.Text = "0.0 B";
            this.maxUpSpeedlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxDlSpeedlbl
            // 
            this.maxDlSpeedlbl.AutoSize = true;
            this.maxDlSpeedlbl.Font = new System.Drawing.Font("Trebuchet MS", 7.5F);
            this.maxDlSpeedlbl.ForeColor = System.Drawing.Color.White;
            this.maxDlSpeedlbl.Location = new System.Drawing.Point(18, 15);
            this.maxDlSpeedlbl.Margin = new System.Windows.Forms.Padding(0);
            this.maxDlSpeedlbl.Name = "maxDlSpeedlbl";
            this.maxDlSpeedlbl.Size = new System.Drawing.Size(30, 15);
            this.maxDlSpeedlbl.TabIndex = 9;
            this.maxDlSpeedlbl.Text = "0.0 B";
            this.maxDlSpeedlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // autoStartWithWindowsChkBox
            // 
            this.autoStartWithWindowsChkBox.AutoSize = true;
            this.autoStartWithWindowsChkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoStartWithWindowsChkBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.autoStartWithWindowsChkBox.Location = new System.Drawing.Point(8, 37);
            this.autoStartWithWindowsChkBox.Name = "autoStartWithWindowsChkBox";
            this.autoStartWithWindowsChkBox.Size = new System.Drawing.Size(142, 17);
            this.autoStartWithWindowsChkBox.TabIndex = 25;
            this.autoStartWithWindowsChkBox.Text = "Auto Start with Windows";
            this.autoStartWithWindowsChkBox.UseVisualStyleBackColor = true;
            this.autoStartWithWindowsChkBox.CheckedChanged += new System.EventHandler(this.RegisterInStartup);
            // 
            // displayTrayIconChkBox
            // 
            this.displayTrayIconChkBox.AutoSize = true;
            this.displayTrayIconChkBox.Checked = true;
            this.displayTrayIconChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayTrayIconChkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayTrayIconChkBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayTrayIconChkBox.Location = new System.Drawing.Point(8, 54);
            this.displayTrayIconChkBox.Name = "displayTrayIconChkBox";
            this.displayTrayIconChkBox.Size = new System.Drawing.Size(103, 17);
            this.displayTrayIconChkBox.TabIndex = 28;
            this.displayTrayIconChkBox.Text = "Display tray icon";
            this.displayTrayIconChkBox.UseVisualStyleBackColor = true;
            this.displayTrayIconChkBox.CheckedChanged += new System.EventHandler(this.DisplayNotifyIconInTray);
            // 
            // themeCmbBox
            // 
            this.themeCmbBox.BackColor = System.Drawing.Color.White;
            this.themeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeCmbBox.DropDownWidth = 60;
            this.themeCmbBox.FormattingEnabled = true;
            this.themeCmbBox.Items.AddRange(new object[] {
            System.Drawing.Color.Black,
            System.Drawing.Color.WhiteSmoke,
            System.Drawing.Color.Salmon,
            System.Drawing.Color.Teal,
            System.Drawing.Color.Tomato,
            System.Drawing.Color.SlateGray,
            System.Drawing.Color.SlateBlue,
            System.Drawing.Color.Chocolate});
            this.themeCmbBox.Location = new System.Drawing.Point(109, 113);
            this.themeCmbBox.Margin = new System.Windows.Forms.Padding(0);
            this.themeCmbBox.MaxDropDownItems = 2;
            this.themeCmbBox.Name = "themeCmbBox";
            this.themeCmbBox.Size = new System.Drawing.Size(112, 21);
            this.themeCmbBox.TabIndex = 29;
            this.themeCmbBox.SelectedIndexChanged += new System.EventHandler(this.ApplyTheme);
            // 
            // themelbl
            // 
            this.themelbl.AutoSize = true;
            this.themelbl.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.themelbl.ForeColor = System.Drawing.Color.White;
            this.themelbl.Location = new System.Drawing.Point(106, 97);
            this.themelbl.Margin = new System.Windows.Forms.Padding(0);
            this.themelbl.Name = "themelbl";
            this.themelbl.Size = new System.Drawing.Size(44, 16);
            this.themelbl.TabIndex = 30;
            this.themelbl.Text = "Theme:";
            // 
            // displayTotalDataInTitleBar
            // 
            this.displayTotalDataInTitleBar.AutoSize = true;
            this.displayTotalDataInTitleBar.Checked = true;
            this.displayTotalDataInTitleBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayTotalDataInTitleBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayTotalDataInTitleBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayTotalDataInTitleBar.Location = new System.Drawing.Point(8, 73);
            this.displayTotalDataInTitleBar.Name = "displayTotalDataInTitleBar";
            this.displayTotalDataInTitleBar.Size = new System.Drawing.Size(137, 17);
            this.displayTotalDataInTitleBar.TabIndex = 32;
            this.displayTotalDataInTitleBar.Text = "Display total data in title";
            this.displayTotalDataInTitleBar.UseVisualStyleBackColor = true;
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.appNotifyIcon.BalloonTipText = "Net Speed Widget is running in tray.";
            this.appNotifyIcon.BalloonTipTitle = "Net Speed Widget";
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "Net Speed Widget";
            this.appNotifyIcon.Visible = true;
            this.appNotifyIcon.BalloonTipClicked += new System.EventHandler(this.trayIcon_DoubleClick);
            this.appNotifyIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // appHeaderTitleBar
            // 
            this.appHeaderTitleBar.BackColor = System.Drawing.Color.SlateGray;
            this.appHeaderTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appHeaderTitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appHeaderTitleBar.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.appHeaderTitleBar.ForeColor = System.Drawing.Color.White;
            this.appHeaderTitleBar.Location = new System.Drawing.Point(15, 0);
            this.appHeaderTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.appHeaderTitleBar.Name = "appHeaderTitleBar";
            this.appHeaderTitleBar.Size = new System.Drawing.Size(371, 15);
            this.appHeaderTitleBar.TabIndex = 33;
            this.appHeaderTitleBar.Text = "Net Speed Widget";
            this.appHeaderTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appHeaderTitleBar_MouseDown);
            this.appHeaderTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appHeaderTitleBar_MouseMove);
            this.appHeaderTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.appHeaderTitleBar_MouseUp);
            // 
            // appHeaderIcon
            // 
            this.appHeaderIcon.Image = global::NetSpeedWidget.Properties.Resources.unnamed;
            this.appHeaderIcon.Location = new System.Drawing.Point(0, 0);
            this.appHeaderIcon.Margin = new System.Windows.Forms.Padding(0);
            this.appHeaderIcon.Name = "appHeaderIcon";
            this.appHeaderIcon.Size = new System.Drawing.Size(15, 15);
            this.appHeaderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appHeaderIcon.TabIndex = 34;
            this.appHeaderIcon.TabStop = false;
            // 
            // exitlblBtn
            // 
            this.exitlblBtn.BackColor = System.Drawing.Color.Black;
            this.exitlblBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitlblBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitlblBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlblBtn.ForeColor = System.Drawing.Color.White;
            this.exitlblBtn.Location = new System.Drawing.Point(369, 0);
            this.exitlblBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitlblBtn.Name = "exitlblBtn";
            this.exitlblBtn.Size = new System.Drawing.Size(15, 15);
            this.exitlblBtn.TabIndex = 35;
            this.exitlblBtn.Text = "x";
            this.exitlblBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitlblBtn.Click += new System.EventHandler(this.ExitApp);
            this.exitlblBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.exitlblBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            this.exitlblBtn.MouseHover += new System.EventHandler(this.ExitBtn_MouseEnter);
            // 
            // minimizelblBtn
            // 
            this.minimizelblBtn.BackColor = System.Drawing.Color.Black;
            this.minimizelblBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimizelblBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizelblBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizelblBtn.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.minimizelblBtn.ForeColor = System.Drawing.Color.White;
            this.minimizelblBtn.Location = new System.Drawing.Point(351, 0);
            this.minimizelblBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizelblBtn.Name = "minimizelblBtn";
            this.minimizelblBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.minimizelblBtn.Size = new System.Drawing.Size(15, 15);
            this.minimizelblBtn.TabIndex = 36;
            this.minimizelblBtn.Text = "-";
            this.minimizelblBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizelblBtn.Click += new System.EventHandler(this.MinimizeAppToTray);
            this.minimizelblBtn.MouseEnter += new System.EventHandler(this.MinimizeBtn_MouseEnter);
            this.minimizelblBtn.MouseLeave += new System.EventHandler(this.MinimizeBtn_MouseLeave);
            // 
            // aboutlblBtn
            // 
            this.aboutlblBtn.BackColor = System.Drawing.Color.Black;
            this.aboutlblBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutlblBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutlblBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutlblBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.aboutlblBtn.ForeColor = System.Drawing.Color.White;
            this.aboutlblBtn.Location = new System.Drawing.Point(333, 0);
            this.aboutlblBtn.Margin = new System.Windows.Forms.Padding(0);
            this.aboutlblBtn.Name = "aboutlblBtn";
            this.aboutlblBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.aboutlblBtn.Size = new System.Drawing.Size(15, 15);
            this.aboutlblBtn.TabIndex = 37;
            this.aboutlblBtn.Text = "?";
            this.aboutlblBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutlblBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            this.aboutlblBtn.MouseEnter += new System.EventHandler(this.aboutlblBtn_MouseEnter);
            this.aboutlblBtn.MouseLeave += new System.EventHandler(this.aboutlblBtn_MouseLeave);
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.optionsGroupBox.Controls.Add(this.resetStaticsEveryDay);
            this.optionsGroupBox.Controls.Add(this.topmostChkBox);
            this.optionsGroupBox.Controls.Add(this.autoStartWithWindowsChkBox);
            this.optionsGroupBox.Controls.Add(this.displayTrayIconChkBox);
            this.optionsGroupBox.Controls.Add(this.displayTotalDataInTitleBar);
            this.optionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsGroupBox.ForeColor = System.Drawing.Color.White;
            this.optionsGroupBox.Location = new System.Drawing.Point(227, 20);
            this.optionsGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(153, 114);
            this.optionsGroupBox.TabIndex = 38;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // resetStaticsEveryDay
            // 
            this.resetStaticsEveryDay.AutoSize = true;
            this.resetStaticsEveryDay.Checked = true;
            this.resetStaticsEveryDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resetStaticsEveryDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetStaticsEveryDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetStaticsEveryDay.Location = new System.Drawing.Point(8, 92);
            this.resetStaticsEveryDay.Name = "resetStaticsEveryDay";
            this.resetStaticsEveryDay.Size = new System.Drawing.Size(136, 17);
            this.resetStaticsEveryDay.TabIndex = 33;
            this.resetStaticsEveryDay.Text = "Reset statics every day";
            this.resetStaticsEveryDay.UseVisualStyleBackColor = true;
            // 
            // resetStaticsBtnToolTip
            // 
            this.resetStaticsBtnToolTip.AutomaticDelay = 200;
            this.resetStaticsBtnToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.resetStaticsBtnToolTip.ToolTipTitle = "Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 172);
            this.Controls.Add(this.appHeaderIcon);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.aboutlblBtn);
            this.Controls.Add(this.minimizelblBtn);
            this.Controls.Add(this.exitlblBtn);
            this.Controls.Add(this.themelbl);
            this.Controls.Add(this.themeCmbBox);
            this.Controls.Add(this.dataLimitProgressBar);
            this.Controls.Add(this.maxGroupBox);
            this.Controls.Add(this.currentDataGrpBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.dataLimitValueBox);
            this.Controls.Add(this.dataLimitlbl);
            this.Controls.Add(this.selectNetworklbl);
            this.Controls.Add(this.configurationsCmbBox);
            this.Controls.Add(this.totalDataGrpBox);
            this.Controls.Add(this.appHeaderTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net Speed Widget";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_FormLoading);
            this.totalDataGrpBox.ResumeLayout(false);
            this.totalDataGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLimitValueBox)).EndInit();
            this.currentDataGrpBox.ResumeLayout(false);
            this.currentDataGrpBox.PerformLayout();
            this.maxGroupBox.ResumeLayout(false);
            this.maxGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appHeaderIcon)).EndInit();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentDlSpeedLbl;
        private System.Windows.Forms.Label currentUpSpeedLbl;
        private System.Windows.Forms.GroupBox totalDataGrpBox;
        private System.Windows.Forms.Label totalUpDataLbl;
        private System.Windows.Forms.Label totalDlDataLbl;
        private System.Windows.Forms.ComboBox configurationsCmbBox;
        private System.Windows.Forms.Timer refreshDataTimer;
        private System.Windows.Forms.Label configBtn;
        private System.Windows.Forms.Label totalDataBtn;
        private System.Windows.Forms.CheckBox topmostChkBox;
        private System.Windows.Forms.NumericUpDown dataLimitValueBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox currentDataGrpBox;
        private System.Windows.Forms.ProgressBar dataLimitProgressBar;
        private System.Windows.Forms.ToolTip dataLimitToolTip;
        private System.Windows.Forms.ToolTip selectNetworkTooltip;
        private System.Windows.Forms.ToolTip stayOnTopToolTip;
        private System.Windows.Forms.GroupBox maxGroupBox;
        private System.Windows.Forms.Label maxUpSpeedlbl;
        private System.Windows.Forms.Label maxDlSpeedlbl;
        private System.Windows.Forms.CheckBox autoStartWithWindowsChkBox;
        private System.Windows.Forms.CheckBox displayTrayIconChkBox;
        private System.Windows.Forms.ComboBox themeCmbBox;
        private System.Windows.Forms.Label currentDllbl;
        private System.Windows.Forms.Label currentUplbl;
        private System.Windows.Forms.Label totalDllbl;
        private System.Windows.Forms.Label totalUplbl;
        private System.Windows.Forms.Label maxDllbl;
        private System.Windows.Forms.Label maxUplbl;
        private System.Windows.Forms.Label dataLimitlbl;
        private System.Windows.Forms.Label selectNetworklbl;
        private System.Windows.Forms.Label themelbl;
        private System.Windows.Forms.CheckBox displayTotalDataInTitleBar;
        private System.Windows.Forms.NotifyIcon appNotifyIcon;
        private System.Windows.Forms.Label appHeaderTitleBar;
        private System.Windows.Forms.PictureBox appHeaderIcon;
        private System.Windows.Forms.Label exitlblBtn;
        private System.Windows.Forms.Label minimizelblBtn;
        private System.Windows.Forms.Label aboutlblBtn;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox resetStaticsEveryDay;
        private System.Windows.Forms.ToolTip resetStaticsBtnToolTip;
    }
}

