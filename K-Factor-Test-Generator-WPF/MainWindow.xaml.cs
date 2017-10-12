using K_Factor_Shared;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace K_Factor_Test_Generator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> kvalues;
        private int endValue = 100;

        public MainWindow()
        {
            InitializeComponent();
            this.Title = Constants.AppTitle;
        }
        
        private void CreateGcode_Click(object sender, RoutedEventArgs e)
        {
            int userN, userB, userKS, userKE;

            bool isgood = true;

            if (!int.TryParse(UserNozzle.Text, out userN)) { isgood = false; }
            if (!int.TryParse(UserBed.Text, out userB)) { isgood = false; }
            if (!int.TryParse(UserKStart.Text, out userKS)) { isgood = false; }
            if (!int.TryParse(UserKEnd.Text, out userKE)) { isgood = false; }

            if (!isgood)
            {
                MessageBox.Show("Please check that all entered values are integers.", "Can't continue!");
            }
            else
            {
                Generator g = new Generator();
                var retVal = g.GenerateGCode(userN, userB, userKS, userKE);
                OutputTextBox.IsReadOnly = false;
                OutputTextBox.Text = retVal;
                OutputTextBox.IsReadOnly = true;
                kvalues = g.Kvalues;
                endValue = userKE;
                Save.IsEnabled = true;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = string.Format("KCodeTest-{0}-{1}-{2}-{3}.gcode", UserNozzle.Text, UserBed.Text, UserKStart.Text, UserKEnd.Text);
            saveFileDialog.DefaultExt = ".gcode";
            saveFileDialog.Filter = "GGCODE documents (.gcode)|*.gcode";

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, OutputTextBox.Text);
                OutputInfo info = new OutputInfo(endValue, kvalues);
                info.ShowDialog();
            }
        }

        private void MattLinkButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://mattshub.com/2017/10/02/linear-advance/"));
            e.Handled = true;
        }

        private void SebastianLinkButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Sebastianv650"));
            e.Handled = true;
        }

    }
}
