// Decompiled with JetBrains decompiler
// Type: Oil_Canning___Silverlight.MainPage
// Assembly: Oil Canning - Silverlight, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7325752B-D2B0-4E05-9971-3A603AC58D54
// Assembly location: C:\inetpub\wwwroot\OilCanning_Silverlight\ClientBin\Oil Canning - Silverlight - Copy\Oil Canning - Silverlight.dll

//using CircularGauge;
//using Codeplex.Dashboarding;
//using Microsoft.VisualBasic;
//using Microsoft.VisualBasic.CompilerServices;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Windows;
//using System.Windows.Browser;
//using System.Windows.Controls;
//using System.Windows.Controls.DataVisualization.Charting;
//using System.Windows.Input;

//namespace Oil_Canning___Silverlight
//{
//    [DesignerGenerated]
//    public class MainPage : UserControl
//    {
//        private object oilcanningload;
//        private object oilcanningbool;
//        private object ddq;
//        private object bh210;
//        private object steelgradeselected;
//        private bool FileUploaded;
//        private string FileUploadData;
//        [AccessedThroughProperty("LayoutRoot")]
//        private Grid _LayoutRoot;
//        [AccessedThroughProperty("FVRLabel")]
//        private Label _FVRLabel;
//        [AccessedThroughProperty("FVRTextBox")]
//        private TextBox _FVRTextBox;
//        [AccessedThroughProperty("FVRDial")]
//        private Knob360 _FVRDial;
//        [AccessedThroughProperty("SVRLabel")]
//        private Label _SVRLabel;
//        [AccessedThroughProperty("SVRDial")]
//        private Knob360 _SVRDial;
//        [AccessedThroughProperty("SVRTextBox")]
//        private TextBox _SVRTextBox;
//        [AccessedThroughProperty("ThickLabel")]
//        private Label _ThickLabel;
//        [AccessedThroughProperty("ThickDial")]
//        private Knob360 _ThickDial;
//        [AccessedThroughProperty("ThickTextBox")]
//        private TextBox _ThickTextBox;
//        [AccessedThroughProperty("BowsLabel")]
//        private Label _BowsLabel;
//        [AccessedThroughProperty("LBBDial")]
//        private Knob360 _LBBDial;
//        [AccessedThroughProperty("LBBTextBox")]
//        private TextBox _LBBTextBox;
//        [AccessedThroughProperty("midlabel1")]
//        private Label _midlabel1;
//        [AccessedThroughProperty("MajorLabel")]
//        private Label _MajorLabel;
//        [AccessedThroughProperty("MajorTickLabel")]
//        private Label _MajorTickLabel;
//        [AccessedThroughProperty("Slider1")]
//        private Slider _Slider1;
//        [AccessedThroughProperty("MajorSlider")]
//        private TextBox _MajorSlider;
//        [AccessedThroughProperty("MinorLabel")]
//        private Label _MinorLabel;
//        [AccessedThroughProperty("MinorTickLabel")]
//        private Label _MinorTickLabel;
//        [AccessedThroughProperty("Slider2")]
//        private Slider _Slider2;
//        [AccessedThroughProperty("MinorSlider")]
//        private TextBox _MinorSlider;
//        [AccessedThroughProperty("Label3")]
//        private Label _Label3;
//        [AccessedThroughProperty("Label4")]
//        private Label _Label4;
//        [AccessedThroughProperty("bottomlabel1")]
//        private Label _bottomlabel1;
//        [AccessedThroughProperty("Label1")]
//        private Label _Label1;
//        [AccessedThroughProperty("Label2")]
//        private Label _Label2;
//        [AccessedThroughProperty("DataGrid1")]
//        private DataGrid _DataGrid1;
//        [AccessedThroughProperty("CanningImage")]
//        private Image _CanningImage;
//        [AccessedThroughProperty("CanningBox")]
//        private TextBox _CanningBox;
//        [AccessedThroughProperty("SteelGrade")]
//        private ComboBox _SteelGrade;
//        [AccessedThroughProperty("SteelGradeGauge")]
//        private CircularGaugeControl _SteelGradeGauge;
//        [AccessedThroughProperty("SteelGradeTextBox")]
//        private TextBox _SteelGradeTextBox;
//        [AccessedThroughProperty("ResultsChart")]
//        private System.Windows.Controls.DataVisualization.Charting.Chart _ResultsChart;
//        [AccessedThroughProperty("ResultSeries")]
//        private LineSeries _ResultSeries;
//        [AccessedThroughProperty("exportButton")]
//        private Button _exportButton;
//        [AccessedThroughProperty("Label5")]
//        private Label _Label5;
//        [AccessedThroughProperty("CanningText")]
//        private Label _CanningText;
//        [AccessedThroughProperty("Label7")]
//        private Label _Label7;
//        [AccessedThroughProperty("Label6")]
//        private Label _Label6;
//        [AccessedThroughProperty("Label8")]
//        private Label _Label8;
//        [AccessedThroughProperty("Label9")]
//        private Label _Label9;
//        [AccessedThroughProperty("importButton")]
//        private Button _importButton;
//        [AccessedThroughProperty("DtlChkBox")]
//        private CheckBox _DtlChkBox;
//        [AccessedThroughProperty("UploadLbl")]
//        private Label _UploadLbl;
//        private bool _contentLoaded;

//        public MainPage()
//        {
//            this.steelgradeselected = (object)"None";
//            this.FileUploaded = false;
//            this.FileUploadData = "";
//            this.InitializeComponent();
//        }

//        public void fillChart()
//        {
//            try
//            {
//                List<Chart> chartList1 = new List<Chart>();
//                this.SVRTextBox.Text.ToString();
//                this.ThickTextBox.Text.ToString();
//                double num1 = Conversion.Val(this.FVRTextBox.Text);
//                double num2 = Conversion.Val(this.SVRTextBox.Text);
//                double num3 = Conversion.Val(this.ThickTextBox.Text);
//                double num4 = Conversion.Val(this.LBBTextBox.Text);
//                double num5 = Conversion.Val(this.MajorSlider.Text);
//                double num6 = Conversion.Val(this.MinorSlider.Text);
//                double num7;
//                ref double local1 = ref num7;
//                double num8;
//                ref double local2 = ref num8;
//                double fvr = num1;
//                double svr = num2;
//                double gaugeini = num3;
//                double span = num4;
//                double emaj = num5;
//                double emin = num6;
//                double num9 = Conversions.ToDouble(this.ddq);
//                ref double local3 = ref num9;
//                double num10 = Conversions.ToDouble(this.bh210);
//                ref double local4 = ref num10;
//                List<Chart> oilCanning = this.CalculateOilCanning(ref local1, ref local2, fvr, svr, gaugeini, span, emaj, emin, ref local3, ref local4);
//                this.bh210 = (object)num10;
//                this.ddq = (object)num9;
//                List<Chart> chartList2 = oilCanning;
//                LinearAxis linearAxis1 = new LinearAxis();
//                linearAxis1.Minimum = (double?)0.0;
//                linearAxis1.Maximum = (double?)10.0;
//                linearAxis1.Interval = (double?)1.0;
//                linearAxis1.Orientation = AxisOrientation.X;
//                linearAxis1.Location = AxisLocation.Bottom;
//                LinearAxis linearAxis2 = new LinearAxis();
//                linearAxis2.Minimum = (double?)0.0;
//                linearAxis2.Maximum = (double?)400.0;
//                linearAxis2.Interval = (double?)100.0;
//                linearAxis2.Orientation = AxisOrientation.Y;
//                linearAxis2.Location = AxisLocation.Left;
//                LineSeries lineSeries1 = new LineSeries();
//                lineSeries1.IndependentValuePath = "Deflection";
//                lineSeries1.DependentValuePath = "Load";
//                lineSeries1.DataPointStyle = (Style)this.Resources[(object)"DisableDataPoint"];
//                LineSeries lineSeries2 = lineSeries1;
//                LinearAxis linearAxis3 = new LinearAxis();
//                linearAxis3.Orientation = AxisOrientation.X;
//                linearAxis3.Minimum = (double?)0.0;
//                linearAxis3.Maximum = (double?)10.0;
//                linearAxis3.Interval = (double?)1.0;
//                linearAxis3.Location = AxisLocation.Bottom;
//                linearAxis3.ShowGridLines = true;
//                linearAxis3.Title = (object)"Deflection (MM)";
//                LinearAxis linearAxis4 = linearAxis3;
//                lineSeries2.IndependentAxis = (IAxis)linearAxis4;
//                LineSeries lineSeries3 = lineSeries1;
//                LinearAxis linearAxis5 = new LinearAxis();
//                linearAxis5.Minimum = (double?)0.0;
//                linearAxis5.Maximum = (double?)300.0;
//                linearAxis5.Interval = (double?)50.0;
//                linearAxis5.Orientation = AxisOrientation.Y;
//                linearAxis5.Location = AxisLocation.Left;
//                linearAxis5.ShowGridLines = true;
//                linearAxis5.Title = (object)"Load (N)";
//                LinearAxis linearAxis6 = linearAxis5;
//                lineSeries3.DependentRangeAxis = (IRangeAxis)linearAxis6;
//                if (num7 <= 0.0)
//                {
//                    this.CanningText.Visibility = Visibility.Visible;
//                    this.CanningText.Content = (object)("Oil Canning at " + string.Format("{0:f1}", (object)num8) + "N");
//                    this.oilcanningload = (object)string.Format("{0:f1}", (object)num8);
//                    this.oilcanningbool = (object)1;
//                }
//                else
//                {
//                    this.CanningText.Visibility = Visibility.Collapsed;
//                    this.CanningImage.Visibility = Visibility.Collapsed;
//                    this.oilcanningbool = (object)0;
//                }
//                lineSeries1.ItemsSource = (IEnumerable)chartList2;
//                this.DataGrid1.ItemsSource = (IEnumerable)chartList2;
//                this.ResultsChart.Axes.Clear();
//                this.ResultsChart.Series[0] = (ISeries)lineSeries1;
//                this.exportButton.Visibility = Visibility.Visible;
//            }
//            catch (Exception ex)
//            {
//                ProjectData.SetProjectError(ex);
//                ProjectData.ClearProjectError();
//            }
//        }

