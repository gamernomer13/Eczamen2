﻿namespace ArendaAvto
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arendaAvtoDataSet = new ArendaAvto.ArendaAvtoDataSet();
            this.clientsTableAdapter = new ArendaAvto.ArendaAvtoDataSetTableAdapters.ClientsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fioPoisk = new System.Windows.Forms.TextBox();
            this.phonePoisk = new System.Windows.Forms.TextBox();
            this.nomerPravPoisk = new System.Windows.Forms.TextBox();
            this.mestoPravPoisk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fioPoiskButton = new System.Windows.Forms.Button();
            this.phonePoiskButton = new System.Windows.Forms.Button();
            this.nomerPoiskButton = new System.Windows.Forms.Button();
            this.dataPoiskButton = new System.Windows.Forms.Button();
            this.mestoPoiskButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaAvtoDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.arendaAvtoDataSet;
            // 
            // arendaAvtoDataSet
            // 
            this.arendaAvtoDataSet.DataSetName = "ArendaAvtoDataSet";
            this.arendaAvtoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Клиенты автосалона\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск по полям:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер прав";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата получения прав";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Место получения прав";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Телефон";
            // 
            // fioPoisk
            // 
            this.fioPoisk.Location = new System.Drawing.Point(12, 323);
            this.fioPoisk.Name = "fioPoisk";
            this.fioPoisk.Size = new System.Drawing.Size(122, 20);
            this.fioPoisk.TabIndex = 8;
            // 
            // phonePoisk
            // 
            this.phonePoisk.Location = new System.Drawing.Point(140, 323);
            this.phonePoisk.Name = "phonePoisk";
            this.phonePoisk.Size = new System.Drawing.Size(122, 20);
            this.phonePoisk.TabIndex = 9;
            // 
            // nomerPravPoisk
            // 
            this.nomerPravPoisk.Location = new System.Drawing.Point(268, 323);
            this.nomerPravPoisk.Name = "nomerPravPoisk";
            this.nomerPravPoisk.Size = new System.Drawing.Size(122, 20);
            this.nomerPravPoisk.TabIndex = 10;
            // 
            // mestoPravPoisk
            // 
            this.mestoPravPoisk.Location = new System.Drawing.Point(545, 323);
            this.mestoPravPoisk.Name = "mestoPravPoisk";
            this.mestoPravPoisk.Size = new System.Drawing.Size(122, 20);
            this.mestoPravPoisk.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(803, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Показать всех";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(634, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fioPoiskButton
            // 
            this.fioPoiskButton.Location = new System.Drawing.Point(12, 349);
            this.fioPoiskButton.Name = "fioPoiskButton";
            this.fioPoiskButton.Size = new System.Drawing.Size(122, 23);
            this.fioPoiskButton.TabIndex = 16;
            this.fioPoiskButton.Text = "Поиск по ФИО";
            this.fioPoiskButton.UseVisualStyleBackColor = true;
            this.fioPoiskButton.Click += new System.EventHandler(this.fioPoiskButton_Click);
            // 
            // phonePoiskButton
            // 
            this.phonePoiskButton.Location = new System.Drawing.Point(140, 349);
            this.phonePoiskButton.Name = "phonePoiskButton";
            this.phonePoiskButton.Size = new System.Drawing.Size(122, 23);
            this.phonePoiskButton.TabIndex = 17;
            this.phonePoiskButton.Text = "Поиск по телефону";
            this.phonePoiskButton.UseVisualStyleBackColor = true;
            this.phonePoiskButton.Click += new System.EventHandler(this.phonePoiskButton_Click);
            // 
            // nomerPoiskButton
            // 
            this.nomerPoiskButton.Location = new System.Drawing.Point(268, 349);
            this.nomerPoiskButton.Name = "nomerPoiskButton";
            this.nomerPoiskButton.Size = new System.Drawing.Size(122, 23);
            this.nomerPoiskButton.TabIndex = 18;
            this.nomerPoiskButton.Text = "Поиск по номеру";
            this.nomerPoiskButton.UseVisualStyleBackColor = true;
            this.nomerPoiskButton.Click += new System.EventHandler(this.nomerPoiskButton_Click);
            // 
            // dataPoiskButton
            // 
            this.dataPoiskButton.Location = new System.Drawing.Point(396, 349);
            this.dataPoiskButton.Name = "dataPoiskButton";
            this.dataPoiskButton.Size = new System.Drawing.Size(139, 23);
            this.dataPoiskButton.TabIndex = 19;
            this.dataPoiskButton.Text = "Поиск по дате";
            this.dataPoiskButton.UseVisualStyleBackColor = true;
            this.dataPoiskButton.Click += new System.EventHandler(this.dataPoiskButton_Click);
            // 
            // mestoPoiskButton
            // 
            this.mestoPoiskButton.Location = new System.Drawing.Point(545, 349);
            this.mestoPoiskButton.Name = "mestoPoiskButton";
            this.mestoPoiskButton.Size = new System.Drawing.Size(122, 23);
            this.mestoPoiskButton.TabIndex = 20;
            this.mestoPoiskButton.Text = "Поиск по месту";
            this.mestoPoiskButton.UseVisualStyleBackColor = true;
            this.mestoPoiskButton.Click += new System.EventHandler(this.mestoPoiskButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 70);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск клиентов, бравших авто в аренду в календарный период";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Выберите начальную дату";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2020, 2, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Выберите конечную дату:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(338, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Найти клиентов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(396, 323);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker3.TabIndex = 5;
            this.dateTimePicker3.Value = new System.DateTime(2020, 2, 1, 0, 0, 0, 0);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(652, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 81);
            this.button4.TabIndex = 22;
            this.button4.Text = "Перейти на форму просмотра договоров клиентов";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 491);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mestoPoiskButton);
            this.Controls.Add(this.dataPoiskButton);
            this.Controls.Add(this.nomerPoiskButton);
            this.Controls.Add(this.phonePoiskButton);
            this.Controls.Add(this.fioPoiskButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mestoPravPoisk);
            this.Controls.Add(this.nomerPravPoisk);
            this.Controls.Add(this.phonePoisk);
            this.Controls.Add(this.fioPoisk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Работа с клиентами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arendaAvtoDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ArendaAvtoDataSet arendaAvtoDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ArendaAvtoDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fioPoisk;
        private System.Windows.Forms.TextBox phonePoisk;
        private System.Windows.Forms.TextBox nomerPravPoisk;
        private System.Windows.Forms.TextBox mestoPravPoisk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button fioPoiskButton;
        private System.Windows.Forms.Button phonePoiskButton;
        private System.Windows.Forms.Button nomerPoiskButton;
        private System.Windows.Forms.Button dataPoiskButton;
        private System.Windows.Forms.Button mestoPoiskButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button4;
    }
}

