using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace later_list
{
    public static class ThemeManager
    {
        //FORMS
        private static List<Form> formList = new List<Form>();

        public static void RegisterForm(Form form)
        {
            if (!formList.Contains(form)) formList.Add(form);
        }

        public static void UnRegisterForm(Form form)
        {
            if (formList.Contains(form)) formList.Remove(form);
        }

        //GROUP BOX
        private static List<GroupBox> gbList = new List<GroupBox>();

        public static void RegisterGroupBox(GroupBox gb)
        {
            if (!gbList.Contains(gb)) gbList.Add(gb);
        }

        public static void UnRegisterGroupBox(GroupBox gb)
        {
            if (gbList.Contains(gb)) gbList.Remove(gb);
        }

        //TEXTBOX
        private static List<TextBox> tbList = new List<TextBox>();

        public static void RegisterTextBox(TextBox tb)
        {
            if (!tbList.Contains(tb)) tbList.Add(tb);
        }

        public static void UnRegisterTextBox(TextBox tb)
        {
            if (tbList.Contains(tb)) tbList.Remove(tb);
        }

        //COMBOBOX
        private static List<ComboBox> cbList = new List<ComboBox>();

        public static void RegisterCheckBox(ComboBox cb)
        {
            if (!cbList.Contains(cb)) cbList.Add(cb);
        }

        public static void UnRegisterCheckBox(ComboBox cb)
        {
            if (cbList.Contains(cb)) cbList.Remove(cb);
        }

        //LISTS
        private static List<ListBox> lbList = new List<ListBox>();

        public static void RegisterListBox(ListBox lb)
        {
            if (!lbList.Contains(lb)) lbList.Add(lb);
        }

        public static void UnRegisterListBox(ListBox lb)
        {
            if (lbList.Contains(lb)) lbList.Remove(lb);
        }

        //BUTTONS
        private static List<Button> buttonList = new List<Button>();

        public static void RegisterButton(Button btn)
        {
            if (!buttonList.Contains(btn)) buttonList.Add(btn);
        }

        public static void UnRegisterButton(Button btn)
        {
            if (buttonList.Contains(btn)) buttonList.Remove(btn);
        }

        //SET ALL COLORS
        public static void SetAllBackColors(Color BackColor, Color TextColor, Color ButtonTextColor)
        {
            foreach (Form f in formList) if (f != null) f.BackColor = BackColor;
            foreach (GroupBox gb in gbList) if (gb != null) gb.ForeColor = TextColor;
            foreach (TextBox tb in tbList) if (tb != null) tb.ForeColor = TextColor;
            foreach (TextBox tb in tbList) if (tb != null) tb.BackColor = BackColor;
            foreach (ComboBox cb in cbList) if (cb != null) cb.ForeColor = TextColor;
            foreach (ComboBox cb in cbList) if (cb != null) cb.BackColor = BackColor;
            foreach (ListBox lb in lbList) if (lb != null) lb.ForeColor = TextColor;
            foreach (ListBox lb in lbList) if (lb != null) lb.BackColor = BackColor;
            foreach (Button b in buttonList) if (b != null) b.ForeColor = ButtonTextColor;
        }

        //THEME CONTROL
        public static void ThemeControl(SettingsForm settingsForm)
        {
            if (Properties.Settings.Default.light_checked == true)
            {
                ThemeManager.SetAllBackColors(settingsForm.lightBC, Color.Black, settingsForm.darkTC);
                settingsForm.LoadTheme();
                settingsForm.LightThemeCheck = true;
                settingsForm.DarkThemeCheck = false;
            }
            if (Properties.Settings.Default.dark_checked == true)
            {
                ThemeManager.SetAllBackColors(settingsForm.darkBC, Color.White, settingsForm.darkTC);
                settingsForm.LoadTheme();
                settingsForm.LightThemeCheck = false;
                settingsForm.DarkThemeCheck = true;
            }
        }
    }
}
