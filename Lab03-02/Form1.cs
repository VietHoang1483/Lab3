using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Hàm mở file
        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        richText.LoadFile(openFileDialog.FileName,RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richText.LoadFile(openFileDialog.FileName,RichTextBoxStreamType.PlainText);
                    }

                }
            }
        }

        // Hàm làm mới trang
        private void NewDocument()
        {
            richText.Clear();
            richText.Font = new Font("Tahoma", 14);
            tscboFont.Text = "Tahoma";
            tscboSize.Text = "14";
        }

        //Hàm lưu
        private void SavingFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text Format(*.rtf) | *.rtf | Text File(*.txt) | *.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richText.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.RichText);
                }
                else
                {
                    richText.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.PlainText);
                }

            }
        }

        //Hàm in đậm
        private void Bold()
        {
            FontStyle style = richText.SelectionFont.Style;

            if (richText.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;
            }
            richText.SelectionFont = new Font(richText.SelectionFont, style);
        }

        //Hàm in nghiêng
        private void Italic()
        {
            FontStyle style = richText.SelectionFont.Style;

            if (richText.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richText.SelectionFont = new
            Font(richText.SelectionFont, style);
        }

        //Hàm gạch chân
        private void Underline()
        {
            FontStyle style = richText.SelectionFont.Style;

            if (richText.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richText.SelectionFont = new Font(richText.SelectionFont, style);
        }

        //Hàm đổi font
        private void tscFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscboFont.Text != "" && tscboSize.Text != "")
            {
                float size = float.Parse(tscboSize.Text);
                FontStyle style = richText.SelectionFont != null ? richText.SelectionFont.Style : FontStyle.Regular;
                richText.SelectionFont = new Font(tscboFont.Text, size, style);
            }
        }

        //Hàm đổi Size
        private void tscSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscboFont.Text != "" && tscboSize.Text != "")
            {
                float size = float.Parse(tscboSize.Text);
                FontStyle style = richText.SelectionFont != null ? richText.SelectionFont.Style : FontStyle.Regular;
                richText.SelectionFont = new Font(tscboFont.Text, size, style);
            }
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] sizeValues = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            tscboSize.ComboBox.DataSource = sizeValues;

            foreach (FontFamily fontFamily in new InstalledFontCollection().Families) {
                tscboFont.Items.Add(fontFamily.Name);
            }
            tscboFont.SelectedItem = "Tahoma";
            tscboSize.SelectedItem = 14;
            richText.Font = new Font("Tahoma", 14, FontStyle.Regular); 
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            SavingFile();
        }

        private void tsbtnU_Click(object sender, EventArgs e)
        {
            if (tsbtnB.BackColor == Color.White)
            {
                tsbtnB.BackColor = Color.Silver;
                
            }
            else if (tsbtnB.BackColor == Color.Silver)
            {
                tsbtnB.BackColor = Color.White;
            }
            Bold();
            
        }

        private void tsbtnI_Click(object sender, EventArgs e)
        {
            if (tsbtnI.BackColor == Color.White)
            {
                tsbtnI.BackColor = Color.Silver;

            }
            else if (tsbtnI.BackColor == Color.Silver)
            {
                tsbtnI.BackColor = Color.White;
            }
            Italic();
        }

        private void tsbtnU_Click_1(object sender, EventArgs e)
        {
            if (tsbtnU.BackColor == Color.White)
            {
                tsbtnU.BackColor = Color.Silver;

            }
            else if (tsbtnU.BackColor == Color.Silver)
            {
                tsbtnU.BackColor = Color.White;
            }
            Underline();
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavingFile();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tscboFont_TextChanged(object sender, EventArgs e)
        {

        }

        private void tscboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscboFont.Text != "" && tscboSize.Text != "")
            {
                float size = float.Parse(tscboSize.Text);
                FontStyle style = richText.SelectionFont != null ? richText.SelectionFont.Style : FontStyle.Regular;
                richText.SelectionFont = new Font(tscboFont.Text, size, style);
            }
        }

        private void tscboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscboFont.Text != "" && tscboSize.Text != "")
            {
                float size = float.Parse(tscboSize.Text);
                FontStyle style = richText.SelectionFont != null ? richText.SelectionFont.Style : FontStyle.Regular;
                richText.SelectionFont = new Font(tscboFont.Text, size, style);
            }
        }

        private void tscboSize_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnB_Click(object sender, EventArgs e)
        {
            if (tsbtnB.BackColor == Color.White)
            {
                tsbtnB.BackColor = Color.Silver;

            }
            else if (tsbtnB.BackColor == Color.Silver)
            {
                tsbtnB.BackColor = Color.White;
            }
            Bold();
        }
    }
}
