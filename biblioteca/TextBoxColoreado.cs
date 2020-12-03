using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public class TextBoxColoreado : TextBox
    {
        public new bool ReadOnly
        {
            get
            {
                return base.ReadOnly;
            }
            set
            {
                if (value == true)
                {
                    this.BackColor = Color.Red;
                }
                if (value == false)
                {
                    this.BackColor = Color.White;
                }
                base.ReadOnly = value;
            }
        }
    }
}
