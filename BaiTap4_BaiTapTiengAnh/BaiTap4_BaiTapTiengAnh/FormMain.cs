using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Policy;

namespace BaiTap4_BaiTapTiengAnh
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // kiểm tra xem 1 Form với tên nào đó đã hiển thị trong Form Cha (frmMain) chưa?
        public bool CheckExistForm(string frmname, string frmText)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if( frm.Name == frmname && frm.Text == frmText)
                    return true;
            }
            return false;
        }


        // hiển thị lên trên cùng các trong số các Form Con nếu nó đã hiện mà không phải tạo thể hiện mới
        public void ActiveChildForm(string frmname, string frmText)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == frmname && frm.Text == frmText)
                {
                    frm.Activate(); // Hiển thị lên trên nhất
                    break;
                }
            }
        }

        private void baiDienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExistForm("FormDienTu", "Bài tập điền từ 1"))
                ActiveChildForm("FormDienTu", "Bài tập điền từ 1");
            else
            {
                BTDienTu bt = new BTDienTu();
                bt.Debai = "It can take a long time to become successful in your chosen field," +
                    " however talented you are. One thing you have to be (1) _______ of is that you " +
                    "will face criticism along the way. The world is (2)_________ of people who would " +
                    "rather say something negative than positive. If you’ve made up your (3)_______ to " +
                    "achieve a certain goal, such as writing a novel, (4)_________ the negative criticism " +
                    "of others prevent you from reaching your target, and let the constructive criticism have " +
                    "a positive effect on your work. If someone says you’re totally in the (5)______ of talent, " +
                    "ignore them. That’s negative criticism. If (6), __________, someone advises you to revise " +
                    "your work and gives you a good reason for doing so, you should consider their suggestions " +
                    "carefully. There are many film stars (7)__________ were once out of work . There are many " +
                    "famous novelists who made a complete mess of their first novel – or who didn’t, but had to " +
                    "keep on approaching hundreds of publishers before they could get it (8) ________. Being " +
                    "successful does depend on luck, to a (9)________ extent. But things are more likely to " +
                    "(10) ________ well if you persevere and stay positive.";

                bt.Dapan = "It can take a long time to become successful in your chosen field," +
                    " however talented you are. One thing you have to be (1) __aware__ of is that you " +
                    "will face criticism along the way. The world is (2)__full__ of people who would " +
                    "rather say something negative than positive. If you’ve made up your (3)__mind__ to " +
                    "achieve a certain goal, such as writing a novel, (4)__don’t let__ the negative criticism " +
                    "of others prevent you from reaching your target, and let the constructive criticism have " +
                    "a positive effect on your work. If someone says you’re totally in the (5)__lack__ of talent, " +
                    "ignore them. That’s negative criticism. If (6), __however__, someone advises you to revise " +
                    "your work and gives you a good reason for doing so, you should consider their suggestions " +
                    "carefully. There are many film stars (7)__who__ were once out of work . There are many " +
                    "famous novelists who made a complete mess of their first novel – or who didn’t, but had to " +
                    "keep on approaching hundreds of publishers before they could get it (8) __published__. Being " +
                    "successful does depend on luck, to a (9)__certain__ extent. But things are more likely to " +
                    "(10) __turn out__ well if you persevere and stay positive.";

                List<string> list = new List<string>();
                list.Add("aware");
                list.Add("full");
                list.Add("mind");
                list.Add("don’t let");
                list.Add("lack");
                list.Add("however");
                list.Add("who");
                list.Add("published");
                list.Add("certain");
                list.Add("turn out");

                bt.Dapantungcau = list;

                Data.data = bt;

                FormDienTu frm = new FormDienTu();
                frm.MdiParent = this;
                frm.Text = "Bài tập điền từ 1";
                frm.Show();
            }
        }

        private void baiDienTu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExistForm("FormDienTu", "Bài tập điền từ 2"))
                ActiveChildForm("FormDienTu", "Bài tập điền từ 2");
            else
            {
                BTDienTu bt = new BTDienTu();
                bt.Debai = "Statesmen define a family as “a group of individuals having a common dwelling and related by blood, adoption or marriage, (1) ______________ " +
                    "includes common-law relationships.” Most people are born into one of these groups and(2) ______________live their lives as a family in such a group." +
                    "Although the definition of a family may not change, (3) ______________.relationship of people to each other within the family group changes as society " +
                    "changes.More and more wives are(4) ______________paying jobs, and, as a result, the roles of husband, wife and children are changing. Today, men expect " +
                    "to(5)______________. for pay for about 40 years of their lives, and, in today’s marriages(6)______________.which both spouses have paying jobs, women can " +
                    "expect to work for about 30 to 35 years of their lives.This mean that man must learn to do their share of family tasks such as caring for the children " +
                    "and daily(7)______________chores.Children, too, especially adolescents, have to(8)______________with the members od their family in sharing household " +
                    "tasks.The widespread acceptance of contraception has meant that having(9)______________ is as matter of choice, not an automatic result of marriage." +
                    "Marriage itself has become a choice.As alternatives(10)______________ common - law relationships and single - parent families have become socially " +
                    "acceptable, women will become more independent.";

                bt.Dapan = "Statesmen define a family as “a group of individuals having a common dwelling and related by blood, adoption or marriage, (1) __it__ includes " +
                    "common-law relationships.” Most people are born into one of these groups and(2) __will__ live their lives as a family in such a group.Although the " +
                    "definition of a family may not change, (3) __the__.relationship of people to each other within the family group changes as society changes.More and " +
                    "more wives are(4) __performing__paying jobs, and, as a result, the roles of husband, wife and children are changing. Today, men expect to" +
                    "(5)__work__. for pay for about 40 years of their lives, and, in today’s marriages(6)__in__.which both spouses have paying jobs, women can expect " +
                    "to work for about 30 to 35 years of their lives.This mean that man must learn to do their share of family tasks such as caring for the children and" +
                    " daily(7)______________chores.Children, too, especially adolescents, have to(8)______________with the members od their family in sharing household " +
                    "tasks.The widespread acceptance of contraception has meant that having(9)______________ is as matter of choice, not an automatic result of marriage." +
                    "Marriage itself has become a choice.As alternatives(10)______________ common - law relationships and single - parent families have become socially " +
                    "acceptable, women will become more independent.";

                List<string> list = new List<string>();
                list.Add("it");
                list.Add("will");
                list.Add("the");
                list.Add("performing");
                list.Add("work");
                list.Add("in");
                list.Add("household");
                list.Add("cooperate");
                list.Add("children");
                list.Add("such as");
                bt.Dapantungcau = list;
                Data.data = bt;

                FormDienTu frm = new FormDienTu();
                frm.MdiParent = this;
                frm.Text = "Bài tập điền từ 2";
                frm.Show();
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình này không?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
