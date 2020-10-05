namespace PairsName
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNms = new System.Windows.Forms.TextBox();
            this.btnSfl = new System.Windows.Forms.Button();
            this.btnUn = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNms = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnClrN = new System.Windows.Forms.Button();
            this.btnClrL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 225);
            this.listBox1.TabIndex = 0;
            // 
            // txtNms
            // 
            this.txtNms.Location = new System.Drawing.Point(12, 319);
            this.txtNms.Name = "txtNms";
            this.txtNms.Size = new System.Drawing.Size(114, 20);
            this.txtNms.TabIndex = 1;
            this.txtNms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNms_KeyDown);
            // 
            // btnSfl
            // 
            this.btnSfl.Location = new System.Drawing.Point(174, 359);
            this.btnSfl.Name = "btnSfl";
            this.btnSfl.Size = new System.Drawing.Size(81, 23);
            this.btnSfl.TabIndex = 2;
            this.btnSfl.Text = "Перемешать";
            this.btnSfl.UseVisualStyleBackColor = true;
            this.btnSfl.Click += new System.EventHandler(this.BtnSfl_Click);
            // 
            // btnUn
            // 
            this.btnUn.Location = new System.Drawing.Point(316, 359);
            this.btnUn.Name = "btnUn";
            this.btnUn.Size = new System.Drawing.Size(81, 23);
            this.btnUn.TabIndex = 3;
            this.btnUn.Text = "Объединить";
            this.btnUn.UseVisualStyleBackColor = true;
            this.btnUn.Click += new System.EventHandler(this.BtnUn_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(79, 25);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(47, 20);
            this.txtNum.TabIndex = 4;
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNum_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество имен:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите имена:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnNms
            // 
            this.btnNms.Location = new System.Drawing.Point(12, 345);
            this.btnNms.Name = "btnNms";
            this.btnNms.Size = new System.Drawing.Size(114, 20);
            this.btnNms.TabIndex = 7;
            this.btnNms.Text = "Готово";
            this.btnNms.UseVisualStyleBackColor = true;
            this.btnNms.Click += new System.EventHandler(this.BtnNms_Click);
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(54, 51);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 20);
            this.btnNum.TabIndex = 8;
            this.btnNum.Text = "Готово";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(174, 77);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(223, 225);
            this.listBox2.TabIndex = 10;
            // 
            // btnClrN
            // 
            this.btnClrN.Location = new System.Drawing.Point(12, 367);
            this.btnClrN.Name = "btnClrN";
            this.btnClrN.Size = new System.Drawing.Size(114, 23);
            this.btnClrN.TabIndex = 11;
            this.btnClrN.Text = "Очистить список";
            this.btnClrN.UseVisualStyleBackColor = true;
            this.btnClrN.Click += new System.EventHandler(this.BtnClrN_Click);
            // 
            // btnClrL
            // 
            this.btnClrL.Location = new System.Drawing.Point(283, 319);
            this.btnClrL.Name = "btnClrL";
            this.btnClrL.Size = new System.Drawing.Size(114, 23);
            this.btnClrL.TabIndex = 12;
            this.btnClrL.Text = "Очистить список";
            this.btnClrL.UseVisualStyleBackColor = true;
            this.btnClrL.Click += new System.EventHandler(this.BtnClrL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 394);
            this.Controls.Add(this.btnClrL);
            this.Controls.Add(this.btnClrN);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.btnNms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnUn);
            this.Controls.Add(this.btnSfl);
            this.Controls.Add(this.txtNms);
            this.Controls.Add(this.listBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать пару";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNms;
        private System.Windows.Forms.Button btnSfl;
        private System.Windows.Forms.Button btnUn;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNms;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnClrN;
        private System.Windows.Forms.Button btnClrL;
    }
}

