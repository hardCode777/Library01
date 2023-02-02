using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FormEditAuthors : Form
    {
        BindingList<Author> authors;
        BindingSource bindingSource;
        public FormEditAuthors(BindingList <Author> authors)
        {
            InitializeComponent();
            this.authors = authors;
            bindingSource = new BindingSource();
            bindingSource.DataSource = authors;
            listBoxEditAuthors.DataSource = bindingSource;
            listBoxEditAuthors.DisplayMember = "Name";
            listBoxEditAuthors.ValueMember = "Id";
            textEditAuthorsId.DataBindings.Add("Text", bindingSource, "Id");
            textEditAuthorsName.DataBindings.Add("Text", bindingSource, "Name");
            buttonEditAuthorsAdd.Click += ButtonEditAuthorsAdd_Click;
            buttonEditAuthorsRemove.Click += ButtonEditAuthorsRemove_Click;
        }

        private void ButtonEditAuthorsRemove_Click(object sender, EventArgs e)
        {
            if (listBoxEditAuthors.SelectedIndex >= 0)
                authors.RemoveAt(listBoxEditAuthors.SelectedIndex);
        }

        private void ButtonEditAuthorsAdd_Click(object sender, EventArgs e)
        {
            int nextId = 0;
            if (authors.Count == 0)
                nextId = 1;
            else
                nextId = authors[authors.Count - 1].Id + 1; //???
            listBoxEditAuthors.Focus();  //???
            authors.AddNew();
            authors[authors.Count - 1].Id = nextId;
            listBoxEditAuthors.SelectedIndex = listBoxEditAuthors.Items.Count - 1;
            textEditAuthorsName.Focus();
        }
    }
}
