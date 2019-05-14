using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
//using System.Data.SQLite;

namespace Wpf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Text Text;
        public MainWindow()
        {
            InitializeComponent();
            Text = new Text();
            DataContext = Text;
            //GenerateDatabase();
        }

        public void GenerateDatabase()
        {
            /*SQLiteConnection.CreateFile("inhalt.sqlite");
            SQLiteConnection SqLiteConnection = new SQLiteConnection("Data Source = inhalt.sqlite; Version=3;");
            SqLiteConnection.Open();

            string sql = "CREATE TABLE texte(id integer primary key autoincrement, textinhalt TEXT, textfarben TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, SqLiteConnection);
            command.ExecuteNonQuery();
            */

        }
        


        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            // *************************************************************************
            // Hiermit können wir unsere Daten in eine Datenbank speichern, wichtig dabei ist die Parametrisierung
            // der zu speichernden Werte (siehe SQL-Injection)
            // Aufgrund der Dateigröße musste ich das NuGet Paket : "System.Data.SQLite.Core" leider entfernen
            // bitte das NuGet Paket installieren, um diesen Code auszuführen
            // *************************************************************************s
            
            /*SQLiteConnection SqLiteConnection = new SQLiteConnection("Data Source = inhalt.sqlite; Version=3;");
            SqLiteConnection.Open();

            string sql = "INSERT INTO texte(textinhalt, textfarben) VALUES (@textinhalt, @textfarbe)";
            SQLiteCommand command = new SQLiteCommand(sql, SqLiteConnection);
            command.Parameters.Add("@textinhalt", System.Data.DbType.String).Value = Text.TextInhalt;
            command.Parameters.Add("@textfarbe", System.Data.DbType.String).Value = Text.TextFarbe;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            */
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "inhalt.xml";
            saveFileDialog.Filter = "Textdatei|*.xml";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.RestoreDirectory = true;
            if ((bool)saveFileDialog.ShowDialog())
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate)))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Text));
                    xmlSerializer.Serialize(binaryWriter.BaseStream, Text);
                }
            }
        }

        private void Oeffnen_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "inhalt.xml";
            openFileDialog.Filter = "Textdatei|*.xml";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.RestoreDirectory = true;
            if ((bool)openFileDialog.ShowDialog())
            {
                using (BinaryReader binaryReader = new BinaryReader(File.Open(openFileDialog.FileName, FileMode.OpenOrCreate)))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Text));
                    Text = (Text)xmlSerializer.Deserialize(binaryReader.BaseStream);
                    DataContext = Text;
                }
            }
        }
    }
}
