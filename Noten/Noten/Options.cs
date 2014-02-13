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

        bool setLanguageClose;

        Form1 form1;

        public Options(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        public void setSettings(Settings newSettings)
        {
            settings = newSettings;
        }

        private void setLanguage()
        {
            string[] Language = settings.getLanguage();
            label1.Text = Language[13];
            label2.Text = Language[0];
            label3.Text = Language[1];
            label4.Text = Language[2];
            label5.Text = Language[3];
            label6.Text = Language[4];
            button1.Text = Language[6];
        }

        private void Options_Load(object sender, EventArgs e)
        {
            textBox2.Text = settings.getSetting(1).ToString();
            textBox3.Text = settings.getSetting(2).ToString();
            textBox4.Text = settings.getSetting(3).ToString();
            textBox5.Text = settings.getSetting(4).ToString();
            textBox6.Text = settings.getSetting(5).ToString();
            string ComboBoxText;
            if(settings.getSetting(6) == 1)
            {
                ComboBoxText = "Deutsch";
            }
            else
            {
                ComboBoxText = "Englisch";
            }
            comboBox1.Text = ComboBoxText;
            setLanguageClose = false;
            setLanguage();
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
            form1.setLanguage();
            setLanguage();
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            setLanguageClose = true;
        }



    }
}
