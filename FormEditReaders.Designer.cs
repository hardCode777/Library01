
namespace Library
{
    partial class FormEditReaders
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
            this.textEditId = new System.Windows.Forms.TextBox();
            this.listBoxEditReader = new System.Windows.Forms.ListBox();
            this.buttonEditReaderAdd = new System.Windows.Forms.Button();
            this.buttonEditReaderRemove = new System.Windows.Forms.Button();
            this.textEditName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textEditId
            // 
            this.textEditId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditId.Location = new System.Drawing.Point(349, 12);
            this.textEditId.Name = "textEditId";
            this.textEditId.Size = new System.Drawing.Size(283, 32);
            this.textEditId.TabIndex = 0;
            // 
            // listBoxEditReader
            // 
            this.listBoxEditReader.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxEditReader.FormattingEnabled = true;
            this.listBoxEditReader.ItemHeight = 15;
            this.listBoxEditReader.Location = new System.Drawing.Point(0, 0);
            this.listBoxEditReader.Name = "listBoxEditReader";
            this.listBoxEditReader.Size = new System.Drawing.Size(328, 450);
            this.listBoxEditReader.TabIndex = 1;
            // 
            // buttonEditReaderAdd
            // 
            this.buttonEditReaderAdd.Location = new System.Drawing.Point(349, 146);
            this.buttonEditReaderAdd.Name = "buttonEditReaderAdd";
            this.buttonEditReaderAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonEditReaderAdd.TabIndex = 2;
            this.buttonEditReaderAdd.Text = "Add";
            this.buttonEditReaderAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEditReaderRemove
            // 
            this.buttonEditReaderRemove.Location = new System.Drawing.Point(557, 146);
            this.buttonEditReaderRemove.Name = "buttonEditReaderRemove";
            this.buttonEditReaderRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonEditReaderRemove.TabIndex = 3;
            this.buttonEditReaderRemove.Text = "Remove";
            this.buttonEditReaderRemove.UseVisualStyleBackColor = true;
            // 
            // textEditName
            // 
            this.textEditName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditName.Location = new System.Drawing.Point(349, 73);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(283, 32);
            this.textEditName.TabIndex = 4;
            // 
            // FormEditReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.buttonEditReaderRemove);
            this.Controls.Add(this.buttonEditReaderAdd);
            this.Controls.Add(this.listBoxEditReader);
            this.Controls.Add(this.textEditId);
            this.Name = "FormEditReaders";
            this.Text = "FormEditReaders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEditId;
        private System.Windows.Forms.ListBox listBoxEditReader;
        private System.Windows.Forms.Button buttonEditReaderAdd;
        private System.Windows.Forms.Button buttonEditReaderRemove;
        private System.Windows.Forms.TextBox textEditName;
    }
}