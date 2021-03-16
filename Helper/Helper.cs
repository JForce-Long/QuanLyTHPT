using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    public partial class Helpers : Form
    {
        Button CurrentButton;
        public Helpers()
        {
            InitializeComponent();
            btnClick(addStHelperBTN);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER,CATSTATE.STUDENT);
        }
        void btnClick(Button btn)
        {
            if (CurrentButton == null)
            {
                CurrentButton = btn;
                Utilities.setButtonState(true, ref CurrentButton);
                return;
            }
            if (CurrentButton == btn)
                return;
            Utilities.setButtonState(false, ref CurrentButton);
            CurrentButton = btn;
            Utilities.setButtonState(true, ref CurrentButton);
        }
        #region HocSinh
        private void addStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER,CATSTATE.STUDENT);
        }

        private void editStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.STUDENT);
        }

        private void delStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.STUDENT);
        }

        private void searchStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.STUDENT);
        }
        #endregion
        #region GiaoVien
        private void addTeacherHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER, CATSTATE.TEACHER);
        }

        private void editTeacherHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.TEACHER);
        }

        private void delTeacherHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.TEACHER);
        }

        private void searchTeacherHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.TEACHER);
        }
        #endregion
    }
}
