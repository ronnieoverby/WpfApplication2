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
