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
        //FORM
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
        private static List<GroupBox> groupBoxList = new List<GroupBox>();

        public static void RegisterGroupBox(GroupBox gb)
        {
            if (!groupBoxList.Contains(gb)) groupBoxList.Add(gb);
        }

        public static void UnRegisterGroupBox(GroupBox gb)
        {
            if (groupBoxList.Contains(gb)) groupBoxList.Remove(gb);
        }

        //TEXTBOX
        private static List<TextBox> textBoxList = new List<TextBox>();

        public static void RegisterTextBox(TextBox tb)
        {
            if (!textBoxList.Contains(tb)) textBoxList.Add(tb);
        }

        public static void UnRegisterTextBox(TextBox tb)
        {
            if (textBoxList.Contains(tb)) textBoxList.Remove(tb);
        }

        //COMBOBOX
        private static List<ComboBox> comboBoxList = new List<ComboBox>();

        public static void RegisterCheckBox(ComboBox cb)
        {
            if (!comboBoxList.Contains(cb)) comboBoxList.Add(cb);
        }

        public static void UnRegisterCheckBox(ComboBox cb)
        {
            if (comboBoxList.Contains(cb)) comboBoxList.Remove(cb);
        }

        //LISTBOX
        private static List<ListBox> listBoxList = new List<ListBox>();

        public static void RegisterListBox(ListBox lb)
        {
            if (!listBoxList.Contains(lb)) listBoxList.Add(lb);
        }

        public static void UnRegisterListBox(ListBox lb)
        {
            if (listBoxList.Contains(lb)) listBoxList.Remove(lb);
        }

        //BUTTON
        private static List<Button> buttonList = new List<Button>();

        public static void RegisterButton(Button btn)
        {
            if (!buttonList.Contains(btn)) buttonList.Add(btn);
        }

        public static void UnRegisterButton(Button btn)
        {
            if (buttonList.Contains(btn)) buttonList.Remove(btn);
        }

        //SET ALL THEME COLORS
        public static void SetAllThemeColors(Color BackColor, Color TextColor, Color ButtonTextColor)
        {
            foreach (Form     f  in formList    ) if (f  != null) f.BackColor  = BackColor;
            foreach (GroupBox gb in groupBoxList) if (gb != null) gb.ForeColor = TextColor;
            foreach (TextBox  tb in textBoxList ) if (tb != null) tb.ForeColor = TextColor;
            foreach (TextBox  tb in textBoxList ) if (tb != null) tb.BackColor = BackColor;
            foreach (ComboBox cb in comboBoxList) if (cb != null) cb.ForeColor = TextColor;
            foreach (ComboBox cb in comboBoxList) if (cb != null) cb.BackColor = BackColor;
            foreach (ListBox  lb in listBoxList ) if (lb != null) lb.ForeColor = TextColor;
            foreach (ListBox  lb in listBoxList ) if (lb != null) lb.BackColor = BackColor;
            foreach (Button   b  in buttonList  ) if (b  != null) b.ForeColor  = ButtonTextColor;
        }

        //CURRENT THEME
        public static void CurrrentTheme(SettingsForm settingsForm)
        {
            if (Properties.Settings.Default.light_checked == true)
            {
                SetAllThemeColors(settingsForm.lightThemeBackgroundColor, Color.Black, settingsForm.darkThemeTextColor);
                settingsForm.LightThemeCheck = true;
                settingsForm.DarkThemeCheck = false;
            }
            if (Properties.Settings.Default.dark_checked == true)
            {
                SetAllThemeColors(settingsForm.darkThemeBackgroundColor, Color.White, settingsForm.darkThemeTextColor);
                settingsForm.LightThemeCheck = false;
                settingsForm.DarkThemeCheck = true;
            }
        }
    }
}
