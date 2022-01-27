using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberpunkRedCharacterBuilder
{
    public partial class rollWIndow : Form
    {
        

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public rollWIndow()
        {
            InitializeComponent();

        }
        public void dieRoll(bool isStatRoll, int die, int stat, int skill)
        {
            if(isStatRoll)
            {
                Random rnd = new Random();
                int roll = rnd.Next(1, die + 1);

                rollLabel.Text = $"{roll} + {stat} = {roll + stat}";
            }
            else {
                Random rnd = new Random();
                int roll = rnd.Next(1, die + 1);

                rollLabel.Text = $"{roll} + {stat} + {skill} = {roll + stat + skill}";

            }

        }
    }
   
}
