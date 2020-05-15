using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VM2
{
  public partial class Form1 : Form
  {
    double[,] result_a;
    double[,] result_b;
    double L, T,  t, h, b0, b1, b2, phi1, phi2;

    int hnum, tnum;
    int part;

    double time_a, time_b;

    public Form1()
    {
      InitializeComponent();
      ChartArea chart = chart1.ChartAreas[0];
      chart.AxisX.RoundAxisValues();
      progressBar1.Minimum = 0;
      progressBar1.Value = 0;
      progressBar1.Step = 1;
    }

    private void TextBoxesDouble_TextFormat(object sender, KeyPressEventArgs e)
    {
      if (!((e.KeyChar >= '0' && e.KeyChar <= '9')
        || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == 8))
      {
        e.Handled = true;
        return;
      }
      if (e.KeyChar == '.')
      {
        e.KeyChar = ',';
      }
    }

    private void TextBoxesInt_TextFormat(object sender, KeyPressEventArgs e)
    {
      if (!((e.KeyChar >= '0' && e.KeyChar <= '9')
        || e.KeyChar == 8))
      {
        e.Handled = true;
        return;
      }
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.Handled = true;
        SelectNextControl(ActiveControl, true, true, true, true);
      }
      if (e.KeyCode == Keys.Space)
      {
        e.Handled = true;
        if (label12.Text == "")
        {
          MessageBox.Show("Нужно сначала выполнить часть B!");
          return;
        }
        string part_a = "Часть A";
        if (chart1.Series[part_a].Enabled == false)
        {
          progressBar1.Value = 0;
          result_a = new double[hnum, tnum];
          part = 0;
          backgroundWorker1.RunWorkerAsync();
        }
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if(backgroundWorker1.IsBusy != true)
      {
        label10.Text = "";
        label12.Text = "";

        progressBar1.Value = 0;
        chart1.Series.Clear();
        chart1.Legends.Clear();

        L = double.Parse(textBox1.Text);
        T = double.Parse(textBox2.Text);
        tnum = int.Parse(textBox3.Text);
        hnum = int.Parse(textBox4.Text);
        phi1 = double.Parse(textBox5.Text);
        phi2 = double.Parse(textBox6.Text);
        b0 = double.Parse(textBox7.Text);
        b1 = double.Parse(textBox8.Text);
        b2 = double.Parse(textBox9.Text);
        h = L / (hnum - 1);
        t = T / (tnum - 1);
        if (t / (h * h) < 1.0 / 4)
        {
          MessageBox.Show("t/h^2 должно быть меньше 1/4");
          return;
        }
        chart1.ChartAreas[0].AxisX.Minimum = 0;
        chart1.ChartAreas[0].AxisX.Maximum = L;
        result_b = new double[hnum, tnum];

        progressBar1.Maximum = tnum;

        part = 1;
        backgroundWorker1.RunWorkerAsync();
      }
    }

    private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker worker = sender as BackgroundWorker;


      if (part == 1)
        result_b = CalculationResult();
      else
        result_a = CalculationResult();
    }

    private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (part == 1)
      {
        PartB();
        label12.Text = (time_b).ToString();
      }
      else
      {
        PartA();
        label10.Text = (time_a).ToString();
      }
    }

    private double phi(double x)
    {
      return (1.0 / L) + phi1 * Math.Cos((Math.PI * x) / L) + phi2 * Math.Cos((2 * Math.PI * x) / L);
    }

    public double b(double x)
    {
      return part * b0 + b1 * Math.Cos((Math.PI * x) / L) + b2 * Math.Cos((2 * Math.PI * x) / L);
    }

    private double Simpson(ref double[,] result, int tstep, int part)
    {
      int coeff;
      double I;
      double current_x = h;

      if (part == 1)
      {
        I = b(0) * result[0, tstep];
        for (int i = 1; i < hnum - 1; ++i)
        {
          coeff = 4;
          if (i % 2 == 0) coeff = 2;
          I += b(current_x) * coeff * result[i, tstep];
          current_x += h;
        }
        I += b(current_x) * result[hnum - 1, tstep];
      }
      else
      {
        I = result[0, tstep];
        for (int i = 1; i < hnum - 1; i++)
        {
          coeff = 4;
          if (i % 2 == 0) coeff = 2;
          I += coeff * result[i, tstep];
          current_x += h;
        }
        I += result[hnum - 1, tstep];
      }
      I *= (h / 3);
      return I;
    }

    private double[] Fcount(ref double[,] result, int tstep, int part)
    {
      double[] F = new double[hnum];
      for (int i = 0; i < hnum; i++)
        F[i] = h * h * result[i, tstep] * (t * (b(h * i) - part * Simpson(ref result, tstep, part)) + 1);
      return F;
    }

    public double[,] CalculationResult()
    {
      double[] F;
      double[] alpha = new double[hnum];
      double[] beta = new double[hnum];
      double[,] result = new double[hnum, tnum];

      var timer = System.Diagnostics.Stopwatch.StartNew();

      double current_x = 0;
      for (int k = 0; k < hnum; k++)
      {
        result[k, 0] = phi(current_x);
        current_x += h;
      }

      int K = hnum;
      double B, C0, Ak, Ck, AK;
      B = h * h + 2 * t;
      C0 = AK = -2 * t;
      Ak = Ck = -1 * t;

      for (int tstep = 0; tstep < tnum - 1; tstep++)
      {
        F = Fcount(ref result, tstep, part);

        alpha[0] = -1 * (C0 / B);
        beta[0] = F[0] / B;

        for (int k = 1; k < K - 1; k++)
        {
          alpha[k] = (-1 * Ck) / (Ak * alpha[k - 1] + B);
          beta[k] = (F[k] - Ak * beta[k - 1]) / (Ak * alpha[k - 1] + B);
        }

        result[K - 1, tstep + 1] = (F[K - 1] - AK * beta[K - 2]) / (AK * alpha[K - 2] + B);

        for (int k = K - 1; k > 0; k--)
        {
          result[k - 1, tstep + 1] = alpha[k - 1] * result[k, tstep + 1] + beta[k - 1];
        }

        progressBar1.Value++;
      }

      if (part == 0)
      {
        double I = Simpson(ref result, tnum - 1, 0);
        for (int k = 0; k < K; k++)
          result[k, tnum - 1] /= I;
      }

      timer.Stop();
      double time = (timer.Elapsed).TotalMilliseconds;
      if (part == 0) time_a = time;
      else time_b = time;

      return result;
    }

    private void PartA()
    {
      progressBar1.Value = tnum;

      string part_a = "Часть A";
      chart1.Series[part_a].Enabled = true;
      chart1.Series[part_a].IsVisibleInLegend = true;

      double current_x = 0;
      for (int k = 0; k < hnum; ++k)
      {
        chart1.Series[part_a].Points.AddXY(current_x, result_a[k, tnum - 1]);
        current_x += h;
      }
    }

    private void PartB()
    {
      string end_t = "Часть B";
      string begin_t = "Входные данные";
      string part_a = "Часть A";

      chart1.Series.Add(begin_t);
      chart1.Series.Add(end_t);
      chart1.Series.Add(part_a);

      chart1.Series[begin_t].IsVisibleInLegend = true;
      chart1.Series[end_t].IsVisibleInLegend = true;
      chart1.Series[part_a].IsVisibleInLegend = false;

      chart1.Series[part_a].Enabled = false;

      chart1.Series[begin_t].ChartType = SeriesChartType.Spline;
      chart1.Series[end_t].ChartType = SeriesChartType.Spline;
      chart1.Series[part_a].ChartType = SeriesChartType.Spline;

      chart1.Series[begin_t].BorderWidth = 2;
      chart1.Series[end_t].BorderWidth = 2;
      chart1.Series[part_a].BorderWidth = 2;

      chart1.Series[begin_t].Color = Color.DarkBlue;
      chart1.Series[end_t].Color = Color.Tomato;
      chart1.Series[part_a].Color = Color.LightGreen;

      chart1.Legends.Add(new Legend("legend"));
      chart1.Legends["legend"].Font = new Font(chart1.Legends["legend"].Font.FontFamily, 10);
      chart1.Legends["legend"].Docking = Docking.Bottom;
      chart1.Legends["legend"].LegendStyle = LegendStyle.Column;

      double current_x = 0;
      for (int k = 0; k < hnum; k++)
      {
        chart1.Series[begin_t].Points.AddXY(current_x, result_b[k, 0]);
        chart1.Series[end_t].Points.AddXY(current_x, result_b[k, tnum - 1]);
        current_x += h;
      }

      MyDataGrid.RowCount = hnum;
      MyDataGrid.ColumnCount = 2;
      MyDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      MyDataGrid.Columns[0].HeaderText = "phi[i]";
      MyDataGrid.Columns[1].HeaderText = "b[i]";

      for (int k = 0; k < hnum; k++)
      {
        MyDataGrid.Rows[k].HeaderCell.Value = k.ToString();
        MyDataGrid.Rows[k].Cells[0].Value = result_b[k, 0].ToString();
        MyDataGrid.Rows[k].Cells[1].Value = b(h * k).ToString();
      }
      progressBar1.Value = tnum;
    }
  }
}
