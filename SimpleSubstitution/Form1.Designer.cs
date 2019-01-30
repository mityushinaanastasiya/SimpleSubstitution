namespace SimpleSubstitution
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
            this.CoderButton = new System.Windows.Forms.Button();
            this.deshifrButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CoderButton
            // 
            this.CoderButton.Location = new System.Drawing.Point(43, 25);
            this.CoderButton.Name = "CoderButton";
            this.CoderButton.Size = new System.Drawing.Size(95, 47);
            this.CoderButton.TabIndex = 0;
            this.CoderButton.Text = "Кодировать";
            this.CoderButton.UseVisualStyleBackColor = true;
            this.CoderButton.Click += new System.EventHandler(this.codeButtonClick);
            // 
            // deshifrButton
            // 
            this.deshifrButton.Location = new System.Drawing.Point(43, 117);
            this.deshifrButton.Name = "deshifrButton";
            this.deshifrButton.Size = new System.Drawing.Size(95, 47);
            this.deshifrButton.TabIndex = 1;
            this.deshifrButton.Text = "Расшифровать";
            this.deshifrButton.UseVisualStyleBackColor = true;
            this.deshifrButton.Click += new System.EventHandler(this.deshifrButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deshifrButton);
            this.Controls.Add(this.CoderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CoderButton;
        private System.Windows.Forms.Button deshifrButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

