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

namespace CyberpunkRedCharacterBuilder
{
    public partial class characterCreationStats : UserControl
    {
        public characterCreationStats()
        {
            InitializeComponent();
            intLabel.Text = "2";
            refLabel.Text = "2";
            dexLabel.Text = "2";
            techLabel.Text = "2";
            coolLabel.Text = "2";
            willLabel.Text = "2";
            luckLabel.Text = "2";
            moveLabel.Text = "2";
            bodyLabel.Text = "2";
            empLabel.Text = "2";
            Form1.character.INT = 2;
            Form1.character.REF = 2;
            Form1.character.DEX = 2;
            Form1.character.TECH = 2;
            Form1.character.COOL = 2;
            Form1.character.WILL = 2;
            Form1.character.LUCK = 2;
            Form1.character.MOVE = 2;
            Form1.character.BODY = 2;
            Form1.character.EMP = 2;
        }
        //the click events titled ___plusLabel or ___minusLabel change and display the value of the skills
        private void coolPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.COOL++;
            if (Form1.character.COOL > 8)
            {
                Form1.character.COOL = 8;
            }
            coolLabel.Text = Convert.ToString(Form1.character.COOL);
        }

        private void coolMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.COOL--;
            if (Form1.character.COOL < 2)
            {
                Form1.character.COOL = 2;
            }
            coolLabel.Text = Convert.ToString(Form1.character.COOL);

        }

        private void techMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.TECH--;
            if (Form1.character.TECH < 2)
            {
                Form1.character.TECH = 2;
            }
            techLabel.Text = Convert.ToString(Form1.character.TECH);
        }

        private void techPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.TECH++;
            if (Form1.character.TECH > 8)
            {
                Form1.character.TECH = 8;
            }
            techLabel.Text = Convert.ToString(Form1.character.TECH);
        }

        private void dexMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.DEX--;
            if (Form1.character.DEX < 2)
            {
                Form1.character.DEX = 2;
            }
            dexLabel.Text = Convert.ToString(Form1.character.DEX);
        }

        private void dexPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.DEX++;
            if (Form1.character.DEX > 8)
            {
                Form1.character.DEX = 8;
            }
            dexLabel.Text = Convert.ToString(Form1.character.DEX);
        }

        private void refMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.DEX--;
            if (Form1.character.DEX < 2)
            {
                Form1.character.DEX = 2;
            }
            dexLabel.Text = Convert.ToString(Form1.character.DEX);
        }

        private void intMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.INT--;
            if (Form1.character.INT < 2)
            {
                Form1.character.INT = 2;
            }
            intLabel.Text = Convert.ToString(Form1.character.INT);
        }

        private void refPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.REF++;
            if (Form1.character.REF > 8)
            {
                Form1.character.REF = 8;
            }
            refLabel.Text = Convert.ToString(Form1.character.REF);
        }

        private void intPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.INT++;
            if (Form1.character.INT > 8)
            {
                Form1.character.INT = 8;
            }
            intLabel.Text = Convert.ToString(Form1.character.INT);
        }

        private void willMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.WILL--;
            if (Form1.character.WILL < 2)
            {
                Form1.character.WILL = 2;
            }
            willLabel.Text = Convert.ToString(Form1.character.WILL);
        }

        private void empPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.EMP++;
            if (Form1.character.EMP > 8)
            {
                Form1.character.EMP = 8;
            }
            empLabel.Text = Convert.ToString(Form1.character.EMP);
        }

        private void bodyMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.BODY--;
            if (Form1.character.BODY < 2)
            {
                Form1.character.BODY = 2;
            }
            bodyLabel.Text = Convert.ToString(Form1.character.BODY);
        }

        private void bodyPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.BODY++;
            if (Form1.character.BODY > 8)
            {
                Form1.character.BODY = 8;
            }
            bodyLabel.Text = Convert.ToString(Form1.character.BODY);
        }

        private void moveMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.MOVE--;
            if (Form1.character.MOVE < 2)
            {
                Form1.character.MOVE = 2;
            }
            moveLabel.Text = Convert.ToString(Form1.character.MOVE);
        }

        private void movePlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.MOVE++;
            if (Form1.character.MOVE > 8)
            {
                Form1.character.MOVE = 8;
            }
            moveLabel.Text = Convert.ToString(Form1.character.MOVE);
        }

        private void luckMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.LUCK--;
            if (Form1.character.LUCK < 2)
            {
                Form1.character.LUCK = 2;
            }
            luckLabel.Text = Convert.ToString(Form1.character.LUCK);
        }

        private void luckPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.LUCK_Max++;
            if (Form1.character.LUCK_Max > 8)
            {
                Form1.character.LUCK_Max = 8;
            }
            luckLabel.Text = Convert.ToString(Form1.character.LUCK_Max);
        }

        private void empMinusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.EMP--;
            if (Form1.character.EMP < 2)
            {
                Form1.character.EMP = 2;
            }
            empLabel.Text = Convert.ToString(Form1.character.EMP);
        }

        private void willPlusLabel_Click(object sender, EventArgs e)
        {
            Form1.character.WILL++;
            if (Form1.character.WILL > 8)
            {
                Form1.character.WILL = 8;
            }
            willLabel.Text = Convert.ToString(Form1.character.WILL);
        }
        //stores character information in an xml file
        private void button1_Click(object sender, EventArgs e)
        {

            XmlWriter writer = XmlWriter.Create("character.xml");

            writer.WriteStartElement("character");

            writer.WriteStartElement("name");
            writer.WriteString(Form1.character.name);
            writer.WriteEndElement();

            writer.WriteStartElement("role");
            writer.WriteString(Form1.character.role);
            writer.WriteEndElement();

            writer.WriteStartElement("ip");
            writer.WriteString($"{1}");
            writer.WriteEndElement();

            writer.WriteStartElement("stats");

            writer.WriteStartElement("INT");
            writer.WriteString($"{Form1.character.INT}");
            writer.WriteEndElement();

            writer.WriteStartElement("REF");
            writer.WriteString($"{Form1.character.REF}");
            writer.WriteEndElement();

            writer.WriteStartElement("DEX");
            writer.WriteString($"{Form1.character.DEX}");
            writer.WriteEndElement();

            writer.WriteStartElement("TECH");
            writer.WriteString($"{Form1.character.TECH}");
            writer.WriteEndElement();

            writer.WriteStartElement("COOL");
            writer.WriteString($"{Form1.character.COOL}");
            writer.WriteEndElement();

            writer.WriteStartElement("WILL");
            writer.WriteString($"{Form1.character.WILL}");
            writer.WriteEndElement();

            writer.WriteStartElement("LUCK_MAX");
            writer.WriteString($"{Form1.character.LUCK_Max}");
            writer.WriteEndElement();

            writer.WriteStartElement("LUCK");
            writer.WriteString($"{Form1.character.LUCK}");
            writer.WriteEndElement();

            writer.WriteStartElement("MOVE");
            writer.WriteString($"{Form1.character.MOVE}");
            writer.WriteEndElement();

            writer.WriteStartElement("BODY");
            writer.WriteString($"{Form1.character.BODY}");
            writer.WriteEndElement();

            writer.WriteStartElement("EMP");
            writer.WriteString($"{Form1.character.EMP}");
            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndElement();

            
            writer.Close();

            //opens the skill selection
            this.Controls.Clear();
            characterCreationSkills cs = new characterCreationSkills();

            this.Controls.Add(cs);
        }
    }
}
