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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnToDo = new System.Windows.Forms.Button();
            this.numericUpDownNumberOfSteps = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(12, 12);
            this.graph.Name = "graph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "series";
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(760, 410);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart";
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(778, 195);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(88, 41);
            this.btnToDo.TabIndex = 1;
            this.btnToDo.Text = "Сделать хорошо";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // numericUpDownNumberOfSteps
            // 
            this.numericUpDownNumberOfSteps.Location = new System.Drawing.Point(779, 121);
            this.numericUpDownNumberOfSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfSteps.Name = "numericUpDownNumberOfSteps";
            this.numericUpDownNumberOfSteps.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownNumberOfSteps.TabIndex = 2;
            this.numericUpDownNumberOfSteps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumberOfSteps.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfSteps_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 461);
            this.Controls.Add(this.numericUpDownNumberOfSteps);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfSteps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfSteps;
    }
}

