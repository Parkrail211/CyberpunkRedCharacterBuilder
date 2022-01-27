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
    public partial class startScreen : UserControl
    {
        public startScreen()
        {
            InitializeComponent();
        }
        //load a character
        private void loadButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            characterScreen cs = new characterScreen();

           this.Controls.Add(cs);

            

        }
        //make a new character
        private void createButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            characterCreationStats cs = new characterCreationStats();

            this.Controls.Add(cs);
        }
    }
}
