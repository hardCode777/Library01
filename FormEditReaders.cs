using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FormEditReaders : Form
    {
        BindingList <Reader> readers;
        BindingSource bindingSource; 
        public FormEditReaders(BindingList <Reader> readers)
        {
            InitializeComponent();
            this.readers = readers;
            bindingSource = new BindingSource();
            bindingSource.DataSource = readers;
            listBoxEditReader.DataSource = bindingSource;
            listBoxEditReader.DisplayMember = "Name";
            listBoxEditReader.ValueMember = "Id";
            textEditId.DataBindings.Add("Text", bindingSource, "Id");
            textEditName.DataBindings.Add("Text", bindingSource, "Name");
            buttonEditReaderAdd.Click += ButtonEditReaderAdd_Click;
            buttonEditReaderRemove.Click += ButtonEditReaderRemove_Click;
            textEditId.ReadOnly = true;
        }

        private void ButtonEditReaderRemove_Click(object sender, EventArgs e)
        {
            if (listBoxEditReader.SelectedIndex>=0)
            readers.RemoveAt(listBoxEditReader.SelectedIndex);
        }

        private void ButtonEditReaderAdd_Click(object sender, EventArgs e)
        {
            int nextId = 0;
            if (readers.Count == 0)
                nextId = 1;
            else
                nextId = readers[readers.Count - 1].Id + 1; //???
            listBoxEditReader.Focus();  //???
            readers.AddNew();
            readers[readers.Count - 1].Id = nextId;
            listBoxEditReader.SelectedIndex = listBoxEditReader.Items.Count - 1;
            textEditName.Focus();
        }
    }
}
