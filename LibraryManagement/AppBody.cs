using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LibraryManagement
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();





        public AppBody()
        {
            InitializeComponent();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_Timer.Start();
        }

        private void Log_in_Timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_in_Timer.Stop();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOff_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // sliding panel code starts from here
        bool isSlidingPannelExpanded;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 100;
        private void SlidingPannel_ToggelButton_Click(object sender, EventArgs e)
        {
            if(isSlidingPannelExpanded)
            {
                // retract pannel
            }
            SlidingPannel_Timer.Start();
        }

        private void SlidingPannel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                // retract pannel
                sliding_panel.Width -= 30;
                if(sliding_panel.Width <= MinSliderWidth)
                {
                    // stop decreasing the width
                    isSlidingPannelExpanded = false;
                    SlidingPannel_Timer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                // expand the panel
                sliding_panel.Width += 30;
                if (sliding_panel.Width >= MaxSliderWidth)
                {
                    // stop expanding
                    isSlidingPannelExpanded = true;
                    SlidingPannel_Timer.Stop();

                    this.Refresh();
                }

            }
        }

        private void AboutTabButton_Click(object sender, EventArgs e)
        {

        }

        private void BookTabButton_Click(object sender, EventArgs e)
        {
            if(!contentPanel.Controls.Contains(BooksUserControl.Instance))
            {
                contentPanel.Controls.Add(BooksUserControl.Instance);
                BooksUserControl.Instance.Dock = DockStyle.Fill;
                BooksUserControl.Instance.BringToFront();
            }
            else
            {
                BooksUserControl.Instance.BringToFront();
            }
        }

        private void SettingsTabButton_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(DepartmentUserControl.Instance))
            {
                contentPanel.Controls.Add(DepartmentUserControl.Instance);
                DepartmentUserControl.Instance.Dock = DockStyle.Fill;
                DepartmentUserControl.Instance.BringToFront();
            }
            else
            {
                DepartmentUserControl.Instance.BringToFront();
            }
        }

        private void TransactionTabButton_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(TransactionUserControl.Instance))
            {
                contentPanel.Controls.Add(TransactionUserControl.Instance);
                TransactionUserControl.Instance.Dock = DockStyle.Fill;
                TransactionUserControl.Instance.BringToFront();
            }
            else
            {
                TransactionUserControl.Instance.BringToFront();
            }
        }

        private void BorrowerTabButton_Click(object sender, EventArgs e)
        {
            if (!contentPanel.Controls.Contains(BorrowUserControl.Instance))
            {
                contentPanel.Controls.Add(BorrowUserControl.Instance);
                BorrowUserControl.Instance.Dock = DockStyle.Fill;
                BorrowUserControl.Instance.BringToFront();
            }
            else
            {
                BorrowUserControl.Instance.BringToFront();
            }
        }

        private void Address_Click(object sender, EventArgs e)
        {

        }
    }
}
