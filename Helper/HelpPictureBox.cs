using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    public partial class HelpPictureBox : UserControl
    {
        Graphics g;
        int currentIndex = 0;
        int[] maxIndex = new int[4] { 1, 2, 1, 1 };
        HELPERSTATE currentState = HELPERSTATE.ADDHELPER;
        CATSTATE currentObjectToRef = CATSTATE.STUDENT;
        string[,] helpStringStudent = new string[4, 3] 
        { 
            { "B1: Điền thông tin học sinh cần thêm vào các bảng", "B2: Nhấp chuột trái vào nút Thêm để thêm học sinh vào cơ sở dữ liệu","" }, 
            { "B1: Nhấp chuột trái 2 lần vào dòng học sinh cần sửa trong bảng hoặc gõ mã học sinh vào trong ô", "B2: Thay đổi thông tin ở trên các bảng","B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin học sinh" },
            { "B1: Nhấp chuột trái 2 lần vào dòng học sinh cần xoá", "B2: Nhấp chuột trái vào nút Xoá để xoá học sinh khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin học sinh cần tìm kiếm vào bảng", "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các học sinh tương đồng với thông tin đã nhập","" }
        };
        string[,] helpStringTeacher = new string[4, 3]
        {
            { "B1: Điền thông tin giáo viên cần thêm vào các bảng", "B2: Nhấp chuột trái vào nút Thêm để thêm giáo viên vào cơ sở dữ liệu","" },
            { "B1: Nhấp chuột trái 2 lần vào dòng giáo viên cần sửa trong bảng hoặc gõ mã giáo viên vào trong ô", "B2: Thay đổi thông tin ở trên các bảng","B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin giáo viên" },
            { "B1: Nhấp chuột trái 2 lần vào dòng giáo viên cần xoá", "B2: Nhấp chuột trái vào nút Xoá để xoá giáo viên khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin giáo viên cần tìm kiếm vào bảng", "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các giáo viên tương đồng với thông tin đã nhập","" }
        };
        public HelpPictureBox()
        {
            InitializeComponent();
            g = progressBar.CreateGraphics();
            progressBar.Paint += progressPaint;
        }

        private void progressPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            float percentage = 1f / (maxIndex[(int)currentState] + 1);
            int width = Convert.ToInt32(progressBar.Width * percentage);
            Rectangle rectangle = new Rectangle(0, 0, width, progressBar.Height);
            SolidBrush brush = new SolidBrush(Color.Red);

            e.Graphics.FillRectangle(brush, rectangle);
        }

        private void setImage(string filename)
        {
            switch(currentObjectToRef)
            {
                case CATSTATE.TEACHER:
                    helpLabel.Text = helpStringTeacher[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\GV" + filename);
                    break;
                case CATSTATE.STUDENT:
                    helpLabel.Text = helpStringStudent[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\HS" + filename);
                    break;
            }   

            helperPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void updateInformation(HELPERSTATE state,CATSTATE catstate, int index = 0)
        {
            //Pass
            if (index > maxIndex[(int)currentState] || index < 0) return;

            index = Define.Clamp(ref index, 0, maxIndex[(int)currentState]);
            currentIndex = index;
            currentState = state;
            currentObjectToRef = catstate;
            FillProgressBar(index);
            switch (state)
            {
                case HELPERSTATE.ADDHELPER:
                    setImage("\\add" + index + ".png");
                    return;
                case HELPERSTATE.DELETEHELPER:
                    setImage("\\del" + index + ".png");
                    return;
                case HELPERSTATE.EDITHELPER:
                    setImage("\\edit" + index + ".png");
                    return;
                case HELPERSTATE.SEARCHHELPER:
                    setImage("\\search" + index + ".png");
                    return;
            }
        }

        private void FillProgressBar(int index)
        {
            g.Clear(Color.White);
            float percentage = (float)(index + 1) / (maxIndex[(int)currentState] + 1);
            int width = Convert.ToInt32(progressBar.Width * percentage);
            Rectangle rectangle = new Rectangle(0, 0, width, progressBar.Height);

            SolidBrush brush = new SolidBrush(Color.Red);
            
            g.FillRectangle(brush, rectangle);
        }

        private void previousBTN_Click(object sender, EventArgs e)
        {
            updateInformation(currentState,currentObjectToRef ,currentIndex - 1);
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            updateInformation(currentState, currentObjectToRef, currentIndex + 1);
        }

        void checkLabeOverflow()
        {
            while (helpLabel.Width < System.Windows.Forms.TextRenderer.MeasureText(helpLabel.Text,
            new Font(helpLabel.Font.FontFamily, helpLabel.Font.Size, helpLabel.Font.Style)).Width)
            {
                helpLabel.Font = new Font(helpLabel.Font.FontFamily, helpLabel.Font.Size - 0.5f, helpLabel.Font.Style);
            }
        }

        private void helperPic_Resize(object sender, EventArgs e)
        {
            checkLabeOverflow();
        }
    }
}
