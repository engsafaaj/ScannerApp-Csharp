namespace ScannerApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            linkLabelLoadDevices = new LinkLabel();
            buttonScan = new Button();
            comboBoxDpi = new NumericUpDown();
            numericUpDownScannerPaperCont = new NumericUpDown();
            groupBox2 = new GroupBox();
            linkLabelOpenSavedFolder = new LinkLabel();
            linkLabelChangeSavedFolder = new LinkLabel();
            textBoxSavedFolder = new TextBox();
            groupBox1 = new GroupBox();
            radioButtonGray = new RadioButton();
            radioButtonColor = new RadioButton();
            pictureBox2 = new PictureBox();
            comboBoxPaperSize = new ComboBox();
            label4 = new Label();
            comboBoxDevices = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBoxShow = new PictureBox();
            buttonSaveImage = new Button();
            toolTip1 = new ToolTip(components);
            pictureBoxLoading = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDpi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScannerPaperCont).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabelLoadDevices);
            panel1.Controls.Add(buttonScan);
            panel1.Controls.Add(comboBoxDpi);
            panel1.Controls.Add(numericUpDownScannerPaperCont);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(comboBoxPaperSize);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxDevices);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 819);
            panel1.TabIndex = 0;
            // 
            // linkLabelLoadDevices
            // 
            linkLabelLoadDevices.AutoSize = true;
            linkLabelLoadDevices.Font = new Font("Cairo Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLoadDevices.Location = new Point(196, 154);
            linkLabelLoadDevices.Name = "linkLabelLoadDevices";
            linkLabelLoadDevices.Size = new Size(53, 26);
            linkLabelLoadDevices.TabIndex = 8;
            linkLabelLoadDevices.TabStop = true;
            linkLabelLoadDevices.Text = "تحديث";
            linkLabelLoadDevices.LinkClicked += linkLabelLoadDevices_LinkClicked;
            // 
            // buttonScan
            // 
            buttonScan.Dock = DockStyle.Bottom;
            buttonScan.Image = Properties.Resources.scanner_50px;
            buttonScan.ImageAlign = ContentAlignment.MiddleRight;
            buttonScan.Location = new Point(0, 752);
            buttonScan.Name = "buttonScan";
            buttonScan.Size = new Size(340, 65);
            buttonScan.TabIndex = 0;
            buttonScan.Text = "اجراء المسح";
            buttonScan.UseVisualStyleBackColor = true;
            buttonScan.Click += buttonScan_Click;
            // 
            // comboBoxDpi
            // 
            comboBoxDpi.Location = new Point(27, 377);
            comboBoxDpi.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            comboBoxDpi.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            comboBoxDpi.Name = "comboBoxDpi";
            comboBoxDpi.Size = new Size(295, 45);
            comboBoxDpi.TabIndex = 2;
            comboBoxDpi.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownScannerPaperCont
            // 
            numericUpDownScannerPaperCont.Location = new Point(27, 275);
            numericUpDownScannerPaperCont.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownScannerPaperCont.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownScannerPaperCont.Name = "numericUpDownScannerPaperCont";
            numericUpDownScannerPaperCont.Size = new Size(295, 45);
            numericUpDownScannerPaperCont.TabIndex = 2;
            toolTip1.SetToolTip(numericUpDownScannerPaperCont, "عدد الاوراق في جهاز الماسح");
            numericUpDownScannerPaperCont.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(linkLabelOpenSavedFolder);
            groupBox2.Controls.Add(linkLabelChangeSavedFolder);
            groupBox2.Controls.Add(textBoxSavedFolder);
            groupBox2.Font = new Font("Cairo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(27, 616);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 128);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "مكان الحفظ";
            // 
            // linkLabelOpenSavedFolder
            // 
            linkLabelOpenSavedFolder.AutoSize = true;
            linkLabelOpenSavedFolder.Location = new Point(241, 89);
            linkLabelOpenSavedFolder.Name = "linkLabelOpenSavedFolder";
            linkLabelOpenSavedFolder.Size = new Size(48, 37);
            linkLabelOpenSavedFolder.TabIndex = 8;
            linkLabelOpenSavedFolder.TabStop = true;
            linkLabelOpenSavedFolder.Text = "فتح";
            linkLabelOpenSavedFolder.LinkClicked += linkLabelOpenSavedFolder_LinkClicked;
            // 
            // linkLabelChangeSavedFolder
            // 
            linkLabelChangeSavedFolder.AutoSize = true;
            linkLabelChangeSavedFolder.Location = new Point(12, 89);
            linkLabelChangeSavedFolder.Name = "linkLabelChangeSavedFolder";
            linkLabelChangeSavedFolder.Size = new Size(156, 37);
            linkLabelChangeSavedFolder.TabIndex = 9;
            linkLabelChangeSavedFolder.TabStop = true;
            linkLabelChangeSavedFolder.Text = "تغيير مسار الحفظ";
            linkLabelChangeSavedFolder.LinkClicked += linkLabelChangeSavedFolder_LinkClicked;
            // 
            // textBoxSavedFolder
            // 
            textBoxSavedFolder.Location = new Point(12, 41);
            textBoxSavedFolder.Name = "textBoxSavedFolder";
            textBoxSavedFolder.ReadOnly = true;
            textBoxSavedFolder.Size = new Size(277, 45);
            textBoxSavedFolder.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonGray);
            groupBox1.Controls.Add(radioButtonColor);
            groupBox1.Font = new Font("Cairo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(26, 520);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 84);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "خيارات اللون";
            // 
            // radioButtonGray
            // 
            radioButtonGray.AutoSize = true;
            radioButtonGray.Font = new Font("Cairo Medium", 12F, FontStyle.Bold);
            radioButtonGray.Location = new Point(31, 34);
            radioButtonGray.Name = "radioButtonGray";
            radioButtonGray.Size = new Size(117, 41);
            radioButtonGray.TabIndex = 6;
            radioButtonGray.Text = "غير ملون";
            radioButtonGray.UseVisualStyleBackColor = true;
            // 
            // radioButtonColor
            // 
            radioButtonColor.AutoSize = true;
            radioButtonColor.Checked = true;
            radioButtonColor.Font = new Font("Cairo Medium", 12F, FontStyle.Bold);
            radioButtonColor.ForeColor = Color.FromArgb(255, 128, 0);
            radioButtonColor.Location = new Point(182, 34);
            radioButtonColor.Name = "radioButtonColor";
            radioButtonColor.Size = new Size(86, 41);
            radioButtonColor.TabIndex = 5;
            radioButtonColor.TabStop = true;
            radioButtonColor.Text = "ملون";
            radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.AppLogo;
            pictureBox2.Location = new Point(27, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // comboBoxPaperSize
            // 
            comboBoxPaperSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaperSize.FormattingEnabled = true;
            comboBoxPaperSize.Items.AddRange(new object[] { "A4", "A5", "A3", "Letter" });
            comboBoxPaperSize.Location = new Point(25, 465);
            comboBoxPaperSize.Name = "comboBoxPaperSize";
            comboBoxPaperSize.Size = new Size(296, 45);
            comboBoxPaperSize.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 235);
            label4.Name = "label4";
            label4.Size = new Size(111, 37);
            label4.TabIndex = 20;
            label4.Text = "عدد النسخ";
            // 
            // comboBoxDevices
            // 
            comboBoxDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDevices.FormattingEnabled = true;
            comboBoxDevices.Location = new Point(26, 185);
            comboBoxDevices.Name = "comboBoxDevices";
            comboBoxDevices.Size = new Size(296, 45);
            comboBoxDevices.TabIndex = 1;
            toolTip1.SetToolTip(comboBoxDevices, "اختيار جهاز الفحص المتصل");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 425);
            label5.Name = "label5";
            label5.Size = new Size(76, 37);
            label5.TabIndex = 20;
            label5.Text = "الورقة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 327);
            label3.Name = "label3";
            label3.Size = new Size(126, 37);
            label3.TabIndex = 20;
            label3.Text = "دقة الفحص";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo ExtraBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 11);
            label2.Name = "label2";
            label2.Size = new Size(129, 112);
            label2.TabIndex = 20;
            label2.Text = "الماسح\r\nالضوئي";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 145);
            label1.Name = "label1";
            label1.Size = new Size(71, 37);
            label1.TabIndex = 20;
            label1.Text = "الجهاز";
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BackColor = Color.White;
            pictureBoxShow.Dock = DockStyle.Fill;
            pictureBoxShow.Image = Properties.Resources.scaning;
            pictureBoxShow.Location = new Point(342, 0);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(595, 819);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 1;
            pictureBoxShow.TabStop = false;
            // 
            // buttonSaveImage
            // 
            buttonSaveImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveImage.Font = new Font("Cairo Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveImage.Image = Properties.Resources.save_32px;
            buttonSaveImage.Location = new Point(873, 765);
            buttonSaveImage.Name = "buttonSaveImage";
            buttonSaveImage.Size = new Size(52, 42);
            buttonSaveImage.TabIndex = 10;
            toolTip1.SetToolTip(buttonSaveImage, "حفظ الصورة المعروضة");
            buttonSaveImage.UseVisualStyleBackColor = true;
            buttonSaveImage.Click += buttonSaveImage_Click;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.Anchor = AnchorStyles.None;
            pictureBoxLoading.BackColor = Color.Transparent;
            pictureBoxLoading.Image = Properties.Resources.loading;
            pictureBoxLoading.Location = new Point(342, 745);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(595, 73);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoading.TabIndex = 2;
            pictureBoxLoading.TabStop = false;
            pictureBoxLoading.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 819);
            Controls.Add(buttonSaveImage);
            Controls.Add(pictureBoxLoading);
            Controls.Add(pictureBoxShow);
            Controls.Add(panel1);
            Font = new Font("Cairo Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الماسح الضوئي";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxDpi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScannerPaperCont).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxShow;
        private PictureBox pictureBox2;
        private ComboBox comboBoxDevices;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButtonGray;
        private RadioButton radioButtonColor;
        private Label label3;
        private GroupBox groupBox2;
        private LinkLabel linkLabelChangeSavedFolder;
        private TextBox textBoxSavedFolder;
        private Label label4;
        private Button buttonScan;
        private NumericUpDown numericUpDownScannerPaperCont;
        private Button buttonSaveImage;
        private ToolTip toolTip1;
        private LinkLabel linkLabelOpenSavedFolder;
        private PictureBox pictureBoxLoading;
        private LinkLabel linkLabelLoadDevices;
        private ComboBox comboBoxPaperSize;
        private Label label5;
        private NumericUpDown comboBoxDpi;
    }
}
