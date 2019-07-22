using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CrudApplicationDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
        }

        private void setResolution()
        {
            const int margin = 0;
            Rectangle rect = new Rectangle(
                Screen.PrimaryScreen.WorkingArea.X + margin,
                Screen.PrimaryScreen.WorkingArea.Y + margin,
                Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
            this.Bounds = rect;
            this.WindowState = FormWindowState.Maximized;
        }

        public void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            setResolution();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain frmMain = this;
            //BaseForm BaseForm = new BaseForm();
            //BaseForm.MdiParent = this;
            //BaseForm.Show();
            
            setResolution();
        }

        #region HeadFunction
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panelHead_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion 

        private void btnBooks_Click(object sender, EventArgs e)
        {
            testform testform = new testform();
            testform.MdiParent = this;
            bunifuTransition1.ShowSync(testform);
            testform.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            test2 testform2 = new test2();
            testform2.MdiParent = this;
            bunifuTransition2.ShowSync(testform2);
            testform2.Show();
        }


    }
}
