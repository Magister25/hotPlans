using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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



namespace hotPlans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = this;

            // Need to initialize this, otherwise you get a null exception
            //Tasks = new ObservableCollection<string>();            
            
        }


        //public ListView Tasks { get; set; }
        //public ObservableCollection<string> Tasks { get; set; }

        // Add an item to the list        
        //private void Button_Click_Add(object sender, RoutedEventArgs e)
        //{
        //    // Custom control for entering a single string
        //    SingleEntryDialog _Dlg = new SingleEntryDialog();

        //    // OutputBox is a string property of the custom control
        //    if ((bool)_Dlg.ShowDialog())
        //        Tasks.Add(_Dlg.OutputBox.Trim());
        //}

    }
}
