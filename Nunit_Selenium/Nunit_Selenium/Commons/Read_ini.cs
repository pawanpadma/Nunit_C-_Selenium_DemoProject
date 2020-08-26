using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Nunit_Selenium.Commons {

    public class Read_ini {
        private IniData read;

        public Read_ini(string fileName) {
            if (!File.Exists(fileName)) {
                throw new IOException("File " + fileName + "does not exist");
            }
            IniParser.FileIniDataParser parser = new FileIniDataParser();
            read = parser.ReadFile(fileName);
        }

        public string GetProperty(string section, string key) {
            KeyDataCollection data = read[section];
            return data[key];
        }
    }
}