//        private List<Chart> CalculateOilCanning(
//          ref double ocvar,
//          ref double peakld,
//          double fvr,
//          double svr,
//          double gaugeini,
//          double span,
//          double emaj,
//          double emin,
//          ref double DDQ,
//          ref double BH210)
//        {
//            List<Chart> oilCanning = new List<Chart>();
//            double[] numArray1 = new double[21];
//            double[] numArray2 = new double[11];
//            double[] numArray3 = new double[11];
//            double[] numArray4 = new double[11];
//            double[] numArray5 = new double[11];
//            float[] numArray6 = new float[213];
//            float[] numArray7 = new float[213];
//            int num1 = 0;
//            double x1 = Math.Log(1.0 + emaj / double.Parse("100.0"));
//            double x2 = Math.Log(1.0 + emin / double.Parse("100.0"));
//            double d = (x1 + x2) * -1.0;
//            double x3 = gaugeini * Math.Exp(d);
//            double x4 = double.Parse("1") / fvr * 10000.0;
//            double x5 = double.Parse("1") / svr * 10000.0;
//            double num2 = double.Parse("1.8");
//            double num3 = (double.Parse("1") + num2) / Math.Sqrt(1.0 + 2.0 * num2);
//            double num4 = double.Parse("2") * num2 / (1.0 + num2);
//            double num5 = num3 * Math.Sqrt(Math.Pow(x1, 2.0) + Math.Pow(x2, 2.0) + num4 * x1 * x2);
//            double num6 = double.Parse("-72.53232126") + x4 * double.Parse("15.59828914") + x5 * double.Parse("13.0651791") + x3 * double.Parse("213.1634827") + num5 * double.Parse("100") * double.Parse("-1.95848059") + Math.Pow(x4, 2.0) * double.Parse("-0.795970382") + Math.Pow(x5, 2.0) * double.Parse("-0.797708151") + Math.Pow(x3, 2.0) * double.Parse("-27.44855967") + Math.Pow(num5 * double.Parse("100"), 2.0) * double.Parse("0.098745276") + x4 * x5 * double.Parse("-0.364333318") + x4 * x3 * double.Parse("-21.50222199") + x5 * x3 * double.Parse("-18.23194649") + x4 * (num5 * double.Parse("100.0")) * double.Parse("0.137396826") + x5 * (num5 * double.Parse("100.0")) * double.Parse("-0.217857199") + x3 * (num5 * double.Parse("100.0")) * double.Parse("15.4962963");
//            DDQ = num6;
//            double num7 = double.Parse("1.36");
//            double num8 = (double.Parse("1") + num7) / Math.Sqrt(1.0 + 2.0 * num7);
//            double num9 = double.Parse("2") * num7 / (1.0 + num7);
//            double num10 = num8 * Math.Sqrt(Math.Pow(x1, 2.0) + Math.Pow(x2, 2.0) + num9 * x1 * x2);
//            double num11 = x4 * 4.236321106 - 28.68952216 + x5 * 9.637663376 + x3 * 149.0650957 + num10 * 100.0 * -2.694921243 + Math.Pow(x4, 2.0) * -0.927863682 + Math.Pow(x5, 2.0) * -1.783005598 + Math.Pow(x3, 2.0) * 130.2316872 + Math.Pow(num10 * 100.0, 2.0) * -2.233762661 + x4 * x5 * 0.071358337 + x4 * x3 * -0.229851852 + x5 * x3 * -5.062709231 + x4 * (num10 * 100.0) * -0.1787746 + x5 * (num10 * 100.0) * 0.103470248 + x3 * (num10 * 100.0) * 44.96068783;
//            BH210 = num11;
//            if (this.SteelGrade.SelectedIndex == 0)
//            {
//                if (num6 > 0.0)
//                {
//                    this.SteelGradeTextBox.Text = string.Format("{0:f2}", (object)num6) + " (N)";
//                    this.SteelGradeGauge.CurrentValue = Conversions.ToDouble(string.Format("{0:f2}", (object)num6));
//                    this.steelgradeselected = (object)"ddq";
//                }
//            }
//            else if (this.SteelGrade.SelectedIndex == 1 && num11 > 0.0)
//            {
//                this.SteelGradeTextBox.Text = string.Format("{0:f3}", (object)num11) + " (N)";
//                this.SteelGradeGauge.CurrentValue = Conversions.ToDouble(string.Format("{0:f3}", (object)num11));
//                this.steelgradeselected = (object)"bh120";
//            }
//            double num12 = x3 - double.Parse("0.7");
//            double num13 = double.Parse("10000.0") / fvr - double.Parse("2.0");
//            double num14 = double.Parse("10000.0") / svr - double.Parse("2.0");
//            double num15 = double.Parse("1000.0") / span - double.Parse("4.0");
//            numArray2[2] = Math.Exp(double.Parse("4.27941") + double.Parse("3.192017") * num12 + double.Parse("0.276748") * num13 + double.Parse("0.077946") * num14 + double.Parse("0.401123") * num15 - double.Parse("2.500264") * num12 * num12 + 0.0 * num13 * num13 + double.Parse("0.053851") * num14 * num14 + double.Parse("0.084306") * num15 * num15 + double.Parse("0.047732") * num12 * num13 + double.Parse("0.153347") * num12 * num14 - double.Parse("0.49623") * num12 * num15 + double.Parse("0.018811") * num13 * num14 + 0.0 * num13 * num15 - double.Parse("0.166958") * num14 * num15);
//            numArray2[3] = Math.Exp(double.Parse("4.613227") + double.Parse("2.800366") * num12 + double.Parse("0.182534") * num13 - double.Parse("0.109508") * num14 + double.Parse("0.602971") * num15 - double.Parse("2.466414") * num12 * num12 - double.Parse("0.022599") * num13 * num13 + double.Parse("0.057154") * num14 * num14 + double.Parse("0.097518") * num15 * num15 + double.Parse("0.139263") * num12 * num13 + double.Parse("0.323791") * num12 * num14 - double.Parse("0.589021") * num12 * num15 + double.Parse("0.005832") * num13 * num14 - double.Parse("0.047279") * num13 * num15 - double.Parse("0.195309") * num14 * num15);
//            numArray2[4] = Math.Exp(double.Parse("5.003404") + double.Parse("2.616944") * num12 + double.Parse("0.116201") * num13 - double.Parse("0.211101") * num14 + double.Parse("0.762237") * num15 - double.Parse("1.79095") * num12 * num12 - double.Parse("0.007297") * num13 * num13 + double.Parse("0.054589") * num14 * num14 + double.Parse("0.10057") * num15 * num15 + double.Parse("0.126543") * num12 * num13 + double.Parse("0.141616") * num12 * num14 - double.Parse("0.517168") * num12 * num15 - double.Parse("0.01239") * num13 * num14 - double.Parse("0.044924") * num13 * num15 - double.Parse("0.193162") * num14 * num15);
//            numArray2[5] = Math.Exp(double.Parse("5.373838") + double.Parse("2.113913") * num12 + double.Parse("0.070318") * num13 - double.Parse("0.274353") * num14 + double.Parse("0.874416") * num15 - double.Parse("2.529494") * num12 * num12 - double.Parse("0.000384") * num13 * num13 + double.Parse("0.076426") * num14 * num14 + double.Parse("0.099986") * num15 * num15 + double.Parse("0.179211") * num12 * num13 + double.Parse("0.151922") * num12 * num14 - double.Parse("0.733827") * num12 * num15 - double.Parse("0.001944") * num13 * num14 - double.Parse("0.049825") * num13 * num15 - double.Parse("0.192579") * num14 * num15);
//            numArray2[6] = Math.Exp(double.Parse("5.772223") + double.Parse("2.533498") * num12 + double.Parse("0.028164") * num13 - double.Parse("0.400536") * num14 + double.Parse("1.173905") * num15 - double.Parse("2.443019") * num12 * num12 + double.Parse("0.00487") * num13 * num13 + double.Parse("0.111013") * num14 * num14 + double.Parse("0.187753") * num15 * num15 + double.Parse("0.100495") * num12 * num13 + double.Parse("0.078791") * num12 * num14 - double.Parse("0.381425") * num12 * num15 + double.Parse("0.010735") * num13 * num14 - double.Parse("0.058385") * num13 * num15 - double.Parse("0.234094") * num14 * num15);
//            numArray2[7] = Math.Exp(6.178011 + double.Parse("2.201") * num12 - double.Parse("0.023444") * num13 - double.Parse("0.513154") * num14 + double.Parse("1.392907") * num15 - double.Parse("2.184983") * num12 * num12 + double.Parse("0.012779") * num13 * num13 + double.Parse("0.131457") * num14 * num14 + double.Parse("0.225974") * num15 * num15 + double.Parse("0.050317") * num12 * num13 + double.Parse("0.124977") * num12 * num14 - double.Parse("0.575138") * num12 * num15 + double.Parse("0.019902") * num13 * num14 - double.Parse("0.077663") * num13 * num15 - double.Parse("0.270135") * num14 * num15);
//            numArray2[8] = Math.Exp(6.471374 + double.Parse("2.025984") * num12 - double.Parse("0.074294") * num13 - double.Parse("0.552174") * num14 + double.Parse("1.420372") * num15 - double.Parse("3.159497") * num12 * num12 + double.Parse("0.017696") * num13 * num13 + double.Parse("0.143595") * num14 * num14 + double.Parse("0.19991") * num15 * num15 - double.Parse("0.000382") * num12 * num13 + double.Parse("0.120918") * num12 * num14 - double.Parse("0.658293") * num12 * num15 + double.Parse("0.032529") * num13 * num14 - double.Parse("0.097144") * num13 * num15 - double.Parse("0.262298") * num14 * num15);
//            numArray2[9] = Math.Exp(double.Parse("6.955466") + double.Parse("1.987479") * num12 - double.Parse("0.161447") * num13 - double.Parse("0.665285") * num14 + double.Parse("1.758484") * num15 - double.Parse("2.392414") * num12 * num12 + double.Parse("0.016408") * num13 * num13 + double.Parse("0.149745") * num14 * num14 + double.Parse("0.276407") * num15 * num15 + double.Parse("0.061953") * num12 * num13 + double.Parse("0.229413") * num12 * num14 - double.Parse("0.640081") * num12 * num15 + double.Parse("0.055921") * num13 * num14 - double.Parse("0.134679") * num13 * num15 - double.Parse("0.296333") * num14 * num15);
//            numArray2[10] = numArray2[9] * numArray2[9] / numArray2[8];
//            numArray3[2] = numArray2[2] * (0.229131 - double.Parse("0.533769") * num12 - double.Parse("0.09538") * num13 - double.Parse("0.171593") * num14 + double.Parse("0.192254") * num15 + double.Parse("0.15805") * num12 * num12 + double.Parse("0.017829") * num14 * num14 - double.Parse("0.004949") * num15 * num15 - double.Parse("0.022224") * num12 * num13 - double.Parse("0.023265") * num12 * num14 - double.Parse("0.107278") * num12 * num15 - double.Parse("0.007157") * num13 * num14 + double.Parse("0.006589") * num14 * num15);
//            numArray3[3] = numArray2[3] * (0.391165 - double.Parse("0.421133") * num12 - double.Parse("0.06414") * num13 - double.Parse("0.099538") * num14 + double.Parse("0.130754") * num15 + double.Parse("1.024189") * num12 * num12 - double.Parse("0.004901") * num13 * num13 + double.Parse("0.000543") * num14 * num14 - double.Parse("0.02751") * num15 * num15 + double.Parse("0.034047") * num12 * num13 + double.Parse("0.050731") * num12 * num14 - double.Parse("0.083898") * num12 * num15 - double.Parse("0.027176") * num13 * num14 + double.Parse("0.025477") * num13 * num15 + double.Parse("0.025167") * num14 * num15);
//            numArray3[4] = numArray2[4] * (double.Parse("0.403497") - double.Parse("0.313428") * num12 - double.Parse("0.019231") * num13 - double.Parse("0.017605") * num14 + double.Parse("0.061348") * num15 - double.Parse("0.178529") * num12 * num12 + double.Parse("0.004678") * num13 * num13 + double.Parse("0.005024") * num14 * num14 - double.Parse("0.038606") * num15 * num15 - double.Parse("0.018657") * num12 * num13 - double.Parse("0.110628") * num12 * num14 - double.Parse("0.025661") * num12 * num15 - double.Parse("0.009588") * num13 * num14 + double.Parse("0.026129") * num13 * num15 + double.Parse("0.047928") * num14 * num15);
//            numArray3[5] = numArray2[5] * (double.Parse("0.350108") - double.Parse("0.132292") * num12 - double.Parse("0.003085") * num13 + double.Parse("0.021036") * num14 + double.Parse("0.005417") * num15 - double.Parse("0.558879") * num12 * num12 + double.Parse("0.00585") * num13 * num13 + double.Parse("0.006212") * num14 * num14 - double.Parse("0.044316") * num15 * num15 - double.Parse("0.054108") * num12 * num13 - double.Parse("0.06248") * num12 * num14 + double.Parse("0.017229") * num12 * num15 + double.Parse("0.00384") * num13 * num14 + double.Parse("0.021152") * num13 * num15 + double.Parse("0.055015") * num14 * num15);
//            numArray3[6] = numArray2[6] * (double.Parse("0.283007") - double.Parse("0.055599") * num12 - double.Parse("0.001509") * num13 + double.Parse("0.031342") * num14 - double.Parse("0.036797") * num15 - double.Parse("0.403868") * num12 * num12 + double.Parse("0.004872") * num13 * num13 + double.Parse("0.00918") * num14 * num14 - double.Parse("0.051491") * num15 * num15 - double.Parse("0.024149") * num12 * num13 - double.Parse("0.028595") * num12 * num14 + double.Parse("0.003327") * num12 * num15 + double.Parse("0.006365") * num13 * num14 + double.Parse("0.014414") * num13 * num15 + double.Parse("0.052277") * num14 * num15);
//            numArray3[7] = numArray2[7] * (double.Parse("0.229139") - double.Parse("0.04943") * num12 - double.Parse("0.005106") * num13 + double.Parse("0.038833") * num14 - double.Parse("0.079926") * num15 + double.Parse("0.10034") * num12 * num12 - double.Parse("0.001251") * num13 * num13 + double.Parse("0.002882") * num14 * num14 - double.Parse("0.062055") * num15 * num15 - double.Parse("0.027398") * num12 * num13 + double.Parse("0.011251") * num12 * num14 - double.Parse("0.013299") * num12 * num15 + double.Parse("0.009892") * num13 * num14 + double.Parse("0.006774") * num13 * num15 + double.Parse("0.052234") * num14 * num15);
//            numArray3[8] = numArray2[8] * (double.Parse("0.189993") - double.Parse("0.161041") * num12 - double.Parse("0.010419") * num13 + double.Parse("0.037259") * num14 - double.Parse("0.088346") * num15 - double.Parse("0.00172") * num12 * num12 + double.Parse("0.001801") * num13 * num13 + double.Parse("0.000522") * num14 * num14 - double.Parse("0.059061") * num15 * num15 - double.Parse("0.007702") * num12 * num13 + double.Parse("0.049029") * num12 * num14 - double.Parse("0.075455") * num12 * num15 + double.Parse("0.011599") * num13 * num14 + double.Parse("0.004558") * num13 * num15 + double.Parse("0.04975") * num14 * num15);
//            numArray3[9] = numArray2[9] * (double.Parse("0.160086") - double.Parse("0.217281") * num12 - double.Parse("0.017121") * num13 + double.Parse("0.036687") * num14 - double.Parse("0.116599") * num15 + double.Parse("0.095436") * num12 * num12 - double.Parse("0.000802") * num13 * num13 - double.Parse("0.003654") * num14 * num14 - double.Parse("0.066166") * num15 * num15 + double.Parse("0.026926") * num12 * num13 + double.Parse("0.046008") * num12 * num14 - double.Parse("0.100392") * num12 * num15 + double.Parse("0.01371") * num13 * num14 + double.Parse("0.000813") * num13 * num15 + double.Parse("0.047239") * num14 * num15);
//            numArray3[10] = numArray2[10] * (2.0 * numArray3[9] / numArray2[9] - numArray3[8] / numArray2[8]);
//            peakld = Math.Exp(double.Parse("4.366247") + double.Parse("3.740587") * num12 + double.Parse("0.433377") * num13 + double.Parse("0.350224") * num14 + double.Parse("0.085641") * num15 - double.Parse("3.027345") * num12 * num12 - double.Parse("0.11474") * num13 * num13 - double.Parse("0.039947") * num14 * num14 + double.Parse("0.051843") * num15 * num15 - double.Parse("0.13102") * num12 * num13 + double.Parse("0.094794") * num12 * num14 + double.Parse("0.116543") * num12 * num15 - double.Parse("0.007454") * num13 * num14 - double.Parse("0.013298") * num13 * num15 - double.Parse("0.099503") * num14 * num15 + double.Parse("0.008318") * num15 * num15 * num15 + double.Parse("0.044045") * num14 * num14 * num15 - double.Parse("0.022015") * num14 * num15 * num15 - double.Parse("0.187397") * num12 * num13 * num15 + double.Parse("0.102058") * num12 * num14 * num15);
//            double num16 = double.Parse("54.807929") + double.Parse("163.619243") * num12 + double.Parse("15.998347") * num13 + double.Parse("2.568738") * num14 + double.Parse("13.968088") * num15 + double.Parse("53.781422") * num12 * num12 - 1.993944 * num13 * num13 + double.Parse("1.058319") * num14 * num14 + double.Parse("5.637651") * num15 * num15 + double.Parse("37.888375") * num12 * num13 - double.Parse("0.422129") * num12 * num14 + double.Parse("12.143284") * num12 * num15 + double.Parse("0.319604") * num13 * num14 + double.Parse("0.75981") * num13 * num15 - double.Parse("11.219268") * num14 * num15;
//            if (Strings.Len(Conversions.ToString(num16)) == 0)
//                num16 = double.Parse("0.0");
//            double num17 = double.Parse("1.271147") + double.Parse("1.124717") * num12 + double.Parse("0.113626") * num13 + double.Parse("0.184286") * num14 - double.Parse("0.631231") * num12 * num12 + double.Parse("0.015319") * num13 * num13 + double.Parse("0.002371") * num14 * num14 + double.Parse("0.017226") * num15 * num15 + double.Parse("0.194801") * num12 * num13 + double.Parse("0.187503") * num12 * num14 - double.Parse("0.12826") * num12 * num15 - double.Parse("0.060003") * num13 * num14 + double.Parse("0.000307") * num13 * num15 + double.Parse("0.044967") * num14 * num15;
//            double num18;
//            if (numArray3[2] > num16)
//            {
//                double num19 = num16 + numArray2[2] - numArray3[2];
//                num18 = (num19 - Math.Sqrt(num19 * num19 - double.Parse("4.0") * peakld * (num16 - numArray3[2]))) / (num16 - numArray3[2]);
//                if (double.Parse("1.9") < num18)
//                    num18 = double.Parse("1.9");
//            }
//            else
//                num18 = double.Parse("1.9");
//            if (num18 < num17)
//                num17 = num18;
//            double num20 = num16;
//            double num21 = (peakld - num16 * num17) / (num17 * num17);
//            numArray3[1] = (double.Parse("4.0") * (numArray2[2] - peakld) - (double.Parse("4.0") - num17 * num17) * numArray3[2]) / ((double.Parse("2.0") - num17) * (double.Parse("2.0") - num17));
//            numArray4[1] = (numArray3[2] - (numArray2[2] - peakld) / (double.Parse("2.0") - num17)) / (double.Parse("2.0") - num17);
//            numArray2[1] = numArray2[2] - 2.0 * numArray3[1] - double.Parse("4.0") * numArray4[1];
//            int index1 = 2;
//            do
//            {
//                numArray4[index1] = -numArray3[checked(index1 + 1)] - 2.0 * numArray3[index1] + 3.0 * (numArray2[checked(index1 + 1)] - numArray2[index1]);
//                numArray5[index1] = numArray3[checked(index1 + 1)] + numArray3[index1] + 2.0 * (numArray2[index1] - numArray2[checked(index1 + 1)]);
//                checked { ++index1; }
//            }
//            while (index1 <= 9);
//            double a = -1.0;
//            int num22 = 0;
//            int index2 = 1;
//            do
//            {
//                numArray6[index2] = 0.05f * (float)checked(index2 - 1);
//                if (index2 % 20 == 1)
//                    ++a;
//                numArray7[index2] = (double)numArray6[index2] > num17 ? (a >= 2.0 ? (float)(numArray2[checked((int)Math.Round(a))] + ((double)numArray6[index2] - a) * (numArray3[checked((int)Math.Round(a))] + ((double)numArray6[index2] - a) * (numArray4[checked((int)Math.Round(a))] + ((double)numArray6[index2] - a) * numArray5[checked((int)Math.Round(a))]))) : (float)(numArray2[1] + (double)numArray6[index2] * (numArray3[1] + (double)numArray6[index2] * numArray4[1]))) : numArray6[index2] * (float)(num20 + num21 * (double)numArray6[index2]);
//                checked { ++num22; }
//                if ((double)numArray7[index2] < double.Parse("400.0"))
//                    checked { ++index2; }
//                else
//                    break;
//            }
//            while (index2 <= 201);
//            int index3 = 1;
//            do
//            {
//                checked { ++num1; }
//                string str1 = numArray6[index3].ToString();
//                string str2 = Conversions.ToString(numArray7[index3]);
//                if ((double)numArray7[index3] > 0.0)
//                    oilCanning.Add(new Chart(Conversions.ToDouble(str1), Conversions.ToDouble(str2)));
//                if ((double)numArray7[index3] < 400.0)
//                    checked { ++index3; }
//                else
//                    break;
//            }
//            while (index3 <= 201);
//            ocvar = numArray3[1] + num17 * (2.0 * numArray4[1]);
//            return oilCanning;
//        }

