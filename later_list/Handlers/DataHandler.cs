﻿using System.Windows.Forms;

namespace later_list.Handlers
{
    public static class DataHandler
    {
        public static void AddDataToList(ListViewItem data, ListView listView)
        {
            listView.Items.Add(data);
        }

        public static void RemoveDataFromList(ListView listView)
        {
            listView.Items.RemoveAt(listView.SelectedIndices[0]);
        }

        public static void InsertEditedDataToList(int index, ListViewItem editedData, ListView listView)
        {
            listView.Items.Insert(index, editedData);
        }
    }
}
