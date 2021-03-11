﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using QuanLy_HS_GV_THPT;

namespace Helper
{
    public enum CATSTATE : int
    {
        TEACHER = 0,
        STUDENT = 1,
    }
    public enum HELPERSTATE : int
    {
        ADDHELPER = 0,
        EDITHELPER = 1,
        DELETEHELPER = 2,
        SEARCHHELPER = 3
    }
    class Utilities
    {
        static Color baseButtonBackColor = SystemColors.Control;
        static Color activeButtonBackColor = Color.RoyalBlue;
        static Color baseButtonForeColor = Color.Black;
        static Color activeButtonForeColor = Color.White;
        public static DangNhap GetMainForm()
        {
            foreach (Form form in Application.OpenForms)
                if (form is DangNhap)
                    return (DangNhap)form;
            return null;
        }
        public static void setButtonState(bool bIsActive, ref Button btn)
        {
            if(bIsActive)
            {
                btn.BackColor = activeButtonBackColor;
                btn.ForeColor = activeButtonForeColor;
            }
            else
            {
                btn.BackColor = baseButtonBackColor;
                btn.ForeColor = baseButtonForeColor;
            }
        }
    }
    class Define
    {
        //Datasourse (khac nhau)
        //DN: ADMIN\SQLEXPRESS
        public const string dataSource = @"Data Source=DESKTOP-3PP3KKO;Initial Catalog=Quanlynhasu_3F;Integrated Security=True";

        public static int Clamp(ref int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;

        }
    }
}
