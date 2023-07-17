namespace WinFormsControlLab
{
    partial class ColorChange
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decRadioButton1 = new System.Windows.Forms.RadioButton();
            this.hexRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorTextBoх3 = new WinFormsControlLab.ColorTextBoх();
            this.colorTextBoх2 = new WinFormsControlLab.ColorTextBoх();
            this.colorTextBoх1 = new WinFormsControlLab.ColorTextBoх();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Синий";
            // 
            // decRadioButton1
            // 
            this.decRadioButton1.AutoSize = true;
            this.decRadioButton1.Checked = true;
            this.decRadioButton1.Enabled = false;
            this.decRadioButton1.Location = new System.Drawing.Point(8, 105);
            this.decRadioButton1.Name = "decRadioButton1";
            this.decRadioButton1.Size = new System.Drawing.Size(53, 20);
            this.decRadioButton1.TabIndex = 3;
            this.decRadioButton1.TabStop = true;
            this.decRadioButton1.Text = "Dec";
            this.decRadioButton1.UseVisualStyleBackColor = true;
            this.decRadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.AutoSize = true;
            this.hexRadioButton.Location = new System.Drawing.Point(67, 105);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(52, 20);
            this.hexRadioButton.TabIndex = 4;
            this.hexRadioButton.Text = "Hex";
            this.hexRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(133, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // colorTextBoх3
            // 
            this.colorTextBoх3.Location = new System.Drawing.Point(82, 70);
            this.colorTextBoх3.Name = "colorTextBoх3";
            this.colorTextBoх3.Size = new System.Drawing.Size(45, 22);
            this.colorTextBoх3.TabIndex = 7;
            this.colorTextBoх3.Text = "0";
            this.colorTextBoх3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colorTextBoх3.TextChanged += new System.EventHandler(this.colorTextBoх_TextChanged);
            // 
            // colorTextBoх2
            // 
            this.colorTextBoх2.Location = new System.Drawing.Point(82, 42);
            this.colorTextBoх2.Name = "colorTextBoх2";
            this.colorTextBoх2.Size = new System.Drawing.Size(45, 22);
            this.colorTextBoх2.TabIndex = 6;
            this.colorTextBoх2.Text = "0";
            this.colorTextBoх2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colorTextBoх2.TextChanged += new System.EventHandler(this.colorTextBoх_TextChanged);
            // 
            // colorTextBoх1
            // 
            this.colorTextBoх1.Location = new System.Drawing.Point(82, 11);
            this.colorTextBoх1.Name = "colorTextBoх1";
            this.colorTextBoх1.Size = new System.Drawing.Size(45, 22);
            this.colorTextBoх1.TabIndex = 5;
            this.colorTextBoх1.Text = "0";
            this.colorTextBoх1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colorTextBoх1.TextChanged += new System.EventHandler(this.colorTextBoх_TextChanged);
            // 
            // ColorChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.colorTextBoх3);
            this.Controls.Add(this.colorTextBoх2);
            this.Controls.Add(this.colorTextBoх1);
            this.Controls.Add(this.hexRadioButton);
            this.Controls.Add(this.decRadioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorChange";
            this.Size = new System.Drawing.Size(251, 137);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton decRadioButton1;
        private System.Windows.Forms.RadioButton hexRadioButton;
        private ColorTextBoх colorTextBoх1;
        private ColorTextBoх colorTextBoх2;
        private ColorTextBoх colorTextBoх3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