//        private void FVRDial_ValueChanged(object sender, DashboardValueChangedEventArgs e) => this.fillChart();

//        private void SVRDial_ValueChanged(object sender, DashboardValueChangedEventArgs e) => this.fillChart();

//        private void ThickDial_ValueChanged(object sender, DashboardValueChangedEventArgs e) => this.fillChart();

//        private void LBBDial_ValueChanged(object sender, DashboardValueChangedEventArgs e) => this.fillChart();

//        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => this.fillChart();

//        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => this.fillChart();

//        private void SteelGrade_SelectionChanged(object sender, SelectionChangedEventArgs e) => this.fillChart();

//        private void FVRTextBox_LostFocus(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                if (Operators.CompareString(this.FVRTextBox.Text, "", false) != 0)
//                {
//                    if (Conversions.ToDouble(this.FVRTextBox.Text) < this.FVRDial.Minimum | Conversions.ToDouble(this.FVRTextBox.Text) > this.FVRDial.Maximum)
//                    {
//                        int num = (int)MessageBox.Show("Valid values for this control are between " + Conversions.ToString(this.FVRDial.Minimum) + " and " + Conversions.ToString(this.FVRDial.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                        this.FVRTextBox.Focus();
//                    }
//                    else
//                        this.fillChart();
//                }
//                else
//                    this.FVRTextBox.Text = Conversions.ToString(this.FVRDial.Minimum);
//            }
//            catch (Exception ex)
//            {
//                ProjectData.SetProjectError(ex);
//                int num = (int)MessageBox.Show("Invalid character in the textbox, please remove the character and try again." + Environment.NewLine + "Valid values for this control are between " + Conversions.ToString(this.FVRDial.Minimum) + " and " + Conversions.ToString(this.FVRDial.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                this.FVRTextBox.Focus();
//                ProjectData.ClearProjectError();
//            }
//        }

