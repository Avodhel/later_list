using System.Windows.Forms;

namespace later_list
{
    public class DataHandler
    {
        public void AddDataToList(ListViewItem data, ListView listView)
        {
            listView.Items.Add(data);
        }

        public void RemoveDataFromList(ListView listView)
        {
            listView.Items.RemoveAt(listView.SelectedIndices[0]);
        }

        public void InsertEditedDataToList(int index, ListViewItem editedData, ListView listView)
        {
            listView.Items.Insert(index, editedData);
        }
    }
}
