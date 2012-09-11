using System.Linq;

namespace WpfApplication2
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            listbox.ItemsSource = Enumerable.Range(1, 3);
        }

        /*
         * THE ISSUE THAT I'M HAVING IS THAT THESE EVENTS DON'T FIRE WHEN A FILE IS DROPPED FROM WINDOWS EXPLORER!!!
         */

        private void ThisDrop(object sender, System.Windows.DragEventArgs e)
        {
            // do something
        }

        private void ThatDrop(object sender, System.Windows.DragEventArgs e)
        {
            // do something else
        }
    }
}