//        private void SVRTextBox_LostFocus(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                if (Operators.CompareString(this.SVRTextBox.Text, "", false) != 0)
//                {
//                    if (Conversions.ToDouble(this.SVRTextBox.Text) < this.SVRDial.Minimum | Conversions.ToDouble(this.SVRTextBox.Text) > this.SVRDial.Maximum)
//                    {
//                        int num = (int)MessageBox.Show("Valid values for this control are between " + Conversions.ToString(this.SVRDial.Minimum) + " and " + Conversions.ToString(this.SVRDial.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                        this.SVRTextBox.Focus();
//                    }
//                    else
//                        this.fillChart();
//                }
//                else
//                    this.SVRTextBox.Text = Conversions.ToString(this.SVRDial.Minimum);
//            }
//            catch (Exception ex)
//            {
//                ProjectData.SetProjectError(ex);
//                int num = (int)MessageBox.Show("Invalid character in the textbox, please remove the character and try again." + Environment.NewLine + "Valid values for this control are between " + Conversions.ToString(this.SVRDial.Minimum) + " and " + Conversions.ToString(this.SVRDial.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                this.SVRTextBox.Focus();
//                ProjectData.ClearProjectError();
//            }
//        }

//        private void ThickTextBox_LostFocus(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                if (Operators.CompareString(this.ThickTextBox.Text, "", false) != 0)
//                {
//                    if (Conversions.ToDouble(this.ThickTextBox.Text) < 0.55 | Conversions.ToDouble(this.ThickTextBox.Text) > 0.85)
//                    {
//                        int num = (int)MessageBox.Show("Valid values for this control are between " + Conversions.ToString(0.55) + " and " + Conversions.ToString(0.85), "Invalid Entry", MessageBoxButton.OK);
//                        this.ThickTextBox.Focus();
//                    }
//                    else
//                        this.fillChart();
//                }
//                else
//                    this.ThickTextBox.Text = Conversions.ToString(0.55);
//            }
//            catch (Exception ex)
//            {
//                ProjectData.SetProjectError(ex);
//                int num = (int)MessageBox.Show("Invalid character in the textbox, please remove the character and try again." + Environment.NewLine + "Valid values for this control are between " + Conversions.ToString(0.55) + " and " + Conversions.ToString(0.85), "Invalid Entry", MessageBoxButton.OK);
//                this.ThickTextBox.Focus();
//                ProjectData.ClearProjectError();
//            }
//        }

