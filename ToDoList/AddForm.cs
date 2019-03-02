// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Windows.Forms;

namespace ToDoList {

    /// <summary>
    /// Форма для добавления записи в базу.
    /// </summary>
    public partial class AddForm : Form {

        Form1 parent;
        public AddForm(Form1 form1) {
            InitializeComponent();
            parent = form1;
            titleTextBox.Text = "";
            textTextBox.Text = "";
            colorComboBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e) {
            if (titleTextBox.Text == "") {
                MessageBox.Show("Title is empty");
                return;
            }
            if (textTextBox.Text == "") {
                MessageBox.Show("Text is empty");
                return;
            }
            Record record = new Record() {
                Title = titleTextBox.Text,
                Text = textTextBox.Text,
                Level = (Level)colorComboBox.SelectedIndex,
                Start = DateTime.Now,
                Finish = null
            };
            parent.AddRecord(record);
            Close();
        }

    }

}
