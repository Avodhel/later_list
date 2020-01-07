using System.Windows.Forms;

namespace later_list
{
    public class DataManager
    {
        public void AddDataToList(string data, ListBox listBox)
        {
            listBox.Items.Add(data);
        }

        public void RemoveDataFromList(ListBox listBox)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        public void InsertEditedDataToList(int index, string editedData, ListBox listBox)
        {
            listBox.Items.Insert(index, editedData);
        }
    }
}
