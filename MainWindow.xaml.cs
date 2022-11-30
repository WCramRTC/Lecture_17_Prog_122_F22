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
        List<CheckBox> checkboxes = new List<CheckBox>();

        // Change My List to a different type of collection
        //List<User> users = new List<User>();

        ObservableCollection<User> users = new ObservableCollection<User>();

        public MainWindow()
        {
            InitializeComponent();

            Preload();

            lvUsers.ItemsSource = users;
            lbNumbers.ItemsSource = users;
        }

        public void Preload()
        {
            checkboxes.Add(chkPepperoni);
            checkboxes.Add(chkMushroom);
            checkboxes.Add(chkOlives);
            //PopulateBoxes();

            users.Add(new User()
            {
                Name = "Will",
                Program = "CSI"
            });

            users.Add(new User()
            {
                Name = "Wong",
                Program = "CSI"
            });

            users.Add(new User()
            {
                Name = "Zack",
                Program = "CSI"
            });

            users.Add(new User()
            {
                Name = "Hannah",
                Program = "CSI"
            });
        }

        private void btnDisplayName_Click(object sender, RoutedEventArgs e)
        {
            //DisplayCheckBoxInformation();
            users.Add(new User()
            {
                Name = "Sam",
                Program = "CSI"
            });

        }

        public void DisplayName()
        {
            string fName = txtFName.Text;
            string lName = txtLName.Text;

            rtbDisplay.Text = $"{fName} {lName}";
        } // DisplayName

        // Pepperoni = true
        // Mushroom = false
        // Olives = true
        public void DisplayCheckBoxInformation()
        {
            rtbDisplay.Text = "";
            foreach (CheckBox box in checkboxes)
            {
                rtbDisplay.Text += $"{box.Content} = {box.IsChecked}\n";

            }

        }

        public void PopulateBoxes()
        {
            for (int i = 0; i <= 20; i++)
            {
                lbNumbers.Items.Add(i);
            }
        }

        // Check Box
        // Radio Button
        // ListBox
        // Combo Box

        // ListView

    } // class

    public class User
    {
        public string Name { get; set; }
        public string Program { get; set; }
    }

}
