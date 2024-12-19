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

namespace BTTLb5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() == DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richText.Text = "";
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            toolStripButton3.BackColor = Color.White;
            toolStripButton4.BackColor = Color.White;
            toolStripButton5.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(toolStripButton3.BackColor == Color.White)
            {
                toolStripButton3.BackColor = Color.Gray;
                Bold();
            } else if (toolStripButton3.BackColor == Color.Gray)
            {
                toolStripButton3.BackColor = Color.White;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (toolStripButton4.BackColor == Color.White)
            {
                toolStripButton4.BackColor = Color.Gray;
                Italic();
            }
            else if (toolStripButton4.BackColor == Color.Gray)
            {
                toolStripButton4.BackColor = Color.White;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (toolStripButton5.BackColor == Color.White)
            {
                toolStripButton5.BackColor = Color.Gray;
                Underline();
            }
            else if (toolStripButton5.BackColor == Color.Gray)
            {
                toolStripButton5.BackColor = Color.White;
            }
        }

        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.LoadFile(openFileDialog.FileName,
RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richTextBox1.LoadFile(openFileDialog.FileName,
RichTextBoxStreamType.PlainText);
                    }

                }
            }
        }

        private void SavingFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text Format(*.rtf) | *.rtf | Text File(*.txt) | *.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog.FileName,
RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(saveFileDialog.FileName,
RichTextBoxStreamType.PlainText);
                }

            }
        }

        private void Bold()
        {
            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;
            }
            richText.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void Italic()
        {
            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new
            Font(richTextBox1.SelectionFont, style);

        }

        private void Underline()
        {
            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new
Font(richTextBox1.SelectionFont, style);
        }
        private void NewDocument()
        {
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Tahoma", 14);
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
        }

        private void lưuVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavingFile();
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SavingFile();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                string selectionFont = toolStripComboBox1.Text;
                float currentSize = richTextBox1.SelectionFont.Size;
                richTextBox1.SelectionFont = new Font(selectionFont,
                currentSize, richTextBox1.SelectionFont.Style);
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                string currentFont = richTextBox1.SelectionFont.FontFamily.Name;
                float selectedSize = float.Parse(toolStripComboBox1.Text);
                richTextBox1.SelectionFont = new Font(currentFont,
selectedSize, richTextBox1.SelectionFont.Style);
            }
        }
    }
}