//        private void LBBTextBox_LostFocus(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                if (Operators.CompareString(this.LBBTextBox.Text, "", false) != 0)
//                {
//                    if (Conversions.ToDouble(this.LBBTextBox.Text) < this.LBBDial.Minimum | Conversions.ToDouble(this.LBBTextBox.Text) > this.LBBDial.Maximum)
//                    {
//                        int num = (int)MessageBox.Show("Valid values for this control are between " + Conversions.ToString(this.LBBDial.Minimum) + " and " + Conversions.ToString(this.LBBDial.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                        this.LBBTextBox.Focus();
//                    }
//                    else
//                        this.fillChart();
//                }
//                else
//                    this.LBBTextBox.Text = Conversions.ToString(this.LBBDial.Minimum);
//            }
//            catch (Exception ex)
//            {
//                ProjectData.SetProjectError(ex);
//                int num = (int)MessageBox.Show("Invalid character in the textbox, please remove the character and try again." + Environment.NewLine + "Valid values for this control are between " + Conversions.ToString(this.LBBDial.Minimum) + " and " + Conversions.ToString(this.LBBDial.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                this.LBBTextBox.Focus();
//                ProjectData.ClearProjectError();
//            }
//        }

//        private void MajorSlider_LostFocus(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                if (Operators.CompareString(this.MajorSlider.Text, "", false) != 0)
//                {
//                    if (Conversions.ToDouble(this.MajorSlider.Text) < 0.0 | Conversions.ToDouble(this.MajorSlider.Text) > 2.0)
//                    {
//                        int num = (int)MessageBox.Show("Valid values for this control are between " + Conversions.ToString(this.Slider1.Minimum) + " and " + Conversions.ToString(this.Slider1.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                        this.MajorSlider.Focus();
//                    }
//                    else
//                        this.fillChart();
//                }
//                else
//                    this.MajorSlider.Text = Conversions.ToString(0.0);
//            }
//            catch (Exception ex)
//            {
//                ProjectData.SetProjectError(ex);
//                int num = (int)MessageBox.Show("Invalid character in the textbox, please remove the character and try again." + Environment.NewLine + "Valid values for this control are between " + Conversions.ToString(this.Slider1.Minimum) + " and " + Conversions.ToString(this.Slider1.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                this.MajorSlider.Focus();
//                ProjectData.ClearProjectError();
//            }
//        }

//        private void MinorSlider_LostFocus(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                if (Operators.CompareString(this.MinorSlider.Text, "", false) != 0)
//                {
//                    if (Conversions.ToDouble(this.MinorSlider.Text) < 0.0 | Conversions.ToDouble(this.MinorSlider.Text) > 2.0)
//                    {
//                        int num = (int)MessageBox.Show("Valid values for this control are between " + Conversions.ToString(this.Slider2.Minimum) + " and " + Conversions.ToString(this.Slider2.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                        this.MinorSlider.Focus();
//                    }
//                    else
//                        this.fillChart();
//                }
//                else
//                    this.MinorSlider.Text = Conversions.ToString(0.0);
//            }
//            catch (Exception ex)
//            {
//                ProjectData.SetProjectError(ex);
//                int num = (int)MessageBox.Show("Invalid character in the textbox, please remove the character and try again." + Environment.NewLine + "Valid values for this control are between " + Conversions.ToString(this.Slider2.Minimum) + " and " + Conversions.ToString(this.Slider2.Maximum), "Invalid Entry", MessageBoxButton.OK);
//                this.MinorSlider.Focus();
//                ProjectData.ClearProjectError();
//            }
//        }

