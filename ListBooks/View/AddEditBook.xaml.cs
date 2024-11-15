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
using System.Windows.Shapes;

namespace ListBooks.View
{
    /// <summary>
    /// Логика взаимодействия для AddEditBook.xaml
    /// </summary>
    public partial class AddEditBook : Window
    {
        public Book Book { get; set; }

        public AddEditBook(Book book = null)
        {
            InitializeComponent();
            DataContext = this;
            Book = book ?? new Book();
        }


        private void Save(object sender, RoutedEventArgs e)
        {
            if (Book.YearRelese == null || Book.Genre == null || Book.Author == null || Book.Name == null || Book.PageCount == null)
            {
                MessageBox.Show("Введите данные книги");
            }
            else
            {
                DialogResult = true;
                Close();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

    }
}
