using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LipireImagini
{
    public partial class Form1 : Form
    {
        private OpenFileDialog open = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            InitializeListBoxStartUp();
            InitializeFileName();
        }

        private void InitializeOpenFileDialog()
        {   
            open.Multiselect = true;
            open.Title = "Selectare de imagini";
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
        }

        private void InitializeListBoxStartUp()
        {
            btnMoveUp.Enabled = false;
            btnMoveUp.Visible = false;
            btnMoveDown.Enabled = false;
            btnMoveDown.Visible = false;
            listBoxImages.Items.Clear();
            listBoxImages.Visible = false;
        }

        private void ShowListBoxImages()
        {
            int max = 0;
            for(int index = 0; index < listBoxImages.Items.Count; ++index)
               max = (int)this.CreateGraphics().MeasureString(listBoxImages.Items[index].ToString(), listBoxImages.Font, TextRenderer.MeasureText(listBoxImages.Items[index].ToString(), new Font("Microsoft Sans Serif", 12.0F))).Width;
            
            listBoxImages.Width = max + 5;
            listBoxImages.Height = (listBoxImages.Items.Count + 1) * 20;
            listBoxImages.Visible = true;

            btnMoveUp.Enabled = true;
            btnMoveUp.Visible = true;
            btnMoveDown.Enabled = true;
            btnMoveDown.Visible = true;

            checkBoxFileName.Enabled = true;
            checkBoxFileName.Visible = true;
            textBoxFileName.Visible = true;
        }

        private void InitializeFileName()
        {
            checkBoxFileName.Visible = false;
            checkBoxFileName.Enabled = false;
            textBoxFileName.Visible = false;
            textBoxFileName.Enabled = false;
            textBoxFileName.Text = "ImagineFinala";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach(string file in open.FileNames)
                {
                    listBoxImages.Items.Add(file);
                }                    
            }

            ShowListBoxImages();
        }

        private void btnStitch_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + textBoxFileName.Text + ".jpeg";

            List<int> imageWidths = new List<int>();
            int nIndex = 0;
            int height = 0;

            foreach (string file in listBoxImages.Items)
            {
                Image img = Image.FromFile(file);
                imageWidths.Add(img.Width);
                height += img.Height;
                img.Dispose();
            }

            imageWidths.Sort();
            int width = imageWidths[imageWidths.Count - 1];

            Bitmap img3 = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(img3);
            g.Clear(SystemColors.AppWorkspace);

            foreach (string file in listBoxImages.Items)
            {
                Image img = Image.FromFile(file);
                if (nIndex == 0)
                {
                    g.DrawImage(img, new Point(0, 0));
                    nIndex++;
                    height = img.Height;
                }
                else
                {
                    g.DrawImage(img, new Point(0, height));
                    height += img.Height;
                }
                img.Dispose();
            }

            g.Dispose();
            img3.Save(path, ImageFormat.Jpeg);
            img3.Dispose();

            MessageBox.Show("Imagine Salvata.");
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            InitializeListBoxStartUp();
            InitializeFileName();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void MoveItem(int direction)
        {
            // Checking selected item
            if (listBoxImages.SelectedItem == null || listBoxImages.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBoxImages.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBoxImages.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBoxImages.SelectedItem;

            // Removing removable element
            listBoxImages.Items.Remove(selected);
            // Insert it in new position
            listBoxImages.Items.Insert(newIndex, selected);
            // Restore selection
            listBoxImages.SetSelected(newIndex, true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxFileName_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFileName.Checked)
            {
                textBoxFileName.Enabled = true;
            }
            else
            {
                textBoxFileName.Enabled = false;
            }
        }
    }
}
