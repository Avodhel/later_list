using System.Windows.Forms;

namespace later_list.Controllers
{
    public static class ErrorController
    {
        public static bool NameFieldRequireCheck(string nameField) => (nameField != string.Empty) ? true : false;

        public static bool DuplicateCheck(ListViewItem lvi) => (lvi != null) ? true : false;
    }
}
