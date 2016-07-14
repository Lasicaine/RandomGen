namespace RandomGen
{
    partial class FormRand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRand));
            this.groupBoxIniz = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxMin = new System.Windows.Forms.MaskedTextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.maskedTextBoxMax = new System.Windows.Forms.MaskedTextBox();
            this.textBoxRez = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxIniz.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIniz
            // 
            this.groupBoxIniz.Controls.Add(this.maskedTextBoxMax);
            this.groupBoxIniz.Controls.Add(this.labelMax);
            this.groupBoxIniz.Controls.Add(this.labelMin);
            this.groupBoxIniz.Controls.Add(this.maskedTextBoxMin);
            this.groupBoxIniz.Location = new System.Drawing.Point(3, 12);
            this.groupBoxIniz.Name = "groupBoxIniz";
            this.groupBoxIniz.Size = new System.Drawing.Size(375, 100);
            this.groupBoxIniz.TabIndex = 0;
            this.groupBoxIniz.TabStop = false;
            this.groupBoxIniz.Text = "Исходные данные для генерации";
            // 
            // maskedTextBoxMin
            // 
            this.maskedTextBoxMin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.maskedTextBoxMin.ForeColor = System.Drawing.Color.Red;
            this.maskedTextBoxMin.Location = new System.Drawing.Point(340, 18);
            this.maskedTextBoxMin.Mask = "000";
            this.maskedTextBoxMin.Name = "maskedTextBoxMin";
            this.maskedTextBoxMin.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBoxMin.TabIndex = 0;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMin.Location = new System.Drawing.Point(10, 25);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(302, 13);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "Введите минимальное значение интервала для выборки: ";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMax.Location = new System.Drawing.Point(10, 57);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(305, 13);
            this.labelMax.TabIndex = 2;
            this.labelMax.Text = "Введите максимальное значение интервала для выборки:";
            // 
            // maskedTextBoxMax
            // 
            this.maskedTextBoxMax.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.maskedTextBoxMax.ForeColor = System.Drawing.Color.Red;
            this.maskedTextBoxMax.Location = new System.Drawing.Point(340, 50);
            this.maskedTextBoxMax.Mask = "000";
            this.maskedTextBoxMax.Name = "maskedTextBoxMax";
            this.maskedTextBoxMax.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBoxMax.TabIndex = 3;
            // 
            // textBoxRez
            // 
            this.textBoxRez.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxRez.Location = new System.Drawing.Point(3, 128);
            this.textBoxRez.Name = "textBoxRez";
            this.textBoxRez.ReadOnly = true;
            this.textBoxRez.Size = new System.Drawing.Size(375, 20);
            this.textBoxRez.TabIndex = 1;
            this.textBoxRez.Text = "Сгенерированное число:";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(3, 163);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(183, 23);
            this.buttonGen.TabIndex = 2;
            this.buttonGen.Text = "Генерировать";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(192, 163);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(186, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormRand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 191);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.textBoxRez);
            this.Controls.Add(this.groupBoxIniz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор псевдослучайных чисел";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRand_FormClosing);
            this.groupBoxIniz.ResumeLayout(false);
            this.groupBoxIniz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIniz;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxRez;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonExit;

    }
}

