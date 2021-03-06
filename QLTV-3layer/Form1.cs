﻿using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_3layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ShowFormDangNhap();
        }

        private void ShowFormDangNhap()
        {
            frm_DangNhap fDangNhap = new frm_DangNhap();
            fDangNhap.setParentForm = this;
            fDangNhap.StartPosition = FormStartPosition.CenterScreen;
            fDangNhap.ShowDialog();

        }
        public void login(string tenNV)
        {
            btIQLTV.Text = "Phần Mền Quản Lý Thư Viện - Xin Chào " + tenNV;
            btDangNhap.Text = "Đăng Xuất";
            btDangNhap.Image = QLTV_3layer.Properties.Resources.reset2_32x32;
            rbtBanDoc.Enabled = true;
            rbtSach.Enabled = true;
            rbtMuonTraSach.Enabled = true;
            rbtThongKeBaoCao.Enabled = true;
        }
        public void logOut()
        {
            btIQLTV.Text = "Phần mền Quản Lý Thư Viện";
            btDangNhap.Text = "Đăng Nhập";
            btDangNhap.Image = QLTV_3layer.Properties.Resources.Login;
            rbtBanDoc.Enabled = false;
            rbtSach.Enabled = false;
            rbtThongKeBaoCao.Enabled = false;
            rbtMuonTraSach.Enabled = false;
        }
       

       /* private void buttonItem14_Click(object sender, EventArgs e)
        {

        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Xử lý thông tin độc giả
        private void btThongtindocgia_Click(object sender, EventArgs e)
        {
            TabItem tab = tabMain.CreateTab("Bạn Đọc");
            frm_BANDOC f_BANDOC = new frm_BANDOC();
            f_BANDOC.Dock = DockStyle.Fill;
            f_BANDOC.FormBorderStyle = FormBorderStyle.None;
            f_BANDOC.TopLevel = false;
            tab.AttachedControl.Controls.Add(f_BANDOC);
            f_BANDOC.Show();
            tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
        }

        private void btNhapsach_Click(object sender, EventArgs e)
        {
            TabItem tab = tabMain.CreateTab("Sách");

        }
    }
}
