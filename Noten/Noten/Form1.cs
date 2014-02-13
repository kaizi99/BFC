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
    public partial class Form1 : Form
    {
        Settings settings;
        public Form1()
        {
            InitializeComponent();
        }

        public void setLanguage()
        {
            settings.loadSettings();
            string[] Language = settings.getLanguage();
            label1.Text = Language[14];
            label2.Text = Language[15];
            button1.Text = Language[5];
            menüToolStripMenuItem.Text = Language[9];
            schließenToolStripMenuItem.Text = Language[11];
            optionenToolStripMenuItem.Text = Language[10];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settings = new Settings();
            setLanguage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int erreichtePunktzahl;
            int gesamtPunktzahl;
            int prozent;
            int note;

            erreichtePunktzahl = int.Parse(textBox1.Text);
            gesamtPunktzahl = int.Parse(textBox2.Text);

            float floatProzent = (float)erreichtePunktzahl / (float)gesamtPunktzahl * 100;

            prozent = (int)floatProzent;

            note = noteErrechnen(prozent);

            MessageBox.Show("Note: " + note + Environment.NewLine + "Prozent: " + prozent, "ERGEBNIS");
        }

        private int noteErrechnen(int prozent)
        {
            int p1 = (int)settings.getSetting(1);
            int p2 = (int)settings.getSetting(2);
            int p3 = (int)settings.getSetting(3);
            int p4 = (int)settings.getSetting(4);
            int p5 = (int)settings.getSetting(5);
            if (prozent >= p1)
            {
                return 1;
            }
            if (prozent < p1 && prozent >= p2)
            {
                return 2;
            }
            if(prozent < p2 && prozent >= p3)
            {
                return 3;
            }
            if(prozent < p3 && prozent >= p4)
            {
                return 4;
            }
            if(prozent < p4 && prozent >= p5)
            {
                return 5;
            }
            if(prozent < p5)
            {
                return 6;
            }
            return 0;
        }
        private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options(this);
            options.setSettings(settings);
            options.ShowDialog();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
