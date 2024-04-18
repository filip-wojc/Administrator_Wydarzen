namespace Administrator_Wydarzen.Views
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.ListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LowPrioBox = new System.Windows.Forms.RadioButton();
            this.MidPrioBox = new System.Windows.Forms.RadioButton();
            this.HighPrioBox = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SortBtn = new System.Windows.Forms.Button();
            this.FiltrBtn = new System.Windows.Forms.Button();
            this.SortByDateBox = new System.Windows.Forms.RadioButton();
            this.SortByPrioBox = new System.Windows.Forms.RadioButton();
            this.SortByTypeBox = new System.Windows.Forms.RadioButton();
            this.FiltrByDateBox = new System.Windows.Forms.RadioButton();
            this.FiltrByPriorityBox = new System.Windows.Forms.RadioButton();
            this.FiltrByTypeBox = new System.Windows.Forms.RadioButton();
            this.Tytuł = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Wystapienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priorytet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(39, 8);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(187, 20);
            this.TitleBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(39, 51);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(187, 73);
            this.DescriptionBox.TabIndex = 3;
            this.DescriptionBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data wystąpienia";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(39, 155);
            this.DateBox.Margin = new System.Windows.Forms.Padding(2);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(187, 20);
            this.DateBox.TabIndex = 5;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Items.AddRange(new object[] {
            "praca",
            "rodzina",
            "rozrywka",
            "zdrowie",
            "sport"});
            this.ListBox.Location = new System.Drawing.Point(39, 214);
            this.ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(187, 49);
            this.ListBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Typ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Priorytet";
            // 
            // LowPrioBox
            // 
            this.LowPrioBox.AutoSize = true;
            this.LowPrioBox.Location = new System.Drawing.Point(39, 291);
            this.LowPrioBox.Margin = new System.Windows.Forms.Padding(2);
            this.LowPrioBox.Name = "LowPrioBox";
            this.LowPrioBox.Size = new System.Drawing.Size(46, 17);
            this.LowPrioBox.TabIndex = 9;
            this.LowPrioBox.TabStop = true;
            this.LowPrioBox.Text = "niski";
            this.LowPrioBox.UseVisualStyleBackColor = true;
            // 
            // MidPrioBox
            // 
            this.MidPrioBox.AutoSize = true;
            this.MidPrioBox.Location = new System.Drawing.Point(39, 310);
            this.MidPrioBox.Margin = new System.Windows.Forms.Padding(2);
            this.MidPrioBox.Name = "MidPrioBox";
            this.MidPrioBox.Size = new System.Drawing.Size(53, 17);
            this.MidPrioBox.TabIndex = 10;
            this.MidPrioBox.TabStop = true;
            this.MidPrioBox.Text = "średni";
            this.MidPrioBox.UseVisualStyleBackColor = true;
            // 
            // HighPrioBox
            // 
            this.HighPrioBox.AutoSize = true;
            this.HighPrioBox.Location = new System.Drawing.Point(39, 330);
            this.HighPrioBox.Margin = new System.Windows.Forms.Padding(2);
            this.HighPrioBox.Name = "HighPrioBox";
            this.HighPrioBox.Size = new System.Drawing.Size(57, 17);
            this.HighPrioBox.TabIndex = 11;
            this.HighPrioBox.TabStop = true;
            this.HighPrioBox.Text = "wysoki";
            this.HighPrioBox.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tytuł,
            this.Opis,
            this.Data_Wystapienia,
            this.Typ,
            this.Priorytet});
            this.dataGridView1.Location = new System.Drawing.Point(406, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(739, 404);
            this.dataGridView1.TabIndex = 12;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(28, 351);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(139, 50);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Dodaj";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(171, 351);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(136, 50);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(28, 405);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(139, 39);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(171, 405);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(136, 39);
            this.LoadBtn.TabIndex = 16;
            this.LoadBtn.Text = "Wczytaj";
            this.LoadBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(291, 69);
            this.SortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(72, 25);
            this.SortBtn.TabIndex = 17;
            this.SortBtn.Text = "Sortuj";
            this.SortBtn.UseVisualStyleBackColor = true;
            // 
            // FiltrBtn
            // 
            this.FiltrBtn.Location = new System.Drawing.Point(291, 179);
            this.FiltrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrBtn.Name = "FiltrBtn";
            this.FiltrBtn.Size = new System.Drawing.Size(72, 25);
            this.FiltrBtn.TabIndex = 18;
            this.FiltrBtn.Text = "Filtruj";
            this.FiltrBtn.UseVisualStyleBackColor = true;
            // 
            // SortByDateBox
            // 
            this.SortByDateBox.AutoSize = true;
            this.SortByDateBox.Location = new System.Drawing.Point(303, 138);
            this.SortByDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.SortByDateBox.Name = "SortByDateBox";
            this.SortByDateBox.Size = new System.Drawing.Size(67, 17);
            this.SortByDateBox.TabIndex = 21;
            this.SortByDateBox.TabStop = true;
            this.SortByDateBox.Text = "Po dacie";
            this.SortByDateBox.UseVisualStyleBackColor = true;
            // 
            // SortByPrioBox
            // 
            this.SortByPrioBox.AutoSize = true;
            this.SortByPrioBox.Location = new System.Drawing.Point(303, 119);
            this.SortByPrioBox.Margin = new System.Windows.Forms.Padding(2);
            this.SortByPrioBox.Name = "SortByPrioBox";
            this.SortByPrioBox.Size = new System.Drawing.Size(89, 17);
            this.SortByPrioBox.TabIndex = 20;
            this.SortByPrioBox.TabStop = true;
            this.SortByPrioBox.Text = "Po priorytecie";
            this.SortByPrioBox.UseVisualStyleBackColor = true;
            // 
            // SortByTypeBox
            // 
            this.SortByTypeBox.AutoSize = true;
            this.SortByTypeBox.Location = new System.Drawing.Point(303, 99);
            this.SortByTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.SortByTypeBox.Name = "SortByTypeBox";
            this.SortByTypeBox.Size = new System.Drawing.Size(63, 17);
            this.SortByTypeBox.TabIndex = 19;
            this.SortByTypeBox.TabStop = true;
            this.SortByTypeBox.Text = "Po typie";
            this.SortByTypeBox.UseVisualStyleBackColor = true;
            // 
            // FiltrByDateBox
            // 
            this.FiltrByDateBox.AutoSize = true;
            this.FiltrByDateBox.Location = new System.Drawing.Point(303, 253);
            this.FiltrByDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrByDateBox.Name = "FiltrByDateBox";
            this.FiltrByDateBox.Size = new System.Drawing.Size(67, 17);
            this.FiltrByDateBox.TabIndex = 24;
            this.FiltrByDateBox.TabStop = true;
            this.FiltrByDateBox.Text = "Po dacie";
            this.FiltrByDateBox.UseVisualStyleBackColor = true;
            // 
            // FiltrByPriorityBox
            // 
            this.FiltrByPriorityBox.AutoSize = true;
            this.FiltrByPriorityBox.Location = new System.Drawing.Point(303, 233);
            this.FiltrByPriorityBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrByPriorityBox.Name = "FiltrByPriorityBox";
            this.FiltrByPriorityBox.Size = new System.Drawing.Size(89, 17);
            this.FiltrByPriorityBox.TabIndex = 23;
            this.FiltrByPriorityBox.TabStop = true;
            this.FiltrByPriorityBox.Text = "Po priorytecie";
            this.FiltrByPriorityBox.UseVisualStyleBackColor = true;
            // 
            // FiltrByTypeBox
            // 
            this.FiltrByTypeBox.AutoSize = true;
            this.FiltrByTypeBox.Location = new System.Drawing.Point(303, 214);
            this.FiltrByTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrByTypeBox.Name = "FiltrByTypeBox";
            this.FiltrByTypeBox.Size = new System.Drawing.Size(63, 17);
            this.FiltrByTypeBox.TabIndex = 22;
            this.FiltrByTypeBox.TabStop = true;
            this.FiltrByTypeBox.Text = "Po typie";
            this.FiltrByTypeBox.UseVisualStyleBackColor = true;
            // 
            // Tytuł
            // 
            this.Tytuł.HeaderText = "Tytuł";
            this.Tytuł.MinimumWidth = 8;
            this.Tytuł.Name = "Tytuł";
            this.Tytuł.ReadOnly = true;
            this.Tytuł.Width = 110;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 8;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 240;
            // 
            // Data_Wystapienia
            // 
            this.Data_Wystapienia.HeaderText = "Data wystąpienia";
            this.Data_Wystapienia.MinimumWidth = 8;
            this.Data_Wystapienia.Name = "Data_Wystapienia";
            this.Data_Wystapienia.ReadOnly = true;
            this.Data_Wystapienia.Width = 75;
            // 
            // Typ
            // 
            this.Typ.HeaderText = "Typ";
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            this.Typ.Width = 200;
            // 
            // Priorytet
            // 
            this.Priorytet.HeaderText = "Priorytet";
            this.Priorytet.MinimumWidth = 8;
            this.Priorytet.Name = "Priorytet";
            this.Priorytet.ReadOnly = true;
            this.Priorytet.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 466);
            this.Controls.Add(this.FiltrByDateBox);
            this.Controls.Add(this.FiltrByPriorityBox);
            this.Controls.Add(this.FiltrByTypeBox);
            this.Controls.Add(this.SortByDateBox);
            this.Controls.Add(this.SortByPrioBox);
            this.Controls.Add(this.SortByTypeBox);
            this.Controls.Add(this.FiltrBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HighPrioBox);
            this.Controls.Add(this.MidPrioBox);
            this.Controls.Add(this.LowPrioBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.CheckedListBox ListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton LowPrioBox;
        private System.Windows.Forms.RadioButton MidPrioBox;
        private System.Windows.Forms.RadioButton HighPrioBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton FiltrByDateBox;
        private System.Windows.Forms.RadioButton FiltrByPriorityBox;
        private System.Windows.Forms.RadioButton FiltrByTypeBox;
        private System.Windows.Forms.RadioButton SortByDateBox;
        private System.Windows.Forms.RadioButton SortByPrioBox;
        private System.Windows.Forms.RadioButton SortByTypeBox;
        private System.Windows.Forms.Button FiltrBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tytuł;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Wystapienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priorytet;
    }
}

