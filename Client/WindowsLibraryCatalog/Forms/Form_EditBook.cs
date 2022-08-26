using System;
using System.Net.Http;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_EditBook : Form
    {
        public Form_EditBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want edit this book?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;
            var book = new Book()
            {
                Author = txtEditAuthor.Text,
                Title = txtEditTitle.Text,
                Year = Convert.ToInt32(txtEditYear.Text),
                PageCount = Convert.ToInt32(txtEditPageCount.Text),
                PurchaseDate = txtEditPurchaseDate.Text
            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44307/");
            var response = client.PutAsJsonAsync("api/books/"+txtEditId.Text, book).Result;
            MessageBox.Show("Book edit SuccessFully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
