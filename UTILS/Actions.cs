using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasigLibrarySystem.UTILS
{
    public static class Action
    {
        public static void SwitchForm(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Hide();
        }
        public static void LogOut(Form currentForm, Form loginForm)
        {
            loginForm.Show();
            currentForm.Hide();
        }
    }
}
