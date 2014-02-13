using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Noten
{
    class FirstStart
    {
        string file;
        string languageFile;
        string sourceFolder;

        public FirstStart()
        {
            if(testFirstStart())
            {
                CreateSettings();
                CreateLanguage();
            }
        }

        private bool testFirstStart()
        {
            //AppData Folder einstellen
            sourceFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kaizi99/";

            //Datei auswählen
            file = sourceFolder + "settings.settings";
            if (!File.Exists(file))
            {
                //Ordner dür die SETTINGS und LANGUAGE Dateien erstellen
                Directory.CreateDirectory(sourceFolder);
                return true;
            }
            return false;
        }

        //Settings mit Standartwerten werden erstellt
        private void CreateSettings()
        {
            //Streamwriter zum schreiben der Datei wird erstellt
            StreamWriter sw = new StreamWriter(file);

            //Datei wird mit Werten gefüllt
            sw.WriteLine(92);
            sw.WriteLine(86);
            sw.WriteLine(63);
            sw.WriteLine(50);
            sw.WriteLine(25);
            sw.WriteLine(2);

            //Datei wird abgespeichert
            sw.Close();
        }

        private void CreateLanguage()
        {
            //Deutsche Srpachdatei erstellen

            //Zu speichernde LANGUAGE Datei wird ausgewählt
            languageFile = sourceFolder + "deutsch.language";

            //Streamwriter zum schreiben der Datei wird erstellt
            StreamWriter sw = new StreamWriter(languageFile);

            //Datei wird mit Werten gefüllt
            sw.WriteLine("Prozent 1");
            sw.WriteLine("Prozent 2");
            sw.WriteLine("Prozent 3");
            sw.WriteLine("Prozent 4");
            sw.WriteLine("Prozent 5");
            sw.WriteLine("Rechnen");
            sw.WriteLine("Speichern");
            sw.WriteLine("Deutsch");
            sw.WriteLine("Englisch");
            sw.WriteLine("Menü");
            sw.WriteLine("Optionen");
            sw.WriteLine("Schließen");
            sw.WriteLine("Über");
            sw.WriteLine("Sprache");
            sw.WriteLine("Erreichte Punktzahl");
            sw.WriteLine("Volle Punktzahl");

            //Datei wird abgespeichert
            sw.Close();

            //Englische Sprachdatei erstellen

            //Zu speichernde LANGUAGE Datei wird ausgewählt
            languageFile = sourceFolder + "english.language";

            //Streamwriter zum schreiben der Datei wird erstellt
            StreamWriter sw2 = new StreamWriter(languageFile);

            //Datei wird mit Werten gefüllt
            sw2.WriteLine("Percent 1");
            sw2.WriteLine("Percent 2");
            sw2.WriteLine("Percent 3");
            sw2.WriteLine("Percent 4");
            sw2.WriteLine("Percent 5");
            sw2.WriteLine("Calculate");
            sw2.WriteLine("Save");
            sw2.WriteLine("German");
            sw2.WriteLine("English");
            sw2.WriteLine("Menu");
            sw2.WriteLine("Options");
            sw2.WriteLine("Quit");
            sw2.WriteLine("About");
            sw2.WriteLine("Language");
            sw2.WriteLine("Achieved Points");
            sw2.WriteLine("Full Points");

            //Datei wird abgespeichert
            sw2.Close();
        }
    }
}
