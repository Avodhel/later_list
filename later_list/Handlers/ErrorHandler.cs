using System.Windows.Forms;

namespace later_list.Handlers
{
    public static class ErrorHandler
    {
        public static bool NameFieldRequireCheck(string nameField) => (nameField != string.Empty) ? true : false;

        public static bool DuplicateCheck(ListViewItem lvi) => (lvi != null) ? true : false;
    }
}
