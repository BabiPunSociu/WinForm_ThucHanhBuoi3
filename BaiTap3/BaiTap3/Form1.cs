using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<string> fileName = new List<string>(); // Đường dẫn + tên file

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Duyệt các ổ đĩa trong máy tính và add vào comboBox
            DriveInfo[] drivers = DriveInfo.GetDrives();    // DriveInfo trong thư viện System.IO;
            foreach(DriveInfo driver in drivers)
            {
                cbBoxODia.Items.Add(driver);
            }    
        }

        private void cbBoxODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBoxODia.SelectedIndex != -1)
            {
                string ODia = cbBoxODia.SelectedItem.ToString().Trim(); // Ví dụ:   C:\
                // Duyệt các thư mục trong ổ đĩa được chọn và add vào comboBox thư mục
                DirectoryInfo Directory = new DirectoryInfo(ODia    /* Đường dẫn */);
                DirectoryInfo[] Directories = Directory.GetDirectories("*.*");
                FileInfo[] files = Directory.GetFiles();
                foreach(DirectoryInfo d in Directories)
                {
                    cbBoxThuMuc.Items.Add(d.Name);
                }    
            }    
        }

        private void cbBoxThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cbBoxThuMuc.SelectedIndex != -1)
            {
                lstTapTin.Items.Clear();
                rtfText.Clear();

                string[] files = Directory.GetFiles(cbBoxODia.Text + cbBoxThuMuc.Text);
                fileName = files.ToList();
                foreach(string file in files)
                {
                    // Nếu file có extension là .mp3 thì add vào listbox
                    string extension = Path.GetExtension(file);
                    // output ".mp3"
                    if (extension == ".mp3" /* || extension == ".txt" || extension == ".rtf" */)
                    lstTapTin.Items.Add(file);
                }    
            }    
        }

        private void lstTapTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( lstTapTin.SelectedIndex != -1 )
            {
                // Chạy file mp3 được chọn
                MediaPlayer.URL = lstTapTin.SelectedItem.ToString();

                // Lấy tên file mà không có Extension
                string tenbaihat = Path.GetFileNameWithoutExtension(lstTapTin.SelectedItem.ToString());
                // Tìm file lời bài hát thông qua dữ liệu lưu ở list fileName
                foreach(string file in fileName)
                {
                    if(Path.GetFileName(file) == tenbaihat+".txt")
                    {
                        FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                        StreamReader rd = new StreamReader(fs,Encoding.UTF8);
                        rtfText.Text = rd.ReadToEnd();
                        rd.Close();
                        fs.Close();

                        return;
                    }   
                    if(Path.GetFileName(file) == tenbaihat+".rtf")
                    {
                        rtfText.LoadFile(file);
                        return;
                    }    
                }
                rtfText.Text = "Không có lời";
            }    
        }
    }
}
