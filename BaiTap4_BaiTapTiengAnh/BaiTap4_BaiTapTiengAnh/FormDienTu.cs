using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4_BaiTapTiengAnh
{
    public partial class FormDienTu : Form
    {
        BTDienTu bt = Data.data;
        public FormDienTu()
        {
            InitializeComponent();
        }

        private void FormDienTu_Load(object sender, EventArgs e)
        {
            txtDeBai.Text = bt.Debai;
        }

        public int kiemtra(TextBox txt,int index)
        {
            if (txt.Text.Trim() == bt.Dapantungcau[index])
            {
                txt.BackColor = Color.Cyan;
                return 1;
            }
            else txt.BackColor = Color.HotPink;
            return 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = kiemtra(txtDA1,0) + kiemtra(txtDA2, 1) + kiemtra(txtDA3, 2) + kiemtra(txtDA4, 3) +
                kiemtra(txtDA5, 4) + kiemtra(txtDA6, 5) + kiemtra(txtDA7, 6) + kiemtra(txtDA8, 7) + 
                kiemtra(txtDA9, 8) + kiemtra(txtDA10, 9);
            MessageBox.Show($"Bạn được {diem} điểm");
        }
        
        private void btnDapAn_Click(object sender, EventArgs e)
        {
            txtDeBai.Text = bt.Dapan;
        }
        public void txtReset(TextBox txt)
                {
                    txt.Clear();
                    txt.BackColor = Color.White;
                }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtDeBai.Text = bt.Debai;
            txtReset(txtDA1);
            txtReset(txtDA2);
            txtReset(txtDA1);
            txtReset(txtDA3);
            txtReset(txtDA4);
            txtReset(txtDA5);
            txtReset(txtDA6);
            txtReset(txtDA7);
            txtReset(txtDA8);
            txtReset(txtDA9);
            txtReset(txtDA10);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi Bài Tập Điền Từ này không?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
