using System.Collections.Generic;
using System.Reflection;
using static Final_Project.LMS;

namespace Final_Project
{
    public partial class LMS : Form
    {

        private List<Book> books = new List<Book>();
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }


        }
        public class People
        {
            public int PeopleID { get; set; }
            public string Name { get; set; }

            public People(int peopleID, string name)
            {
                PeopleID = peopleID;
                Name = name;
            }
        }

        public class Librarian : People
        {
            public bool Subscriber { get; set; }

            public Librarian(int peopleID, string name, bool subscriber) : base(peopleID, name)
            {
                Subscriber = subscriber;
            }
        }
        public class BookCollection : List<Book>
        {
            public BookCollection()
            {
                Add(new Book("The Catcher in the Rye", "J.D. Salinger"));
                Add(new Book("To Kill a Mockingbird", "Harper Lee"));
                Add(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
                Add(new Book("Theory of Gravity", "Stephen Hawking"));
                Add(new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams"));
                Add(new Book("Pride and Prejudice", "Jane Austen"));
                Add(new Book("The Lord of the Rings", "J.R.R. Tolkien"));
                Add(new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling"));
                Add(new Book("1984", "George Orwell"));
                Add(new Book("Brave New World", "Aldous Huxley"));
                Add(new Book("Animal Farm", "George Orwell"));
                Add(new Book("The Picture of Dorian Gray", "Oscar Wilde"));
                Add(new Book("The Adventures of Tom Sawyer", "Mark Twain"));
                Add(new Book("The Adventures of Huckleberry Finn", "Mark Twain"));
                Add(new Book("The Hobbit", "J.R.R. Tolkien"));
                Add(new Book("The Chronicles of Narnia", "C.S. Lewis"));
                Add(new Book("The Cat in the Hat", "Dr. Seuss"));
                Add(new Book("Charlotte's Web", "E.B. White"));
                Add(new Book("A Wrinkle in Time", "Madeleine L'Engle"));
                Add(new Book("The Very Hungry Caterpillar", "Eric Carle"));
            }
        }
        public enum BookList
        {
            The_Catcher_in_the_Rye,
            To_Kill_a_Mockingbird,
            The_Great_Gatsby,
            Pride_and_Prejudice,
            Lord_of_the_Flies,
            Crime_and_Punishment,
            War_and_Peace,
            The_Adventures_of_Tom_Sawyer,
            The_Little_Prince,
            The_Hobbit,
            The_Lord_of_the_Rings,
            The_Chronicles_of_Narnia,
            Frankenstein,
            Wuthering_Heights,
            Dracula,
            Jane_Eyre,
            Alice,
        }
        static int counter;

        public LMS()
        {
            InitializeComponent();
            counter = 0;
            numericUpDown1.Text = counter.ToString();
            numericUpDown1.Refresh();




            dataGridView1.Rows.Add("The Catcher in the Rye");
            dataGridView1.Rows.Add("To Kill a Mockingbird");
            dataGridView1.Rows.Add("The Great Gatsby");
            dataGridView1.Rows.Add("Theory of Gravity");
            dataGridView1.Rows.Add("The Catcher in the Rye");
            dataGridView1.Rows.Add("To Kill a Mockingbird");
            dataGridView1.Rows.Add("The Great Gatsby");
            dataGridView1.Rows.Add("Theory of Gravity");
            dataGridView1.Rows.Add("The Lord of the Rings");


            dataGridView1.Rows[0].Cells[1].Value = "J.D. Salinger";
            dataGridView1.Rows[1].Cells[1].Value = "Harper Lee";
            dataGridView1.Rows[2].Cells[1].Value = "F. Scott Fitzgerald";
            dataGridView1.Rows[3].Cells[1].Value = "Stephen Hawkings";
            dataGridView1.Rows[4].Cells[1].Value = "J.D. Salinger";
            dataGridView1.Rows[5].Cells[1].Value = "Harper Lee";
            dataGridView1.Rows[6].Cells[1].Value = "F. Scott Fitzgerald";
            dataGridView1.Rows[7].Cells[1].Value = "Stephen Hawking";
            dataGridView1.Rows[8].Cells[1].Value = "J.R.R. Tolkien";


            dataGridView1.Rows[0].Cells[2].Value = true;
            dataGridView1.Rows[1].Cells[2].Value = false;
            dataGridView1.Rows[2].Cells[2].Value = true;
            dataGridView1.Rows[3].Cells[2].Value = true;
            dataGridView1.Rows[4].Cells[2].Value = false;
            dataGridView1.Rows[5].Cells[2].Value = true;
            dataGridView1.Rows[6].Cells[2].Value = true;
            dataGridView1.Rows[7].Cells[2].Value = false;


            dataGridView1.Rows.Add("The Catcher in the Rye", "J.D. Salinger", true);
            dataGridView1.Rows.Add("To Kill a Mockingbird", "Harper Lee", false);
            dataGridView1.Rows.Add("The Great Gatsby", "F. Scott Fitzgerald", true);
            dataGridView1.Rows.Add("Theory of Gravity", "Stephen Hawking", true);

            List<People> peopleList = new List<People>
            {
                new People(1001, "John Smith"),
                new People(1002, "Jane Doe"),
                new People(1003, "Bob Johnson"),
                new Librarian(1004, "Sarah Williams", true),
                new People(1005, "Tom Davis"),
                new People(1006, "Emily Lee"),
                new Librarian(1007, "David Wilson", false),
                new People(1008, "Megan Brown"),
                new People(1009, "Mark Taylor"),
                new Librarian(1010, "Anna Garcia", true),
                new People(1011, "Brian Lee"),
                new People(1012, "Jessica Kim"),
                new People(1013, "Michael Chen"),
                new People(1014, "Olivia Nguyen"),
                new People(1015, "Andrew Hernandez"),
                new People(1016, "Sophia Martinez"),
                new People(1017, "William Lee"),
                new People(1018, "Ella Kim"),
                new People(1019, "David Kim"),
                new People(1020, "Jasmine Park")
            };

            foreach (People person in peopleList)
            {
                int rowIndex = PeopleGrid.Rows.Add();
                DataGridViewRow row = PeopleGrid.Rows[rowIndex];
                row.Cells[0].Value = person.PeopleID;
                row.Cells[1].Value = person.Name;
            }



            PeopleGrid.Rows[0].Cells[2].Value = true;
            PeopleGrid.Rows[1].Cells[2].Value = false;
            PeopleGrid.Rows[2].Cells[2].Value = true;
            PeopleGrid.Rows[3].Cells[2].Value = true;
            PeopleGrid.Rows[4].Cells[2].Value = false;
            PeopleGrid.Rows[5].Cells[2].Value = true;
            PeopleGrid.Rows[6].Cells[2].Value = true;
            PeopleGrid.Rows[7].Cells[2].Value = false;
            PeopleGrid.Rows[8].Cells[2].Value = false;
            PeopleGrid.Rows[9].Cells[2].Value = false;
            PeopleGrid.Rows[10].Cells[2].Value = false;
            PeopleGrid.Rows[11].Cells[2].Value = false;
            PeopleGrid.Rows[12].Cells[2].Value = true;


            List<string> featuredBooks = new List<string>();
            Random random = new Random();
            int count = 0;
            while (count < 5)
            {
                int index = random.Next(dataGridView1.Rows.Count);
                if (dataGridView1.Rows[index].Cells[0].Value != null)
                {
                    string bookName = dataGridView1.Rows[index].Cells[0].Value.ToString();

                    string authorName = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    if (featuredBooks.Contains(bookName))
                    {
                        continue;
                    }
                    featuredBooks.Add(bookName);
                    count++;
                }

            }


            foreach (string book in featuredBooks)
            {
                Featured.Items.Add(book);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Featured_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchString = SearchBar.Text;
            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchString))
                    {
                        cell.Style.BackColor = Color.Yellow;
                        found = true;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("No matching cells found.");
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Reserve_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            switch (dataGridView1.Rows[index].Cells[2].Value)
            {
                case false:
                    {
                        dataGridView1.Rows[index].Cells[2].Value = true;
                        string bookName = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        listBox1.Items.Add(bookName);
                        counter++;
                        numericUpDown1.Refresh();
                        MessageBox.Show("The book has been reserved.");
                        break;
                    }

                default:
                    MessageBox.Show("The book is already reserved.");
                    numericUpDown1.Refresh();

                    break;
            }
            numericUpDown1.Refresh();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Refresh();
            if (listBox1.SelectedIndex != -1)
            {
                string selectedBook = listBox1.SelectedItem.ToString();

                numericUpDown1.Text = counter.ToString();
            }
        }

        private void numericUpDown1_TextChanged(object sender, EventArgs e)
        {
            numericUpDown1.Text = counter.ToString();
            numericUpDown1.Refresh();

        }

        private void PeopleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<People> peopleList = new List<People>
            {
                new People(1001, "John Smith"),
                new People(1002, "Jane Doe"),
                new People(1003, "Bob Johnson"),
                new Librarian(1004, "Sarah Williams", true),
                new People(1005, "Tom Davis"),
                new People(1006, "Emily Lee"),
                new Librarian(1007, "David Wilson", false),
                new People(1008, "Megan Brown"),
                new People(1009, "Mark Taylor"),
                new Librarian(1010, "Anna Garcia", true),
                new People(1011, "Brian Lee"),
                new People(1012, "Jessica Kim"),
                new People(1013, "Michael Chen"),
                new People(1014, "Olivia Nguyen"),
                new People(1015, "Andrew Hernandez"),
                new People(1016, "Sophia Martinez"),
                new People(1017, "William Lee"),
                new People(1018, "Ella Kim"),
                new People(1019, "David Kim"),
                new People(1020, "Jasmine Park")
            };

            DataGridViewRow selectedRow = PeopleGrid.Rows[e.RowIndex];
            People selectedPerson = peopleList[e.RowIndex];

            // Set the values of the cells in the row based on the selected person
            selectedRow.Cells[0].Value = selectedPerson.PeopleID;
            selectedRow.Cells[1].Value = selectedPerson.Name;


            // If the selected person is a librarian, update the subscribed checkbox
            if (selectedPerson is Librarian)
            {
                Librarian selectedLibrarian = (Librarian)selectedPerson;
                selectedRow.Cells[2].Value = selectedLibrarian.Subscriber;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unreserve_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedBook = listBox1.SelectedItem.ToString();
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == selectedBook)
                    {
                        bool isChecked = (bool)row.Cells[2].Value;
                        if (isChecked)
                        {
                            row.Cells[2].Value = false;
                            dataGridView1.Refresh();
                            listBox1.Items.Remove(selectedBook);
                        }
                        else
                        {
                            MessageBox.Show("The book is already unreserved");
                        }
                        return;
                    }
                }
                MessageBox.Show("The book was not found");
            }
            else
            {
                MessageBox.Show("Please select a book to unreserve");
            }
        }
    }
}