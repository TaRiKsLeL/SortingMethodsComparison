namespace SortMathodsComparing
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
            this.sortBtn = new System.Windows.Forms.Button();
            this.amountNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearBtn = new System.Windows.Forms.Button();
            this.infoTB = new System.Windows.Forms.TextBox();
            this.decendingRadioBtn = new System.Windows.Forms.RadioButton();
            this.ecendingRadioBtn = new System.Windows.Forms.RadioButton();
            this.arrayRadioBtn = new System.Windows.Forms.RadioButton();
            this.textRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthNUD = new System.Windows.Forms.NumericUpDown();
            this.sortTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dataTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sortedDataTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.amountNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(24, 522);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(101, 40);
            this.sortBtn.TabIndex = 0;
            this.sortBtn.Text = "Сортувати";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // amountNUD
            // 
            this.amountNUD.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountNUD.Location = new System.Drawing.Point(140, 324);
            this.amountNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNUD.Name = "amountNUD";
            this.amountNUD.Size = new System.Drawing.Size(84, 22);
            this.amountNUD.TabIndex = 3;
            this.amountNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortTypeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип сортування";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "К-сть елементів";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ecendingRadioBtn);
            this.groupBox2.Controls.Add(this.decendingRadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(24, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Як сортувати";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRadioBtn);
            this.groupBox3.Controls.Add(this.arrayRadioBtn);
            this.groupBox3.Location = new System.Drawing.Point(24, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 86);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип даних";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 613);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.sortedDataTB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataTB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lengthNUD);
            this.tabPage1.Controls.Add(this.infoTB);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.amountNUD);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.sortBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сортування";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Характеристики сортування";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(131, 522);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(93, 40);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Очистити";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // infoTB
            // 
            this.infoTB.Location = new System.Drawing.Point(24, 410);
            this.infoTB.Multiline = true;
            this.infoTB.Name = "infoTB";
            this.infoTB.ReadOnly = true;
            this.infoTB.Size = new System.Drawing.Size(200, 87);
            this.infoTB.TabIndex = 8;
            // 
            // decendingRadioBtn
            // 
            this.decendingRadioBtn.AutoSize = true;
            this.decendingRadioBtn.Checked = true;
            this.decendingRadioBtn.Location = new System.Drawing.Point(21, 24);
            this.decendingRadioBtn.Name = "decendingRadioBtn";
            this.decendingRadioBtn.Size = new System.Drawing.Size(128, 21);
            this.decendingRadioBtn.TabIndex = 0;
            this.decendingRadioBtn.TabStop = true;
            this.decendingRadioBtn.Text = "За зростанням";
            this.decendingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ecendingRadioBtn
            // 
            this.ecendingRadioBtn.AutoSize = true;
            this.ecendingRadioBtn.Location = new System.Drawing.Point(21, 50);
            this.ecendingRadioBtn.Name = "ecendingRadioBtn";
            this.ecendingRadioBtn.Size = new System.Drawing.Size(122, 21);
            this.ecendingRadioBtn.TabIndex = 1;
            this.ecendingRadioBtn.Text = "За спаданням";
            this.ecendingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // arrayRadioBtn
            // 
            this.arrayRadioBtn.AutoSize = true;
            this.arrayRadioBtn.Checked = true;
            this.arrayRadioBtn.Location = new System.Drawing.Point(21, 23);
            this.arrayRadioBtn.Name = "arrayRadioBtn";
            this.arrayRadioBtn.Size = new System.Drawing.Size(113, 21);
            this.arrayRadioBtn.TabIndex = 2;
            this.arrayRadioBtn.Text = "Масив чисел";
            this.arrayRadioBtn.UseVisualStyleBackColor = true;
            // 
            // textRadioBtn
            // 
            this.textRadioBtn.AutoSize = true;
            this.textRadioBtn.Location = new System.Drawing.Point(21, 50);
            this.textRadioBtn.Name = "textRadioBtn";
            this.textRadioBtn.Size = new System.Drawing.Size(122, 21);
            this.textRadioBtn.TabIndex = 3;
            this.textRadioBtn.Text = "Масив записів";
            this.textRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Розрядність";
            // 
            // lengthNUD
            // 
            this.lengthNUD.Location = new System.Drawing.Point(140, 364);
            this.lengthNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lengthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthNUD.Name = "lengthNUD";
            this.lengthNUD.Size = new System.Drawing.Size(84, 22);
            this.lengthNUD.TabIndex = 9;
            this.lengthNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // sortTypeComboBox
            // 
            this.sortTypeComboBox.FormattingEnabled = true;
            this.sortTypeComboBox.Items.AddRange(new object[] {
            "Бульбашкою",
            "Вибіркою",
            "Швидке сортування",
            "Методом Шелла"});
            this.sortTypeComboBox.Location = new System.Drawing.Point(21, 29);
            this.sortTypeComboBox.Name = "sortTypeComboBox";
            this.sortTypeComboBox.Size = new System.Drawing.Size(158, 24);
            this.sortTypeComboBox.TabIndex = 11;
            this.sortTypeComboBox.Text = "-----Виберіть-----";
            // 
            // dataTB
            // 
            this.dataTB.Location = new System.Drawing.Point(325, 38);
            this.dataTB.Multiline = true;
            this.dataTB.Name = "dataTB";
            this.dataTB.ReadOnly = true;
            this.dataTB.Size = new System.Drawing.Size(507, 243);
            this.dataTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Вхідні дані";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Відсортовані дані";
            // 
            // sortedDataTB
            // 
            this.sortedDataTB.Location = new System.Drawing.Point(325, 313);
            this.sortedDataTB.Multiline = true;
            this.sortedDataTB.Name = "sortedDataTB";
            this.sortedDataTB.ReadOnly = true;
            this.sortedDataTB.Size = new System.Drawing.Size(507, 243);
            this.sortedDataTB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(886, 662);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Сортування";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.NumericUpDown amountNUD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox infoTB;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton ecendingRadioBtn;
        private System.Windows.Forms.RadioButton decendingRadioBtn;
        private System.Windows.Forms.RadioButton textRadioBtn;
        private System.Windows.Forms.RadioButton arrayRadioBtn;
        private System.Windows.Forms.ComboBox sortTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lengthNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sortedDataTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dataTB;
    }
}

