using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomForm_Practice_1
{
    public partial class rcm : UserControl
    {
        public rcm()
        {
            InitializeComponent();
        }
        private void rcm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid);
        }
        private void rcm_Load(object sender, EventArgs e)
        {
            this.Show();
            rcmMenuPanel.Location = new Point(1, 1);
            rcmSetupPanel.Location = new Point(1, 31);
        }
    }
}
