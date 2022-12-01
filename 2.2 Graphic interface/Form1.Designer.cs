namespace _2._2_Graphic_interface
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
            this.label1 = new System.Windows.Forms.Label();
            this.CardNumberBox = new System.Windows.Forms.TextBox();
            this.KnowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер масти";
            // 
            // CardNumberBox
            // 
            this.CardNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumberBox.Location = new System.Drawing.Point(169, 6);
            this.CardNumberBox.Name = "CardNumberBox";
            this.CardNumberBox.Size = new System.Drawing.Size(61, 23);
            this.CardNumberBox.TabIndex = 1;
            // 
            // KnowButton
            // 
            this.KnowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KnowButton.Location = new System.Drawing.Point(24, 35);
            this.KnowButton.Name = "KnowButton";
            this.KnowButton.Size = new System.Drawing.Size(190, 38);
            this.KnowButton.TabIndex = 2;
            this.KnowButton.Text = "Узнать масть по номеру";
            this.KnowButton.UseVisualStyleBackColor = true;
            this.KnowButton.Click += new System.EventHandler(this.KnowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 82);
            this.Controls.Add(this.KnowButton);
            this.Controls.Add(this.CardNumberBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "2.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardNumberBox;
        private System.Windows.Forms.Button KnowButton;
    }
}

