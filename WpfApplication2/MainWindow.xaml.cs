using System;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using Image = System.Windows.Controls.Image;

namespace WpfApplication2
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            listbox.ItemsSource = Enumerable.Range(1, 3);
        }

        private void DropHandler(object sender, DragEventArgs e)
        {
            var filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            var img = (Image) sender;
            try
            {
                img.Source = new BitmapImage(new Uri(filePaths[0]));
            }
            catch
            {
                // probably not an image file
            }
        }
    }
}
