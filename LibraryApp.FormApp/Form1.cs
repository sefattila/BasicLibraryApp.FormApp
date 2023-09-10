using LibraryApp.BLL.BookService;
using LibraryApp.Repository.Concretes;
using LibraryApp.Repository.Interfaces;

namespace LibraryApp.FormApp
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;

        private IBookRepo _bookRepo;
        private IBookService _bookService;
        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _bookRepo = new BookRepo(_context);
            _bookService = new BookService(_bookRepo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookService.GetBooksByName(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookService.GetByAuthorName(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookService.GetByCategory(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookService.OrderByASC(x => x.ReleaseDate);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookService.OrderByASC(x => x.Fiyat);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookService.GetLastTenBook();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookService.GetStockControl();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookService.GetDiscounts();
        }
    }
}