// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System.Windows.Forms;
using System.Drawing;

namespace ToDoList {

    /// <summary>
    /// Обёртка над ListViewItem для получения значений столбцов.
    /// </summary>
    class Item {

        ListViewItem item;

        public Item(ListViewItem listViewItem) {
            item = listViewItem;
        }

        public ListViewItem Value {
            get { return item; }
            set { item = value; }
        }

        public string Title {
            get { return item.SubItems[1].Text; }
            set { item.SubItems[1].Text = value; }
        }

        public int ID {
            get { return int.Parse(item.SubItems[0].Text); }
        }

        public void Finished() {
            item.SubItems[2].Text = "●";
        }

        public Color Level {
            get { return item.SubItems[3].BackColor; }
            set { item.SubItems[3].BackColor = value; }
        }

        public string Text {
            get { return item.SubItems[4].Text; }
            set { item.SubItems[4].Text = value; }
        }

        public string Finish {
            get { return item.SubItems[5].Text; }
            set { item.SubItems[5].Text = value; }
        }

        public string Start {
            get { return item.SubItems[6].Text; }
        }

    }

}