//        private void exportButton_Click(object sender, RoutedEventArgs e)
//        {
//            SaveFileDialog saveFileDialog = new SaveFileDialog()
//            {
//                DefaultExt = "csv",
//                Filter = "CSV Files (*.csv)|*.csv|Excel XML (*.xml)|*.xml|All files (*.*)|*.*",
//                FilterIndex = 1
//            };
//            bool flag = true;
//            bool? nullable = saveFileDialog.ShowDialog();
//            if ((nullable.HasValue ? new bool?(nullable.GetValueOrDefault() == flag) : new bool?()).GetValueOrDefault())
//            {
//                try
//                {
//                    using (Stream stream = saveFileDialog.OpenFile())
//                    {
//                        using (StreamWriter streamWriter = new StreamWriter(stream))
//                        {
//                            string str;
//                            if (this.FileUploaded)
//                            {
//                                this.UploadLbl.Visibility = Visibility.Visible;
//                                this.FileUploaded = false;
//                                str = this.FileUploadData;
//                                this.FileUploadData = "";
//                            }
//                            else
//                                str = this.ExportDataGrid(true, this.DataGrid1, this.FVRTextBox.Text.ToString(), this.SVRTextBox.Text, this.ThickTextBox.Text, this.LBBTextBox.Text, this.MajorSlider.Text, this.MinorSlider.Text, Conversions.ToString(this.ddq), Conversions.ToString(this.bh210));
//                            streamWriter.Write(str);
//                            streamWriter.Close();
//                        }
//                        stream.Close();
//                    }
//                }
//                catch (IOException ex)
//                {
//                    ProjectData.SetProjectError((Exception)ex);
//                    ProjectData.ClearProjectError();
//                }
//            }
//            HtmlPage.Window.Invoke("CallPageMethod", (object)"fvr=", (object)this.FVRTextBox.Text.ToString(), (object)"&svr=", (object)this.SVRTextBox.Text.ToString(), (object)"&thick=", (object)this.ThickTextBox.Text.ToString(), (object)"&lbb=", (object)this.LBBTextBox.Text.ToString(), (object)"&major=", (object)this.MajorSlider.Text.ToString(), (object)"&minor=", (object)this.MinorSlider.Text.ToString(), (object)"&grade=", (object)this.steelgradeselected.ToString());
//        }

//        private void ImportButton_Click(object sender, RoutedEventArgs e)
//        {
//            OpenFileDialog openFileDialog = new OpenFileDialog()
//            {
//                Filter = "CSV Files (*.csv)|*.csv",
//                FilterIndex = 1
//            };
//            List<ImportList> importListList = new List<ImportList>();
//            int index1 = 0;
//            int num1 = 0;
//            string str1 = "";
//            bool flag = true;
//            bool? nullable = openFileDialog.ShowDialog();
//            if ((nullable.HasValue ? new bool?(nullable.GetValueOrDefault() == flag) : new bool?()).GetValueOrDefault())
//            {
//                try
//                {
//                    Stream stream = (Stream)openFileDialog.File.OpenRead();
//                    using (TextReader textReader = (TextReader)new StreamReader(stream))
//                    {
//                        string Expression = textReader.ReadLine().Trim();
//                        if (!Information.IsNothing((object)Expression) && Expression.Length > 0)
//                        {
//                            object obj1 = (object)Expression.Split(',');
//                            for (; !Information.IsNothing((object)Expression); Expression = textReader.ReadLine())
//                            {
//                                string str2 = Expression.Trim();
//                                if (str2.Length > 0)
//                                {
//                                    string[] strArray = str2.Split(',');
//                                    importListList.Add(new ImportList());
//                                    importListList[index1].ID = num1;
//                                    int index2 = 0;
//                                    try
//                                    {
//                                        foreach (object obj2 in (IEnumerable)obj1)
//                                        {
//                                            object objectValue = RuntimeHelpers.GetObjectValue(obj2);
//                                            importListList[index1].Order = index2;
//                                            string Left = objectValue.ToString().ToUpper().Trim();
//                                            if (Operators.CompareString(Left, "FVR", false) == 0)
//                                                importListList[index1].FVR = strArray[index2].ToString();
//                                            else if (Operators.CompareString(Left, "SVR", false) == 0)
//                                                importListList[index1].SVR = strArray[index2].ToString();
//                                            else if (Operators.CompareString(Left, "GAUGEINI", false) == 0)
//                                                importListList[index1].GaugeINI = strArray[index2].ToString();
//                                            else if (Operators.CompareString(Left, "SPAN", false) == 0)
//                                                importListList[index1].Span = strArray[index2].ToString();
//                                            else if (Operators.CompareString(Left, "EMAJ", false) == 0)
//                                                importListList[index1].EMaj = strArray[index2].ToString();
//                                            else if (Operators.CompareString(Left, "EMIN", false) == 0)
//                                                importListList[index1].EMin = strArray[index2].ToString();
//                                            else if (Operators.CompareString(Left, "STEELGRADE", false) == 0)
//                                                importListList[index1].SteelGrade = strArray[index2].ToString();
//                                            checked { ++index2; }
//                                        }
//                                    }
//                                    finally
//                                    {
//                                        IEnumerator enumerator;
//                                        if (enumerator is IDisposable)
//                                            (enumerator as IDisposable).Dispose();
//                                    }
//                                    checked { ++num1; }
//                                    checked { ++index1; }
//                                }
//                            }
//                        }
//                        stream.Close();
//                    }
//                    try
//                    {
//                        foreach (ImportList importList1 in importListList)
//                        {
//                            if (importList1.ID != 0)
//                            {
//                                DataGrid dataGrid1 = this.DataGrid1;
//                                ImportList importList2 = importList1;
//                                double num2 = Conversions.ToDouble(importList2.Ocvar);
//                                ref double local1 = ref num2;
//                                ImportList importList3 = importList1;
//                                double num3 = Conversions.ToDouble(importList3.PeakID);
//                                ref double local2 = ref num3;
//                                double fvr = Conversions.ToDouble(importList1.FVR);
//                                double svr = Conversions.ToDouble(importList1.SVR);
//                                double gaugeini = Conversions.ToDouble(importList1.GaugeINI);
//                                double span = Conversions.ToDouble(importList1.Span);
//                                double emaj = Conversions.ToDouble(importList1.EMaj);
//                                double emin = Conversions.ToDouble(importList1.EMin);
//                                ImportList importList4 = importList1;
//                                double num4 = Conversions.ToDouble(importList4.DDQ);
//                                ref double local3 = ref num4;
//                                ImportList importList5 = importList1;
//                                double num5 = Conversions.ToDouble(importList5.BH210);
//                                ref double local4 = ref num5;
//                                List<Chart> oilCanning = this.CalculateOilCanning(ref local1, ref local2, fvr, svr, gaugeini, span, emaj, emin, ref local3, ref local4);
//                                importList5.BH210 = Conversions.ToString(num5);
//                                importList4.DDQ = Conversions.ToString(num4);
//                                importList3.PeakID = Conversions.ToString(num3);
//                                importList2.Ocvar = Conversions.ToString(num2);
//                                dataGrid1.ItemsSource = (IEnumerable)oilCanning;
//                                str1 += this.ExportDataGrid(true, this.DataGrid1, importList1.FVR, importList1.SVR, importList1.GaugeINI, importList1.Span, importList1.EMaj, importList1.EMin, importList1.DDQ, importList1.BH210);
//                            }
//                        }
//                    }
//                    finally
//                    {
//                        List<ImportList>.Enumerator enumerator;
//                        enumerator.Dispose();
//                    }
//                    this.UploadLbl.Visibility = ~Visibility.Visible;
//                    this.FileUploaded = true;
//                    this.FileUploadData = str1;
//                }
//                catch (IOException ex)
//                {
//                    ProjectData.SetProjectError((Exception)ex);
//                    int num6 = (int)MessageBox.Show("There was an issue with the file during processing. Please ensure there is a valid header in the first row of the file and the file is in a comma delimited format. ", "Error during File Processing", MessageBoxButton.OK);
//                    ProjectData.ClearProjectError();
//                }
//            }
//            HtmlPage.Window.Invoke("CallPageMethod", (object)"fvr=", (object)this.FVRTextBox.Text.ToString(), (object)"&svr=", (object)this.SVRTextBox.Text.ToString(), (object)"&thick=", (object)this.ThickTextBox.Text.ToString(), (object)"&lbb=", (object)this.LBBTextBox.Text.ToString(), (object)"&major=", (object)this.MajorSlider.Text.ToString(), (object)"&minor=", (object)this.MinorSlider.Text.ToString(), (object)"&grade=", (object)this.steelgradeselected.ToString());
//        }

