
namespace Library
{
    partial class FormLibrary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxReaders = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toLendBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toEditReaders = new System.Windows.Forms.ToolStripMenuItem();
            this.toEditBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toEditAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxReaders
            // 
            this.listBoxReaders.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxReaders.FormattingEnabled = true;
            this.listBoxReaders.ItemHeight = 15;
            this.listBoxReaders.Location = new System.Drawing.Point(0, 24);
            this.listBoxReaders.Name = "listBoxReaders";
            this.listBoxReaders.Size = new System.Drawing.Size(286, 426);
            this.listBoxReaders.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(286, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 426);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(605, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(290, 426);
            this.listBox2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.readersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toLendBook,
            this.toReturnBook});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Log";
            // 
            // toLendBook
            // 
            this.toLendBook.Name = "toLendBook";
            this.toLendBook.Size = new System.Drawing.Size(180, 22);
            this.toLendBook.Text = "Lend a book";
            // 
            // toReturnBook
            // 
            this.toReturnBook.Name = "toReturnBook";
            this.toReturnBook.Size = new System.Drawing.Size(180, 22);
            this.toReturnBook.Text = "Return a book";
            // 
            // readersToolStripMenuItem
            // 
            this.readersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toEditReaders,
            this.toEditBooks,
            this.toEditAuthors});
            this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
            this.readersToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.readersToolStripMenuItem.Text = "Edit";
            // 
            // toEditReaders
            // 
            this.toEditReaders.Name = "toEditReaders";
            this.toEditReaders.Size = new System.Drawing.Size(180, 22);
            this.toEditReaders.Text = "Readers";
            // 
            // toEditBooks
            // 
            this.toEditBooks.Name = "toEditBooks";
            this.toEditBooks.Size = new System.Drawing.Size(180, 22);
            this.toEditBooks.Text = "Books";
            // 
            // toEditAuthors
            // 
            this.toEditAuthors.Name = "toEditAuthors";
            this.toEditAuthors.Size = new System.Drawing.Size(180, 22);
            this.toEditAuthors.Text = "Authors";
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBoxReaders);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLibrary";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxReaders;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toLendBook;
        private System.Windows.Forms.ToolStripMenuItem toReturnBook;
        private System.Windows.Forms.ToolStripMenuItem readersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toEditReaders;
        private System.Windows.Forms.ToolStripMenuItem toEditBooks;
        private System.Windows.Forms.ToolStripMenuItem toEditAuthors;
    }
}

