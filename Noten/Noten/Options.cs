using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noten
{
    public partial class Options : Form
    {
        Settings settings;

        public Options()
        {
            InitializeComponent();
        }

        public void setSettings(Settings newSettings)
        {
            settings = newSettings;
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] settingsArray = new int[6];
            bool parseP1 = int.TryParse(textBox2.Text,out settingsArray[0]);
            bool parseP2 = int.TryParse(textBox3.Text,out settingsArray[1]);
            bool parseP3 = int.TryParse(textBox4.Text,out settingsArray[2]);
            bool parseP4 = int.TryParse(textBox5.Text,out settingsArray[3]);
            bool parseP5 = int.TryParse(textBox6.Text,out settingsArray[4]);
            if (comboBox1.Text == "Deutsch")
            {
                settingsArray[5] = 1;
            }
            else
            {
                settingsArray[5] = 2;
            }
            if(parseP1 == true && parseP2 == true && parseP3 == true && parseP4 == true && parseP5 == true)
            {
                settings.saveSettings(settingsArray);
            }
        }



    }
}
