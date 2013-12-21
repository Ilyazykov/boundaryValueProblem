namespace BoundaryValue
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnToDo = new System.Windows.Forms.Button();
            this.numericUpDownNumberOfSteps = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTestTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonTestOne = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfSteps)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(12, 12);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "series2";
            this.graph.Series.Add(series1);
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(786, 410);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart";
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(804, 195);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(101, 41);
            this.btnToDo.TabIndex = 1;
            this.btnToDo.Text = "Сделать хорошо";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // numericUpDownNumberOfSteps
            // 
            this.numericUpDownNumberOfSteps.Location = new System.Drawing.Point(804, 29);
            this.numericUpDownNumberOfSteps.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumberOfSteps.Name = "numericUpDownNumberOfSteps";
            this.numericUpDownNumberOfSteps.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownNumberOfSteps.TabIndex = 2;
            this.numericUpDownNumberOfSteps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumberOfSteps.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfSteps_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTestTwo);
            this.groupBox1.Controls.Add(this.radioButtonTestOne);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(804, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задача";
            // 
            // radioButtonTestTwo
            // 
            this.radioButtonTestTwo.AutoSize = true;
            this.radioButtonTestTwo.Location = new System.Drawing.Point(7, 68);
            this.radioButtonTestTwo.Name = "radioButtonTestTwo";
            this.radioButtonTestTwo.Size = new System.Drawing.Size(82, 17);
            this.radioButtonTestTwo.TabIndex = 2;
            this.radioButtonTestTwo.Text = "Тестовая 2";
            this.radioButtonTestTwo.UseVisualStyleBackColor = true;
            this.radioButtonTestTwo.CheckedChanged += new System.EventHandler(this.radioButtonTestTwo_CheckedChanged);
            // 
            // radioButtonTestOne
            // 
            this.radioButtonTestOne.AutoSize = true;
            this.radioButtonTestOne.Location = new System.Drawing.Point(7, 44);
            this.radioButtonTestOne.Name = "radioButtonTestOne";
            this.radioButtonTestOne.Size = new System.Drawing.Size(82, 17);
            this.radioButtonTestOne.TabIndex = 1;
            this.radioButtonTestOne.Text = "Тестовая 1";
            this.radioButtonTestOne.UseVisualStyleBackColor = true;
            this.radioButtonTestOne.CheckedChanged += new System.EventHandler(this.radioButtonTestOne_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Основная";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonMain_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownNumberOfSteps);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfSteps)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfSteps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTestTwo;
        private System.Windows.Forms.RadioButton radioButtonTestOne;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

