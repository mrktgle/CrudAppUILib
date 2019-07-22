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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
        }

        private void setResolution()
        {

            //int width = Screen.PrimaryScreen.WorkingArea.Width;
            //int height = Screen.PrimaryScreen.WorkingArea.Height;

            //const int margin = 0;
            //Rectangle rect = new Rectangle(
            //    Screen.PrimaryScreen.WorkingArea.X + margin,
            //    Screen.PrimaryScreen.WorkingArea.Y + margin,
            //    Screen.PrimaryScreen.WorkingArea.Width,
            //    Screen.PrimaryScreen.WorkingArea.Height);
            //this.Bounds = rect;

            if (Screen.PrimaryScreen.WorkingArea.X == 1366 && Screen.PrimaryScreen.WorkingArea.Y == 768)
            {
                this.Height = 1;
                this.Width = 1;
            }
        }

        public void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.WorkingArea.Width == 1366 && Screen.PrimaryScreen.WorkingArea.Height == 768)
            {
                int width = Screen.PrimaryScreen.WorkingArea.Width - 1000;
                int height = Screen.PrimaryScreen.WorkingArea.Height - 700;
            }
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            setResolution();
        }
    }
}
