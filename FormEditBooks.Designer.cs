
namespace Library
{
    partial class FormEditBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textEditBooksName = new System.Windows.Forms.TextBox();
            this.buttonEditBooksRemove = new System.Windows.Forms.Button();
            this.buttonEditBooksAdd = new System.Windows.Forms.Button();
            this.listBoxEditBooks = new System.Windows.Forms.ListBox();
            this.textEditBooksId = new System.Windows.Forms.TextBox();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textEditBooksName
            // 
            this.textEditBooksName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditBooksName.Location = new System.Drawing.Point(334, 68);
            this.textEditBooksName.Name = "textEditBooksName";
            this.textEditBooksName.Size = new System.Drawing.Size(283, 32);
            this.textEditBooksName.TabIndex = 9;
            // 
            // buttonEditBooksRemove
            // 
            this.buttonEditBooksRemove.Location = new System.Drawing.Point(542, 118);
            this.buttonEditBooksRemove.Name = "buttonEditBooksRemove";
            this.buttonEditBooksRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonEditBooksRemove.TabIndex = 8;
            this.buttonEditBooksRemove.Text = "Remove";
            this.buttonEditBooksRemove.UseVisualStyleBackColor = true;
            // 
            // buttonEditBooksAdd
            // 
            this.buttonEditBooksAdd.Location = new System.Drawing.Point(334, 118);
            this.buttonEditBooksAdd.Name = "buttonEditBooksAdd";
            this.buttonEditBooksAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonEditBooksAdd.TabIndex = 7;
            this.buttonEditBooksAdd.Text = "Add";
            this.buttonEditBooksAdd.UseVisualStyleBackColor = true;
            // 
            // listBoxEditBooks
            // 
            this.listBoxEditBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxEditBooks.FormattingEnabled = true;
            this.listBoxEditBooks.ItemHeight = 15;
            this.listBoxEditBooks.Location = new System.Drawing.Point(0, 0);
            this.listBoxEditBooks.Name = "listBoxEditBooks";
            this.listBoxEditBooks.Size = new System.Drawing.Size(328, 450);
            this.listBoxEditBooks.TabIndex = 6;
            // 
            // textEditBooksId
            // 
            this.textEditBooksId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditBooksId.Location = new System.Drawing.Point(334, 12);
            this.textEditBooksId.Name = "textEditBooksId";
            this.textEditBooksId.Size = new System.Drawing.Size(283, 32);
            this.textEditBooksId.TabIndex = 5;
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.ItemHeight = 15;
            this.listBoxAuthors.Location = new System.Drawing.Point(334, 164);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(283, 274);
            this.listBoxAuthors.TabIndex = 10;
            // 
            // FormEditBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.listBoxAuthors);
            this.Controls.Add(this.textEditBooksName);
            this.Controls.Add(this.buttonEditBooksRemove);
            this.Controls.Add(this.buttonEditBooksAdd);
            this.Controls.Add(this.listBoxEditBooks);
            this.Controls.Add(this.textEditBooksId);
            this.Name = "FormEditBooks";
            this.Text = "FormEditBooks";
            //this.Load += new System.EventHandler(this.FormEditBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEditBooksName;
        private System.Windows.Forms.Button buttonEditBooksRemove;
        private System.Windows.Forms.Button buttonEditBooksAdd;
        private System.Windows.Forms.ListBox listBoxEditBooks;
        private System.Windows.Forms.TextBox textEditBooksId;
        private System.Windows.Forms.ListBox listBoxAuthors;
    }
}