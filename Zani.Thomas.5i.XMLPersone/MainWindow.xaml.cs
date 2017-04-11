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
using System.Linq;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace Zani.Thomas._5i.XMLPersone
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            XElement dati = XElement.Load("Persone.xml");
            IEnumerable<XElement> tuttepersone = dati.Elements("Persona");

            ObservableCollection<Persona> Lista = new ObservableCollection<Persona>();

            foreach(var ogg in tuttepersone)
            {
                Lista.Add(new Persona(ogg));
            }

            DAtti.ItemsSource = Lista;
        }

        

    }
}
