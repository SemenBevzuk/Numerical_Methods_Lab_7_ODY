namespace Numerical_Methods_Lab_7_ODY
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_x_0 = new System.Windows.Forms.TextBox();
            this.textBox_u_0 = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_eps = new System.Windows.Forms.TextBox();
            this.textBox_borderAccuracy = new System.Windows.Forms.TextBox();
            this.textBox_max_steps = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_borderRight = new System.Windows.Forms.TextBox();
            this.checkBox_StepControlChecked = new System.Windows.Forms.CheckBox();
            this.button_trueSolution = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.dataGridView_MetodInfo = new System.Windows.Forms.DataGridView();
            this.comboBox_TaskSelect = new System.Windows.Forms.ComboBox();
            this.dataGridView_TaskInfo = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
            this.textBox_y_0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MetodInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskInfo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(6, 6);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1149, 436);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Точность выхода на границу:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Максимум шагов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Контроль ЛП:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Шаг интегрирования (h):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "u_0 =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "x_0 =";
            // 
            // textBox_x_0
            // 
            this.textBox_x_0.Location = new System.Drawing.Point(417, 131);
            this.textBox_x_0.Name = "textBox_x_0";
            this.textBox_x_0.Size = new System.Drawing.Size(94, 26);
            this.textBox_x_0.TabIndex = 42;
            this.textBox_x_0.Text = "0";
            // 
            // textBox_u_0
            // 
            this.textBox_u_0.Location = new System.Drawing.Point(417, 166);
            this.textBox_u_0.Name = "textBox_u_0";
            this.textBox_u_0.Size = new System.Drawing.Size(94, 26);
            this.textBox_u_0.TabIndex = 43;
            this.textBox_u_0.Text = "1";
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(417, 230);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(94, 26);
            this.textBox_h.TabIndex = 44;
            this.textBox_h.Text = "0,01";
            // 
            // textBox_eps
            // 
            this.textBox_eps.Location = new System.Drawing.Point(417, 262);
            this.textBox_eps.Name = "textBox_eps";
            this.textBox_eps.Size = new System.Drawing.Size(94, 26);
            this.textBox_eps.TabIndex = 45;
            this.textBox_eps.Text = "0,01";
            // 
            // textBox_borderAccuracy
            // 
            this.textBox_borderAccuracy.Location = new System.Drawing.Point(417, 361);
            this.textBox_borderAccuracy.Name = "textBox_borderAccuracy";
            this.textBox_borderAccuracy.Size = new System.Drawing.Size(94, 26);
            this.textBox_borderAccuracy.TabIndex = 46;
            this.textBox_borderAccuracy.Text = "0,01";
            // 
            // textBox_max_steps
            // 
            this.textBox_max_steps.Location = new System.Drawing.Point(417, 393);
            this.textBox_max_steps.Name = "textBox_max_steps";
            this.textBox_max_steps.Size = new System.Drawing.Size(94, 26);
            this.textBox_max_steps.TabIndex = 47;
            this.textBox_max_steps.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Правая граница:";
            // 
            // textBox_borderRight
            // 
            this.textBox_borderRight.Location = new System.Drawing.Point(417, 326);
            this.textBox_borderRight.Name = "textBox_borderRight";
            this.textBox_borderRight.Size = new System.Drawing.Size(94, 26);
            this.textBox_borderRight.TabIndex = 49;
            this.textBox_borderRight.Text = "3";
            // 
            // checkBox_StepControlChecked
            // 
            this.checkBox_StepControlChecked.AutoSize = true;
            this.checkBox_StepControlChecked.Checked = true;
            this.checkBox_StepControlChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_StepControlChecked.Location = new System.Drawing.Point(257, 433);
            this.checkBox_StepControlChecked.Name = "checkBox_StepControlChecked";
            this.checkBox_StepControlChecked.Size = new System.Drawing.Size(158, 24);
            this.checkBox_StepControlChecked.TabIndex = 50;
            this.checkBox_StepControlChecked.Text = "Коррекция шага";
            this.checkBox_StepControlChecked.UseVisualStyleBackColor = true;
            // 
            // button_trueSolution
            // 
            this.button_trueSolution.Location = new System.Drawing.Point(1181, 523);
            this.button_trueSolution.Name = "button_trueSolution";
            this.button_trueSolution.Size = new System.Drawing.Size(243, 53);
            this.button_trueSolution.TabIndex = 53;
            this.button_trueSolution.Text = "Показать точное решение";
            this.button_trueSolution.UseVisualStyleBackColor = true;
            this.button_trueSolution.Visible = false;
            this.button_trueSolution.Click += new System.EventHandler(this.button_trueSolution_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(756, 522);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(219, 55);
            this.button_reset.TabIndex = 52;
            this.button_reset.Text = "Сброс";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(152, 524);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(383, 53);
            this.button_start.TabIndex = 51;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // dataGridView_MetodInfo
            // 
            this.dataGridView_MetodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MetodInfo.Location = new System.Drawing.Point(152, 727);
            this.dataGridView_MetodInfo.Name = "dataGridView_MetodInfo";
            this.dataGridView_MetodInfo.RowTemplate.Height = 28;
            this.dataGridView_MetodInfo.Size = new System.Drawing.Size(1425, 150);
            this.dataGridView_MetodInfo.TabIndex = 54;
            // 
            // comboBox_TaskSelect
            // 
            this.comboBox_TaskSelect.FormattingEnabled = true;
            this.comboBox_TaskSelect.Items.AddRange(new object[] {
            "Тестовая задача",
            "Основная задача №1",
            "Основная задача №2"});
            this.comboBox_TaskSelect.Location = new System.Drawing.Point(191, 55);
            this.comboBox_TaskSelect.Name = "comboBox_TaskSelect";
            this.comboBox_TaskSelect.Size = new System.Drawing.Size(264, 28);
            this.comboBox_TaskSelect.TabIndex = 55;
            this.comboBox_TaskSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox_TaskSelect_SelectedIndexChanged);
            // 
            // dataGridView_TaskInfo
            // 
            this.dataGridView_TaskInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaskInfo.Location = new System.Drawing.Point(152, 594);
            this.dataGridView_TaskInfo.Name = "dataGridView_TaskInfo";
            this.dataGridView_TaskInfo.RowTemplate.Height = 28;
            this.dataGridView_TaskInfo.Size = new System.Drawing.Size(1425, 95);
            this.dataGridView_TaskInfo.TabIndex = 58;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(547, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 478);
            this.tabControl1.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cartesianChart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1161, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "u от x";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cartesianChart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1161, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "y от x";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(6, 4);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(1149, 436);
            this.cartesianChart2.TabIndex = 1;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cartesianChart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1161, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "y от u";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartesianChart3
            // 
            this.cartesianChart3.Location = new System.Drawing.Point(6, 4);
            this.cartesianChart3.Name = "cartesianChart3";
            this.cartesianChart3.Size = new System.Drawing.Size(1149, 436);
            this.cartesianChart3.TabIndex = 1;
            this.cartesianChart3.Text = "cartesianChart3";
            // 
            // textBox_y_0
            // 
            this.textBox_y_0.Location = new System.Drawing.Point(417, 198);
            this.textBox_y_0.Name = "textBox_y_0";
            this.textBox_y_0.Size = new System.Drawing.Size(94, 26);
            this.textBox_y_0.TabIndex = 61;
            this.textBox_y_0.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "y_0 =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "a =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "b =";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(191, 476);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(94, 26);
            this.textBox_a.TabIndex = 64;
            this.textBox_a.Text = "1";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(417, 476);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(94, 26);
            this.textBox_b.TabIndex = 65;
            this.textBox_b.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 926);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_y_0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView_TaskInfo);
            this.Controls.Add(this.comboBox_TaskSelect);
            this.Controls.Add(this.dataGridView_MetodInfo);
            this.Controls.Add(this.button_trueSolution);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.checkBox_StepControlChecked);
            this.Controls.Add(this.textBox_borderRight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_max_steps);
            this.Controls.Add(this.textBox_borderAccuracy);
            this.Controls.Add(this.textBox_eps);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.textBox_u_0);
            this.Controls.Add(this.textBox_x_0);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MetodInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaskInfo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_x_0;
        private System.Windows.Forms.TextBox textBox_u_0;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_eps;
        private System.Windows.Forms.TextBox textBox_borderAccuracy;
        private System.Windows.Forms.TextBox textBox_max_steps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_borderRight;
        private System.Windows.Forms.CheckBox checkBox_StepControlChecked;
        private System.Windows.Forms.Button button_trueSolution;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.DataGridView dataGridView_MetodInfo;
        private System.Windows.Forms.ComboBox comboBox_TaskSelect;
        private System.Windows.Forms.DataGridView dataGridView_TaskInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.TabPage tabPage3;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
        private System.Windows.Forms.TextBox textBox_y_0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;

    }
}

