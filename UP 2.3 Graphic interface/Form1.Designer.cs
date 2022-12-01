namespace UP_2._3_Graphic_interface
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
            this.ForBox = new System.Windows.Forms.RichTextBox();
            this.WhileBox = new System.Windows.Forms.RichTextBox();
            this.DoWhileBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NValueBox = new System.Windows.Forms.TextBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ForBox
            // 
            this.ForBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForBox.Location = new System.Drawing.Point(9, 61);
            this.ForBox.Name = "ForBox";
            this.ForBox.Size = new System.Drawing.Size(159, 289);
            this.ForBox.TabIndex = 0;
            this.ForBox.Text = "";
            // 
            // WhileBox
            // 
            this.WhileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhileBox.Location = new System.Drawing.Point(174, 61);
            this.WhileBox.Name = "WhileBox";
            this.WhileBox.Size = new System.Drawing.Size(159, 289);
            this.WhileBox.TabIndex = 1;
            this.WhileBox.Text = "";
            // 
            // DoWhileBox
            // 
            this.DoWhileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoWhileBox.Location = new System.Drawing.Point(339, 61);
            this.DoWhileBox.Name = "DoWhileBox";
            this.DoWhileBox.Size = new System.Drawing.Size(159, 289);
            this.DoWhileBox.TabIndex = 2;
            this.DoWhileBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(237, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "while";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(392, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "do..while";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите число строк:";
            // 
            // NValueBox
            // 
            this.NValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NValueBox.Location = new System.Drawing.Point(163, 6);
            this.NValueBox.Name = "NValueBox";
            this.NValueBox.Size = new System.Drawing.Size(100, 23);
            this.NValueBox.TabIndex = 7;
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetButton.Location = new System.Drawing.Point(269, 7);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(229, 23);
            this.GetButton.TabIndex = 8;
            this.GetButton.Text = "Вывести последовательность";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 362);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.NValueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoWhileBox);
            this.Controls.Add(this.WhileBox);
            this.Controls.Add(this.ForBox);
            this.Name = "Form1";
            this.Text = "2.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ForBox;
        private System.Windows.Forms.RichTextBox WhileBox;
        private System.Windows.Forms.RichTextBox DoWhileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NValueBox;
        private System.Windows.Forms.Button GetButton;
    }
}

