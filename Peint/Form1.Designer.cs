namespace Peint
{
    partial class Form1
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
            this.listBoxShapes = new System.Windows.Forms.ListBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxShapes
            // 
            this.listBoxShapes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxShapes.FormattingEnabled = true;
            this.listBoxShapes.Location = new System.Drawing.Point(12, 41);
            this.listBoxShapes.Name = "listBoxShapes";
            this.listBoxShapes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxShapes.Size = new System.Drawing.Size(120, 329);
            this.listBoxShapes.TabIndex = 0;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(24, 23);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(12, 390);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(138, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(650, 329);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(138, 12);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(75, 23);
            this.buttonPoint.TabIndex = 4;
            this.buttonPoint.Text = "Точка";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(219, 12);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLine.TabIndex = 5;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.ButtonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(300, 12);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(75, 23);
            this.buttonCircle.TabIndex = 6;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.ButtonCircle_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(381, 12);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(99, 23);
            this.buttonRectangle.TabIndex = 7;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.ButtonRectangle_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(486, 12);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(75, 23);
            this.buttonEllipse.TabIndex = 8;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.ButtonEllipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.listBoxShapes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShapes;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonEllipse;
    }
}

