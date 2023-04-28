namespace ListBoxControl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteList2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnClearList2 = new System.Windows.Forms.Button();
            this.btnAddList2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddList1 = new System.Windows.Forms.Button();
            this.btnDeleteList1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClearList1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteList2);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.btnClearList2);
            this.groupBox2.Controls.Add(this.btnAddList2);
            this.groupBox2.Location = new System.Drawing.Point(16, 277);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(578, 256);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список с многострочной выборкой";
            // 
            // btnDeleteList2
            // 
            this.btnDeleteList2.Location = new System.Drawing.Point(342, 115);
            this.btnDeleteList2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteList2.Name = "btnDeleteList2";
            this.btnDeleteList2.Size = new System.Drawing.Size(200, 44);
            this.btnDeleteList2.TabIndex = 7;
            this.btnDeleteList2.Text = "Удалить";
            this.btnDeleteList2.UseVisualStyleBackColor = true;
            this.btnDeleteList2.Click += new System.EventHandler(this.btnDeleteList2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(28, 42);
            this.listBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(274, 179);
            this.listBox2.TabIndex = 5;
            // 
            // btnClearList2
            // 
            this.btnClearList2.Location = new System.Drawing.Point(342, 181);
            this.btnClearList2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClearList2.Name = "btnClearList2";
            this.btnClearList2.Size = new System.Drawing.Size(200, 44);
            this.btnClearList2.TabIndex = 8;
            this.btnClearList2.Text = "Очистить";
            this.btnClearList2.UseVisualStyleBackColor = true;
            this.btnClearList2.Click += new System.EventHandler(this.btnClearList2_Click);
            // 
            // btnAddList2
            // 
            this.btnAddList2.Location = new System.Drawing.Point(342, 42);
            this.btnAddList2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddList2.Name = "btnAddList2";
            this.btnAddList2.Size = new System.Drawing.Size(200, 52);
            this.btnAddList2.TabIndex = 6;
            this.btnAddList2.Text = "Добавить";
            this.btnAddList2.UseVisualStyleBackColor = true;
            this.btnAddList2.Click += new System.EventHandler(this.btnAddList2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnAddList1);
            this.groupBox1.Controls.Add(this.btnDeleteList1);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.btnClearList1);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(578, 246);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список с единичным выделением";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(30, 37);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 179);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnAddList1
            // 
            this.btnAddList1.Location = new System.Drawing.Point(344, 37);
            this.btnAddList1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddList1.Name = "btnAddList1";
            this.btnAddList1.Size = new System.Drawing.Size(200, 44);
            this.btnAddList1.TabIndex = 0;
            this.btnAddList1.Text = "Добавить";
            this.btnAddList1.UseVisualStyleBackColor = true;
            this.btnAddList1.Click += new System.EventHandler(this.btnAddList1_Click);
            // 
            // btnDeleteList1
            // 
            this.btnDeleteList1.Location = new System.Drawing.Point(344, 129);
            this.btnDeleteList1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteList1.Name = "btnDeleteList1";
            this.btnDeleteList1.Size = new System.Drawing.Size(200, 44);
            this.btnDeleteList1.TabIndex = 1;
            this.btnDeleteList1.Text = "Удалить";
            this.btnDeleteList1.UseVisualStyleBackColor = true;
            this.btnDeleteList1.Click += new System.EventHandler(this.btnDeleteList1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(344, 85);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(196, 31);
            this.txtInput.TabIndex = 3;
            // 
            // btnClearList1
            // 
            this.btnClearList1.Location = new System.Drawing.Point(344, 179);
            this.btnClearList1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClearList1.Name = "btnClearList1";
            this.btnClearList1.Size = new System.Drawing.Size(200, 44);
            this.btnClearList1.TabIndex = 4;
            this.btnClearList1.Text = "Очистить";
            this.btnClearList1.UseVisualStyleBackColor = true;
            this.btnClearList1.Click += new System.EventHandler(this.btnClearList1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ListBox";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteList2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnClearList2;
        private System.Windows.Forms.Button btnAddList2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddList1;
        private System.Windows.Forms.Button btnDeleteList1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnClearList1;
    }
}

