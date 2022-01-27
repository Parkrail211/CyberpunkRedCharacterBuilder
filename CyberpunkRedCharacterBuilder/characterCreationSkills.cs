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
    public partial class characterCreationSkills : UserControl
    {
        public characterCreationSkills()
        {
            InitializeComponent();
        }

        private void characterCreationSkills_Load(object sender, EventArgs e)
        {
            XmlReader reader = XmlReader.Create("baseSkills.xml");
            string name, stat;
            int bonus;


            // reads the baseSkills xml file 
            while (reader.Read())
            {
                //  if (reader.NodeType == XmlNodeType.Text)
                //  {


                for (int i = 0; i < 66; i++)

                {
                    reader.ReadToFollowing("name");
                    name = reader.ReadString();
                    reader.ReadToFollowing("skill");
                    stat = reader.GetAttribute("stat");

                    bonus = Convert.ToInt32(reader.GetAttribute("bonus"));




                    Skill skill = new Skill(name, stat, bonus);
                    Form1.skills.Add(skill);
                }




                //  }
            }

            //loads all the skills onto the screen
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

        //these click events change the values of the skill bonuses, currently only the first coloumn is implemented
        private void skill19PlusButton_Click(object sender, EventArgs e)
        {
            Form1.skills[19].skillMod++;
            if (Form1.skills[19].skillMod > 6)
            {
                Form1.skills[19].skillMod = 6;

            }
            skillLabel19.Text = $"{Form1.skills[19].name}: {Form1.skills[19].skillMod}";
        }

        private void skill24PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[24].skillMod++;
            if (Form1.skills[24].skillMod > 6)
            {
                Form1.skills[24].skillMod = 6;

            }
            skillLabel24.Text = $"{Form1.skills[24].name}: {Form1.skills[24].skillMod}";

        }

        private void skill23MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[23].skillMod--;
            if (Form1.skills[23].skillMod < 0)
            {
                Form1.skills[23].skillMod = 0;

            }
            skillLabel23.Text = $"{Form1.skills[23].name}: {Form1.skills[23].skillMod}";
        }

        private void skill23PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[23].skillMod++;
            if (Form1.skills[23].skillMod > 6)
            {
                Form1.skills[23].skillMod = 6;

            }
            skillLabel23.Text = $"{Form1.skills[23].name}: {Form1.skills[23].skillMod}";

        }

        private void skil22MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[22].skillMod--;
            if (Form1.skills[22].skillMod < 0)
            {
                Form1.skills[22].skillMod = 0;

            }
            skillLabel22.Text = $"{Form1.skills[22].name}: {Form1.skills[22].skillMod}";
        }

        private void skill22PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[22].skillMod++;
            if (Form1.skills[22].skillMod > 6)
            {
                Form1.skills[22].skillMod = 6;

            }
            skillLabel22.Text = $"{Form1.skills[22].name}: {Form1.skills[22].skillMod}";
        }

        private void skill21MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[21].skillMod--;
            if (Form1.skills[21].skillMod < 0)
            {
                Form1.skills[21].skillMod = 0;

            }
            skillLabel21.Text = $"{Form1.skills[21].name}: {Form1.skills[21].skillMod}";
        }

        private void skill21PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[21].skillMod++;
            if (Form1.skills[21].skillMod > 6)
            {
                Form1.skills[21].skillMod = 6;

            }
            skillLabel21.Text = $"{Form1.skills[21].name}: {Form1.skills[21].skillMod}";
        }

        private void skill20MinisLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[20].skillMod--;
            if (Form1.skills[20].skillMod < 0)
            {
                Form1.skills[20].skillMod = 0;

            }
            skillLabel20.Text = $"{Form1.skills[20].name}: {Form1.skills[20].skillMod}";
        }

        private void skill20PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[20].skillMod++;
            if (Form1.skills[20].skillMod > 6)
            {
                Form1.skills[20].skillMod = 6;

            }
            skillLabel20.Text = $"{Form1.skills[20].name}: {Form1.skills[20].skillMod}";

        }

        private void skill19MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[19].skillMod--;
            if (Form1.skills[19].skillMod < 0)
            {
                Form1.skills[19].skillMod = 0;

            }
            skillLabel19.Text = $"{Form1.skills[19].name}: {Form1.skills[19].skillMod}";
        }

        private void skill24MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[24].skillMod--;
            if (Form1.skills[24].skillMod < 0)
            {
                Form1.skills[24].skillMod = 0;

            }
            skillLabel24.Text = $"{Form1.skills[24].name}: {Form1.skills[24].skillMod}";
        }

        private void skill18MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[18].skillMod--;
            if (Form1.skills[18].skillMod < 0)
            {
                Form1.skills[1].skillMod = 0;

            }
            skillLabel18.Text = $"{Form1.skills[18].name}: {Form1.skills[18].skillMod}";
        }

        private void skill18PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[18].skillMod++;
            if (Form1.skills[18].skillMod > 6)
            {
                Form1.skills[18].skillMod = 6;

            }
            skillLabel18.Text = $"{Form1.skills[18].name}: {Form1.skills[18].skillMod}";

        }

        private void skill17MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[17].skillMod--;
            if (Form1.skills[17].skillMod < 0)
            {
                Form1.skills[17].skillMod = 0;

            }
            skillLabel17.Text = $"{Form1.skills[17].name}: {Form1.skills[17].skillMod}";
        }

        private void skill17PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[17].skillMod++;
            if (Form1.skills[17].skillMod > 6)
            {
                Form1.skills[17].skillMod = 6;

            }
            skillLabel17.Text = $"{Form1.skills[17].name}: {Form1.skills[17].skillMod}";

        }

        private void skill16MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[16].skillMod--;
            if (Form1.skills[16].skillMod < 0)
            {
                Form1.skills[16].skillMod = 0;

            }
            skillLabel16.Text = $"{Form1.skills[16].name}: {Form1.skills[16].skillMod}";
        }

        private void skill16PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[16].skillMod++;
            if (Form1.skills[16].skillMod > 6)
            {
                Form1.skills[16].skillMod = 6;

            }
            skillLabel16.Text = $"{Form1.skills[16].name}: {Form1.skills[16].skillMod}";
        }

        private void skill15MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[15].skillMod--;
            if (Form1.skills[15].skillMod < 0)
            {
                Form1.skills[15].skillMod = 0;

            }
            skillLabel15.Text = $"{Form1.skills[15].name}: {Form1.skills[15].skillMod}";
        }

        private void skill15PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[15].skillMod++;
            if (Form1.skills[15].skillMod > 6)
            {
                Form1.skills[15].skillMod = 6;

            }
            skillLabel15.Text = $"{Form1.skills[15].name}: {Form1.skills[15].skillMod}";
        }

        private void skill14MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[14].skillMod--;
            if (Form1.skills[14].skillMod < 0)
            {
                Form1.skills[14].skillMod = 0;

            }
            skillLabel14.Text = $"{Form1.skills[14].name}: {Form1.skills[14].skillMod}";
        }

        private void skill14PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[14].skillMod++;
            if (Form1.skills[14].skillMod > 6)
            {
                Form1.skills[14].skillMod = 6;

            }
            skillLabel18.Text = $"{Form1.skills[14].name}: {Form1.skills[14].skillMod}";

        }

        private void skil13MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[13].skillMod--;
            if (Form1.skills[13].skillMod < 0)
            {
                Form1.skills[13].skillMod = 0;

            }
            skillLabel13.Text = $"{Form1.skills[13].name}: {Form1.skills[13].skillMod}";
        }

        private void skill13PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[13].skillMod++;
            if (Form1.skills[13].skillMod > 6)
            {
                Form1.skills[13].skillMod = 6;

            }
            skillLabel13.Text = $"{Form1.skills[13].name}: {Form1.skills[13].skillMod}";
        }

        private void skill12MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[12].skillMod--;
            if (Form1.skills[12].skillMod < 0)
            {
                Form1.skills[12].skillMod = 0;

            }
            skillLabel12.Text = $"{Form1.skills[12].name}: {Form1.skills[12].skillMod}";
        }

        private void skill12PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[12].skillMod++;
            if (Form1.skills[12].skillMod > 6)
            {
                Form1.skills[12].skillMod = 6;

            }
            skillLabel12.Text = $"{Form1.skills[12].name}: {Form1.skills[12].skillMod}";
        }

        private void skill11MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[11].skillMod--;
            if (Form1.skills[11].skillMod < 0)
            {
                Form1.skills[11].skillMod = 0;

            }
            skillLabel11.Text = $"{Form1.skills[11].name}: {Form1.skills[11].skillMod}";
        }

        private void skill11PlusLabels_Click(object sender, EventArgs e)
        {
            Form1.skills[11].skillMod++;
            if (Form1.skills[11].skillMod > 6)
            {
                Form1.skills[11].skillMod = 6;

            }
            skillLabel11.Text = $"{Form1.skills[11].name}: {Form1.skills[11].skillMod}";

        }

        private void skill10MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[10].skillMod--;
            if (Form1.skills[10].skillMod < 0)
            {
                Form1.skills[10].skillMod = 0;

            }
            skillLabel10.Text = $"{Form1.skills[10].name}: {Form1.skills[10].skillMod}";
        }

        private void skill10PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[10].skillMod++;
            if (Form1.skills[10].skillMod > 6)
            {
                Form1.skills[10].skillMod = 6;

            }
            skillLabel10.Text = $"{Form1.skills[10].name}: {Form1.skills[10].skillMod}";
        }

        private void skill9MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[9].skillMod--;
            if (Form1.skills[9].skillMod < 0)
            {
                Form1.skills[9].skillMod = 0;

            }
            skillLabel9.Text = $"{Form1.skills[9].name}: {Form1.skills[9].skillMod}";
        }

        private void skill9PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[9].skillMod++;
            if (Form1.skills[9].skillMod > 6)
            {
                Form1.skills[9].skillMod = 6;

            }
            skillLabel18.Text = $"{Form1.skills[18].name}: {Form1.skills[18].skillMod}";
        }

        private void skill8MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[8].skillMod--;
            if (Form1.skills[8].skillMod < 0)
            {
                Form1.skills[8].skillMod = 0;

            }
            skillLabel8.Text = $"{Form1.skills[8].name}: {Form1.skills[8].skillMod}";
        }

        private void skill8PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[8].skillMod++;
            if (Form1.skills[8].skillMod > 6)
            {
                Form1.skills[8].skillMod = 6;

            }
            skillLabel8.Text = $"{Form1.skills[8].name}: {Form1.skills[8].skillMod}";
        }

        private void skill7MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[7].skillMod--;
            if (Form1.skills[7].skillMod < 0)
            {
                Form1.skills[7].skillMod = 0;

            }
            skillLabel7.Text = $"{Form1.skills[7].name}: {Form1.skills[7].skillMod}";
        }

        private void skill7PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[7].skillMod++;
            if (Form1.skills[7].skillMod > 6)
            {
                Form1.skills[7].skillMod = 6;

            }
            skillLabel7.Text = $"{Form1.skills[7].name}: {Form1.skills[7].skillMod}";
        }

        private void skil6MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[6].skillMod--;
            if (Form1.skills[6].skillMod < 0)
            {
                Form1.skills[6].skillMod = 0;

            }
            skillLabel6.Text = $"{Form1.skills[6].name}: {Form1.skills[6].skillMod}";
        }

        private void skill6PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[6].skillMod++;
            if (Form1.skills[6].skillMod > 6)
            {
                Form1.skills[6].skillMod = 6;

            }
            skillLabel6.Text = $"{Form1.skills[6].name}: {Form1.skills[6].skillMod}";
        }

        private void skill5MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[5].skillMod--;
            if (Form1.skills[5].skillMod < 0)
            {
                Form1.skills[5].skillMod = 0;

            }
            skillLabel5.Text = $"{Form1.skills[5].name}: {Form1.skills[5].skillMod}";
        }

        private void skill5PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[5].skillMod++;
            if (Form1.skills[5].skillMod > 6)
            {
                Form1.skills[5].skillMod = 6;

            }
            skillLabel5.Text = $"{Form1.skills[5].name}: {Form1.skills[5].skillMod}";
        }

        private void skill4MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[4].skillMod--;
            if (Form1.skills[4].skillMod < 0)
            {
                Form1.skills[4].skillMod = 0;

            }
            skillLabel4.Text = $"{Form1.skills[4].name}: {Form1.skills[4].skillMod}";
        }

        private void skill4PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[4].skillMod++;
            if (Form1.skills[4].skillMod > 6)
            {
                Form1.skills[4].skillMod = 6;

            }
            skillLabel4.Text = $"{Form1.skills[4].name}: {Form1.skills[4].skillMod}";
        }

        private void skill3MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[3].skillMod--;
            if (Form1.skills[3].skillMod < 0)
            {
                Form1.skills[3].skillMod = 0;

            }
            skillLabel3.Text = $"{Form1.skills[3].name}: {Form1.skills[3].skillMod}";
        }

        private void skill3PlusLabel_Click(object sender, EventArgs e)
        {

            Form1.skills[3].skillMod++;
            if (Form1.skills[3].skillMod > 6)
            {
                Form1.skills[3].skillMod = 6;

            }
            skillLabel3.Text = $"{Form1.skills[3].name}: {Form1.skills[3].skillMod}";
        }

        private void skill2MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[2].skillMod--;
            if (Form1.skills[2].skillMod < 0)
            {
                Form1.skills[2].skillMod = 0;

            }
            skillLabel2.Text = $"{Form1.skills[2].name}: {Form1.skills[2].skillMod}";
        }

        private void skill2PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[2].skillMod++;
            if (Form1.skills[2].skillMod > 6)
            {
                Form1.skills[2].skillMod = 6;

            }
            skillLabel2.Text = $"{Form1.skills[2].name}: {Form1.skills[2].skillMod}";

        }

        private void skill1MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[1].skillMod--;
            if (Form1.skills[1].skillMod < 0)
            {
                Form1.skills[1].skillMod = 0;

            }
            skillLabel1.Text = $"{Form1.skills[1].name}: {Form1.skills[1].skillMod}";
        }

        private void skill1PlusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[1].skillMod++;
            if (Form1.skills[1].skillMod > 6)
            {
                Form1.skills[1].skillMod = 6;

            }
            skillLabel1.Text = $"{Form1.skills[1].name}: {Form1.skills[1].skillMod}";
        }

        private void skill0MinusLabel_Click(object sender, EventArgs e)
        {
            Form1.skills[0].skillMod--;
            if (Form1.skills[0].skillMod < 0)
            {
                Form1.skills[0].skillMod = 0;

            }
            skillLabel0.Text = $"{Form1.skills[0].name}: {Form1.skills[0].skillMod}";
        }

        private void skill0PlusButton_Click(object sender, EventArgs e)
        {
            Form1.skills[0].skillMod++;
            if (Form1.skills[0].skillMod > 6)
            {
                Form1.skills[0].skillMod = 6;

            }
            skillLabel0.Text = $"{Form1.skills[0].name}: {Form1.skills[0].skillMod}";
        }

        private void skill48PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill49PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill48MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill49MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill47MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill47PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill46MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill46PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill45MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill45PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill44MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill44PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill43MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill43PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill42MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill42PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill41MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill41PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill40MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill40PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill39MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill39PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill38MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill38PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill37MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill37PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill36MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill36PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill35MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill35PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill34MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill34PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill33MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill33PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill32MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill32PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill31MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill31PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill30MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill30PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill29MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill29PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill28MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill28PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill27MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill27PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill26MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill26PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill25MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skil25PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill63PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill65PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill64MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill64PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill63MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill65MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill62MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill62PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill061MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill61PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill60MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill60PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill59MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill59PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill58MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill58PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill57MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill57PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill56MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill56PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill55MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill55PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill54MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill54PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill53MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill53PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill52MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill52PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill51MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill51PlusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill50MinusLabel_Click(object sender, EventArgs e)
        {

        }

        private void skill50PlusLabel_Click(object sender, EventArgs e)
        {

        }

        //saves skills in an xml file
        private void nextButton_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("skills.xml");
            writer.WriteStartElement("skills");
            foreach (Skill skl in Form1.skills)
            {
                writer.WriteStartElement("name");
                writer.WriteString(skl.name);
                writer.WriteEndElement();

                writer.WriteStartElement("skill");

                writer.WriteAttributeString("stat", skl.statName);
                writer.WriteAttributeString("bonus", $"{skl.skillMod}");

                writer.WriteEndElement();

            }
            writer.WriteEndElement();

            writer.Close();

            //opens characterScreen
            this.Controls.Clear();
            characterScreen cs = new characterScreen();

            this.Controls.Add(cs);
        }
    }
}
