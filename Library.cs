using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormLibrary : Form
    {
        Lib lib;
        XMLFile serialiseFile = new XMLFile("basa.xml");
        public FormLibrary()
        {
            InitializeComponent();
            lib = serialiseFile.DeSerialize();

            toEditReaders.Click += ToEditReaders_Click;
            this.FormClosed += (sender, e) => serialiseFile.Serialize(lib);

            toEditAuthors.Click += ToEditAuthors_Click;

            toEditBooks.Click += ToEditBooks_Click;
        }

        private void ToEditBooks_Click(object sender, EventArgs e)
        {
            FormEditBooks formEditBooks = new FormEditBooks(lib.Books);
            formEditBooks.ShowDialog();
        }

        private void ToEditAuthors_Click(object sender, EventArgs e)
        {
            FormEditAuthors formEditAuthors = new FormEditAuthors(lib.Authors);
            formEditAuthors.ShowDialog();
        }

        private void ToEditReaders_Click(object sender, EventArgs e)
        {
            FormEditReaders formEditReaders = new FormEditReaders(lib.Readers);
            formEditReaders.ShowDialog();
        }

        
    }
}
