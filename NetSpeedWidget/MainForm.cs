using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NetSpeedWidget
{
    public partial class MainForm : Form
    {
        private NetworkAdapter monitoredNetworkAdaptor;
        private NetworkMonitor networkMonitor;

        private long totalDlData;
        private long totalUpData;
        private long maxDlSpeed;
        private long maxUpSpeed;
        private long totalDataConsumed;
        private Point currentPositionPoint;

        public decimal DataLimitValue { get; set; }

        public MainForm()
        {
            InitializeComponent();

            InitialLoad();
        }

        private void InitialLoad()
        {
            refreshDataTimer.Interval = 1000;

            networkMonitor = new NetworkMonitor();
            if (networkMonitor.Adapters.Length > 0)
            {
                configurationsCmbBox.Items.AddRange(networkMonitor.Adapters);
                SetTootTips();
            }
            else
            {
                configurationsCmbBox.Enabled = false;
                MessageBox.Show("No network adapters found on this computer.");
                return;
            }

            //Tray icon menu
            ToolStripButton trayExitButton = new ToolStripButton("Exit")
            {
                TextImageRelation = TextImageRelation.TextBeforeImage,
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Alignment = ToolStripItemAlignment.Left
            };
            ToolStripButton trayShowButton = new ToolStripButton("Show")
            {
                TextImageRelation = TextImageRelation.TextBeforeImage,
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Alignment = ToolStripItemAlignment.Left
            };
            trayExitButton.Click += ExitApp;
            trayShowButton.Click += trayIcon_DoubleClick;
            appNotifyIcon.ContextMenuStrip = new ContextMenuStrip();
            appNotifyIcon.ContextMenuStrip.Items.Add(trayShowButton);
            appNotifyIcon.ContextMenuStrip.Items.Add(trayExitButton);

            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                //case PowerModes.Resume:
                //    break;
                //case PowerModes.StatusChange:
                //    break;
                //Hack: Some system returns garbage in performance counter after resuming from sleep
                case PowerModes.Suspend:
                    System.Threading.Thread.Sleep(5000);
                    break;
                //default:
                //    break;
            }
        }
        #region FormEvents
        private void MainForm_FormLoading(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AppLocation != new Point(0, 0))
            {
                Location = Properties.Settings.Default.AppLocation;
            }

            if(resetStaticsEveryDay.Checked && Properties.Settings.Default.AppLastRunDate < DateTime.Today)
            {
                totalDlData = 0;
                totalUpData = 0;
                maxDlSpeed = 0;
                maxUpSpeed = 0;
            }
            else
            {
                totalDlData = Properties.Settings.Default.TotalDlValue;
                totalUpData = Properties.Settings.Default.TotalUpValue;
                maxDlSpeed = Properties.Settings.Default.MaxDlSpeed;
                maxUpSpeed = Properties.Settings.Default.MaxUpSpeed;
            }
            

            maxDlSpeedlbl.Text = FormatNetworkData(maxDlSpeed) + "/s";
            maxUpSpeedlbl.Text = FormatNetworkData(maxUpSpeed) + "/s";

            if (configurationsCmbBox.Items.Count > Properties.Settings.Default.SelectedNetworkIndex)
            {
                configurationsCmbBox.SelectedIndex = Properties.Settings.Default.SelectedNetworkIndex;
            }
            else if (configurationsCmbBox.Items.Count == 1)
            {
                configurationsCmbBox.SelectedIndex = 0;
            }

            themeCmbBox.SelectedIndex = Properties.Settings.Default.SelectedThemeIndex;

            dataLimitValueBox.Value = Properties.Settings.Default.DataLimitValue;

            topmostChkBox.Checked = Properties.Settings.Default.IsStayOnTop;
            autoStartWithWindowsChkBox.Checked = Properties.Settings.Default.IsAutoStartWithWindows;
            displayTrayIconChkBox.Checked = Properties.Settings.Default.IsDisplayIconInTray;
            displayTotalDataInTitleBar.Checked = Properties.Settings.Default.IsDisplayTotalDataInTitleBar;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TotalDlValue = totalDlData;
            Properties.Settings.Default.TotalUpValue = totalUpData;
            Properties.Settings.Default.MaxDlSpeed = maxDlSpeed;
            Properties.Settings.Default.MaxUpSpeed = maxUpSpeed;

            Properties.Settings.Default.SelectedNetworkIndex = configurationsCmbBox.SelectedIndex;
            Properties.Settings.Default.SelectedThemeIndex = themeCmbBox.SelectedIndex;

            Properties.Settings.Default.DataLimitValue = dataLimitValueBox.Value;

            Properties.Settings.Default.IsStayOnTop = topmostChkBox.Checked;
            Properties.Settings.Default.IsAutoStartWithWindows = autoStartWithWindowsChkBox.Checked;
            Properties.Settings.Default.IsDisplayIconInTray = displayTrayIconChkBox.Checked;
            Properties.Settings.Default.IsDisplayTotalDataInTitleBar = displayTotalDataInTitleBar.Checked;
            Properties.Settings.Default.IsResetStaticsEveryday = resetStaticsEveryDay.Checked;

            Properties.Settings.Default.AppLastRunDate = DateTime.Today;

            Properties.Settings.Default.Save();

            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                if (MessageBox.Show("Do you really want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }
        #endregion

        private void SetTootTips()
        {
            dataLimitToolTip.SetToolTip(dataLimitValueBox, "Useful to get notified when set data limit is exceeded.\nInsert data limit in MB (MegaBytes)\n-1 = Do not limit\n10000 = Max limit");
            selectNetworkTooltip.SetToolTip(configurationsCmbBox, "Select an available network to start monitoring the data.");
        }

        private void ShowTotalDataPanel(object sender, EventArgs e)
        {
            totalDataGrpBox.Visible = !totalDataGrpBox.Visible;
            Height = totalDataGrpBox.Visible ? 120 : Properties.Settings.Default.MainFormCompactHeight;
        }

        private void ShowConfigurationPanel(object sender, EventArgs e)
        {
            configurationsCmbBox.Visible = !configurationsCmbBox.Visible;
            Width = configurationsCmbBox.Visible ? Properties.Settings.Default.MainFormDefaultWidth : Properties.Settings.Default.MainFormCompactWidth;

            totalDataGrpBox.Visible = configurationsCmbBox.Visible;
            Height = totalDataGrpBox.Visible ? Properties.Settings.Default.MainFormDefaultHeight : Properties.Settings.Default.MainFormCompactHeight;

            totalDataBtn.Visible = !configurationsCmbBox.Visible;
            configBtn.Text = configurationsCmbBox.Visible ? "<" : ">";
        }

        private void RefreshDataTimer_Tick(object sender, EventArgs e)
        {
            //Get the speeds
            monitoredNetworkAdaptor.Refresh();

            if (monitoredNetworkAdaptor.DownloadSpeed >= 0)
            {
                totalDlData += monitoredNetworkAdaptor.DownloadSpeed;
                totalUpData += monitoredNetworkAdaptor.UploadSpeed;

                if (maxDlSpeed < monitoredNetworkAdaptor.DownloadSpeed)
                {
                    maxDlSpeed = monitoredNetworkAdaptor.DownloadSpeed;
                    maxDlSpeedlbl.Text = FormatNetworkData(maxDlSpeed) + "/s";
                }
                if (maxUpSpeed < monitoredNetworkAdaptor.UploadSpeed)
                {
                    maxUpSpeed = monitoredNetworkAdaptor.UploadSpeed;
                    maxUpSpeedlbl.Text = FormatNetworkData(maxUpSpeed) + "/s";
                }

                currentDlSpeedLbl.Text = FormatNetworkData(monitoredNetworkAdaptor.DownloadSpeed) + "/s";
                currentUpSpeedLbl.Text = FormatNetworkData(monitoredNetworkAdaptor.UploadSpeed) + "/s";
                totalDlDataLbl.Text = FormatNetworkData(totalDlData);
                totalUpDataLbl.Text = FormatNetworkData(totalUpData);
                totalDataConsumed = totalDlData + totalUpData;

                if (DataLimitValue > 0 && totalDataConsumed >= DataLimitValue)
                {
                    dataLimitValueBox.Value = -1;
                    this.TopMost = true;
                    _ = MessageBox.Show("Data limit reached!",
                                        "Warning",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                    this.TopMost = false;
                }
                if (DataLimitValue > 0)
                {
                    dataLimitProgressBar.Value = Convert.ToInt32(totalDataConsumed / DataLimitValue * 100);
                }

                //Set title bar text
                appHeaderTitleBar.Text = !displayTotalDataInTitleBar.Checked
                    ? Properties.Settings.Default.AppName
                    + " "
                    + Properties.Settings.Default.AppVersion
                    : FormatNetworkData(totalDataConsumed)
                    + (DataLimitValue > 0 ? " " + dataLimitProgressBar.Value + "%" : "")
                    + " - Total Data";

                if (WindowState == FormWindowState.Minimized)
                {
                    appNotifyIcon.Text = Properties.Settings.Default.AppName + " " + Properties.Settings.Default.AppVersion + "\n" +
                        "D: " + currentDlSpeedLbl.Text + "\nU: " + currentUpSpeedLbl.Text;
                }
                else
                {
                    appNotifyIcon.Text = Properties.Settings.Default.AppName + " " + Properties.Settings.Default.AppVersion;
                }
            }

            //Coloring
            if (BackColor == Color.Black)
            {
                if (currentDlSpeedLbl.Text.Contains("MB"))
                {
                    currentDlSpeedLbl.ForeColor = Color.Yellow;
                }
                else if (currentDlSpeedLbl.Text.Contains("KB"))
                {
                    currentDlSpeedLbl.ForeColor = Color.Lime;
                }
                else
                {
                    currentDlSpeedLbl.ForeColor = Color.White;
                }

                if (currentUpSpeedLbl.Text.Contains("MB"))
                {
                    currentUpSpeedLbl.ForeColor = Color.Yellow;
                }
                else if (currentUpSpeedLbl.Text.Contains("KB"))
                {
                    currentUpSpeedLbl.ForeColor = Color.Lime;
                }
                else
                {
                    currentUpSpeedLbl.ForeColor = Color.White;
                }
            }
            else
            {
                if (BackColor == Color.WhiteSmoke)
                {
                    currentDlSpeedLbl.ForeColor = Color.Black;
                    currentUpSpeedLbl.ForeColor = Color.Black;
                }
                else
                {
                    currentDlSpeedLbl.ForeColor = Color.White;
                    currentUpSpeedLbl.ForeColor = Color.White;
                }

            }
        }

        private void Configurations_Changed(object sender, EventArgs e)
        {
            refreshDataTimer.Stop();
            networkMonitor.StopMonitoring();
            if (configurationsCmbBox.SelectedIndex > -1)
            {
                monitoredNetworkAdaptor = (NetworkAdapter)configurationsCmbBox.SelectedItem;
                networkMonitor.StartMonitoring(monitoredNetworkAdaptor);
                refreshDataTimer.Start();
            }
        }
        private string FormatNetworkData(double dataRate)
        {
            if (dataRate > 999)
            {
                dataRate /= 1024;
                if (dataRate > 999)
                {
                    dataRate /= 1024;
                    if (dataRate > 999)
                    {
                        return $"{dataRate / 1024:n1}" + " GB";
                    }
                    else { return $"{dataRate:n1}" + " MB"; }
                }
                else { return $"{dataRate:n1}" + " KB"; }
            }
            else
            {
                return $"{dataRate:n1}" + " B";
            }
        }

        private void StayOnTopChkBox_CheckedChanged(
            object sender,
            EventArgs e) => TopMost = topmostChkBox.Checked;

        private void SetDataLimitValue(object sender, EventArgs e)
        {
            dataLimitProgressBar.Value = 0;
            dataLimitProgressBar.Maximum = 100;

            DataLimitValue = dataLimitValueBox.Value * 1024 * 1024; //Storing in bytes

            if (DataLimitValue > 0)
            {
                dataLimitProgressBar.Visible = true;
            }
            else
            {
                dataLimitProgressBar.Visible = false;
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            dataLimitValueBox.Value = -1;
            totalDlDataLbl.Text = "0.0 B";
            totalUpDataLbl.Text = "0.0 B";
            totalDlData = 0;
            totalUpData = 0;
            totalDataConsumed = 0;

            maxDlSpeed = 0;
            maxUpSpeed = 0;
            maxDlSpeedlbl.Text = "0 B/s";
            maxUpSpeedlbl.Text = "0 B/s";

            Properties.Settings.Default.LastStaticsResetDate = DateTime.Today;
            Properties.Settings.Default.Save();

        }

        private void AboutBtn_Click(object sender, EventArgs e) =>
            _ = MessageBox.Show(Properties.Settings.Default.AppName
                                + " "
                                + Properties.Settings.Default.AppVersion
                                + "\nDeveloper: Raj",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

        private void ApplyTheme(object sender, EventArgs e)
        {
            BackColor = (Color)themeCmbBox.SelectedItem;
            if(BackColor == Color.Tomato)
            {
                appHeaderTitleBar.BackColor = Color.Firebrick;
            }
            else if(BackColor==Color.Teal)
            {
                appHeaderTitleBar.BackColor = Color.DarkSlateGray;
            }
            else if (BackColor == Color.SlateBlue)
            {
                appHeaderTitleBar.BackColor = Color.DarkSlateBlue;
            }
            else if (BackColor == Color.Salmon)
            {
                appHeaderTitleBar.BackColor = Color.IndianRed;
            }
            else if (BackColor == Color.Chocolate)
            {
                appHeaderTitleBar.BackColor = Color.SaddleBrown;
            }
            else
            {
                appHeaderTitleBar.BackColor = Color.DimGray;
            }
            if (BackColor == Color.WhiteSmoke)
            {
                currentDataGrpBox.ForeColor = Color.Black;
                totalDataGrpBox.ForeColor = Color.Black;
                maxGroupBox.ForeColor = Color.Black;
                currentDllbl.ForeColor = Color.Black;
                currentDlSpeedLbl.ForeColor = Color.Black;
                currentUplbl.ForeColor = Color.Black;
                currentUpSpeedLbl.ForeColor = Color.Black;
                totalDllbl.ForeColor = Color.Black;
                totalUplbl.ForeColor = Color.Black;
                maxDllbl.ForeColor = Color.Black;
                maxUplbl.ForeColor = Color.Black;
                totalDlDataLbl.ForeColor = Color.Black;
                totalUpDataLbl.ForeColor = Color.Black;
                maxDlSpeedlbl.ForeColor = Color.Black;
                maxUpSpeedlbl.ForeColor = Color.Black;
                selectNetworklbl.ForeColor = Color.Black;
                dataLimitlbl.ForeColor = Color.Black;
                topmostChkBox.ForeColor = Color.Black;
                autoStartWithWindowsChkBox.ForeColor = Color.Black;
                displayTrayIconChkBox.ForeColor = Color.Black;
                themelbl.ForeColor = Color.Black;
                displayTotalDataInTitleBar.ForeColor = Color.Black;
                optionsGroupBox.ForeColor = Color.Black;
                resetStaticsEveryDay.ForeColor = Color.Black;
            }
            else
            {
                currentDataGrpBox.ForeColor = Color.White;
                totalDataGrpBox.ForeColor = Color.White;
                maxGroupBox.ForeColor = Color.White;
                currentDllbl.ForeColor = Color.White;
                currentDlSpeedLbl.ForeColor = Color.White;
                currentUplbl.ForeColor = Color.White;
                currentUpSpeedLbl.ForeColor = Color.White;
                totalDllbl.ForeColor = Color.White;
                totalUplbl.ForeColor = Color.White;
                maxDllbl.ForeColor = Color.White;
                maxUplbl.ForeColor = Color.White;
                totalDlDataLbl.ForeColor = Color.White;
                totalUpDataLbl.ForeColor = Color.White;
                maxDlSpeedlbl.ForeColor = Color.White;
                maxUpSpeedlbl.ForeColor = Color.White;
                selectNetworklbl.ForeColor = Color.White;
                dataLimitlbl.ForeColor = Color.White;
                topmostChkBox.ForeColor = Color.White;
                autoStartWithWindowsChkBox.ForeColor = Color.White;
                displayTrayIconChkBox.ForeColor = Color.White;
                themelbl.ForeColor = Color.White;
                displayTotalDataInTitleBar.ForeColor = Color.White;
                optionsGroupBox.ForeColor = Color.White;
                resetStaticsEveryDay.ForeColor = Color.White;

            }

        }


        #region TrayEvents
        private void DisplayNotifyIconInTray(object sender, EventArgs e)
        {
            appNotifyIcon.Visible = displayTrayIconChkBox.Checked;
        }
        private void MinimizeAppToTray(object sender, EventArgs e)
        {
            if (!appNotifyIcon.Visible)
            {
                appNotifyIcon.Visible = true;
            }
            WindowState = FormWindowState.Minimized;
            Hide();
            appNotifyIcon.ShowBalloonTip(500);
        }
        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Normal)
            {
                Show();
                WindowState = FormWindowState.Normal;

                if (!displayTrayIconChkBox.Checked)
                {
                    appNotifyIcon.Visible = false;
                }
            }
        }
        #endregion

        private void RegisterInStartup(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (autoStartWithWindowsChkBox.Checked)
                {
                    _ = registryKey.CreateSubKey(Properties.Settings.Default.AppName);
                    registryKey.SetValue(Properties.Settings.Default.AppName, "\"" + Application.ExecutablePath + "\"");
                }
                else
                {
                    registryKey.DeleteValue(Properties.Settings.Default.AppName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't register in windows. Permission denied!");
            }

        }

        private void ExitApp(object sender, EventArgs e) => Application.Exit();

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitlblBtn.BackColor = Color.Red;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitlblBtn.BackColor = Color.Black;
        }

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            minimizelblBtn.BackColor = Color.Blue;
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizelblBtn.BackColor = Color.Black;
        }

        private void aboutlblBtn_MouseLeave(object sender, EventArgs e)
        {
            aboutlblBtn.BackColor = Color.Black;
        }

        private void aboutlblBtn_MouseEnter(object sender, EventArgs e)
        {
            aboutlblBtn.BackColor = Color.DarkViolet;
        }

        private void configBtn_MouseEnter(object sender, EventArgs e)
        {
            configBtn.BackColor = Color.Blue;
        }

        private void configBtn_MouseLeave(object sender, EventArgs e)
        {
            configBtn.BackColor = Color.DimGray;
        }

        private void totalDataBtn_MouseEnter(object sender, EventArgs e)
        {
            totalDataBtn.BackColor = Color.Blue;
        }

        private void totalDataBtn_MouseLeave(object sender, EventArgs e)
        {
            totalDataBtn.BackColor = Color.DimGray;
        }

        private void appHeaderTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentPositionPoint = e.Location;
                Cursor = Cursors.SizeAll;
            }
        }

        private void appHeaderTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentPositionPoint.X > 0)
            {
                Location = new Point(Location.X - currentPositionPoint.X + e.X, Location.Y - currentPositionPoint.Y + e.Y);
            }
        }

        private void appHeaderTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentPositionPoint.X > 0)
            {
                currentPositionPoint.X = 0;
                Cursor = Cursors.Default;
                //Save the location
                Properties.Settings.Default.AppLocation = Location;
                Properties.Settings.Default.Save();
            }
        }

        private void resetBtn_MouseHover(object sender, EventArgs e)
        {
            //Display statics information in tooltip
            resetStaticsBtnToolTip.SetToolTip(resetBtn, "Last reset done on:"+Properties.Settings.Default.LastStaticsResetDate);
        }
    }
}
