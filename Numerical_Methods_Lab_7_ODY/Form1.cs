using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Numerical_Methods_Lab_7_ODY
{
    public partial class Form1 : Form
    {
        private int CounterOfTests = 0;
        public Form1()
        {
            InitializeComponent();

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "u",
            });
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "x"
            });
            cartesianChart1.Zoom = ZoomingOptions.Xy;
            cartesianChart1.DefaultLegend = new DefaultLegend { Visibility = Visibility.Visible };
            cartesianChart1.LegendLocation = LegendLocation.Bottom;

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "y",
            });
            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "x"
            });
            cartesianChart2.Zoom = ZoomingOptions.Xy;
            cartesianChart2.DefaultLegend = new DefaultLegend { Visibility = Visibility.Visible };
            cartesianChart2.LegendLocation = LegendLocation.Bottom;

            cartesianChart3.AxisY.Add(new Axis
            {
                Title = "y",
            });
            cartesianChart3.AxisX.Add(new Axis
            {
                Title = "u"
            });
            cartesianChart3.Zoom = ZoomingOptions.Xy;
            cartesianChart3.DefaultLegend = new DefaultLegend { Visibility = Visibility.Visible };
            cartesianChart3.LegendLocation = LegendLocation.Bottom;

            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_MetodInfo.Columns.Clear();
            dataGridView_TaskInfo.Rows.Clear();
            dataGridView_TaskInfo.Columns.Clear();
        }

        private void InitDataGrid_TestTask()
        {
            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_MetodInfo.Columns.Clear();
            dataGridView_MetodInfo.RowCount = 1;
            dataGridView_MetodInfo.ColumnCount = 11;
            dataGridView_MetodInfo.Columns[0].HeaderText = "i";
            dataGridView_MetodInfo.Columns[1].HeaderText = "x_i";
            dataGridView_MetodInfo.Columns[2].HeaderText = "v_i";
            dataGridView_MetodInfo.Columns[3].HeaderText = "v2i";
            dataGridView_MetodInfo.Columns[4].HeaderText = "v_i - v2i";
            dataGridView_MetodInfo.Columns[5].HeaderText = "ОЛП";
            dataGridView_MetodInfo.Columns[6].HeaderText = "h_i";
            dataGridView_MetodInfo.Columns[7].HeaderText = "Ум. шага";
            dataGridView_MetodInfo.Columns[8].HeaderText = "Ув. шага";
            dataGridView_MetodInfo.Columns[9].HeaderText = "u_i";
            dataGridView_MetodInfo.Columns[10].HeaderText = "|u_i - v_i|";
            dataGridView_MetodInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_MetodInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
        private void InitDataGrid_Task1()
        {
            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_MetodInfo.Columns.Clear();
            dataGridView_MetodInfo.RowCount = 1;
            dataGridView_MetodInfo.ColumnCount = 9;
            dataGridView_MetodInfo.Columns[0].HeaderText = "i";
            dataGridView_MetodInfo.Columns[1].HeaderText = "x_i";
            dataGridView_MetodInfo.Columns[2].HeaderText = "v_i";
            dataGridView_MetodInfo.Columns[3].HeaderText = "v2i";
            dataGridView_MetodInfo.Columns[4].HeaderText = "v_i - v2i";
            dataGridView_MetodInfo.Columns[5].HeaderText = "ОЛП";
            dataGridView_MetodInfo.Columns[6].HeaderText = "h_i";
            dataGridView_MetodInfo.Columns[7].HeaderText = "Ум. шага";
            dataGridView_MetodInfo.Columns[8].HeaderText = "Ув. шага";
            dataGridView_MetodInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_MetodInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void InitDataGrid_Task2()
        {
            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_MetodInfo.Columns.Clear();
            dataGridView_MetodInfo.RowCount = 1;
            dataGridView_MetodInfo.ColumnCount = 8;
            dataGridView_MetodInfo.Columns[0].HeaderText = "i";
            dataGridView_MetodInfo.Columns[1].HeaderText = "x_i";
            dataGridView_MetodInfo.Columns[2].HeaderText = "v_i_1";
            dataGridView_MetodInfo.Columns[3].HeaderText = "v_i_2";
            dataGridView_MetodInfo.Columns[4].HeaderText = "ОЛП";
            dataGridView_MetodInfo.Columns[5].HeaderText = "h_i";
            dataGridView_MetodInfo.Columns[6].HeaderText = "Ум. шага";
            dataGridView_MetodInfo.Columns[7].HeaderText = "Ув. шага";
            dataGridView_MetodInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_MetodInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void InitDataGrid_TestTaskInfo()
        {
            dataGridView_TaskInfo.Rows.Clear();
            dataGridView_TaskInfo.Columns.Clear();
            dataGridView_TaskInfo.RowCount = 1;
            dataGridView_TaskInfo.ColumnCount = 11;
            dataGridView_TaskInfo.Columns[0].HeaderText = "n";
            dataGridView_TaskInfo.Columns[1].HeaderText = "b-x_n";
            dataGridView_TaskInfo.Columns[2].HeaderText = "max e";
            dataGridView_TaskInfo.Columns[3].HeaderText = "Ум. шага";
            dataGridView_TaskInfo.Columns[4].HeaderText = "Ув. шага";
            dataGridView_TaskInfo.Columns[5].HeaderText = "max h";
            dataGridView_TaskInfo.Columns[6].HeaderText = "x max h";
            dataGridView_TaskInfo.Columns[7].HeaderText = "min h";
            dataGridView_TaskInfo.Columns[8].HeaderText = "x min h";
            dataGridView_TaskInfo.Columns[9].HeaderText = "max|u - v|";
            dataGridView_TaskInfo.Columns[10].HeaderText = "x max|u - v|";
            dataGridView_TaskInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_TaskInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
        private void InitDataGrid_TaskInfo()
        {
            dataGridView_TaskInfo.Rows.Clear();
            dataGridView_TaskInfo.Columns.Clear();
            dataGridView_TaskInfo.RowCount = 1;
            dataGridView_TaskInfo.ColumnCount = 9;
            dataGridView_TaskInfo.Columns[0].HeaderText = "n";
            dataGridView_TaskInfo.Columns[1].HeaderText = "b-x_n";
            dataGridView_TaskInfo.Columns[2].HeaderText = "max e";
            dataGridView_TaskInfo.Columns[3].HeaderText = "Ум. шага";
            dataGridView_TaskInfo.Columns[4].HeaderText = "Ув. шага";
            dataGridView_TaskInfo.Columns[5].HeaderText = "max h";
            dataGridView_TaskInfo.Columns[6].HeaderText = "x max h";
            dataGridView_TaskInfo.Columns[7].HeaderText = "min h";
            dataGridView_TaskInfo.Columns[8].HeaderText = "x min h";
            dataGridView_TaskInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_TaskInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            CounterOfTests++;
            if (comboBox_TaskSelect.SelectedIndex == 0 || comboBox_TaskSelect.SelectedIndex == 1)
            {
                Function Func;

                if (comboBox_TaskSelect.SelectedIndex == 0)
                {
                    Func = new TestFunction();
                    InitDataGrid_TestTask();
                }
                else
                {
                    Func = new BasicFunction();
                    InitDataGrid_Task1();
                }

                Func<double, double, double> function = Func.FunctionValue;
                Runge_Kutta_2 RK_2 = new Runge_Kutta_2(Convert.ToDouble(textBox_x_0.Text),
                    Convert.ToDouble(textBox_u_0.Text),
                    Convert.ToDouble(textBox_h.Text), Convert.ToDouble(textBox_eps.Text),
                    Convert.ToDouble(textBox_borderRight.Text),
                    Convert.ToDouble(textBox_borderAccuracy.Text), Convert.ToInt32(textBox_max_steps.Text), function,
                    checkBox_StepControlChecked.Checked);
                RK_2.Run();

                cartesianChart1.Series.Add(new LineSeries
                {
                    Title = "Численное решение #" + Convert.ToString(CounterOfTests),
                    Values = new ChartValues<ObservablePoint>(RK_2
                        .GetPoints()
                        .Select(_ => new ObservablePoint(_.X, _.V))),
                    PointGeometrySize = 5
                });

                List<MetodInfo> metodInfos = RK_2.GetMetodInfos();
                List<FunctionValue> functionValues = RK_2.GetFunctionValues();

                if (comboBox_TaskSelect.SelectedIndex == 0)
                {
                    TrueSolution trueSolution = new TrueSolution(Convert.ToDouble(textBox_x_0.Text),
                        Convert.ToDouble(textBox_u_0.Text));
                    for (int index = 0; index < metodInfos.Count; index++)
                    {
                        var metodInfo = metodInfos[index];
                        var functionValue = functionValues[index];
                        dataGridView_MetodInfo.Rows.Add
                            (metodInfo.Iteration, metodInfo.X, functionValue.V, functionValue.VHalf,
                                functionValue.DeltaV,
                                metodInfo.e, metodInfo.H, metodInfo.CountMinusH, metodInfo.CountPlusH,
                                trueSolution.FunctionValue(metodInfo.X, functionValue.V),
                                Math.Abs(trueSolution.FunctionValue(metodInfo.X, functionValue.V) - functionValue.V)
                                    .ToString("F8"));
                    }


                    dataGridView_MetodInfo.AutoResizeColumns();

                    Func<double, double, double> func = trueSolution.FunctionValue;
                    ExperimentInfo experimentInfo = new ExperimentInfo(metodInfos, functionValues, func);

                    InitDataGrid_TestTaskInfo();
                    dataGridView_TaskInfo.Rows.Add(experimentInfo.StepsCount,
                        Convert.ToDouble(textBox_borderRight.Text) - experimentInfo.LastX,
                        experimentInfo.MaxE, experimentInfo.HPlusCount, experimentInfo.HMinusCount,
                        experimentInfo.MaxH, experimentInfo.XMaxH, experimentInfo.MinH, experimentInfo.XMinH,
                        experimentInfo.MaxDeltaUV, experimentInfo.XMaxDeltaUV);
                }
                else
                {
                    for (int index = 0; index < metodInfos.Count; index++)
                    {
                        var metodInfo = metodInfos[index];
                        var functionValue = functionValues[index];
                        dataGridView_MetodInfo.Rows.Add
                            (metodInfo.Iteration, metodInfo.X, functionValue.V, functionValue.VHalf,
                                functionValue.DeltaV,
                                metodInfo.e, metodInfo.H, metodInfo.CountMinusH, metodInfo.CountPlusH);
                    }
                    dataGridView_MetodInfo.AutoResizeColumns();
                    ExperimentInfo experimentInfo = new ExperimentInfo(metodInfos, functionValues);

                    InitDataGrid_TaskInfo();
                    dataGridView_TaskInfo.Rows.Add(experimentInfo.StepsCount,
                        Convert.ToDouble(textBox_borderRight.Text) - experimentInfo.LastX,
                        experimentInfo.MaxE, experimentInfo.HMinusCount, experimentInfo.HPlusCount,
                        experimentInfo.MaxH, experimentInfo.XMaxH, experimentInfo.MinH, experimentInfo.XMinH);
                }
            }
            else
            {
                InitDataGrid_Task2();
                FunctionF f = new FunctionF();
                FunctionG g = new FunctionG(Convert.ToDouble(textBox_a.Text), Convert.ToDouble(textBox_b.Text));
                Runge_Kutta_2_System RK_2_s = new Runge_Kutta_2_System(Convert.ToDouble(textBox_x_0.Text),
                    Convert.ToDouble(textBox_u_0.Text), Convert.ToDouble(textBox_y_0.Text),
                    Convert.ToDouble(textBox_h.Text), Convert.ToDouble(textBox_eps.Text),
                    Convert.ToDouble(textBox_borderRight.Text), Convert.ToDouble(textBox_borderAccuracy.Text),
                    Convert.ToInt32(textBox_max_steps.Text), checkBox_StepControlChecked.Checked, g.FunctionValue, f.FunctionValue);
                RK_2_s.Run();

                List<MetodInfo> metodInfos = RK_2_s.GetMetodInfos();
                List<Point2D> functionValues = RK_2_s.GetPoints();
                ExperimentInfoSystem experimentInfo = new ExperimentInfoSystem(metodInfos, functionValues);

                cartesianChart1.Series.Add(new LineSeries
                {
                    Title = "Численное решение #" + Convert.ToString(CounterOfTests),
                    Values = new ChartValues<ObservablePoint>(RK_2_s
                        .GetPoints()
                        .Select(_ => new ObservablePoint(_.X, _.V1))),
                    PointGeometrySize = 5
                });
                cartesianChart2.Series.Add(new LineSeries
                {
                    Title = "Численное решение #" + Convert.ToString(CounterOfTests),
                    Values = new ChartValues<ObservablePoint>(RK_2_s
                        .GetPoints()
                        .Select(_ => new ObservablePoint(_.X, _.V2))),
                    PointGeometrySize = 5
                });
                cartesianChart3.Series.Add(new LineSeries
                {
                    Title = "Численное решение #" + Convert.ToString(CounterOfTests),
                    Values = new ChartValues<ObservablePoint>(RK_2_s
                        .GetPoints()
                        .Select(_ => new ObservablePoint(_.V1, _.V2))),
                    PointGeometrySize = 5
                });

                for (int index = 0; index < metodInfos.Count; index++)
                {
                    var metodInfo = metodInfos[index];
                    var functionValue = functionValues[index];
                    dataGridView_MetodInfo.Rows.Add
                        (metodInfo.Iteration, metodInfo.X, functionValue.V1, functionValue.V2,
                            metodInfo.e, metodInfo.H, metodInfo.CountMinusH, metodInfo.CountPlusH);
                }
                dataGridView_MetodInfo.AutoResizeColumns();

                InitDataGrid_TaskInfo();
                    dataGridView_TaskInfo.Rows.Add(experimentInfo.StepsCount,
                        Convert.ToDouble(textBox_borderRight.Text) - experimentInfo.LastX,
                        experimentInfo.MaxE, experimentInfo.HMinusCount, experimentInfo.HPlusCount,
                        experimentInfo.MaxH, experimentInfo.XMaxH, experimentInfo.MinH, experimentInfo.XMinH);
            }
        }

        private void button_trueSolution_Click(object sender, EventArgs e)
        {
            TrueSolution trueSolution = new TrueSolution(Convert.ToDouble(textBox_x_0.Text), Convert.ToDouble(textBox_u_0.Text));
            trueSolution.FindPoints(Convert.ToDouble(textBox_borderRight.Text));
            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "Истинное решение",
                Values = new ChartValues<ObservablePoint>(trueSolution
                    .GetPoints()
                    .Select(_ => new ObservablePoint(_.X, _.V))),
                PointGeometry = DefaultGeometries.Square,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69)),
                PointGeometrySize = 5
            });
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            dataGridView_MetodInfo.Rows.Clear();
            dataGridView_MetodInfo.Columns.Clear();
            dataGridView_TaskInfo.Rows.Clear();
            dataGridView_TaskInfo.Columns.Clear();
            cartesianChart1.Series.Clear();
            cartesianChart2.Series.Clear();
            cartesianChart3.Series.Clear();
            CounterOfTests = 0;
        }

        private void comboBox_TaskSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TaskSelect.SelectedIndex == 0)
            {
                button_trueSolution.Visible = true;
            }
            else
            {
                button_trueSolution.Visible = false;
            }
            if (comboBox_TaskSelect.SelectedIndex == 2)
            {
                textBox_a.Visible = true;
                textBox_b.Visible = true;
                textBox_y_0.Visible = true;
            }
            else
            {
                textBox_a.Visible = false;
                textBox_b.Visible = false;
                textBox_y_0.Visible = false;
            }
        }
    }
}
