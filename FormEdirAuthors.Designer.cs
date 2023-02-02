
namespace Library
{
    partial class FormEditAuthors
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
            this.listBoxEditAuthors = new System.Windows.Forms.ListBox();
            this.textEditAuthorsName = new System.Windows.Forms.TextBox();
            this.buttonEditAuthorsRemove = new System.Windows.Forms.Button();
            this.buttonEditAuthorsAdd = new System.Windows.Forms.Button();
            this.textEditAuthorsId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxEditAuthors
            // 
            this.listBoxEditAuthors.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxEditAuthors.FormattingEnabled = true;
            this.listBoxEditAuthors.ItemHeight = 15;
            this.listBoxEditAuthors.Location = new System.Drawing.Point(0, 0);
            this.listBoxEditAuthors.Name = "listBoxEditAuthors";
            this.listBoxEditAuthors.Size = new System.Drawing.Size(328, 450);
            this.listBoxEditAuthors.TabIndex = 2;
            // 
            // textEditAuthorsName
            // 
            this.textEditAuthorsName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditAuthorsName.Location = new System.Drawing.Point(347, 69);
            this.textEditAuthorsName.Name = "textEditAuthorsName";
            this.textEditAuthorsName.Size = new System.Drawing.Size(283, 32);
            this.textEditAuthorsName.TabIndex = 8;
            // 
            // buttonEditAuthorsRemove
            // 
            this.buttonEditAuthorsRemove.Location = new System.Drawing.Point(555, 126);
            this.buttonEditAuthorsRemove.Name = "buttonEditAuthorsRemove";
            this.buttonEditAuthorsRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonEditAuthorsRemove.TabIndex = 7;
            this.buttonEditAuthorsRemove.Text = "Remove";
            this.buttonEditAuthorsRemove.UseVisualStyleBackColor = true;
            // 
            // buttonEditAuthorsAdd
            // 
            this.buttonEditAuthorsAdd.Location = new System.Drawing.Point(347, 126);
            this.buttonEditAuthorsAdd.Name = "buttonEditAuthorsAdd";
            this.buttonEditAuthorsAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonEditAuthorsAdd.TabIndex = 6;
            this.buttonEditAuthorsAdd.Text = "Add";
            this.buttonEditAuthorsAdd.UseVisualStyleBackColor = true;
            // 
            // textEditAuthorsId
            // 
            this.textEditAuthorsId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditAuthorsId.Location = new System.Drawing.Point(347, 12);
            this.textEditAuthorsId.Name = "textEditAuthorsId";
            this.textEditAuthorsId.Size = new System.Drawing.Size(283, 32);
            this.textEditAuthorsId.TabIndex = 5;
            // 
            // FormEdirAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.textEditAuthorsName);
            this.Controls.Add(this.buttonEditAuthorsRemove);
            this.Controls.Add(this.buttonEditAuthorsAdd);
            this.Controls.Add(this.textEditAuthorsId);
            this.Controls.Add(this.listBoxEditAuthors);
            this.Name = "FormEdirAuthors";
            this.Text = "FormEdirAuthors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEditAuthors;
        private System.Windows.Forms.TextBox textEditAuthorsName;
        private System.Windows.Forms.Button buttonEditAuthorsRemove;
        private System.Windows.Forms.Button buttonEditAuthorsAdd;
        private System.Windows.Forms.TextBox textEditAuthorsId;
    }
}