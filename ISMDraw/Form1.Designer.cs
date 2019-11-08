namespace ISMDraw
{
    partial class Drawing
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawing));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.labelTrackBar = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelMoov = new System.Windows.Forms.Label();
            this.labelMoovX = new System.Windows.Forms.Label();
            this.labelMoovY = new System.Windows.Forms.Label();
            this.buttonMoov = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(193, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(486, 325);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(556, 398);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(126, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Захарчук М. С. ІПЗ-19-3";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDraw.Location = new System.Drawing.Point(93, 376);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(94, 23);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClean.Location = new System.Drawing.Point(12, 376);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 3;
            this.buttonClean.Text = "Стереть";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.ButtonClean_Click);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.Location = new System.Drawing.Point(193, 376);
            this.trackBar.Maximum = 30;
            this.trackBar.Name = "trackBar";
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar.Size = new System.Drawing.Size(357, 45);
            this.trackBar.TabIndex = 4;
            // 
            // labelTrackBar
            // 
            this.labelTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTrackBar.AutoSize = true;
            this.labelTrackBar.Location = new System.Drawing.Point(324, 360);
            this.labelTrackBar.Name = "labelTrackBar";
            this.labelTrackBar.Size = new System.Drawing.Size(99, 13);
            this.labelTrackBar.TabIndex = 5;
            this.labelTrackBar.Text = "Количество фигур";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(175, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить фигуру";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "Точка",
            "Линия",
            "Прямоугольник",
            "Круг",
            "Элипс"});
            this.comboBoxShape.Location = new System.Drawing.Point(12, 41);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(175, 21);
            this.comboBoxShape.TabIndex = 7;
            this.comboBoxShape.Text = "Выбирете фигуру ";
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.ComboBoxShape_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 66);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(175, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(125, 108);
            this.numericUpDownY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownY.TabIndex = 9;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(32, 108);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownX.TabIndex = 10;
            // 
            // labelMoov
            // 
            this.labelMoov.AutoSize = true;
            this.labelMoov.Location = new System.Drawing.Point(59, 92);
            this.labelMoov.Name = "labelMoov";
            this.labelMoov.Size = new System.Drawing.Size(78, 13);
            this.labelMoov.TabIndex = 11;
            this.labelMoov.Text = "Сдвиг фигуры";
            // 
            // labelMoovX
            // 
            this.labelMoovX.AutoSize = true;
            this.labelMoovX.Location = new System.Drawing.Point(12, 110);
            this.labelMoovX.Name = "labelMoovX";
            this.labelMoovX.Size = new System.Drawing.Size(14, 13);
            this.labelMoovX.TabIndex = 12;
            this.labelMoovX.Text = "X";
            // 
            // labelMoovY
            // 
            this.labelMoovY.AutoSize = true;
            this.labelMoovY.Location = new System.Drawing.Point(105, 110);
            this.labelMoovY.Name = "labelMoovY";
            this.labelMoovY.Size = new System.Drawing.Size(14, 13);
            this.labelMoovY.TabIndex = 13;
            this.labelMoovY.Text = "Y";
            // 
            // buttonMoov
            // 
            this.buttonMoov.Location = new System.Drawing.Point(12, 134);
            this.buttonMoov.Name = "buttonMoov";
            this.buttonMoov.Size = new System.Drawing.Size(175, 23);
            this.buttonMoov.TabIndex = 14;
            this.buttonMoov.Text = "Сдвинуть";
            this.buttonMoov.UseVisualStyleBackColor = true;
            this.buttonMoov.Click += new System.EventHandler(this.ButtonMoov_Click);
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(691, 420);
            this.Controls.Add(this.buttonMoov);
            this.Controls.Add(this.labelMoovY);
            this.Controls.Add(this.labelMoovX);
            this.Controls.Add(this.labelMoov);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelTrackBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(707, 459);
            this.Name = "Drawing";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Рисование";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label labelTrackBar;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelMoov;
        private System.Windows.Forms.Label labelMoovX;
        private System.Windows.Forms.Label labelMoovY;
        private System.Windows.Forms.Button buttonMoov;
    }
}