//        private void CallJavascript(object o, EventArgs e) => HtmlPage.Window.Invoke("callbtnMethod");

//        private void exportHistoryButton_Click(object sender, RoutedEventArgs e)
//        {
//        }

//        private string FormatCSVField(string data) => string.Format("\"{0}\"", (object)data.Replace("\"", "\"\"\"").Replace("\n", "").Replace("\r", ""));

//        public string ExportDataGrid(
//          bool withHeaders,
//          DataGrid grid,
//          string FVR,
//          string SVR,
//          string GaugeINI,
//          string Span,
//          string EMaj,
//          string EMin,
//          string sDDQ,
//          string sBH210)
//        {
//            StringBuilder stringBuilder = new StringBuilder();
//            if (!(grid.ItemsSource is IList itemsSource))
//                return "";
//            stringBuilder.Append("Oil Canning Results,Ran on:,").Append(DateTime.Now.ToString("d")).Append("\r\n");
//            stringBuilder.Append("Front View Radius (mm),Side View Radius (mm),Thickness (mm),Free Span Between Bows (mm),Major Stretch (%),Minor Stretch (%)").Append("\r\n");
//            stringBuilder.Append(FVR.ToString()).Append(",").Append(SVR.ToString()).Append(",").Append(GaugeINI.ToString()).Append(",").Append(Span.ToString()).Append(",").Append(EMaj.ToString()).Append(",").Append(EMin.ToString()).Append("\r\n");
//            if (this.DtlChkBox.IsChecked.GetValueOrDefault())
//            {
//                MainPage mainPage = this;
//                List<string> stringList = new List<string>();
//                object obj1;
//                grid.Columns.ToList<DataGridColumn>().ForEach((Action<DataGridColumn>)(a0 => obj1 = ((VB\u0024AnonymousDelegate_0<DataGridColumn, object>)(col =>
//                {
//                    if (col is DataGridBoundColumn)
//                        stringList.Add(mainPage.FormatCSVField(col.Header.ToString()));
//                    object obj2;
//                    return obj2;
//                }))(a0)));
//                stringBuilder.Append(string.Join(",", stringList.ToArray())).Append("\r\n");
//                stringBuilder.Append("0.0, 0.0").Append("\r\n");
//                try
//                {
//                    foreach (object obj3 in (IEnumerable)itemsSource)
//                    {
//                        object objectValue = RuntimeHelpers.GetObjectValue(obj3);
//                        List<string> stringList1 = new List<string>();
//                        try
//                        {
//                            foreach (DataGridColumn column in (Collection<DataGridColumn>)grid.Columns)
//                            {
//                                if (column is DataGridBoundColumn)
//                                {
//                                    string path = (column as DataGridBoundColumn).Binding.Path.Path;
//                                    PropertyInfo property = objectValue.GetType().GetProperty(path);
//                                    if (property != null)
//                                        stringList1.Add(this.FormatCSVField(property.GetValue(RuntimeHelpers.GetObjectValue(objectValue), (object[])null).ToString()));
//                                }
//                            }
//                        }
//                        finally
//                        {
//                            IEnumerator<DataGridColumn> enumerator;
//                            enumerator?.Dispose();
//                        }
//                        stringBuilder.Append(string.Join(",", stringList1.ToArray())).Append("\r\n");
//                    }
//                }
//                finally
//                {
//                    IEnumerator enumerator;
//                    if (enumerator is IDisposable)
//                        (enumerator as IDisposable).Dispose();
//                }
//            }
//            object obj;
//            if (Operators.ConditionalCompareObjectEqual(this.oilcanningbool, (object)0, false))
//                obj = (object)"No oil canning < 400 (N)";
//            else if (Operators.ConditionalCompareObjectEqual(this.oilcanningbool, (object)1, false))
//                obj = RuntimeHelpers.GetObjectValue(this.oilcanningload);
//            stringBuilder.Append("Oil Canning Load (N),0.1mm dent load (DDQ+),0.1mm dent load (BH210)").Append("\r\n");
//            stringBuilder.Append(obj.ToString()).Append(",").Append(sDDQ.ToString()).Append(",").Append(sBH210.ToString()).Append("\r\n");
//            return stringBuilder.ToString();
//        }

//        public void ValidateTextbox(object sender, KeyEventArgs e)
//        {
//            if (e.Key == Key.Tab)
//                return;
//            string str = "";
//            if (e.PlatformKeyCode == 190 | e.PlatformKeyCode == 110)
//                str = ".";
//            else if (e.PlatformKeyCode == 68)
//            {
//                e.Handled = true;
//            }
//            else
//            {
//                string Right = e.Key.ToString().Replace("D", "").Replace("NumPad", "");
//                object obj = Operators.AddObject(NewLateBinding.LateGet(sender, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)Right);
//                Regex regex = new Regex("^[0-9]+[.]?[0-9]*$", RegexOptions.IgnoreCase);
//                e.Handled = !regex.IsMatch(Conversions.ToString(obj));
//            }
//        }

//        private void Slider2_LostMouseCapture(object sender, MouseEventArgs e) => this.fillChart();

//        private void Slider1_LostMouseCapture(object sender, MouseEventArgs e) => this.fillChart();

//        internal virtual Grid LayoutRoot
//        {
//            [DebuggerNonUserCode]
//            get => this._LayoutRoot;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._LayoutRoot = value;
//        }

//        internal virtual Label FVRLabel
//        {
//            [DebuggerNonUserCode]
//            get => this._FVRLabel;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._FVRLabel = value;
//        }

//        internal virtual TextBox FVRTextBox
//        {
//            [DebuggerNonUserCode]
//            get => this._FVRTextBox;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._FVRTextBox = value;
//        }

//        internal virtual Knob360 FVRDial
//        {
//            [DebuggerNonUserCode]
//            get => this._FVRDial;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._FVRDial = value;
//        }

//        internal virtual Label SVRLabel
//        {
//            [DebuggerNonUserCode]
//            get => this._SVRLabel;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._SVRLabel = value;
//        }

//        internal virtual Knob360 SVRDial
//        {
//            [DebuggerNonUserCode]
//            get => this._SVRDial;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._SVRDial = value;
//        }

//        internal virtual TextBox SVRTextBox
//        {
//            [DebuggerNonUserCode]
//            get => this._SVRTextBox;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._SVRTextBox = value;
//        }

//        internal virtual Label ThickLabel
//        {
//            [DebuggerNonUserCode]
//            get => this._ThickLabel;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._ThickLabel = value;
//        }

//        internal virtual Knob360 ThickDial
//        {
//            [DebuggerNonUserCode]
//            get => this._ThickDial;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._ThickDial = value;
//        }

//        internal virtual TextBox ThickTextBox
//        {
//            [DebuggerNonUserCode]
//            get => this._ThickTextBox;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._ThickTextBox = value;
//        }

//        internal virtual Label BowsLabel
//        {
//            [DebuggerNonUserCode]
//            get => this._BowsLabel;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._BowsLabel = value;
//        }

//        internal virtual Knob360 LBBDial
//        {
//            [DebuggerNonUserCode]
//            get => this._LBBDial;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._LBBDial = value;
//        }

//        internal virtual TextBox LBBTextBox
//        {
//            [DebuggerNonUserCode]
//            get => this._LBBTextBox;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._LBBTextBox = value;
//        }

//        internal virtual Label midlabel1
//        {
//            [DebuggerNonUserCode]
//            get => this._midlabel1;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._midlabel1 = value;
//        }

//        internal virtual Label MajorLabel
//        {
//            [DebuggerNonUserCode]
//            get => this._MajorLabel;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._MajorLabel = value;
//        }

//        internal virtual Label MajorTickLabel
//        {
//            [DebuggerNonUserCode]
//            get => this._MajorTickLabel;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._MajorTickLabel = value;
//        }

//        internal virtual Slider Slider1
//        {
//            [DebuggerNonUserCode]
//            get => this._Slider1;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Slider1 = value;
//        }

//        internal virtual TextBox MajorSlider
//        {
//            [DebuggerNonUserCode]
//            get => this._MajorSlider;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._MajorSlider = value;
//        }

