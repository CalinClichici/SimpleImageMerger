
namespace LipireImagini
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnStitch = new System.Windows.Forms.Button();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.checkBoxFileName = new System.Windows.Forms.CheckBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adauga Imagini";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnStitch
            // 
            this.btnStitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnStitch.Location = new System.Drawing.Point(12, 104);
            this.btnStitch.Name = "btnStitch";
            this.btnStitch.Size = new System.Drawing.Size(159, 40);
            this.btnStitch.TabIndex = 1;
            this.btnStitch.Text = "Lipeste Imagini";
            this.btnStitch.UseVisualStyleBackColor = true;
            this.btnStitch.Click += new System.EventHandler(this.btnStitch_Click);
            // 
            // listBoxImages
            // 
            this.listBoxImages.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 20;
            this.listBoxImages.Items.AddRange(new object[] {
            "img1",
            "img2",
            "img3"});
            this.listBoxImages.Location = new System.Drawing.Point(224, 54);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(186, 80);
            this.listBoxImages.TabIndex = 5;
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnClearList.Location = new System.Drawing.Point(13, 58);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(159, 40);
            this.btnClearList.TabIndex = 6;
            this.btnClearList.Text = "Elimina Imaginile";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnExit.Location = new System.Drawing.Point(13, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFileName.Location = new System.Drawing.Point(371, 19);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(116, 26);
            this.textBoxFileName.TabIndex = 9;
            this.textBoxFileName.Text = "ImagineFinala";
            // 
            // checkBoxFileName
            // 
            this.checkBoxFileName.AutoSize = true;
            this.checkBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxFileName.Location = new System.Drawing.Point(178, 21);
            this.checkBoxFileName.Name = "checkBoxFileName";
            this.checkBoxFileName.Size = new System.Drawing.Size(187, 24);
            this.checkBoxFileName.TabIndex = 10;
            this.checkBoxFileName.Text = "Numele Imaginii Finale";
            this.checkBoxFileName.UseVisualStyleBackColor = true;
            this.checkBoxFileName.CheckedChanged += new System.EventHandler(this.checkBoxFileName_CheckedChanged);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackgroundImage = global::LipireImagini.Properties.Resources.up_arrow___Copy;
            this.btnMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveDown.Location = new System.Drawing.Point(177, 104);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(40, 40);
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackgroundImage = global::LipireImagini.Properties.Resources.down_arrow;
            this.btnMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveUp.Location = new System.Drawing.Point(178, 54);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(40, 40);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.listBoxImages);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnStitch);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lipeste Imagini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btnStitch;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.CheckBox checkBoxFileName;
    }
}

