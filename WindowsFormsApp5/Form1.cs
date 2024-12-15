using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            foreach (FontFamily fontFamily in new InstalledFontCollection().Families)
            { cbxFont.Items.Add(fontFamily.Name); }
            cbxFont.SelectedItem = "Tahoma";
        }
        private void loadSize()
        {
            int[] sizeValues = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            cbxSize.ComboBox.DataSource = sizeValues;
            cbxSize.SelectedItem = 14;
        
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

        private void cbxSize_Click(object sender, EventArgs e)
        {

        }

        private void indam_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Style.HasFlag(FontStyle.Bold))
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Bold;
                }

                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void innghieng__Click(object sender, EventArgs e)
        {

            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Style.HasFlag(FontStyle.Italic))
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Italic;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Italic;
                }
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }
    }

        private void gachchan__Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Style.HasFlag(FontStyle.Underline))
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Underline;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Underline;
                }

                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void taoVanBanMoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn tạo văn bản mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                richText.Clear();
            }
        }

        private void moTap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    richText.Text = reader.ReadToEnd();
                }
            }
        }

        private void lưuNộiDungVănBản_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(richText.Text);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn tạo văn bản mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                richText.Clear();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(richText.Text);
                }
            }
            }
    }
}
