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

namespace Microsoft.VisualStudio.Setup.Samples.OfflineLayout
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var cmd = new StringBuilder("vs_community.exe");

            cmd.Append($" --layout {LayoutFolder.Text} ");

            foreach (Workload workload in WorkloadsControl.SelectedItems)
            {
                cmd.Append($"--add {workload.ID} ");
            }

            foreach(Language language in LanguageControl.SelectedItems)
            {
                cmd.Append($"--lang {language.ID} ");
            }

            MessageBox.Show(cmd.ToString());
        }

        private void FolderOpenButton(object sender, RoutedEventArgs e)
        {
            var folderDialog = new Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog();

            folderDialog.Title = "Select layout folder";
            folderDialog.IsFolderPicker = true;
            folderDialog.EnsurePathExists = true;
            if (folderDialog.ShowDialog() == WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok)
            {
                LayoutFolder.Text = folderDialog.FileName;
            }
        }
    }
}
