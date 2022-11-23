using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace _3.PL.Views
{
    public partial class FrmForgotPW : Form
    {
        private INhanVienServices _iNhanVienServices;
        private static Random random = new Random();
        
            
        public FrmForgotPW()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
            this.CenterToScreen();
            
        }


        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void MailSendThruGmail(string email, string pw)
        {
            MailAddress fromAddress = new MailAddress("anhptph25812@fpt.edu.vn", "Admin");
            MailAddress toAddress = new MailAddress(email, "User");
            const string subject = "Đổi mật khẩu tài khoản phần mềm bán mũ 47 Brand";
            string body = @"Bạn đã yêu cầu đổi mật khẩu. Mật khẩu mới của bạn là: <b>" + pw + "</b>";

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage(fromAddress.Address, toAddress.Address, subject, body);
            msg.IsBodyHtml = true;

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("anhptph25812@fpt.edu.vn", "j g f p o s l x y p s y w h a r"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
            };
            //try
            //{
            //    client.Send(msg);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}          
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                client.Send(msg);
            }
        }

      

       

        private void lb_SignIn_Click(object sender, EventArgs e)
        {

            FrmLogin frmLogin = new FrmLogin();
            this.Close();
            frmLogin.ShowDialog();
            
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            var em = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Email == tb_email.Text && x.TaiKhoan == tb_tk.Text);
            if (em == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản và Email trùng khớp. Vui lòng kiểm tra lại");
            }
            else
            {
                string random = RandomString(6);
                em.MatKhau = random;
                _iNhanVienServices.Update(em);

                MailSendThruGmail(tb_email.Text, random);
                MessageBox.Show($"Mật khẩu mới đã được gởi đến {tb_email.Text} . Vui lòng kiểm tra email để tiếp tục bước tiếp theo...");
                this.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
            }
        }
    }
}
