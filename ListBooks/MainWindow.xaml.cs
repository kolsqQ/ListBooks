using ListBooks.View;
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

namespace ListBooks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Book> Books { get; set; }
        public Book SelectedBook { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            Books = new ObservableCollection<Book>();
            DataContext = this;

        }


        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            var addEditWindow = new AddEditBook();
            addEditWindow.ShowDialog();
            Books.Add(addEditWindow.Book);


        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {

           var addEditWindow = new AddEditBook(SelectedBook);
           addEditWindow.ShowDialog();
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
           Books.Remove(SelectedBook);
        }
    }
}
