namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Finished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Finish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.finishLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Finished,
            this.Level,
            this.Text,
            this.Finish,
            this.Start});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(13, 13);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(375, 288);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.Width = 288;
            // 
            // Finished
            // 
            this.Finished.Text = "✓";
            this.Finished.Width = 23;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Level.Width = 57;
            // 
            // Text
            // 
            this.Text.Text = "";
            this.Text.Width = 0;
            // 
            // Finish
            // 
            this.Finish.Text = "";
            this.Finish.Width = 0;
            // 
            // Start
            // 
            this.Start.Text = "";
            this.Start.Width = 0;
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(394, 105);
            this.textTextBox.MaxLength = 350;
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(369, 138);
            this.textTextBox.TabIndex = 1;
            this.textTextBox.TextChanged += new System.EventHandler(this.textTextBox_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(394, 45);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(369, 35);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(394, 278);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Record";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(495, 278);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(688, 278);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 7;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "StartTime:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(457, 249);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(0, 13);
            this.startLabel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Finish:";
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Location = new System.Drawing.Point(621, 249);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(0, 13);
            this.finishLabel.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(593, 278);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red"});
            this.colorComboBox.Location = new System.Drawing.Point(515, 21);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 13;
            // 
            // colorPanel
            // 
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(643, 21);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(120, 21);
            this.colorPanel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 313);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.finishLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Finished;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label finishLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ColumnHeader Text;
        private System.Windows.Forms.ColumnHeader Finish;
        private System.Windows.Forms.ColumnHeader Start;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Panel colorPanel;
    }
}

