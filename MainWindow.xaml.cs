/*-------------------------------------------------------
Name:Ryan Daly
Student Number: S00237889
Date: 26/02/2024
Program Purpose: Repeat Exam 2024 Object Oriented Programming
w
---------------------------------------------------------*/
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static oopRepeat.Book;

namespace oopRepeat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetData();

        }

        private void GetData()
        {



            Book b1 = new Book()
            {
                Title = "The Book of Why",
                PublishDate = new DateTime(2018, 1, 1),
                Cost = 13.99m,
                Author = "Judea Pearl",
                Genre = BookType.Tech,
                Description = "A Turing Award-winning computer scientist and statistician shows how understanding causality has revolutionized science and will revolutionize artificial intelligence"
            };

            Book b2 = new Book()
            {
                Title = "The Black Box Society",
                PublishDate = new DateTime(2014, 11, 17),
                Cost = 23.12m,
                Author = "Frank Pasquale",
                Genre = BookType.Tech,
                Description = "Every day, corporations are connecting the dots about our personal behavior―silently scrutinizing clues left behind by our work habits and Internet use. The data compiled and portraits created are incredibly detailed, to the point of being invasive. But who connects the dots about what firms are doing with this information? "
            };

            Book b3 = new Book()
            {
                Title = "Weapons of Math Destruction",
                PublishDate = new DateTime(2016, 9, 6),
                Cost = 21.99m,
                Author = "Cathy O Neil",
                Genre = BookType.Tech,
                Description = "We live in the age of the algorithm. Increasingly, the decisions that affect our lives--where we go to school, whether we can get a job or a loan, how much we pay for health insurance--are being made not by humans, but by machines. In theory, this should lead to greater fairness: Everyone is judged according to the same rules"
            };

            Book b4 = new Book()
            {
                Title = "Machines Like Me",
                PublishDate = new DateTime(2019, 4, 18),
                Cost = 13.99m,
                Author = "Ian McEwan",
                Genre = BookType.Fiction,
                Description = "Britain has lost the Falklands war, Margaret Thatcher battles Tony Benn for power and Alan Turing achieves a breakthrough in artificial intelligence. In a world not quite like this one, two lovers will be tested beyond their understanding.e"
            };

            Book b5 = new Book()
            {
                Title = "The Handmaids Tale",
                PublishDate = new DateTime(1985, 1, 1),
                Cost = 15.99m,
                Author = "Margaret Atwood",
                Genre = BookType.Fiction,
                Description = "Funny, unexpected, horrifying, and altogether convincing, The Handmaid's Tale is at once scathing satire, dire warning, and tour de force."
            };

            Book b6 = new Book()
            {
                Title = "Artificial Intelligence: A Modern Approach",
                PublishDate = new DateTime(1994, 12, 13),
                Cost = 25.99m,
                Author = "Stuart Russell",
                Genre = BookType.NonFiction,
                Description = "For one or two-semester, undergraduate or graduate-level courses in Artificial Intelligence. The long-anticipated revision of this best-selling text offers the most comprehensive, up-to-date introduction to the theory and practice of artificial intelligence."
            };
            lbxBooks.Items.Add(b1.Title + " - " + b1.Author);
            lbxBooks.Items.Add(b2.Title + " - " + b2.Author);
            lbxBooks.Items.Add(b3.Title + " - " + b3.Author);
            lbxBooks.Items.Add(b4.Title + " - " + b4.Author);
            lbxBooks.Items.Add(b5.Title + " - " + b5.Author);
            lbxBooks.Items.Add(b6.Title + " - " + b6.Author);



        }
       
        private void lbxBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //check what book is selected
            Book selected = lbxBooks.SelectedItem as Book;
            //checking for null
            if (selected != null)
            {
                //update the text blocks 
                //textblocks arent updating
                tblkDes.Text = selected.Description;
                tblkCost.Text = selected.Cost.ToString();
                tblkYear.Text = selected.PublishDate.ToString();
            }
            
        }

        //moving from all books to selected books
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lbxBooks.SelectedItem != null)
            {
                //tried to use textblocks but they wouldnt update even when books were selected
                lbxSelectedBooks.Items.Add(lbxBooks.SelectedItem);
                lbxBooks.Items.Remove(lbxBooks.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected");
            }

        }
        //moving from selected books to all books

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbxSelectedBooks.SelectedItem != null)
            {
                lbxBooks.Items.Add(lbxSelectedBooks.SelectedItem);
                lbxSelectedBooks.Items.Remove(lbxSelectedBooks.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected");
            }
        }
        //methods for filtering functionality

        private void radioAll_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void radioFiction_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioTech_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioNonFiction_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

