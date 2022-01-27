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

    public partial class characterScreen : UserControl
    {
       
        public characterScreen()
        {
            InitializeComponent();
            
        }

        private void characterScreen_Load(object sender, EventArgs e)
        {
            // displays the values on the screen
            characterLoad();
            showSkills();
            nameLabel.Text = $"Name: {Form1.character.name}";
            roleLabel.Text = Form1.character.role;
            intLabel.Text = $"INT: {Form1.character.INT}";
            refLabel.Text = $"REF: {Form1.character.REF}";
            dexLabel.Text = $"DEX: {Form1.character.DEX}";
            techLabel.Text = $"TECH: {Form1.character.TECH}";
            coolLabel.Text = $"COOL: {Form1.character.COOL}";
            willLabel.Text = $"WILL: {Form1.character.WILL}";
            luckLabel.Text = $"LUCK: {Form1.character.LUCK_Max}";
            moveLabel.Text = $"MOVE: {Form1.character.MOVE}";
            bodyLabel.Text = $"BODY: {Form1.character.BODY}";
            empLabel.Text = $"EMP: {Form1.character.EMP}";

        }
        void characterLoad()
        {

            
            //loads all the skills into a list and the character into an object

            XmlReader reader = XmlReader.Create("character.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {

                    reader.ReadToFollowing("character");

                    reader.ReadToDescendant("name");

                    Form1.character.name = reader.ReadString();

                    reader.ReadToNextSibling("role");
                    Form1.character.role = reader.ReadString();

                    reader.ReadToNextSibling("ip");

                    reader.ReadToNextSibling("stats");
                    reader.ReadToDescendant("INT");
                    Form1.character.INT = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("REF");
                    Form1.character.REF = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("DEX");
                    Form1.character.DEX = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("TECH");
                    Form1.character.TECH = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("COOL");
                    Form1.character.COOL = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("WILL");
                    Form1.character.WILL = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("LUCK_MAX");
                    Form1.character.LUCK = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("MOVE");
                    Form1.character.MOVE = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("BODY");
                    Form1.character.BODY = Convert.ToInt32(reader.ReadString());
                    reader.ReadToNextSibling("EMP");
                    Form1.character.EMP = Convert.ToInt32(reader.ReadString());

                    

                }
            }


            XmlReader reader2 = XmlReader.Create("skills.xml");
            string skillName, stat;
            int bonus;



            while (reader2.Read())
            {
                //  if (reader.NodeType == XmlNodeType.Text)
                //  {


                for (int i = 0; i < 66; i++)

                {
                    reader2.ReadToFollowing("name");
                    skillName = reader2.ReadString();
                    reader2.ReadToFollowing("skill");
                    stat = reader2.GetAttribute("stat");

                    bonus = Convert.ToInt32(reader2.GetAttribute("bonus"));




                    Skill skill = new Skill(skillName, stat, bonus);
                    Form1.skills.Add(skill);
                }




                //  }
            }
        }
        //displays skills
        void showSkills()
        {
            skillLabel0.Text = $"{Form1.skills[0].name}: {Form1.skills[0].skillMod}";
            skillLabel1.Text = $"{Form1.skills[1].name}: {Form1.skills[1].skillMod}";
            skillLabel2.Text = $"{Form1.skills[2].name}: {Form1.skills[2].skillMod}";
            skillLabel3.Text = $"{Form1.skills[3].name}: {Form1.skills[3].skillMod}";
            skillLabel4.Text = $"{Form1.skills[4].name}: {Form1.skills[4].skillMod}";
            skillLabel5.Text = $"{Form1.skills[5].name}: {Form1.skills[5].skillMod}";
            skillLabel6.Text = $"{Form1.skills[6].name}: {Form1.skills[6].skillMod}";
            skillLabel7.Text = $"{Form1.skills[7].name}: {Form1.skills[7].skillMod}";
            skillLabel8.Text = $"{Form1.skills[8].name}: {Form1.skills[8].skillMod}";
            skillLabel9.Text = $"{Form1.skills[9].name}: {Form1.skills[9].skillMod}";
            skillLabel10.Text = $"{Form1.skills[10].name}: {Form1.skills[10].skillMod}";
            skillLabel11.Text = $"{Form1.skills[11].name}: {Form1.skills[11].skillMod}";
            skillLabel12.Text = $"{Form1.skills[12].name}: {Form1.skills[12].skillMod}";
            skillLabel13.Text = $"{Form1.skills[13].name}: {Form1.skills[13].skillMod}";
            skillLabel14.Text = $"{Form1.skills[14].name}: {Form1.skills[14].skillMod}";
            skillLabel15.Text = $"{Form1.skills[15].name}: {Form1.skills[15].skillMod}";
            skillLabel16.Text = $"{Form1.skills[16].name}: {Form1.skills[16].skillMod}";
            skillLabel17.Text = $"{Form1.skills[17].name}: {Form1.skills[17].skillMod}";
            skillLabel18.Text = $"{Form1.skills[18].name}: {Form1.skills[18].skillMod}";
            skillLabel19.Text = $"{Form1.skills[19].name}: {Form1.skills[19].skillMod}";
            skillLabel20.Text = $"{Form1.skills[20].name}: {Form1.skills[20].skillMod}";
            skillLabel21.Text = $"{Form1.skills[21].name}: {Form1.skills[21].skillMod}";
            skillLabel22.Text = $"{Form1.skills[22].name}: {Form1.skills[22].skillMod}";
            skillLabel23.Text = $"{Form1.skills[23].name}: {Form1.skills[23].skillMod}";
            skillLabel24.Text = $"{Form1.skills[24].name}: {Form1.skills[24].skillMod}";
            skillLabel25.Text = $"{Form1.skills[25].name}: {Form1.skills[25].skillMod}";
            skillLabel26.Text = $"{Form1.skills[26].name}: {Form1.skills[26].skillMod}";
            skillLabel27.Text = $"{Form1.skills[27].name}: {Form1.skills[27].skillMod}";
            skillLabel28.Text = $"{Form1.skills[28].name}: {Form1.skills[28].skillMod}";
            skillLabel29.Text = $"{Form1.skills[29].name}: {Form1.skills[29].skillMod}";
            skillLabel30.Text = $"{Form1.skills[30].name}: {Form1.skills[30].skillMod}";
            skillLabel31.Text = $"{Form1.skills[31].name}: {Form1.skills[31].skillMod}";
            skillLabel32.Text = $"{Form1.skills[32].name}: {Form1.skills[32].skillMod}";
            skillLabel33.Text = $"{Form1.skills[33].name}: {Form1.skills[33].skillMod}";
            skillLabel34.Text = $"{Form1.skills[34].name}: {Form1.skills[34].skillMod}";
            skillLabel35.Text = $"{Form1.skills[35].name}: {Form1.skills[35].skillMod}";
            skillLabel36.Text = $"{Form1.skills[36].name}: {Form1.skills[36].skillMod}";
            skillLabel37.Text = $"{Form1.skills[37].name}: {Form1.skills[37].skillMod}";
            skillLabel38.Text = $"{Form1.skills[38].name}: {Form1.skills[38].skillMod}";
            skillLabel39.Text = $"{Form1.skills[39].name}: {Form1.skills[39].skillMod}";
            skillLabel40.Text = $"{Form1.skills[40].name}: {Form1.skills[40].skillMod}";
            skillLabel41.Text = $"{Form1.skills[41].name}: {Form1.skills[41].skillMod}";
            skillLabel42.Text = $"{Form1.skills[42].name}: {Form1.skills[42].skillMod}";
            skillLabel43.Text = $"{Form1.skills[43].name}: {Form1.skills[43].skillMod}";
            skillLabel44.Text = $"{Form1.skills[44].name}: {Form1.skills[44].skillMod}";
            skillLabel45.Text = $"{Form1.skills[45].name}: {Form1.skills[45].skillMod}";
            skillLabel46.Text = $"{Form1.skills[46].name}: {Form1.skills[46].skillMod}";
            skillLabel47.Text = $"{Form1.skills[47].name}: {Form1.skills[47].skillMod}";
            skillLabel48.Text = $"{Form1.skills[48].name}: {Form1.skills[48].skillMod}";
            skillLabel49.Text = $"{Form1.skills[49].name}: {Form1.skills[49].skillMod}";
            skillLabel50.Text = $"{Form1.skills[50].name}: {Form1.skills[50].skillMod}";
            skillLabel51.Text = $"{Form1.skills[51].name}: {Form1.skills[51].skillMod}";
            skillLabel52.Text = $"{Form1.skills[52].name}: {Form1.skills[52].skillMod}";
            skillLabel53.Text = $"{Form1.skills[53].name}: {Form1.skills[53].skillMod}";
            skillLabel54.Text = $"{Form1.skills[54].name}: {Form1.skills[54].skillMod}";
            skillLabel55.Text = $"{Form1.skills[55].name}: {Form1.skills[55].skillMod}";
            skillLabel56.Text = $"{Form1.skills[56].name}: {Form1.skills[56].skillMod}";
            skillLabel57.Text = $"{Form1.skills[57].name}: {Form1.skills[57].skillMod}";
            skillLabel58.Text = $"{Form1.skills[58].name}: {Form1.skills[58].skillMod}";
            skillLabel59.Text = $"{Form1.skills[59].name}: {Form1.skills[59].skillMod}";
            skillLabel60.Text = $"{Form1.skills[60].name}: {Form1.skills[60].skillMod}";
            skillLabel61.Text = $"{Form1.skills[61].name}: {Form1.skills[61].skillMod}";
            skillLabel62.Text = $"{Form1.skills[62].name}: {Form1.skills[62].skillMod}";
            skillLabel63.Text = $"{Form1.skills[63].name}: {Form1.skills[63].skillMod}";
            skillLabel64.Text = $"{Form1.skills[64].name}: {Form1.skills[64].skillMod}";
            skillLabel65.Text = $"{Form1.skills[65].name}: {Form1.skills[65].skillMod}";
        }

      //automaticaly rolls currently only works for intellegence rolls
        void showRollWindow(bool isStatRoll, int die, int stat, int skill)
        {
            rollWIndow rw = new rollWIndow();
            rw.Show();
            rw.dieRoll(isStatRoll, die, stat, skill);
            

        }
        

        

        private void intLabel_Click(object sender, EventArgs e)
        {
           
                showRollWindow(true, 10, Form1.character.INT, 0);
           
        }

        
    }
}
