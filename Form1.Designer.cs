namespace GetChecked
{
    partial class Form1
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnGetItem = new System.Windows.Forms.Button();
            this.listBoxitem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxIndex = new System.Windows.Forms.ListBox();
            this.btnGetIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Java",
            "C",
            "C++",
            "C#",
            "Objective-C",
            "PHP",
            "Python",
            "Ruby",
            "Javascript",
            "SQL"});
            this.checkedListBox.Location = new System.Drawing.Point(29, 36);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(249, 184);
            this.checkedListBox.TabIndex = 0;
            // 
            // btnGetItem
            // 
            this.btnGetItem.Location = new System.Drawing.Point(29, 238);
            this.btnGetItem.Name = "btnGetItem";
            this.btnGetItem.Size = new System.Drawing.Size(75, 23);
            this.btnGetItem.TabIndex = 1;
            this.btnGetItem.Text = "Get item";
            this.btnGetItem.UseVisualStyleBackColor = true;
            this.btnGetItem.Click += new System.EventHandler(this.BtnGetItem_Click);
            // 
            // listBoxitem
            // 
            this.listBoxitem.FormattingEnabled = true;
            this.listBoxitem.Location = new System.Drawing.Point(29, 267);
            this.listBoxitem.Name = "listBoxitem";
            this.listBoxitem.Size = new System.Drawing.Size(120, 95);
            this.listBoxitem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programming languages";
            // 
            // listBoxIndex
            // 
            this.listBoxIndex.FormattingEnabled = true;
            this.listBoxIndex.Location = new System.Drawing.Point(203, 267);
            this.listBoxIndex.Name = "listBoxIndex";
            this.listBoxIndex.Size = new System.Drawing.Size(120, 95);
            this.listBoxIndex.TabIndex = 5;
            // 
            // btnGetIndex
            // 
            this.btnGetIndex.Location = new System.Drawing.Point(203, 238);
            this.btnGetIndex.Name = "btnGetIndex";
            this.btnGetIndex.Size = new System.Drawing.Size(75, 23);
            this.btnGetIndex.TabIndex = 4;
            this.btnGetIndex.Text = "Get index";
            this.btnGetIndex.UseVisualStyleBackColor = true;
            this.btnGetIndex.Click += new System.EventHandler(this.BtnGetIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 374);
            this.Controls.Add(this.listBoxIndex);
            this.Controls.Add(this.btnGetIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxitem);
            this.Controls.Add(this.btnGetItem);
            this.Controls.Add(this.checkedListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnGetItem;
        private System.Windows.Forms.ListBox listBoxitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxIndex;
        private System.Windows.Forms.Button btnGetIndex;
    }
}

