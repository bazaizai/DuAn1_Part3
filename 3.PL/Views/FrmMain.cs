using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Xps;

namespace _3.PL.Views
{
    public partial class FrmMain : Form
    {
        private Form CurrentFormChild;
        private IconButton currentBtn;
        private Panel LeftBorderBtn;
        public FrmMain()
        {
            InitializeComponent();
            HidePanel();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, QLSP.Height);
            pnlMenu.Controls.Add(LeftBorderBtn);
            this.StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0,0,0);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            CheckMenuPanel();
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(48, 143, 157);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();
                //Current Child Form Icon
                btbHome.IconChar = currentBtn.IconChar;
                btbHome.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(48, 143, 157);
                currentBtn.ForeColor = Color.FromArgb(252, 253, 253);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(252, 253, 253);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            LeftBorderBtn.Visible = false;
            btbHome.IconChar = IconChar.Home;
            btbHome.IconColor = Color.MediumPurple;
            lblHome.Text = "Home";
        }
        private void ResetLeftBorder()
        {
            DisableButton();
            LeftBorderBtn.Visible = false;
            btbHome.IconChar = IconChar.Home;
            btbHome.IconColor = Color.MediumPurple;
            lblHome.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ptnTileBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


       
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            CurrentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(ChildForm);
            pnlBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void HidePanel()
        {
            pnlbtn1.Visible = false;
            pnlbtn5.Visible = false;
            pnlbtn9.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlbtn1.Visible == true)
                pnlbtn1.Visible = false;
            if (pnlbtn5.Visible == true)
                pnlbtn5.Visible = false;
            if (pnlbtn9.Visible == true)
                pnlbtn9.Visible = false; 
            if (pnlGiaoDich.Visible == true)
                pnlGiaoDich.Visible = false;
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
                ResetLeftBorder();
            }
                
        }

        private void CheckMenuPanel()
        {
            if (pnlbtn1.Visible)
            {
                pnlbtn1.Visible = false;
            }
            if (pnlbtn5.Visible)
            {
                pnlbtn5.Visible = false;
            }
            if (pnlbtn9.Visible)
            {
                pnlbtn9.Visible = false;
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            if (pnlbtn1.Visible == false)
            {
                ActivateButton(sender, RGBColors.color1);
                ShowSubMenu(pnlbtn1);
            }
            else
            {
                pnlbtn1.Visible=false;  
            }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnCTSP.Text;
            OpenChildForm(new FrmChiTietSP());
            HideSubMenu();
        }
        private void btnSP_Click(object sender, EventArgs e)
        {
            //lblHome.Text = btnSP.Text;
            //OpenChildForm(new frm());
            HideSubMenu();
        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            lblHome.Text = btnKieusp.Text;
            OpenChildForm(new FrmQLKieuSP());
            HideSubMenu();
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ResetLeftBorder();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ResetLeftBorder();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (pnlbtn5.Visible == false)
            {
                ActivateButton(sender, RGBColors.color1);
                ShowSubMenu(pnlbtn5);
            }
            else
            {
                pnlbtn5.Visible=false;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CurrentFormChild != null)
            {
                CurrentFormChild.Close();
            }
            Reset();
            HideSubMenu();
        }

        private void _X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _ToNho_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
             
        }

        private void _tru_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnBanHang.Text;
            OpenChildForm(new frmQLBanHang());
            ActivateButton(sender, RGBColors.color1);
            HideSubMenu();
        }

        private void btnMauSac_Click(object sender, EventArgs e)
        {
            //lblHome.Text = btnMauSac.Text;
            OpenChildForm(new FrmMauSac());
            HideSubMenu();
        }

        private void btnChatLieu_Click(object sender, EventArgs e)
        {
            //lblHome.Text = btnChatLieu.Text;
            //OpenChildForm(new frmchat());
            HideSubMenu();
        }

        private void btnKichThuoc_Click(object sender, EventArgs e)
        {
            //lblHome.Text = btnKichThuoc.Text;
            //OpenChildForm(new ());
            HideSubMenu();
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            //lblHome.Text = btnTeam.Text;
            OpenChildForm(new FrmTeam());
            HideSubMenu();
        }

        private void BtnGiaiDau_Click(object sender, EventArgs e)
        {
            lblHome.Text = BtnGiaiDau.Text;
            OpenChildForm(new FrmGiaiDau());
            HideSubMenu();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnNhanvien.Text;
            OpenChildForm(new FrmNhanVien());
            HideSubMenu();
        }

        private void btnChucvu_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnChucvu.Text;
            OpenChildForm(new FrmChucVu());
            HideSubMenu();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnCTSP.Text;
            OpenChildForm(new FrmTeam());
            HideSubMenu();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnCTSP.Text;
            OpenChildForm(new FrmKichCo());
            HideSubMenu();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnCTSP.Text;
            OpenChildForm(new FrmChatLieu());
            HideSubMenu();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            lblHome.Text = btnCTSP.Text;
            OpenChildForm(new FrmMauSac());
            HideSubMenu();
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            lblHome.Text = iconButton1.Text;
            OpenChildForm(new FrmKhachHang());
            ActivateButton(sender, RGBColors.color1);
            HideSubMenu();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            if (pnlGiaoDich.Visible == false)
            {
                ActivateButton(sender, RGBColors.color1);
                ShowSubMenu(pnlGiaoDich);
            }
            else
            {
                pnlGiaoDich.Visible = false;
            }
        }
    }
}
