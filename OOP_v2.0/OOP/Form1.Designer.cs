namespace OOP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRedshift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxDiameter = new System.Windows.Forms.TextBox();
            this.textBoxShine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRedshift = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxSpace = new System.Windows.Forms.ComboBox();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelF = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonClearInfo = new System.Windows.Forms.Button();
            this.dataGridViewType = new System.Windows.Forms.DataGridView();
            this.ColumType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnAge,
            this.ColumnDistance,
            this.ColumnRedshift});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название:";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Возраст:";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            // 
            // ColumnDistance
            // 
            this.ColumnDistance.HeaderText = "Расстояние (св. лет):";
            this.ColumnDistance.Name = "ColumnDistance";
            this.ColumnDistance.ReadOnly = true;
            this.ColumnDistance.Width = 150;
            // 
            // ColumnRedshift
            // 
            this.ColumnRedshift.HeaderText = "Красное смещение:";
            this.ColumnRedshift.Name = "ColumnRedshift";
            this.ColumnRedshift.ReadOnly = true;
            this.ColumnRedshift.Width = 150;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 279);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(12, 324);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(191, 22);
            this.textBoxAge.TabIndex = 2;
            // 
            // textBoxDiameter
            // 
            this.textBoxDiameter.Location = new System.Drawing.Point(12, 369);
            this.textBoxDiameter.Name = "textBoxDiameter";
            this.textBoxDiameter.Size = new System.Drawing.Size(191, 22);
            this.textBoxDiameter.TabIndex = 3;
            // 
            // textBoxShine
            // 
            this.textBoxShine.Location = new System.Drawing.Point(11, 414);
            this.textBoxShine.Name = "textBoxShine";
            this.textBoxShine.Size = new System.Drawing.Size(191, 22);
            this.textBoxShine.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Возраст (лет):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Диаметр (св. лет):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Светимость  (L⨀):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Расстояние (св. лет):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(251, 279);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(191, 22);
            this.textBoxDistance.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 443);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Красное смещение:";
            // 
            // textBoxRedshift
            // 
            this.textBoxRedshift.Location = new System.Drawing.Point(12, 463);
            this.textBoxRedshift.Name = "textBoxRedshift";
            this.textBoxRedshift.Size = new System.Drawing.Size(191, 22);
            this.textBoxRedshift.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(785, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 57);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить объект";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(952, 277);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 57);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить объект";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(785, 361);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(144, 57);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить свойства объекта";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 304);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Объект:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBoxSpace
            // 
            this.comboBoxSpace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpace.FormattingEnabled = true;
            this.comboBoxSpace.Items.AddRange(new object[] {
            "Не уточнено",
            "Галактика",
            "Туманность",
            "Звездное скопление",
            "Черная дыра",
            "Квазар"});
            this.comboBoxSpace.Location = new System.Drawing.Point(251, 324);
            this.comboBoxSpace.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSpace.Name = "comboBoxSpace";
            this.comboBoxSpace.Size = new System.Drawing.Size(191, 24);
            this.comboBoxSpace.TabIndex = 30;
            this.comboBoxSpace.Tag = "";
            this.comboBoxSpace.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpace_SelectedIndexChanged);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(785, 12);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(311, 244);
            this.listBoxInfo.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 33;
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(248, 353);
            this.labelF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(37, 17);
            this.labelF.TabIndex = 34;
            this.labelF.Text = "Тип:";
            this.labelF.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(248, 398);
            this.labelS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(89, 17);
            this.labelS.TabIndex = 36;
            this.labelS.Text = "Масса (M⨀):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 418);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 22);
            this.textBox2.TabIndex = 35;
            // 
            // buttonClearInfo
            // 
            this.buttonClearInfo.Location = new System.Drawing.Point(952, 361);
            this.buttonClearInfo.Name = "buttonClearInfo";
            this.buttonClearInfo.Size = new System.Drawing.Size(144, 57);
            this.buttonClearInfo.TabIndex = 37;
            this.buttonClearInfo.Text = "Очистить поле с информацией";
            this.buttonClearInfo.UseVisualStyleBackColor = true;
            this.buttonClearInfo.Click += new System.EventHandler(this.buttonClearInfo_Click);
            // 
            // dataGridViewType
            // 
            this.dataGridViewType.AllowUserToAddRows = false;
            this.dataGridViewType.AllowUserToDeleteRows = false;
            this.dataGridViewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumType});
            this.dataGridViewType.Location = new System.Drawing.Point(478, 279);
            this.dataGridViewType.Name = "dataGridViewType";
            this.dataGridViewType.ReadOnly = true;
            this.dataGridViewType.RowTemplate.Height = 24;
            this.dataGridViewType.Size = new System.Drawing.Size(278, 206);
            this.dataGridViewType.TabIndex = 38;
            this.dataGridViewType.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewType_CellMouseClick);
            // 
            // ColumType
            // 
            this.ColumType.HeaderText = "Выберите тип";
            this.ColumType.Name = "ColumType";
            this.ColumType.ReadOnly = true;
            this.ColumType.Width = 165;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 504);
            this.Controls.Add(this.dataGridViewType);
            this.Controls.Add(this.buttonClearInfo);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxSpace);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRedshift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShine);
            this.Controls.Add(this.textBoxDiameter);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxDiameter;
        private System.Windows.Forms.TextBox textBoxShine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRedshift;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSpace;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRedshift;
        private System.Windows.Forms.Button buttonClearInfo;
        private System.Windows.Forms.DataGridView dataGridViewType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumType;
    }
}

