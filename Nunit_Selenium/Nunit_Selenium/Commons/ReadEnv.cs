using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nunit_Selenium.Commons {

    public class ReadEnv {
        public static IniData read;
        public static Read_ini env;

        public static string ReadData(string section, string key) {
            env = new Read_ini(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"ConfigurationFiles\Config.ini"));
            string envType = env.GetProperty("environment", "environmentType");
            if (envType.Equals("dev", StringComparison.OrdinalIgnoreCase)) {
                IniParser.FileIniDataParser parser = new FileIniDataParser();
                read = parser.ReadFile(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"ConfigurationFiles\Dev.ini"));
            } else if (envType.Equals("qa", StringComparison.OrdinalIgnoreCase)) {
                IniParser.FileIniDataParser parser = new FileIniDataParser();
                read = parser.ReadFile(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"ConfigurationFiles\Qa.ini"));
            } else if (envType.Equals("staging", StringComparison.OrdinalIgnoreCase)) {
                IniParser.FileIniDataParser parser = new FileIniDataParser();
                read = parser.ReadFile(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"ConfigFiles\Staging.ini"));
            }
            KeyDataCollection data = read[section];
            return data[key];
        }

        //public string GetProperty(string section, string key)
        //{
        //    KeyDataCollection data = read[section];
        //    return data[key];
        //}
    }
}