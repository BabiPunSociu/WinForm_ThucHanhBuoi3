namespace BaiTap3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBoxODia = new System.Windows.Forms.ComboBox();
            this.cbBoxThuMuc = new System.Windows.Forms.ComboBox();
            this.lstTapTin = new System.Windows.Forms.ListBox();
            this.rtfText = new System.Windows.Forms.RichTextBox();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tập tin";
            // 
            // cbBoxODia
            // 
            this.cbBoxODia.FormattingEnabled = true;
            this.cbBoxODia.Location = new System.Drawing.Point(103, 8);
            this.cbBoxODia.Name = "cbBoxODia";
            this.cbBoxODia.Size = new System.Drawing.Size(446, 26);
            this.cbBoxODia.TabIndex = 4;
            this.cbBoxODia.SelectedIndexChanged += new System.EventHandler(this.cbBoxODia_SelectedIndexChanged);
            // 
            // cbBoxThuMuc
            // 
            this.cbBoxThuMuc.FormattingEnabled = true;
            this.cbBoxThuMuc.Location = new System.Drawing.Point(103, 46);
            this.cbBoxThuMuc.Name = "cbBoxThuMuc";
            this.cbBoxThuMuc.Size = new System.Drawing.Size(446, 26);
            this.cbBoxThuMuc.TabIndex = 5;
            this.cbBoxThuMuc.SelectedIndexChanged += new System.EventHandler(this.cbBoxThuMuc_SelectedIndexChanged);
            // 
            // lstTapTin
            // 
            this.lstTapTin.FormattingEnabled = true;
            this.lstTapTin.ItemHeight = 18;
            this.lstTapTin.Location = new System.Drawing.Point(25, 121);
            this.lstTapTin.Name = "lstTapTin";
            this.lstTapTin.Size = new System.Drawing.Size(524, 184);
            this.lstTapTin.TabIndex = 6;
            this.lstTapTin.SelectedIndexChanged += new System.EventHandler(this.lstTapTin_SelectedIndexChanged);
            // 
            // rtfText
            // 
            this.rtfText.Location = new System.Drawing.Point(564, 8);
            this.rtfText.Name = "rtfText";
            this.rtfText.Size = new System.Drawing.Size(562, 487);
            this.rtfText.TabIndex = 7;
            this.rtfText.Text = "";
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(26, 314);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(522, 180);
            this.MediaPlayer.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1134, 506);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.rtfText);
            this.Controls.Add(this.lstTapTin);
            this.Controls.Add(this.cbBoxThuMuc);
            this.Controls.Add(this.cbBoxODia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 3: Ví dụ ComboBox";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBoxODia;
        private System.Windows.Forms.ComboBox cbBoxThuMuc;
        private System.Windows.Forms.ListBox lstTapTin;
        private System.Windows.Forms.RichTextBox rtfText;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
    }
}

