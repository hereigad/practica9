using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public class TextBoxMultiline : TextBox
    {
        public new bool Multiline
        {
            get
            {
                return base.Multiline;
            }
            set
            {
                if(value == true)
                {
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height * 2);
                }
                if(value == false)
                {
                    this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height / 2);
                }
                base.Multiline = value;
            }
        }
    }
}
