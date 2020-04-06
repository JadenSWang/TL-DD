using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TL_DD
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        #region Window Control Buttons
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            FocusLabel.Focus();
        }

        private void PinBtn_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            if(this.TopMost)
            {
                PinBtn.BackColor = Color.Gray;
                FocusLabel.Focus();
            } else
            {
                PinBtn.BackColor = Color.White;
                FocusLabel.Focus();
            }
        }
        #endregion

        private Point lastPoint;
        private void HomeScreen_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        private void HomeScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - this.lastPoint.X;
                Top += e.Y - this.lastPoint.Y;
            }
        }

        private void ToDoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDoListView.Items.Add("GIGA NIGGA");
        }
    }
}
