// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList {

    public partial class Form1 : Form {

        ToDoDB tddb;
        Item activeItem;
        RecordColumn columnsUpdate;

        const string dtFormat = "dd.MM.yyyy HH:mm";

        public Form1() {
            InitializeComponent();
            titleTextBox.ReadOnly = true;
            textTextBox.ReadOnly = true;
            editButton.Enabled = false;
            finishButton.Enabled = false;
            deleteButton.Visible = false;
            colorPanel.BackColor = Color.White;
            colorComboBox.Visible = false;
            columnsUpdate = RecordColumn.Nothing;
            tddb = new ToDoDB();
            List<Record> records = tddb.GetAll();
            foreach (var record in records)
                AddToListViewItem(record);
            activeItem = new Item(null);
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView.SelectedIndices.Count > 0) {
                activeItem.Value = listView.SelectedItems[0];
                titleTextBox.Text = activeItem.Title;
                textTextBox.Text = activeItem.Text;
                editButton.Enabled = true;
                if (activeItem.Finish == "")
                    finishButton.Enabled = true;
                else
                    finishLabel.Text = activeItem.Finish;
                startLabel.Text = activeItem.Start;
                colorPanel.BackColor = activeItem.Level;
            }
            else {
                editButton.Enabled = false;
                finishButton.Enabled = false;
                finishLabel.Text = "";
                startLabel.Text = "";
                activeItem.Value = null;
                colorPanel.BackColor = Color.White;
            }
        }

        private void finishButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Завершить?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                finishButton.Enabled = false;
                activeItem.Finish = tddb.Finish(activeItem.ID).ToString(dtFormat);
                finishLabel.Text = activeItem.Finish;
                activeItem.Finished();
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            if (editButton.Text == "Edit") {
                editButton.Text = "Rec";
                deleteButton.Visible = true;
                addButton.Enabled = false;
                finishButton.Enabled = false;
                titleTextBox.ReadOnly = false;
                textTextBox.ReadOnly = false;
                listView.Enabled = false;
                titleTextBox.TextChanged += titleTextBox_TextChanged;
                textTextBox.TextChanged += textTextBox_TextChanged;
                colorComboBox.Visible = true;
                colorComboBox.SelectedIndex = 0;
            }
            else {
                editButton.Text = "Edit";
                deleteButton.Visible = false;
                addButton.Enabled = true;
                finishButton.Enabled = true;
                titleTextBox.ReadOnly = true;
                textTextBox.ReadOnly = true;
                listView.Enabled = true;
                titleTextBox.TextChanged -= titleTextBox_TextChanged;
                textTextBox.TextChanged -= textTextBox_TextChanged;
                Level level = (ToDoList.Level)colorComboBox.SelectedIndex;
                Record record = new Record() {
                    Title = titleTextBox.Text,
                    Text = textTextBox.Text,
                    Level = level,
                };
                tddb.Update(activeItem.ID, record, columnsUpdate);
                activeItem.Title = record.Title;
                activeItem.Text = record.Text;
                activeItem.Level = Color.FromName((string)colorComboBox.SelectedItem);
                colorComboBox.Visible = false;
                columnsUpdate = RecordColumn.Nothing;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            int deleteID = activeItem.ID;
            tddb.DeleteRecord(deleteID);
            listView.Items.Remove(activeItem.Value);
            activeItem.Value = null;
            editButton.Text = "Edit";
            deleteButton.Visible = false;
            addButton.Enabled = true;
            finishButton.Enabled = true;
            titleTextBox.ReadOnly = true;
            textTextBox.ReadOnly = true;
            listView.Enabled = true;
            titleTextBox.TextChanged -= titleTextBox_TextChanged;
            textTextBox.TextChanged -= textTextBox_TextChanged;
            colorComboBox.Visible = false;
            columnsUpdate = RecordColumn.Nothing;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e) {
            if(!columnsUpdate.HasFlag(RecordColumn.Title))
                columnsUpdate |= RecordColumn.Title;
        }

        private void textTextBox_TextChanged(object sender, EventArgs e) {
            if (!columnsUpdate.HasFlag(RecordColumn.Text))
                columnsUpdate |= RecordColumn.Text;
        }

        private void addButton_Click(object sender, EventArgs e) {
            AddForm add = new AddForm(this);
            add.ShowDialog();
        }

        public void AddRecord(Record record) {

            tddb.AddRecord(record);
            AddToListViewItem(record);
        }

        private void AddToListViewItem(Record record) {
            string[] items = new string[] { record.ID.ToString(),
                                                record.Title,
                                                record.Finish == null ? "" : "●",
                                                "",
                                                record.Text,
                                                record.Finish == null ? "" : record.Finish.Value.ToString(dtFormat),
                                                record.Start.ToString(dtFormat)};
            ListViewItem viewItem = new ListViewItem(items);
            viewItem.UseItemStyleForSubItems = false;
            Color color = Color.Green;
            if (record.Level == ToDoList.Level.Yellow)
                color = Color.Yellow;
            else if (record.Level == ToDoList.Level.Red)
                color = Color.Red;
            viewItem.SubItems[3].BackColor = color;
            listView.Items.Add(viewItem);
        }

    }

}
