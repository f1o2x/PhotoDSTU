namespace Photoshop_DSTU
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ePICFORMATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ePICFORMATLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.philtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reliefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyContursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBGBRBRGRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.goToGrayToolStripMenuItem,
            this.mirrorVerticalToolStripMenuItem,
            this.philtersToolStripMenuItem,
            this.resizeToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.rGBGBRBRGRGBToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(130, 538);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.ePICFORMATToolStripMenuItem,
            this.ePICFORMATLoadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 18);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ePICFORMATToolStripMenuItem
            // 
            this.ePICFORMATToolStripMenuItem.Name = "ePICFORMATToolStripMenuItem";
            this.ePICFORMATToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ePICFORMATToolStripMenuItem.Text = "EPICFORMAT save";
            this.ePICFORMATToolStripMenuItem.Click += new System.EventHandler(this.ePICFORMATToolStripMenuItem_Click);
            // 
            // ePICFORMATLoadToolStripMenuItem
            // 
            this.ePICFORMATLoadToolStripMenuItem.Name = "ePICFORMATLoadToolStripMenuItem";
            this.ePICFORMATLoadToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ePICFORMATLoadToolStripMenuItem.Text = "EPICFORMAT load";
            this.ePICFORMATLoadToolStripMenuItem.Click += new System.EventHandler(this.ePICFORMATLoadToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBrightnessToolStripMenuItem,
            this.correctBrightnessToolStripMenuItem});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(89, 18);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            // 
            // changeBrightnessToolStripMenuItem
            // 
            this.changeBrightnessToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.changeBrightnessToolStripMenuItem.Name = "changeBrightnessToolStripMenuItem";
            this.changeBrightnessToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.changeBrightnessToolStripMenuItem.Text = "Change Brightness";
            this.changeBrightnessToolStripMenuItem.Click += new System.EventHandler(this.changeBrightnessToolStripMenuItem_Click);
            // 
            // correctBrightnessToolStripMenuItem
            // 
            this.correctBrightnessToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.correctBrightnessToolStripMenuItem.Name = "correctBrightnessToolStripMenuItem";
            this.correctBrightnessToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.correctBrightnessToolStripMenuItem.Text = "Correct Brightness";
            this.correctBrightnessToolStripMenuItem.Click += new System.EventHandler(this.correctBrightnessToolStripMenuItem_Click);
            // 
            // goToGrayToolStripMenuItem
            // 
            this.goToGrayToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.goToGrayToolStripMenuItem.Name = "goToGrayToolStripMenuItem";
            this.goToGrayToolStripMenuItem.Size = new System.Drawing.Size(89, 18);
            this.goToGrayToolStripMenuItem.Text = "Go to Gray";
            this.goToGrayToolStripMenuItem.Click += new System.EventHandler(this.goToGrayToolStripMenuItem_Click);
            // 
            // mirrorVerticalToolStripMenuItem
            // 
            this.mirrorVerticalToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mirrorVerticalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.mirrorVerticalToolStripMenuItem.Name = "mirrorVerticalToolStripMenuItem";
            this.mirrorVerticalToolStripMenuItem.Size = new System.Drawing.Size(61, 18);
            this.mirrorVerticalToolStripMenuItem.Text = "Mirror";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // philtersToolStripMenuItem
            // 
            this.philtersToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.philtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reliefToolStripMenuItem,
            this.greyContursToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.sharpnessToolStripMenuItem,
            this.custom1ToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.philtersToolStripMenuItem.Name = "philtersToolStripMenuItem";
            this.philtersToolStripMenuItem.Size = new System.Drawing.Size(75, 18);
            this.philtersToolStripMenuItem.Text = "Philters";
            // 
            // reliefToolStripMenuItem
            // 
            this.reliefToolStripMenuItem.Name = "reliefToolStripMenuItem";
            this.reliefToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.reliefToolStripMenuItem.Text = "Relief";
            this.reliefToolStripMenuItem.Click += new System.EventHandler(this.reliefToolStripMenuItem_Click);
            // 
            // greyContursToolStripMenuItem
            // 
            this.greyContursToolStripMenuItem.Name = "greyContursToolStripMenuItem";
            this.greyContursToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.greyContursToolStripMenuItem.Text = "Grey and Conturs";
            this.greyContursToolStripMenuItem.Click += new System.EventHandler(this.greyContursToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // sharpnessToolStripMenuItem
            // 
            this.sharpnessToolStripMenuItem.Name = "sharpnessToolStripMenuItem";
            this.sharpnessToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sharpnessToolStripMenuItem.Text = "Sharpness";
            this.sharpnessToolStripMenuItem.Click += new System.EventHandler(this.sharpnessToolStripMenuItem_Click);
            // 
            // custom1ToolStripMenuItem
            // 
            this.custom1ToolStripMenuItem.Name = "custom1ToolStripMenuItem";
            this.custom1ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.custom1ToolStripMenuItem.Text = "Aqua";
            this.custom1ToolStripMenuItem.Click += new System.EventHandler(this.custom1ToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseX2ToolStripMenuItem,
            this.decreaseX2ToolStripMenuItem});
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(61, 18);
            this.resizeToolStripMenuItem.Text = "Resize";
            // 
            // increaseX2ToolStripMenuItem
            // 
            this.increaseX2ToolStripMenuItem.Name = "increaseX2ToolStripMenuItem";
            this.increaseX2ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.increaseX2ToolStripMenuItem.Text = "Increase x2";
            this.increaseX2ToolStripMenuItem.Click += new System.EventHandler(this.increaseX2ToolStripMenuItem_Click);
            // 
            // decreaseX2ToolStripMenuItem
            // 
            this.decreaseX2ToolStripMenuItem.Name = "decreaseX2ToolStripMenuItem";
            this.decreaseX2ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.decreaseX2ToolStripMenuItem.Text = "Decrease x2";
            this.decreaseX2ToolStripMenuItem.Click += new System.EventHandler(this.decreaseX2ToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(61, 18);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // rGBGBRBRGRGBToolStripMenuItem
            // 
            this.rGBGBRBRGRGBToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rGBGBRBRGRGBToolStripMenuItem.Name = "rGBGBRBRGRGBToolStripMenuItem";
            this.rGBGBRBRGRGBToolStripMenuItem.Size = new System.Drawing.Size(124, 18);
            this.rGBGBRBRGRGBToolStripMenuItem.Text = "Switch channels";
            this.rGBGBRBRGRGBToolStripMenuItem.Click += new System.EventHandler(this.rGBGBRBRGRGBToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(983, 538);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DSTU_PhotoShop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ePICFORMATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ePICFORMATLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem philtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reliefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyContursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseX2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseX2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBrightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctBrightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBGBRBRGRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;


    }
}

