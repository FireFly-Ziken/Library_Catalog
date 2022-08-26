using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Net.Http;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        // Update dataGridBook
        public void RefreshDataGridBooks()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44307/");
            var response = client.GetAsync("api/books").Result;
            var book = response.Content.ReadAsAsync<IEnumerable<Book>>().Result;
            dataGridViewBooks.DataSource = book;
        }
        public FormMain()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44307/");
                HttpResponseMessage response = client.GetAsync("api/books").Result;
                var book = response.Content.ReadAsAsync<IEnumerable<Book>>().Result;
                dataGridViewBooks.DataSource = book;
            }
            catch (Exception e)
            {
                MessageBox.Show("There is no connection to the server!?\n\n " + e, "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string date = System.DateTime.Now.ToString("yyyy-MM-dd");
            txtBoxPurchaseDate.Text = date;
        }

        // Filter btn
        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44307/");
            HttpResponseMessage response = client.GetAsync("api/books").Result;
            var book = response.Content.ReadAsAsync<IEnumerable<Book>>().Result;
            if (checkFilterYear.Checked && checkFilterPageCount.Checked)
            {
                var results = book.Where(b => b.Year > Convert.ToInt32(txtFilterYearFrom.Text)
                                              && b.Year < Convert.ToInt32(txtFilterYearTo.Text)
                                              && b.PageCount > Convert.ToInt32(txtFilterPCountFrom.Text)
                                              && b.PageCount < Convert.ToInt32(txtFilterPCountTo.Text));
                dataGridViewBooks.DataSource = results.ToList();
                checkFilterYear.Checked = false;
                checkFilterPageCount.Checked = false;
                return;
            }
            if (checkFilterYear.Checked)
            {
                var results = book.Where(b => b.Year > Convert.ToInt32(txtFilterYearFrom.Text) 
                                              && b.Year < Convert.ToInt32(txtFilterYearTo.Text));
                dataGridViewBooks.DataSource = results.ToList();
                checkFilterYear.Checked = false;
                return;
            }

            if (checkFilterPageCount.Checked)
            {
                var results = book.Where(b => b.PageCount > Convert.ToInt32(txtFilterPCountFrom.Text) 
                                              && b.PageCount < Convert.ToInt32(txtFilterPCountTo.Text));
                dataGridViewBooks.DataSource = results.ToList();
                checkFilterPageCount.Checked = false;
                return;
            }
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (!IsFormValid()) return;
            DialogResult dialog = MessageBox.Show("Are you sure want add this book?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;
            var book = new Book()
            {
                Author = txtBoxAuthor.Text,
                Title = txtBoxTitle.Text,
                Year = Convert.ToInt32(txtBoxYear.Text),
                PageCount = Convert.ToInt32(txtBoxPageCount.Text),
                PurchaseDate = txtBoxPurchaseDate.Text
            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44307/");
            var response = client.PostAsJsonAsync("api/books", book).Result;
            MessageBox.Show("Book Added SuccessFully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBoxAuthor.Clear();
            txtBoxTitle.Clear();
            txtBoxYear.Clear();
            txtBoxPageCount.Clear();
            txtBoxPurchaseDate.Clear();
            RefreshDataGridBooks();
        }

        // Checking the form for completion
        private bool IsFormValid()
        {
            if (txtBoxAuthor.Text.Trim() == string.Empty 
                || txtBoxTitle.Text.Trim() == string.Empty 
                || txtBoxYear.Text.Trim() == string.Empty
                || txtBoxPageCount.Text.Trim() == string.Empty
                || txtBoxPurchaseDate.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want clear this book?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;
            txtBoxAuthor.Clear();
            txtBoxTitle.Clear();
            txtBoxYear.Clear();
            txtBoxPageCount.Clear();
        }

        // Delete Book 
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            //if (!IsFormValid()) return;
            DialogResult dialog = MessageBox.Show("Are you sure want DELETE this book?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44307/");
            HttpResponseMessage response = client.DeleteAsync("api/books/" +txtSelectedId.Text).Result;
            MessageBox.Show("Book Delete SuccessFully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtSelectedAuthor.Clear();
            txtSelectedTitle.Clear();
            txtSelectedYear.Clear();
            txtSelectedPageCount.Clear();
            txtSelectedPurchaseDate.Clear();
            RefreshDataGridBooks();
        }

        // Select Book - Click on dataGrid
        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                {
                    txtSelectedId.Text = dataGridViewBooks.SelectedRows[0].Cells[0].Value.ToString();
                    txtSelectedAuthor.Text = dataGridViewBooks.SelectedRows[0].Cells[1].Value.ToString();
                    txtSelectedTitle.Text = dataGridViewBooks.SelectedRows[0].Cells[2].Value.ToString();
                    txtSelectedYear.Text = dataGridViewBooks.SelectedRows[0].Cells[3].Value.ToString();
                    txtSelectedPageCount.Text = dataGridViewBooks.SelectedRows[0].Cells[4].Value.ToString();
                    txtSelectedPurchaseDate.Text = dataGridViewBooks.SelectedRows[0].Cells[5].Value.ToString();
                }
            };
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            Form_EditBook fw = new Form_EditBook();
            fw.txtEditId.Text = this.txtSelectedId.Text;
            fw.txtEditAuthor.Text = this.txtSelectedAuthor.Text;
            fw.txtEditTitle.Text = this.txtSelectedTitle.Text;
            fw.txtEditYear.Text = this.txtSelectedYear.Text;
            fw.txtEditPageCount.Text = this.txtSelectedPageCount.Text;
            fw.txtEditPurchaseDate.Text = this.txtSelectedPurchaseDate.Text;
            fw.ShowDialog();
            this.OnLoad(e);
            RefreshDataGridBooks();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44307/");
            HttpResponseMessage response = client.GetAsync("api/books").Result;
            var book = response.Content.ReadAsAsync<IEnumerable<Book>>().Result;
            var results = book.Where(b => b.Title.Contains(txtSearch.Text));
            dataGridViewBooks.DataSource = results.ToList();
        }
    }
}
