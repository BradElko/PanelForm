using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomForm_Practice_1
{
    public partial class FlatButton : Button
    {
        public FlatButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, false);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
