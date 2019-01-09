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
using LibraryProject.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Book book = null;
        public MainWindow()
        {
            InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            book = new Book(1674, "harry Potter", "J. K. Rowling");
            Books.DataContext = book;
        }

    }
}

            /*private void button_click(object sender, RoutedEventArgs e)
            {

                bookWithAuthor.Title = "Harry Potter and the Chamber of Secrets";

            }


        public class BookAuthor : INotifyPropertyChanged
        {
            private int id;
            public int Id
            {
                get { return id; }
                set
                {
                    id = value;
                    onPropertyChanged();
                }
            }
            private string title;
            public string Title
            {
                get { return title; }
                set
                {
                    title = value;
                    onPropertyChanged();
                }
            }
            public string author { get; set; }

            public BookAuthor(Book book, Author author)
            {
                id = book.id;
                title = book.Title;
                this.author = author.firstName + " " + author.lastName;
            }

            public event PropertyChangedEventHandler PropertyChanged;
            private void onPropertyChanged(
                [CallerMemberName] string caller = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(caller));
                }
            }

        }
    }
}
    }
}*/
