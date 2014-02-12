using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Noten
{
    public class Settings
    { 
        /* 
         * Klasee zum auslesen der Settings Datei
         * Reihenfolge der Einstellungen:
         * 1 - 5 = Prozentzahlen für die Noten" bi, beginnend bei der Note "Sehr Gut "MangelHAFT"
         * 6 = Sprache
         */

        /*
         * 
         * 
         * 
         * 
         */ 

        public Settings()
        {
            loadSettings();
        }

        //Prozentzahlen
        float p1, p2, p3, p4, p5;

        //Sprache 1=Deutsch 2=Englisch
        int language;

        //Datei in der die Settings stehen
        string file;
        string languageFile;
        string sourceFolder;

        //Arrays für die Sprache
        string[] languageStrings;

        //Einstellungen laden
        private void loadSettings()
        {
            //AppData Folder einstellen
            sourceFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/kaizi99/";

            //Datei auswählen
            file = sourceFolder + "settings.settings";
            StreamReader sr = new StreamReader(file);

            //Prozentzahlen auslesen
            p1 = float.Parse(sr.ReadLine());
            p2 = float.Parse(sr.ReadLine());
            p3 = float.Parse(sr.ReadLine());
            p4 = float.Parse(sr.ReadLine());
            p5 = float.Parse(sr.ReadLine());

            //Sprache auslesen
            language = int.Parse(sr.ReadLine());

            sr.Close();

            //Sprache laden, momentan wegen Bugs auskommentiert
            //loadLanguage();
        }

        //Sprache laden
        private void loadLanguage()
        {
            if (language == 1)
            {
                //Deutsche Language Datei laden
                languageFile = sourceFolder + "deutsch.language";
                StreamReader sr = new StreamReader(languageFile);

                int counter = 0;
                while ((languageStrings[counter] = sr.ReadLine()) != null)
                {
                    counter++;
                }
            }
            else if (language == 2)
            {
                //Englische Language Datei laden
                languageFile = sourceFolder + "english.language";
                StreamReader sr = new StreamReader(languageFile);

                int counter = 0;
                while ((languageStrings[counter] = sr.ReadLine()) != null)
                {
                    counter++;
                }
            }
        }

        public float getSetting(int settingIndex)
        {
            //Variable Settings einen Wert zuweisen
            int settings = 0;

            //Der settings Variable einen durch settingIndex bestimmten Wert zuweisen
            switch(settingIndex)
            {
                case 1:
                    settings = (int)p1;
                    break;
                case 2:
                    settings = (int)p2;
                    break;
                case 3:
                    settings = (int)p3;
                    break;
                case 4:
                    settings = (int)p4;
                    break;
                case 5:
                    settings = (int)p5;
                    break;
                case 6:
                    settings = language;
                    break;
            }

            //Wert, der zuvor durch settingIndex ausgewählt wurde zurückgeben
            return settings;
        }

        //Sprach-Strings zurückgeben
        public string[] getLanguage()
        {
            return languageStrings;
        }

        public void saveSettings(int[] saveSettings)
        {
            //Datei löschen zum neubeschreiben
            File.Delete(file);

            //Datei schreiben auf Grund der Werte von saveSetting
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(saveSettings[0]);
            sw.WriteLine(saveSettings[1]);
            sw.WriteLine(saveSettings[2]);
            sw.WriteLine(saveSettings[3]);
            sw.WriteLine(saveSettings[4]);
            sw.WriteLine(saveSettings[5]);

            //Datei schreiben
            sw.Close();
        }

    }
}
