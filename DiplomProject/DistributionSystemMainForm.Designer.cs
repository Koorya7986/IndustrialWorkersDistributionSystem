namespace DiplomProject
{
	partial class DistributionSystemMainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			label1 = new Label();
			label2 = new Label();
			dataGridView_errors = new DataGridView();
			dataGridView_equipment = new DataGridView();
			button_update_equipment = new Button();
			tabPage2 = new TabPage();
			label4 = new Label();
			button_update_workers = new Button();
			dataGridView_workers = new DataGridView();
			tabPage3 = new TabPage();
			listBox_workers = new ListBox();
			listBox_equipment = new ListBox();
			button_reset = new Button();
			button_save = new Button();
			button_distribute = new Button();
			dataGridView_results = new DataGridView();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			radioButton_save_txt = new RadioButton();
			radioButton_save_word = new RadioButton();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_errors).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView_equipment).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_workers).BeginInit();
			tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_results).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1080, 607);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = Color.PowderBlue;
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(label2);
			tabPage1.Controls.Add(dataGridView_errors);
			tabPage1.Controls.Add(dataGridView_equipment);
			tabPage1.Controls.Add(button_update_equipment);
			tabPage1.ForeColor = SystemColors.ControlText;
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1072, 579);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Оборудование";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.Location = new Point(22, 14);
			label1.Name = "label1";
			label1.Size = new Size(206, 21);
			label1.TabIndex = 16;
			label1.Text = "Доступное оборудование";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label2.Location = new Point(305, 14);
			label2.Name = "label2";
			label2.Size = new Size(72, 21);
			label2.TabIndex = 15;
			label2.Text = "Ошибки";
			// 
			// dataGridView_errors
			// 
			dataGridView_errors.AllowUserToAddRows = false;
			dataGridView_errors.AllowUserToDeleteRows = false;
			dataGridView_errors.AllowUserToResizeRows = false;
			dataGridView_errors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_errors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView_errors.BackgroundColor = Color.LightCyan;
			dataGridView_errors.BorderStyle = BorderStyle.Fixed3D;
			dataGridView_errors.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView_errors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView_errors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridView_errors.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView_errors.Location = new Point(305, 50);
			dataGridView_errors.MultiSelect = false;
			dataGridView_errors.Name = "dataGridView_errors";
			dataGridView_errors.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridView_errors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView_errors.RowHeadersVisible = false;
			dataGridView_errors.ShowEditingIcon = false;
			dataGridView_errors.Size = new Size(746, 506);
			dataGridView_errors.TabIndex = 14;
			// 
			// dataGridView_equipment
			// 
			dataGridView_equipment.AllowUserToAddRows = false;
			dataGridView_equipment.AllowUserToDeleteRows = false;
			dataGridView_equipment.AllowUserToResizeColumns = false;
			dataGridView_equipment.AllowUserToResizeRows = false;
			dataGridView_equipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_equipment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView_equipment.BackgroundColor = Color.LightCyan;
			dataGridView_equipment.BorderStyle = BorderStyle.Fixed3D;
			dataGridView_equipment.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dataGridView_equipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView_equipment.Location = new Point(22, 49);
			dataGridView_equipment.MultiSelect = false;
			dataGridView_equipment.Name = "dataGridView_equipment";
			dataGridView_equipment.ReadOnly = true;
			dataGridView_equipment.RowHeadersVisible = false;
			dataGridView_equipment.ShowEditingIcon = false;
			dataGridView_equipment.Size = new Size(260, 507);
			dataGridView_equipment.TabIndex = 13;
			dataGridView_equipment.CurrentCellChanged += dataGridView_equipment_CurrentCellChanged;
			// 
			// button_update_equipment
			// 
			button_update_equipment.Font = new Font("Segoe UI", 9.75F);
			button_update_equipment.Location = new Point(940, 14);
			button_update_equipment.Name = "button_update_equipment";
			button_update_equipment.Size = new Size(111, 30);
			button_update_equipment.TabIndex = 11;
			button_update_equipment.Text = "Обновить";
			button_update_equipment.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.BackColor = Color.PowderBlue;
			tabPage2.Controls.Add(label4);
			tabPage2.Controls.Add(button_update_workers);
			tabPage2.Controls.Add(dataGridView_workers);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1076, 583);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Рабочий состав";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label4.Location = new Point(20, 21);
			label4.Name = "label4";
			label4.Size = new Size(100, 21);
			label4.TabIndex = 18;
			label4.Text = "Сотрудники";
			// 
			// button_update_workers
			// 
			button_update_workers.Font = new Font("Segoe UI", 9.75F);
			button_update_workers.Location = new Point(944, 21);
			button_update_workers.Name = "button_update_workers";
			button_update_workers.Size = new Size(111, 30);
			button_update_workers.TabIndex = 17;
			button_update_workers.Text = "Обновить";
			button_update_workers.UseVisualStyleBackColor = true;
			// 
			// dataGridView_workers
			// 
			dataGridView_workers.AllowUserToAddRows = false;
			dataGridView_workers.AllowUserToDeleteRows = false;
			dataGridView_workers.AllowUserToResizeColumns = false;
			dataGridView_workers.AllowUserToResizeRows = false;
			dataGridView_workers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_workers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView_workers.BackgroundColor = Color.LightCyan;
			dataGridView_workers.BorderStyle = BorderStyle.Fixed3D;
			dataGridView_workers.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dataGridView_workers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridView_workers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			dataGridView_workers.DefaultCellStyle = dataGridViewCellStyle5;
			dataGridView_workers.Location = new Point(20, 58);
			dataGridView_workers.MultiSelect = false;
			dataGridView_workers.Name = "dataGridView_workers";
			dataGridView_workers.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = SystemColors.Control;
			dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			dataGridView_workers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			dataGridView_workers.RowHeadersVisible = false;
			dataGridView_workers.ShowEditingIcon = false;
			dataGridView_workers.Size = new Size(1035, 497);
			dataGridView_workers.TabIndex = 15;
			// 
			// tabPage3
			// 
			tabPage3.BackColor = Color.PowderBlue;
			tabPage3.Controls.Add(listBox_workers);
			tabPage3.Controls.Add(listBox_equipment);
			tabPage3.Controls.Add(button_reset);
			tabPage3.Controls.Add(button_save);
			tabPage3.Controls.Add(button_distribute);
			tabPage3.Controls.Add(dataGridView_results);
			tabPage3.Controls.Add(label7);
			tabPage3.Controls.Add(label6);
			tabPage3.Controls.Add(label5);
			tabPage3.Controls.Add(radioButton_save_txt);
			tabPage3.Controls.Add(radioButton_save_word);
			tabPage3.Location = new Point(4, 24);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new Size(1076, 583);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Планирование";
			// 
			// listBox_workers
			// 
			listBox_workers.BackColor = Color.LightCyan;
			listBox_workers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			listBox_workers.FormattingEnabled = true;
			listBox_workers.ItemHeight = 17;
			listBox_workers.Location = new Point(240, 55);
			listBox_workers.Name = "listBox_workers";
			listBox_workers.SelectionMode = SelectionMode.MultiSimple;
			listBox_workers.Size = new Size(296, 344);
			listBox_workers.TabIndex = 28;
			// 
			// listBox_equipment
			// 
			listBox_equipment.BackColor = Color.LightCyan;
			listBox_equipment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			listBox_equipment.FormattingEnabled = true;
			listBox_equipment.ItemHeight = 17;
			listBox_equipment.Location = new Point(26, 55);
			listBox_equipment.Name = "listBox_equipment";
			listBox_equipment.SelectionMode = SelectionMode.MultiSimple;
			listBox_equipment.Size = new Size(195, 344);
			listBox_equipment.TabIndex = 27;
			// 
			// button_reset
			// 
			button_reset.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button_reset.Location = new Point(188, 436);
			button_reset.Name = "button_reset";
			button_reset.Size = new Size(142, 27);
			button_reset.TabIndex = 26;
			button_reset.Text = "Сбросить";
			button_reset.UseVisualStyleBackColor = true;
			// 
			// button_save
			// 
			button_save.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button_save.Location = new Point(26, 526);
			button_save.Name = "button_save";
			button_save.Size = new Size(142, 27);
			button_save.TabIndex = 25;
			button_save.Text = "Сохранить";
			button_save.UseVisualStyleBackColor = true;
			// 
			// button_distribute
			// 
			button_distribute.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button_distribute.Location = new Point(26, 436);
			button_distribute.Name = "button_distribute";
			button_distribute.Size = new Size(142, 27);
			button_distribute.TabIndex = 23;
			button_distribute.Text = "Распределить";
			button_distribute.UseVisualStyleBackColor = true;
			// 
			// dataGridView_results
			// 
			dataGridView_results.AllowUserToAddRows = false;
			dataGridView_results.AllowUserToDeleteRows = false;
			dataGridView_results.AllowUserToResizeColumns = false;
			dataGridView_results.AllowUserToResizeRows = false;
			dataGridView_results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView_results.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView_results.BackgroundColor = Color.LightCyan;
			dataGridView_results.BorderStyle = BorderStyle.Fixed3D;
			dataGridView_results.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = SystemColors.Control;
			dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			dataGridView_results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dataGridView_results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			dataGridView_results.DefaultCellStyle = dataGridViewCellStyle8;
			dataGridView_results.Location = new Point(559, 55);
			dataGridView_results.MultiSelect = false;
			dataGridView_results.Name = "dataGridView_results";
			dataGridView_results.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = SystemColors.Control;
			dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			dataGridView_results.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			dataGridView_results.RowHeadersVisible = false;
			dataGridView_results.ShowEditingIcon = false;
			dataGridView_results.Size = new Size(496, 498);
			dataGridView_results.TabIndex = 21;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label7.Location = new Point(559, 31);
			label7.Name = "label7";
			label7.Size = new Size(79, 21);
			label7.TabIndex = 20;
			label7.Text = "Результат";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label6.Location = new Point(240, 31);
			label6.Name = "label6";
			label6.Size = new Size(100, 21);
			label6.TabIndex = 19;
			label6.Text = "Сотрудники";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label5.Location = new Point(26, 31);
			label5.Name = "label5";
			label5.Size = new Size(122, 21);
			label5.TabIndex = 18;
			label5.Text = "Оборудование";
			// 
			// radioButton_save_txt
			// 
			radioButton_save_txt.AutoSize = true;
			radioButton_save_txt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
			radioButton_save_txt.Location = new Point(174, 490);
			radioButton_save_txt.Name = "radioButton_save_txt";
			radioButton_save_txt.Size = new Size(156, 21);
			radioButton_save_txt.TabIndex = 16;
			radioButton_save_txt.Text = "Текстовый документ";
			radioButton_save_txt.UseVisualStyleBackColor = true;
			// 
			// radioButton_save_word
			// 
			radioButton_save_word.AutoSize = true;
			radioButton_save_word.Checked = true;
			radioButton_save_word.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
			radioButton_save_word.Location = new Point(26, 490);
			radioButton_save_word.Name = "radioButton_save_word";
			radioButton_save_word.Size = new Size(126, 21);
			radioButton_save_word.TabIndex = 15;
			radioButton_save_word.TabStop = true;
			radioButton_save_word.Text = "Документ Word";
			radioButton_save_word.UseVisualStyleBackColor = true;
			// 
			// DistributionSystemMainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1084, 611);
			Controls.Add(tabControl1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			MaximumSize = new Size(1100, 650);
			MinimumSize = new Size(1100, 650);
			Name = "DistributionSystemMainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Distribution System";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_errors).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView_equipment).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_workers).EndInit();
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView_results).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private RadioButton radioButton_14days;
		private RadioButton radioButton_7days;
		private RadioButton radioButton_1day;
		private RadioButton radioButton_save_txt;
		private RadioButton radioButton_save_word;
		private Button button_update_equipment;
		private Label label2;
		private DataGridView dataGridView_errors;
		private DataGridView dataGridView_equipment;
		private Label label1;
		private Label label4;
		private Button button_update_workers;
		private DataGridView dataGridView_workers;
		private DataGridView dataGridView_results;
		private Label label7;
		private Label label6;
		private Label label5;
		private Button button_distribute;
		private Button button_reset;
		private Button button_save;
		private ListBox listBox_workers;
		private ListBox listBox_equipment;
	}
}
