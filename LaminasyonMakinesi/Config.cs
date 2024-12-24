using Microsoft.VisualBasic.ApplicationServices;
using Sharp7;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace LaminasyonMakinesi
{
    public class Config
    {
        //PLC Tanımlama
        public static S7Client
            Plc = new();
        public static int
            PlcStatu = 0;
        public static string
            PlcIP = "192.168.0.1";
        //SQL Tanımlama
        public static string?
            SqlAdress,
            Server = "localhost",
            Database = "Lamination1",
            User = "sa",
            Password = "realtekno";
        public static SqlConnection?
            SqlConnection;

        public static void LoadConfig()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.xml");

            // Eğer Config.xml yoksa, oluştur
            if (!File.Exists(configPath))
            {
                CreateDefaultConfig(configPath);
            }

            // Config.xml dosyasını oku ve eksik değerleri tamamla
            XDocument config = XDocument.Load(configPath);

            // PLC Ayarları
            PlcIP = GetOrAddValue(config, "PlcLaminationIP", PlcIP);

            // SQL Ayarları
            Server = GetOrAddValue(config, "Server", Server);
            Database = GetOrAddValue(config, "Database", Database);
            User = GetOrAddValue(config, "User", User);
            Password = GetOrAddValue(config, "Password", Password);

            // Config.xml güncellenmişse kaydet
            config.Save(configPath);

        }
        public static void LoadUsersFromDatabase()
        {

            string query = "SELECT Username, Password, Authority FROM Kullanicilar";


                SqlCommand command = new SqlCommand(query, SqlConnection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Globals.Users.Add(new User
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Authority"].ToString()
                    });
            }
        }
        private static string GetOrAddValue(XDocument config, string key, string? defaultValue)
        {
            XElement? element = config.Root?.Element(key);
            if (element == null || string.IsNullOrEmpty(element.Value))
            {
                // Değer yoksa, varsayılanı ekle
                element = new XElement(key, defaultValue);
                config.Root?.Add(element);
            }

            return element.Value;
        }

        private static void CreateDefaultConfig(string path)
        {
            XDocument defaultConfig = new XDocument(
                new XElement("Config",
                    new XElement("PlcLaminationIP", PlcIP),
                    new XElement("Server", Server),
                    new XElement("Database", Database),
                    new XElement("User", User),
                    new XElement("Password", Password)
                )
            );

            defaultConfig.Save(path);
        }
    }
}
