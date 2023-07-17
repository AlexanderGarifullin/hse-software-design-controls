namespace l2
{
    partial class TestControlsApplication
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
            this.components = new System.ComponentModel.Container();
            this.filePathSelect1 = new WinFormsControlLab.FilePathSelect();
            this.numberBox1 = new WinFormsControlLab.NumberBox(this.components);
            this.colorChange1 = new WinFormsControlLab.ColorChange();
            this.SuspendLayout();
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "";
            this.filePathSelect1.Location = new System.Drawing.Point(132, 62);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(444, 57);
            this.filePathSelect1.TabIndex = 1;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(132, 24);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(474, 22);
            this.numberBox1.TabIndex = 0;
            // 
            // colorChange1
            // 
            this.colorChange1.Location = new System.Drawing.Point(222, 149);
            this.colorChange1.Name = "colorChange1";
            this.colorChange1.Size = new System.Drawing.Size(251, 137);
            this.colorChange1.TabIndex = 2;
            // 
            // TestControlsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 337);
            this.Controls.Add(this.colorChange1);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox1);
            this.Name = "TestControlsApplication";
            this.Text = "TestControlsApplicationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsControlLab.NumberBox numberBox1;
        private WinFormsControlLab.FilePathSelect filePathSelect1;
        private WinFormsControlLab.ColorChange colorChange1;
    }
}