//        internal virtual Label MinorLabel
//        {
//            [DebuggerNonUserCode]
//            get => this._MinorLabel;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._MinorLabel = value;
//        }

//        internal virtual Label MinorTickLabel
//        {
//            [DebuggerNonUserCode]
//            get => this._MinorTickLabel;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._MinorTickLabel = value;
//        }

//        internal virtual Slider Slider2
//        {
//            [DebuggerNonUserCode]
//            get => this._Slider2;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Slider2 = value;
//        }

//        internal virtual TextBox MinorSlider
//        {
//            [DebuggerNonUserCode]
//            get => this._MinorSlider;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._MinorSlider = value;
//        }

//        internal virtual Label Label3
//        {
//            [DebuggerNonUserCode]
//            get => this._Label3;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label3 = value;
//        }

//        internal virtual Label Label4
//        {
//            [DebuggerNonUserCode]
//            get => this._Label4;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label4 = value;
//        }

//        internal virtual Label bottomlabel1
//        {
//            [DebuggerNonUserCode]
//            get => this._bottomlabel1;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._bottomlabel1 = value;
//        }

//        internal virtual Label Label1
//        {
//            [DebuggerNonUserCode]
//            get => this._Label1;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label1 = value;
//        }

//        internal virtual Label Label2
//        {
//            [DebuggerNonUserCode]
//            get => this._Label2;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label2 = value;
//        }

//        internal virtual DataGrid DataGrid1
//        {
//            [DebuggerNonUserCode]
//            get => this._DataGrid1;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._DataGrid1 = value;
//        }

//        internal virtual Image CanningImage
//        {
//            [DebuggerNonUserCode]
//            get => this._CanningImage;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._CanningImage = value;
//        }

//        internal virtual TextBox CanningBox
//        {
//            [DebuggerNonUserCode]
//            get => this._CanningBox;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._CanningBox = value;
//        }

//        internal virtual ComboBox SteelGrade
//        {
//            [DebuggerNonUserCode]
//            get => this._SteelGrade;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._SteelGrade = value;
//        }

//        internal virtual CircularGaugeControl SteelGradeGauge
//        {
//            [DebuggerNonUserCode]
//            get => this._SteelGradeGauge;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._SteelGradeGauge = value;
//        }

//        internal virtual TextBox SteelGradeTextBox
//        {
//            [DebuggerNonUserCode]
//            get => this._SteelGradeTextBox;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._SteelGradeTextBox = value;
//        }

//        internal virtual System.Windows.Controls.DataVisualization.Charting.Chart ResultsChart
//        {
//            [DebuggerNonUserCode]
//            get => this._ResultsChart;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._ResultsChart = value;
//        }

//        internal virtual LineSeries ResultSeries
//        {
//            [DebuggerNonUserCode]
//            get => this._ResultSeries;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._ResultSeries = value;
//        }

//        internal virtual Button exportButton
//        {
//            [DebuggerNonUserCode]
//            get => this._exportButton;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._exportButton = value;
//        }

//        internal virtual Label Label5
//        {
//            [DebuggerNonUserCode]
//            get => this._Label5;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label5 = value;
//        }

//        internal virtual Label CanningText
//        {
//            [DebuggerNonUserCode]
//            get => this._CanningText;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._CanningText = value;
//        }

//        internal virtual Label Label7
//        {
//            [DebuggerNonUserCode]
//            get => this._Label7;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label7 = value;
//        }

//        internal virtual Label Label6
//        {
//            [DebuggerNonUserCode]
//            get => this._Label6;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label6 = value;
//        }

//        internal virtual Label Label8
//        {
//            [DebuggerNonUserCode]
//            get => this._Label8;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label8 = value;
//        }

//        internal virtual Label Label9
//        {
//            [DebuggerNonUserCode]
//            get => this._Label9;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._Label9 = value;
//        }

//        internal virtual Button importButton
//        {
//            [DebuggerNonUserCode]
//            get => this._importButton;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set
//            {
//                RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.ImportButton_Click);
//                if (this._importButton != null)
//                    this._importButton.Click -= routedEventHandler;
//                this._importButton = value;
//                if (this._importButton == null)
//                    return;
//                this._importButton.Click += routedEventHandler;
//            }
//        }

//        internal virtual CheckBox DtlChkBox
//        {
//            [DebuggerNonUserCode]
//            get => this._DtlChkBox;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._DtlChkBox = value;
//        }

//        internal virtual Label UploadLbl
//        {
//            [DebuggerNonUserCode]
//            get => this._UploadLbl;
//            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
//            set => this._UploadLbl = value;
//        }

//        [DebuggerNonUserCode]
//        public void InitializeComponent()
//        {
//            if (this._contentLoaded)
//                return;
//            this._contentLoaded = true;
//            Application.LoadComponent((object)this, new Uri("/Oil%20Canning%20-%20Silverlight;component/MainPage.xaml", UriKind.Relative));
//            this.LayoutRoot = (Grid)this.FindName("LayoutRoot");
//            this.FVRLabel = (Label)this.FindName("FVRLabel");
//            this.FVRTextBox = (TextBox)this.FindName("FVRTextBox");
//            this.FVRDial = (Knob360)this.FindName("FVRDial");
//            this.SVRLabel = (Label)this.FindName("SVRLabel");
//            this.SVRDial = (Knob360)this.FindName("SVRDial");
//            this.SVRTextBox = (TextBox)this.FindName("SVRTextBox");
//            this.ThickLabel = (Label)this.FindName("ThickLabel");
//            this.ThickDial = (Knob360)this.FindName("ThickDial");
//            this.ThickTextBox = (TextBox)this.FindName("ThickTextBox");
//            this.BowsLabel = (Label)this.FindName("BowsLabel");
//            this.LBBDial = (Knob360)this.FindName("LBBDial");
//            this.LBBTextBox = (TextBox)this.FindName("LBBTextBox");
//            this.midlabel1 = (Label)this.FindName("midlabel1");
//            this.MajorLabel = (Label)this.FindName("MajorLabel");
//            this.MajorTickLabel = (Label)this.FindName("MajorTickLabel");
//            this.Slider1 = (Slider)this.FindName("Slider1");
//            this.MajorSlider = (TextBox)this.FindName("MajorSlider");
//            this.MinorLabel = (Label)this.FindName("MinorLabel");
//            this.MinorTickLabel = (Label)this.FindName("MinorTickLabel");
//            this.Slider2 = (Slider)this.FindName("Slider2");
//            this.MinorSlider = (TextBox)this.FindName("MinorSlider");
//            this.Label3 = (Label)this.FindName("Label3");
//            this.Label4 = (Label)this.FindName("Label4");
//            this.bottomlabel1 = (Label)this.FindName("bottomlabel1");
//            this.Label1 = (Label)this.FindName("Label1");
//            this.Label2 = (Label)this.FindName("Label2");
//            this.DataGrid1 = (DataGrid)this.FindName("DataGrid1");
//            this.CanningImage = (Image)this.FindName("CanningImage");
//            this.CanningBox = (TextBox)this.FindName("CanningBox");
//            this.SteelGrade = (ComboBox)this.FindName("SteelGrade");
//            this.SteelGradeGauge = (CircularGaugeControl)this.FindName("SteelGradeGauge");
//            this.SteelGradeTextBox = (TextBox)this.FindName("SteelGradeTextBox");
//            this.ResultsChart = (System.Windows.Controls.DataVisualization.Charting.Chart)this.FindName("ResultsChart");
//            this.ResultSeries = (LineSeries)this.FindName("ResultSeries");
//            this.exportButton = (Button)this.FindName("exportButton");
//            this.Label5 = (Label)this.FindName("Label5");
//            this.CanningText = (Label)this.FindName("CanningText");
//            this.Label7 = (Label)this.FindName("Label7");
//            this.Label6 = (Label)this.FindName("Label6");
//            this.Label8 = (Label)this.FindName("Label8");
//            this.Label9 = (Label)this.FindName("Label9");
//            this.importButton = (Button)this.FindName("importButton");
//            this.DtlChkBox = (CheckBox)this.FindName("DtlChkBox");
//            this.UploadLbl = (Label)this.FindName("UploadLbl");
//        }
//    }
//}
