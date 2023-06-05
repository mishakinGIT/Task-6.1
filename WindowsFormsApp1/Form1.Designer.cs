namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.sportComboBox = new System.Windows.Forms.ComboBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sportComboBox
            // 
            this.sportComboBox.FormattingEnabled = true;
            this.sportComboBox.Location = new System.Drawing.Point(397, 95);
            this.sportComboBox.Name = "sportComboBox";
            this.sportComboBox.Size = new System.Drawing.Size(121, 21);
            this.sportComboBox.TabIndex = 0;
            this.sportComboBox.SelectedIndexChanged += new System.EventHandler(this.sportComboBox_SelectedIndexChanged);
            // 
            // methodComboBox
            // 
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(397, 122);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(121, 21);
            this.methodComboBox.TabIndex = 1;
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Location = new System.Drawing.Point(409, 149);
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.parameterTextBox.TabIndex = 2;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(425, 175);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 3;
            this.executeButton.Text = "Выполнить";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resultLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.resultLabel.Location = new System.Drawing.Point(445, 201);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TeamSports не надо выбирать, строка создана для описания";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1109, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.parameterTextBox);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.sportComboBox);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.Panel panelMethods;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxParameters;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxMethodName;
        private System.Windows.Forms.ComboBox sportComboBox;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
    }
}

