using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rest4Eyes
{
    public partial class SettingsForm : Form
    {
        Timer timer { get; set; }

        public SettingsForm()
        {
            InitializeComponent();

            Notification.Hello();

            ResetCounter();

            this.MouseDown += new MouseEventHandler((o, e) =>
            {
                base.Capture = false;
                Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref message);
            });
        }



        //    private void ChangeTextBoxAllowTheSettings()
        //    {
        //        Timer timer = ReadSettingsFile();
        //
        //        howOffenRestTextBox.Text = timer.HowOffenRest.ToString();
        //        howLongRestTextBox.Text = timer.HowLongRest.ToString();
        //    }
        //
        //    private Timer ReadSettingsFile()
        //    {
        //        Timer timer = new Timer();
        //        try
        //        {
        //            timer = JsonConvert.DeserializeObject<Timer>(File.ReadAllText("timerSettings.txt"));
        //
        //            return timer;
        //        }
        //        catch (Exception)
        //        {
        //
        //            throw new Exception();
        //        }
        //    }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }



        private void SaveButton_Click(object sender, EventArgs e)
        {
            ResetCounter();
            SaveSettings((int)timer.HowLongRest, (int)timer.HowOffenRest);

            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                countLabel.Text = "";
            }

            countLabel.Visible = true;
            Hide();
        }

        private bool SaveSettings(int howLongRest, int howOffenRest )
        {
            try
            {
                List<Timer> timerSetting = new List<Timer>();
                timerSetting.Add(new Timer()
                {
                    HowOffenRest = howOffenRest,
                    HowLongRest = howLongRest
                });

                string json = JsonConvert.SerializeObject(timerSetting.ToArray());

                using (System.IO.StreamWriter writer = new(@"timerSettings.txt"))
                {
                    writer.WriteLine(json);
                }

                Notification.SaveSuccesed();
                return true;
            }
            catch (Exception e)
            {
                Notification.Error();
                return false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = (int)timer.HowOffenRest--;

            countLabel.Text = "Ближайший отдых через: " + (i / 60 + 1).ToString() + " минут";

            if (i == 0)
            {
                Notification.TimeToRest();
                timer1.Stop();
                timer2.Start();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int i = (int)timer.HowLongRest--;

            countLabel.Text = "Продолжать работать через " + (i / 60 + 1).ToString() + " минут";

            if (i == 0)
            {
                Notification.TimeToWork();

                timer2.Stop();
                ResetCounter();
                timer1.Start();
            }
        }

        private void ResetCounter()
        {
            timer = new Timer();
            timer.HowOffenRest = Convert.ToInt32(howOffenRestTextBox.Text) * 60 - 1;
            timer.HowLongRest = Convert.ToInt32(howLongRestTextBox.Text) * 60 - 1;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}