using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

//Cyberpunk Red Character Maker by Parker Railton 
//Jan 26 2022

//this program creates and stores the name, role, stats, and skills of a character

namespace CyberpunkRedCharacterBuilder
{

    public partial class Form1 : Form
    {
        //list to hold skills
        public static List<Skill> skills = new List<Skill>();
        //character object
        public static Character character = new Character("", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);


        public Form1()
        {
            InitializeComponent();
            //open the start screen
            startScreen ss = new startScreen();

            this.Controls.Add(ss);


        }

       
    }


}

