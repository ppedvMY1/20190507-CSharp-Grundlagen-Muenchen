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
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
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
