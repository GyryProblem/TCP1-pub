namespace TCP1
{
    partial class CalculationForm
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
            this.RgBBox = new System.Windows.Forms.TextBox();
            this.RgABox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.OperationPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RgCBox = new System.Windows.Forms.TextBox();
            this.OperatonMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RgBBox
            // 
            this.RgBBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RgBBox.Location = new System.Drawing.Point(12, 114);
            this.RgBBox.MaxLength = 8;
            this.RgBBox.Name = "RgBBox";
            this.RgBBox.Size = new System.Drawing.Size(358, 34);
            this.RgBBox.TabIndex = 1;
            this.RgBBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RgBBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RgBBox_KeyPress);
            // 
            // RgABox
            // 
            this.RgABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RgABox.Location = new System.Drawing.Point(12, 45);
            this.RgABox.MaxLength = 8;
            this.RgABox.Name = "RgABox";
            this.RgABox.Size = new System.Drawing.Size(358, 34);
            this.RgABox.TabIndex = 0;
            this.RgABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RgABox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RgABox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(313, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "RgA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(304, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "RgB:";
            // 
            // InfoBox
            // 
            this.InfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBox.Location = new System.Drawing.Point(12, 222);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoBox.Size = new System.Drawing.Size(358, 319);
            this.InfoBox.TabIndex = 4;
            this.InfoBox.TabStop = false;
            // 
            // OperationPlus
            // 
            this.OperationPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationPlus.Location = new System.Drawing.Point(12, 163);
            this.OperationPlus.Name = "OperationPlus";
            this.OperationPlus.Size = new System.Drawing.Size(160, 40);
            this.OperationPlus.TabIndex = 2;
            this.OperationPlus.Text = "\"+\"";
            this.OperationPlus.UseVisualStyleBackColor = true;
            this.OperationPlus.Click += new System.EventHandler(this.OperationPlus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(303, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "RgC:";
            // 
            // RgCBox
            // 
            this.RgCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RgCBox.Location = new System.Drawing.Point(12, 576);
            this.RgCBox.Name = "RgCBox";
            this.RgCBox.ReadOnly = true;
            this.RgCBox.Size = new System.Drawing.Size(358, 34);
            this.RgCBox.TabIndex = 6;
            this.RgCBox.TabStop = false;
            this.RgCBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperatonMinus
            // 
            this.OperatonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperatonMinus.Location = new System.Drawing.Point(210, 163);
            this.OperatonMinus.Name = "OperatonMinus";
            this.OperatonMinus.Size = new System.Drawing.Size(160, 40);
            this.OperatonMinus.TabIndex = 3;
            this.OperatonMinus.Text = "\"-\"";
            this.OperatonMinus.UseVisualStyleBackColor = true;
            this.OperatonMinus.Click += new System.EventHandler(this.OperatonMinus_Click);
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 623);
            this.Controls.Add(this.RgCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OperatonMinus);
            this.Controls.Add(this.OperationPlus);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RgABox);
            this.Controls.Add(this.RgBBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RgBBox;
        private System.Windows.Forms.TextBox RgABox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InfoBox;
        private System.Windows.Forms.Button OperationPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RgCBox;
        private System.Windows.Forms.Button OperatonMinus;
    }
}

