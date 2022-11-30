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

namespace Lecture_17_Prog_122_F22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        ObservableCollection<User> users = new ObservableCollection<User>();

        public MainWindow()
        {
            InitializeComponent();
            //List<User> users = new List<User>();
            users.Add(new User { Name = "Will", Age = "39" , CSIGrade = 52, GenEdGrade = 70 });
            users.Add(new User { Name = "Hannah", Age = "28", CSIGrade = 100, GenEdGrade = 90 });
            users.Add(new User { Name = "Kristyn", Age = "28", CSIGrade = 95, GenEdGrade = 100 });

            lvTest.ItemsSource = users;
            cmbDropDown.ItemsSource = users;

        }

        private void btnAddData_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User { Name = "Sam", Age = "22" });
        } // btnAddData_Click

        private void cmbDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cmbDropDown.SelectedIndex.ToString());
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public int CSIGrade { get; set; }
        public int GenEdGrade { get; set; }

        public double Average
        {
            get => GradeAverage();
        }

        public double GradeAverage()
        {
            return (CSIGrade + GenEdGrade) / 2.0;
        }
    }
}
