using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using QuanLyBanThuoc.DTO;
namespace QuanLyBanThuoc.GUI
{
    public partial class MyFourCustom : UserControl
    {
        System.Timers.Timer timer;
        public MyFourCustom()
        {
            InitializeComponent();
        }

        private void MyFourCustom_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }
        delegate void UpdateLabel(Label lbl, string value);
        void UpdateDataLable(Label lbl,string value)
        {
            lbl.Text = value;
        }
        SoundPlayer player = new SoundPlayer();
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if(currentTime.Hour==userTime.Hour&&currentTime.Minute==userTime.Minute&&currentTime.Second==userTime.Second){
                timer.Stop();
                try
                {
                    UpdateLabel upd = UpdateDataLable;
                    if (lblStatus.InvokeRequired)
                        Invoke(upd, lblStatus, "Stop");
                    player = new SoundPlayer();
                    player.SoundLocation = @"E:\Music\Creep.wav";
                    player.PlayLooping();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Running....";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Stop";
            player.Stop();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Winform.sick = new fSick();
            this.Hide();
            Winform.sick.ShowDialog();
            this.Show();
        }
    }
}
