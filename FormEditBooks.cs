using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FormEditBooks : Form
    {
        BindingList<Book> books;
        BindingSource bindingSourceBooks;

        BindingList<Author> authors;
        BindingSource bindingSourceAuthors;
        public FormEditBooks(BindingList<Book> books,BindingList<Author> authors)
        {
            InitializeComponent();
            //books
            this.books = books;
            bindingSourceBooks = new BindingSource();
            bindingSourceBooks.DataSource = books;
            listBoxEditBooks.DataSource = bindingSourceBooks;
            listBoxEditBooks.DisplayMember = "Name";
            listBoxEditBooks.ValueMember = "Id";
            textEditBooksAuthor.DataBindings.Add("Text", bindingSourceBooks, "Id");
            textEditBooksName.DataBindings.Add("Text", bindingSourceBooks, "Name");
            buttonEditBooksAdd.Click += ButtonEditBooksAdd_Click;
            buttonEditBooksRemove.Click += ButtonEditBooksRemove_Click;
            // authors
            this.authors = authors;
            bindingSourceAuthors = new BindingSource();
            bindingSourceAuthors.DataSource = authors;
            listBoxAuthors.DataSource = bindingSourceAuthors;
            listBoxAuthors.DisplayMember = "Name";

        }

        private void ButtonEditBooksRemove_Click(object sender, EventArgs e)
        {
            if (listBoxEditBooks.SelectedIndex >= 0)
                books.RemoveAt(listBoxEditBooks.SelectedIndex);
        }

        private void ButtonEditBooksAdd_Click(object sender, EventArgs e)
        {
            int nextId = 0;
            if (books.Count == 0)
                nextId = 1;
            else
                nextId = books[books.Count - 1].Id + 1; 
            listBoxEditBooks.Focus();  
            books.AddNew();
            books[books.Count - 1].Id = nextId;
            listBoxEditBooks.SelectedIndex = listBoxEditBooks.Items.Count - 1;
            textEditBooksName.Focus();
        }

        
    }
}
