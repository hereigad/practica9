using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteca;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbc1.ReadOnly = true;
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            TextBoxColoreado tbc2 = new TextBoxColoreado();
            tbc2.Location = new Point(356, 75);
            tbc2.Name = "tbc2";
            tbc2.Size = new Size(100, 20);
            tbc2.TabIndex = 4;

            Button botontbc2 = new Button();
            botontbc2.Location = new Point(476, 75);
            botontbc2.Name = "botontbc2";
            botontbc2.Size = new Size(75, 23);
            botontbc2.TabIndex = 5;
            botontbc2.Text = "botontbc2";
            botontbc2.UseVisualStyleBackColor = true;
            botontbc2.Click += new EventHandler(this.botonCrear_Click);

            this.Controls.Add(tbc2);
            this.Controls.Add(botontbc2);
        }
    }
}
