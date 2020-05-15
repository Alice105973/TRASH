namespace VM2
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox9 = new System.Windows.Forms.TextBox();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.button1 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.MyDataGrid = new System.Windows.Forms.DataGridView();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBox9);
      this.groupBox1.Controls.Add(this.textBox8);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.textBox7);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.textBox6);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.textBox5);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.textBox3);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.textBox4);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(13, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(424, 189);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Параметры:";
      // 
      // textBox9
      // 
      this.textBox9.Location = new System.Drawing.Point(263, 150);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new System.Drawing.Size(60, 22);
      this.textBox9.TabIndex = 16;
      this.textBox9.Text = "0,5";
      this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // textBox8
      // 
      this.textBox8.Location = new System.Drawing.Point(129, 150);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(60, 22);
      this.textBox8.TabIndex = 15;
      this.textBox8.Text = "0,5";
      this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(16, 174);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(0, 17);
      this.label7.TabIndex = 14;
      // 
      // textBox7
      // 
      this.textBox7.Location = new System.Drawing.Point(58, 150);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(57, 22);
      this.textBox7.TabIndex = 13;
      this.textBox7.Text = "0,5";
      this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(12, 153);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(378, 17);
      this.label8.TabIndex = 12;
      this.label8.Text = "b(x) =                +                 cos(πx/l) +                 cos(2πx/l)";
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(218, 112);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(60, 22);
      this.textBox6.TabIndex = 11;
      this.textBox6.Text = "0,5";
      this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(16, 136);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(0, 17);
      this.label6.TabIndex = 10;
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(88, 112);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(57, 22);
      this.textBox5.TabIndex = 9;
      this.textBox5.Text = "0,5";
      this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(12, 115);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(334, 17);
      this.label5.TabIndex = 8;
      this.label5.Text = "φ(x) = 1/l +                cos(πx/l) +                 cos(2πx/l)";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(216, 44);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(126, 17);
      this.label4.TabIndex = 7;
      this.label4.Text = "Кол-во шагов по x";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(354, 68);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(64, 22);
      this.textBox3.TabIndex = 6;
      this.textBox3.Text = "10";
      this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesInt_TextFormat);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(215, 73);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(124, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "Кол-во шагов по t";
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(354, 39);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(64, 22);
      this.textBox4.TabIndex = 4;
      this.textBox4.Text = "100";
      this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesInt_TextFormat);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(124, 70);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(64, 22);
      this.textBox2.TabIndex = 3;
      this.textBox2.Text = "1";
      this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(124, 39);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(64, 22);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "10";
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxesDouble_TextFormat);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Время";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Длина стержня";
      // 
      // chart1
      // 
      chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
      chartArea3.AxisX.Title = "x";
      chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
      chartArea3.AxisY.Title = "y";
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.chart1.Legends.Add(legend3);
      this.chart1.Location = new System.Drawing.Point(443, 20);
      this.chart1.Name = "chart1";
      series3.ChartArea = "ChartArea1";
      series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series3.Legend = "Legend1";
      series3.Name = "Series1";
      this.chart1.Series.Add(series3);
      this.chart1.Size = new System.Drawing.Size(536, 440);
      this.chart1.TabIndex = 1;
      this.chart1.Text = "chart1";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(13, 209);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(423, 34);
      this.button1.TabIndex = 2;
      this.button1.Text = "Рассчитать";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 487);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(967, 23);
      this.progressBar1.TabIndex = 5;
      // 
      // MyDataGrid
      // 
      this.MyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.MyDataGrid.Location = new System.Drawing.Point(13, 249);
      this.MyDataGrid.Name = "MyDataGrid";
      this.MyDataGrid.RowHeadersWidth = 51;
      this.MyDataGrid.RowTemplate.Height = 24;
      this.MyDataGrid.Size = new System.Drawing.Size(423, 232);
      this.MyDataGrid.TabIndex = 6;
      this.MyDataGrid.TabStop = false;
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(442, 464);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(218, 17);
      this.label9.TabIndex = 7;
      this.label9.Text = "Время выполнения части A, мс:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(666, 463);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(0, 17);
      this.label10.TabIndex = 8;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(833, 464);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(65, 17);
      this.label11.TabIndex = 9;
      this.label11.Text = "Части B:";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(904, 463);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(0, 17);
      this.label12.TabIndex = 10;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(991, 521);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.MyDataGrid);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.groupBox1);
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Численное решение начально-краевой задачи";
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.MyDataGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.DataGridView MyDataGrid;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
  }
}

