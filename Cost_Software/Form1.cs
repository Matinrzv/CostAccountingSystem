using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cost_Software.Data;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace Cost_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // اتصال رویداد TextChanged برای همه تکست‌باکس‌های ورودی
            AttachTextChangedEvents();
            AttachNumericEvents(this);
        }

        // متد برای اتصال رویدادها به همه تکست‌باکس‌های ورودی
        private void AttachTextChangedEvents()
        {
            // ==================== هزینه‌های متغیر - قیفی ====================
            txtGheifiArd.TextChanged += OnInputChanged;
            txtGheifiAB.TextChanged += OnInputChanged;
            txtGheifiVanil.TextChanged += OnInputChanged;
            txtGheifiNailon.TextChanged += OnInputChanged;
            txtGheifiKarton.TextChanged += OnInputChanged;
            txtGheifiSaier.TextChanged += OnInputChanged;
            txtGheifiSum.TextChanged += OnInputChanged;

            // ==================== هزینه‌های متغیر - برشی ====================
            txtBorshiArd.TextChanged += OnInputChanged;
            txtBorshiAb.TextChanged += OnInputChanged;
            txtBorshiVanil.TextChanged += OnInputChanged;
            txtBorshiNailon.TextChanged += OnInputChanged;
            txtBorshiKarton.TextChanged += OnInputChanged;
            txtBorshiSaier.TextChanged += OnInputChanged;
            txtBorshiSum.TextChanged += OnInputChanged;

            // ==================== هزینه‌های متغیر - حصیری ====================
            txtHasiriArd.TextChanged += OnInputChanged;
            txtHasiriAb.TextChanged += OnInputChanged;
            txtHasiriVanil.TextChanged += OnInputChanged;
            txtHasiriNailon.TextChanged += OnInputChanged;
            txtHasiriKarton.TextChanged += OnInputChanged;
            txtHasiriSaier.TextChanged += OnInputChanged;
            txtHasiriSum.TextChanged += OnInputChanged;

            // ==================== نرخ آرد و وزن مصرف آرد ====================
            txtNerkheArd.TextChanged += OnInputChanged;
            txtGheifiVaznMasrafArd.TextChanged += OnInputChanged;
            txtBoreshiVaznMasrafArd.TextChanged += OnInputChanged;
            txtHasiriVaznMasrafArd.TextChanged += OnInputChanged;

            // ==================== هزینه‌های متغیر - جمع کل (ردیف All) ====================
            txtGheifiArdAll.TextChanged += OnInputChanged;
            txtGheifiAbAll.TextChanged += OnInputChanged;
            txtGheifiVanilAll.TextChanged += OnInputChanged;
            txtGheifiNailonAll.TextChanged += OnInputChanged;
            txtGheifiKartonAll.TextChanged += OnInputChanged;
            txtGheifiSaierAll.TextChanged += OnInputChanged;

            txtBorshiArdAll.TextChanged += OnInputChanged;
            txtBorshiAbAll.TextChanged += OnInputChanged;
            txtBorshiVanilAll.TextChanged += OnInputChanged;
            txtBorshiNailonAll.TextChanged += OnInputChanged;
            txtBorshiKartonAll.TextChanged += OnInputChanged;
            txtBorshiSaierAll.TextChanged += OnInputChanged;

            txtHasiriArdAll.TextChanged += OnInputChanged;
            txtHasiriAbAll.TextChanged += OnInputChanged;
            txtHasiriVanilAll.TextChanged += OnInputChanged;
            txtHasiriNailonAll.TextChanged += OnInputChanged;
            txtHasiriKartonAll.TextChanged += OnInputChanged;
            txtHasiriSaierAll.TextChanged += OnInputChanged;

            txtSumArd.TextChanged += OnInputChanged;
            txtSumAb.TextChanged += OnInputChanged;
            txtSumVanil.TextChanged += OnInputChanged;
            txtSumNailon.TextChanged += OnInputChanged;
            txtSumKarton.TextChanged += OnInputChanged;
            txtSumSaier.TextChanged += OnInputChanged;

            // ==================== هزینه‌های ثابت ====================
            txtSalary.TextChanged += OnInputChanged;
            txtWater.TextChanged += OnInputChanged;
            txtElect.TextChanged += OnInputChanged;
            txtGaz.TextChanged += OnInputChanged;
            txtSum.TextChanged += OnInputChanged;

            // ==================== فروش - قیفی ====================
            txtGheifiGheymatForosh.TextChanged += OnInputChanged;
            txtGheifiTedadForosh.TextChanged += OnInputChanged;
            txtGheifiDarsadMasraf.TextChanged += OnInputChanged;
            txtGheifiDotSarBeSar.TextChanged += OnInputChanged;
            txtGheifiSahmHazineSabet.TextChanged += OnInputChanged;
            txtGheifiForoshVaghei.TextChanged += OnInputChanged;
            txtGheifiHazineMotaghaierKol.TextChanged += OnInputChanged;
            txtGheifiHashieNakhales.TextChanged += OnInputChanged;
            txtGheifiSodOrZian.TextChanged += OnInputChanged;

            // ==================== فروش - برشی ====================
            txtBoreshiGheymatForosh.TextChanged += OnInputChanged;
            txtBoreshiTedadForosh.TextChanged += OnInputChanged;
            txtBoreshiDarsadMasraf.TextChanged += OnInputChanged;
            txtBoreshiDotSarBeSar.TextChanged += OnInputChanged;
            txtBoreshiSahmHazineSabet.TextChanged += OnInputChanged;
            txtBoreshiForoshVaghei.TextChanged += OnInputChanged;
            txtBoreshiHazineMotaghayerKol.TextChanged += OnInputChanged;
            txtBoreshiHashieNakhales.TextChanged += OnInputChanged;
            txtBoreshiSodOrZian.TextChanged += OnInputChanged;

            // ==================== فروش - حصیری ====================
            txtHasiriGheymatForosh.TextChanged += OnInputChanged;
            txtHasiriTedadForosh.TextChanged += OnInputChanged;
            txtHasiriDarsadMasraf.TextChanged += OnInputChanged;
            txtHasiriDotSarBeSar.TextChanged += OnInputChanged;
            txtHasiriSahmHazineSabet.TextChanged += OnInputChanged;
            txtHasiriForoshVaghei.TextChanged += OnInputChanged;
            txtHasiriHazineMotaghayerKol.TextChanged += OnInputChanged;
            txtHasiriHashieNaKales.TextChanged += OnInputChanged;
            txtHasiriSodOrZian.TextChanged += OnInputChanged;

            // ==================== فروش - جمع ====================
            txtSumSodOrZian.TextChanged += OnInputChanged;
            txtSumHashieNakhales.TextChanged += OnInputChanged;
            txtSumHazineMotaghayerKol.TextChanged += OnInputChanged;
            txtSumForoshVaghei.TextChanged += OnInputChanged;
            txtSumSahmHazineSabet.TextChanged += OnInputChanged;
            txtSumDotSarBeSar.TextChanged += OnInputChanged;

            // ==================== نقطه سر به سر - قیفی ====================
            txtGheifiGheymat.TextChanged += OnInputChanged;
            txtGheifiHazineMotaghyerHarVahed.TextChanged += OnInputChanged;
            txtGheifiHashieHarVahed.TextChanged += OnInputChanged;
            txtGheifiDarsadMasrafArd.TextChanged += OnInputChanged;
            txtGheifiDotTedad.TextChanged += OnInputChanged;
            txtGheifiDotMablagh.TextChanged += OnInputChanged;

            // ==================== نقطه سر به سر - برشی ====================
            txtBoreshiGheymat.TextChanged += OnInputChanged;
            txtBoreshiHazineMotaghayerHarVahed.TextChanged += OnInputChanged;
            txtBoreshiHashieHarVahed.TextChanged += OnInputChanged;
            txtBoreshiDarsadMasrafArd.TextChanged += OnInputChanged;
            txtBoreshiDotTedad.TextChanged += OnInputChanged;
            txtBoreshiDotMablagh.TextChanged += OnInputChanged;

            // ==================== نقطه سر به سر - حصیری ====================
            txtHasiriGheymat.TextChanged += OnInputChanged;
            txtHasiriHazineMotaghayerHarVahed.TextChanged += OnInputChanged;
            txtHasiriHashieHarVahed.TextChanged += OnInputChanged;
            txtHasiriDarsadMasrafArd.TextChanged += OnInputChanged;
            txtHasiriDotTedad.TextChanged += OnInputChanged;
            txtHasiriDotMablagh.TextChanged += OnInputChanged;

            // ==================== نقطه سر به سر - جمع ====================
            txtArdAll.TextChanged += OnInputChanged;

            // ==================== جمع کل ====================
            txtSumVariableAll.TextChanged += OnInputChanged;
            txtSumFixedAll.TextChanged += OnInputChanged;
            txtSumAll.TextChanged += OnInputChanged;
        }

        // رویداد تغییر متن
        private void OnInputChanged(object sender, EventArgs e)
        {
            UpdateAllCalculations();
        }
        private void NumericTextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (decimal.TryParse(txt.Text.Replace(",", ""), out decimal number))
            {
                txt.Text = number.ToString("#,##0.##");
            }
        }

        // متد به‌روزرسانی همه محاسبات
        private void UpdateAllCalculations()
        {
            try
            {
                // دریافت مقادیر از فرم
                DataManager.GetValuesFromForm(this);

                // ====== به‌روزرسانی هزینه آرد ======
                txtGheifiArd.Text = Formulas.Ard_Gheifi().ToString("N0");
                txtBorshiArd.Text = Formulas.Ard_Boreshi().ToString("N0");
                txtHasiriArd.Text = Formulas.Ard_Hasiri().ToString("N0");

                // ====== به‌روزرسانی جمع هزینه متغیر ======
                txtGheifiSum.Text = Formulas.GheifiVariableTotal().ToString("N0");
                txtBorshiSum.Text = Formulas.BorshiVariableTotal().ToString("N0");
                txtHasiriSum.Text = Formulas.HasiriVariableTotal().ToString("N0");

                // ====== به‌روزرسانی جمع کل هزینه متغیر ======
                txtSumVariableAll.Text = Formulas.TotalVariableCost().ToString("N0");

                // ====== به‌روزرسانی جمع هزینه ثابت ======
                txtSum.Text = Formulas.TotalFixedCost().ToString("N0");
                txtSumFixedAll.Text = Formulas.TotalFixedCost().ToString("N0");

                // ====== به‌روزرسانی جمع کل ======
                txtSumAll.Text = Formulas.TotalCost().ToString("N0");

                // ====== به‌روزرسانی فروش ======
                txtGheifiForoshVaghei.Text = Formulas.GheifiSales().ToString("N0");
                txtBoreshiForoshVaghei.Text = Formulas.BorshiSales().ToString("N0");
                txtHasiriForoshVaghei.Text = Formulas.HasiriSales().ToString("N0");
                txtSumForoshVaghei.Text = Formulas.TotalSales().ToString("N0");

                txtGheifiDotSarBeSar.Text = Formulas.GheifiSingleProductBEP().ToString("N2");
                txtBoreshiDotSarBeSar.Text = Formulas.BoreshiSingleProductBEP().ToString("N2");
                txtHasiriDotSarBeSar.Text = Formulas.HasiriSingleProductBEP().ToString("N2");
                txtSumDotSarBeSar.Text = Formulas.SumSingleProductBEP().ToString("N2");

                txtGheifiDotTedad.Text = Formulas.GheifiSingleProductBEP().ToString("N2");
                txtBoreshiDotTedad.Text = Formulas.BoreshiSingleProductBEP().ToString("N2");
                txtHasiriDotTedad.Text = Formulas.HasiriSingleProductBEP().ToString("N2");

                txtGheifiTedadForosh.Text = Formulas.GheifiSingleProductBEP().ToString("N2");
                txtBoreshiTedadForosh.Text = Formulas.BoreshiSingleProductBEP().ToString("N2");
                txtHasiriTedadForosh.Text = Formulas.HasiriSingleProductBEP().ToString("N2");

                txtGheifiSahmHazineSabet.Text = Formulas.GheifiSahmHazineSabet().ToString("N0");
                txtBoreshiSahmHazineSabet.Text = Formulas.BoreshiSahmHazineSabet().ToString("N0");
                txtHasiriSahmHazineSabet.Text = Formulas.HasiriSahmHazineSabet().ToString("N0");
                txtSumSahmHazineSabet.Text = Formulas.SumSahmHazineSabet().ToString("N0");

                txtGheifiHazineMotaghaierKol.Text = Formulas.GheifiHazineMotaghayreKol().ToString("N0");
                txtBoreshiHazineMotaghayerKol.Text = Formulas.BoreshiHazineMotaghayreKol().ToString("N0");
                txtHasiriHazineMotaghayerKol.Text = Formulas.HasiriHazineMotaghayreKol().ToString("N0");
                txtSumHazineMotaghayerKol.Text = Formulas.SumHazineMotaghayreKol().ToString("N0");

                txtGheifiHashieNakhales.Text = Formulas.GheifiHashieNakhales().ToString("N0");
                txtBoreshiHashieNakhales.Text = Formulas.BoreshiHashieNakhales().ToString("N0");
                txtHasiriHashieNaKales.Text = Formulas.HasiriHashieNakhales().ToString("N0");
                txtSumHashieNakhales.Text = Formulas.SumHashieNakhales().ToString("N0");

                txtGheifiGheymat.Text = Formulas.GheifiGheymatForosh().ToString("N0");
                txtGheifiGheymatForosh.Text = Formulas.GheifiGheymatForosh().ToString("N0");
                txtBoreshiGheymat.Text = Formulas.BoreshiGheymatForosh().ToString("N0");
                txtBoreshiGheymatForosh.Text = Formulas.BoreshiGheymatForosh().ToString("N0");
                txtHasiriGheymat.Text = Formulas.HasiriGheymatForosh().ToString("N0");
                txtHasiriGheymatForosh.Text = Formulas.HasiriGheymatForosh().ToString("N0");

                txtGheifiHazineMotaghyerHarVahed.Text = Formulas.GheifiVariableTotal().ToString("N0");
                txtBoreshiHazineMotaghayerHarVahed.Text = Formulas.BorshiVariableTotal().ToString("N0");
                txtHasiriHazineMotaghayerHarVahed.Text = Formulas.HasiriVariableTotal().ToString("N0");

                txtGheifiHashieHarVahed.Text = Formulas.GheifiHashieHarVahed().ToString("N0");
                txtBoreshiHashieHarVahed.Text = Formulas.BoreshiHashieHarVahed().ToString("N0");
                txtHasiriHashieHarVahed.Text = Formulas.HasiriHashieHarVahed().ToString("N0");

                txtGheifiVaznMasrafArd.Text = Formulas.GheifiVaznMasrafiArd().ToString("N2");
                txtBoreshiVaznMasrafArd.Text = Formulas.BoreshiVaznMasrafiArd().ToString("N2");
                txtHasiriVaznMasrafArd.Text = Formulas.HasiriVaznMasrafiArd().ToString("N2");

                txtGheifiDarsadMasraf.Text = Formulas.GheifiDarsadMasrafiArd().ToString("N2");
                txtGheifiDarsadMasrafArd.Text = Formulas.GheifiDarsadMasrafiArd().ToString("N2");
                txtBoreshiDarsadMasraf.Text = Formulas.BoreshiDarsadMasrafiArd().ToString("N2");
                txtBoreshiDarsadMasrafArd.Text = Formulas.BoreshiDarsadMasrafiArd().ToString("N2");
                txtHasiriDarsadMasraf.Text = Formulas.HasiriDarsadMasrafiArd().ToString("N2");
                txtHasiriDarsadMasrafArd.Text = Formulas.HasiriDarsadMasrafiArd().ToString("N2");

                txtGheifiDotMablagh.Text = Formulas.GheifiDotMablagh().ToString("N0");
                txtBoreshiDotMablagh.Text = Formulas.BoreshiDotMablagh().ToString("N0");
                txtHasiriDotMablagh.Text = Formulas.HasiriDotMablagh().ToString("N0");

                txtGheifiArdAll.Text = Formulas.GheifiArdAll().ToString("N0");
                txtGheifiAbAll.Text = Formulas.GheifiABAll().ToString("N0");
                txtGheifiVanilAll.Text = Formulas.GheifiVanilAll().ToString("N0");
                txtGheifiNailonAll.Text = Formulas.GheifiNailonAll().ToString("N0");
                txtGheifiKartonAll.Text = Formulas.GheifiKartonAll().ToString("N0");
                txtGheifiSaierAll.Text = Formulas.GheifiSaierAll().ToString("N0");

                txtBorshiArdAll.Text = Formulas.BoreshiArdAll().ToString("N0");
                txtBorshiAbAll.Text = Formulas.BoreshiABAll().ToString("N0");
                txtBorshiVanilAll.Text = Formulas.BoreshiVanilAll().ToString("N0");
                txtBorshiNailonAll.Text = Formulas.BoreshiNailonAll().ToString("N0");
                txtBorshiKartonAll.Text = Formulas.BoreshiKartonAll().ToString("N0");
                txtBorshiSaierAll.Text = Formulas.BoreshiSaierAll().ToString("N0");

                txtHasiriArdAll.Text = Formulas.HasiriArdAll().ToString("N0");
                txtHasiriAbAll.Text = Formulas.HasiriABAll().ToString("N0");
                txtHasiriVanilAll.Text = Formulas.HasiriVanilAll().ToString("N0");
                txtHasiriNailonAll.Text = Formulas.HasiriNailonAll().ToString("N0");
                txtHasiriKartonAll.Text = Formulas.HasiriKartonAll().ToString("N0");
                txtHasiriSaierAll.Text = Formulas.HasiriSaierAll().ToString("N0");

                txtSumArd.Text = Formulas.SumArdAll().ToString("N0");
                txtSumAb.Text = Formulas.SumABAll().ToString("N0");
                txtSumVanil.Text = Formulas.SumVanilAll().ToString("N0");
                txtSumNailon.Text = Formulas.SumNailonAll().ToString("N0");
                txtSumKarton.Text = Formulas.SumKartonAll().ToString("N0");
                txtSumSaier.Text = Formulas.SumSaierAll().ToString("N0");

                txtArdAll.Text = Formulas.VazneArdKol().ToString("N2");
                // ====== سود خالص ======
                // (در صورت نیاز)
            }
            catch (Exception ex)
            {
                // خطاها رو نادیده بگیر یا لاگ کن
            }
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                !txt.Text.Contains(".") &&
                !txt.Text.Contains(","))
                return;

            e.Handled = true;
        }
        private void NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (string.IsNullOrWhiteSpace(txt.Text))
                return;

            int cursor = txt.SelectionStart;

            string value = txt.Text.Replace(",", "");

            if (!decimal.TryParse(value, out decimal number))
                return;

            string[] parts = value.Split('.');

            if (parts.Length == 1)
            {
                txt.Text = number.ToString("#,##0");
            }
            else
            {
                string integer = decimal.Parse(parts[0]).ToString("#,##0");
                txt.Text = integer + "." + parts[1];
            }

            txt.SelectionStart = txt.Text.Length;
        }
        private void AttachNumericEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.KeyPress += NumericTextBox_KeyPress;
                    txt.Leave += NumericTextBox_Leave;
                }

                if (control.HasChildren)
                    AttachNumericEvents(control);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataManager.GetValuesFromForm(this);
                UpdateAllCalculations();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "ذخیره فایل اکسل";
                saveFileDialog.FileName = $"گزارش_{DateTime.Now:yyyy_MM_dd_HH_mm}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        // ============================================================
                        // شیت 1: همه مقادیر تکست‌باکس‌ها
                        // ============================================================
                        ExcelWorksheet wsAll = package.Workbook.Worksheets.Add("همه مقادیر");

                        wsAll.Cells["A1"].Value = "نام فیلد";
                        wsAll.Cells["B1"].Value = "مقدار";
                        wsAll.Cells["A1:B1"].Style.Font.Bold = true;
                        wsAll.Cells["A1:B1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        wsAll.Cells["A1:B1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        wsAll.Cells["A1:B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                        int row = 2;
                        GetAllTextBoxes(this, wsAll, ref row);
                        wsAll.Cells["A:B"].AutoFitColumns();

                        // ============================================================
                        // شیت 2: هزینه‌های متغیر
                        // ============================================================
                        ExcelWorksheet wsVar = package.Workbook.Worksheets.Add("هزینه‌های متغیر");

                        wsVar.Cells["A1"].Value = "محصول";
                        wsVar.Cells["B1"].Value = "آرد";
                        wsVar.Cells["C1"].Value = "آب";
                        wsVar.Cells["D1"].Value = "وانیل";
                        wsVar.Cells["E1"].Value = "نایلون";
                        wsVar.Cells["F1"].Value = "کارتن";
                        wsVar.Cells["G1"].Value = "سایر";
                        wsVar.Cells["H1"].Value = "جمع";
                        wsVar.Cells["A1:H1"].Style.Font.Bold = true;
                        wsVar.Cells["A1:H1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        wsVar.Cells["A1:H1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                        // قیفی
                        wsVar.Cells["A2"].Value = "قیفی";
                        wsVar.Cells["B2"].Value = DataManager.GheifiArd;
                        wsVar.Cells["C2"].Value = DataManager.GheifiAB;
                        wsVar.Cells["D2"].Value = DataManager.GheifiVanil;
                        wsVar.Cells["E2"].Value = DataManager.GheifiNailon;
                        wsVar.Cells["F2"].Value = DataManager.GheifiKarton;
                        wsVar.Cells["G2"].Value = DataManager.GheifiSaier;
                        wsVar.Cells["H2"].Value = DataManager.GheifiSum;

                        // برشی
                        wsVar.Cells["A3"].Value = "برشی";
                        wsVar.Cells["B3"].Value = DataManager.BorshiArd;
                        wsVar.Cells["C3"].Value = DataManager.BorshiAb;
                        wsVar.Cells["D3"].Value = DataManager.BorshiVanil;
                        wsVar.Cells["E3"].Value = DataManager.BorshiNailon;
                        wsVar.Cells["F3"].Value = DataManager.BorshiKarton;
                        wsVar.Cells["G3"].Value = DataManager.BorshiSaier;
                        wsVar.Cells["H3"].Value = DataManager.BorshiSum;

                        // حصیری
                        wsVar.Cells["A4"].Value = "حصیری";
                        wsVar.Cells["B4"].Value = DataManager.HasiriArd;
                        wsVar.Cells["C4"].Value = DataManager.HasiriAb;
                        wsVar.Cells["D4"].Value = DataManager.HasiriVanil;
                        wsVar.Cells["E4"].Value = DataManager.HasiriNailon;
                        wsVar.Cells["F4"].Value = DataManager.HasiriKarton;
                        wsVar.Cells["G4"].Value = DataManager.HasiriSaier;
                        wsVar.Cells["H4"].Value = DataManager.HasiriSum;

                        wsVar.Cells["B2:H4"].Style.Numberformat.Format = "#,##0";

                        // جمع کل
                        wsVar.Cells["A5"].Value = "جمع کل";
                        wsVar.Cells["A5"].Style.Font.Bold = true;
                        wsVar.Cells["B5"].Value = DataManager.SumArd;
                        wsVar.Cells["C5"].Value = DataManager.SumAb;
                        wsVar.Cells["D5"].Value = DataManager.SumVanil;
                        wsVar.Cells["E5"].Value = DataManager.SumNailon;
                        wsVar.Cells["F5"].Value = DataManager.SumKarton;
                        wsVar.Cells["G5"].Value = DataManager.SumSaier;
                        wsVar.Cells["B5:G5"].Style.Font.Bold = true;
                        wsVar.Cells["B5:G5"].Style.Numberformat.Format = "#,##0";

                        wsVar.Cells["A:H"].AutoFitColumns();

                        // ============================================================
                        // شیت 3: فروش
                        // ============================================================
                        ExcelWorksheet wsSales = package.Workbook.Worksheets.Add("فروش");

                        wsSales.Cells["A1"].Value = "محصول";
                        wsSales.Cells["B1"].Value = "قیمت فروش";
                        wsSales.Cells["C1"].Value = "تعداد فروش";
                        wsSales.Cells["D1"].Value = "فروش واقعی";
                        wsSales.Cells["E1"].Value = "هزینه متغیر کل";
                        wsSales.Cells["F1"].Value = "حاشیه ناخالص";
                        wsSales.Cells["G1"].Value = "سهم هزینه ثابت";
                        wsSales.Cells["H1"].Value = "سود/زیان";
                        wsSales.Cells["A1:H1"].Style.Font.Bold = true;
                        wsSales.Cells["A1:H1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        wsSales.Cells["A1:H1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                        // قیفی
                        wsSales.Cells["A2"].Value = "قیفی";
                        wsSales.Cells["B2"].Value = DataManager.GheifiGheymatForosh;
                        wsSales.Cells["C2"].Value = DataManager.GheifiTedadForosh;
                        wsSales.Cells["D2"].Value = DataManager.GheifiForoshVaghei;
                        wsSales.Cells["E2"].Value = DataManager.GheifiHazineMotaghaierKol;
                        wsSales.Cells["F2"].Value = DataManager.GheifiHashieNakhales;
                        wsSales.Cells["G2"].Value = DataManager.GheifiSahmHazineSabet;
                        wsSales.Cells["H2"].Value = DataManager.GheifiSodOrZian;

                        // برشی
                        wsSales.Cells["A3"].Value = "برشی";
                        wsSales.Cells["B3"].Value = DataManager.BoreshiGheymatForosh;
                        wsSales.Cells["C3"].Value = DataManager.BoreshiTedadForosh;
                        wsSales.Cells["D3"].Value = DataManager.BoreshiForoshVaghei;
                        wsSales.Cells["E3"].Value = DataManager.BoreshiHazineMotaghayerKol;
                        wsSales.Cells["F3"].Value = DataManager.BoreshiHashieNakhales;
                        wsSales.Cells["G3"].Value = DataManager.BoreshiSahmHazineSabet;
                        wsSales.Cells["H3"].Value = DataManager.BoreshiSodOrZian;

                        // حصیری
                        wsSales.Cells["A4"].Value = "حصیری";
                        wsSales.Cells["B4"].Value = DataManager.HasiriGheymatForosh;
                        wsSales.Cells["C4"].Value = DataManager.HasiriTedadForosh;
                        wsSales.Cells["D4"].Value = DataManager.HasiriForoshVaghei;
                        wsSales.Cells["E4"].Value = DataManager.HasiriHazineMotaghayerKol;
                        wsSales.Cells["F4"].Value = DataManager.HasiriHashieNaKales;
                        wsSales.Cells["G4"].Value = DataManager.HasiriSahmHazineSabet;
                        wsSales.Cells["H4"].Value = DataManager.HasiriSodOrZian;

                        // جمع
                        wsSales.Cells["A5"].Value = "جمع";
                        wsSales.Cells["A5"].Style.Font.Bold = true;
                        wsSales.Cells["D5"].Value = DataManager.SumForoshVaghei;
                        wsSales.Cells["E5"].Value = DataManager.SumHazineMotaghayerKol;
                        wsSales.Cells["F5"].Value = DataManager.SumHashieNakhales;
                        wsSales.Cells["G5"].Value = DataManager.SumSahmHazineSabet;
                        wsSales.Cells["H5"].Value = DataManager.SumSodOrZian;
                        wsSales.Cells["D5:H5"].Style.Font.Bold = true;

                        wsSales.Cells["B2:H5"].Style.Numberformat.Format = "#,##0";
                        wsSales.Cells["C2:C4"].Style.Numberformat.Format = "#,##0.00";
                        wsSales.Cells["A:H"].AutoFitColumns();

                        // ============================================================
                        // شیت 4: نقطه سر به سر
                        // ============================================================
                        ExcelWorksheet wsBEP = package.Workbook.Worksheets.Add("نقطه سر به سر");

                        wsBEP.Cells["A1"].Value = "محصول";
                        wsBEP.Cells["B1"].Value = "قیمت فروش";
                        wsBEP.Cells["C1"].Value = "هزینه متغیر هر واحد";
                        wsBEP.Cells["D1"].Value = "حاشیه هر واحد";
                        wsBEP.Cells["E1"].Value = "وزن مصرف آرد";
                        wsBEP.Cells["F1"].Value = "درصد مصرف آرد";
                        wsBEP.Cells["G1"].Value = "نقطه سر به سر (تعداد)";
                        wsBEP.Cells["H1"].Value = "نقطه سر به سر (مبلغ)";
                        wsBEP.Cells["A1:H1"].Style.Font.Bold = true;
                        wsBEP.Cells["A1:H1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        wsBEP.Cells["A1:H1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                        // قیفی
                        wsBEP.Cells["A2"].Value = "قیفی";
                        wsBEP.Cells["B2"].Value = DataManager.GheifiGheymat;
                        wsBEP.Cells["C2"].Value = DataManager.GheifiHazineMotaghyerHarVahed;
                        wsBEP.Cells["D2"].Value = DataManager.GheifiHashieHarVahed;
                        wsBEP.Cells["E2"].Value = DataManager.GheifiVaznMasrafArd;
                        wsBEP.Cells["F2"].Value = DataManager.GheifiDarsadMasrafArd;
                        wsBEP.Cells["G2"].Value = DataManager.GheifiDotTedad;
                        wsBEP.Cells["H2"].Value = DataManager.GheifiDotMablagh;

                        // برشی
                        wsBEP.Cells["A3"].Value = "برشی";
                        wsBEP.Cells["B3"].Value = DataManager.BoreshiGheymat;
                        wsBEP.Cells["C3"].Value = DataManager.BoreshiHazineMotaghayerHarVahed;
                        wsBEP.Cells["D3"].Value = DataManager.BoreshiHashieHarVahed;
                        wsBEP.Cells["E3"].Value = DataManager.BoreshiVaznMasrafArd;
                        wsBEP.Cells["F3"].Value = DataManager.BoreshiDarsadMasrafArd;
                        wsBEP.Cells["G3"].Value = DataManager.BoreshiDotTedad;
                        wsBEP.Cells["H3"].Value = DataManager.BoreshiDotMablagh;

                        // حصیری
                        wsBEP.Cells["A4"].Value = "حصیری";
                        wsBEP.Cells["B4"].Value = DataManager.HasiriGheymat;
                        wsBEP.Cells["C4"].Value = DataManager.HasiriHazineMotaghayerHarVahed;
                        wsBEP.Cells["D4"].Value = DataManager.HasiriHashieHarVahed;
                        wsBEP.Cells["E4"].Value = DataManager.HasiriVaznMasrafArd;
                        wsBEP.Cells["F4"].Value = DataManager.HasiriDarsadMasrafArd;
                        wsBEP.Cells["G4"].Value = DataManager.HasiriDotTedad;
                        wsBEP.Cells["H4"].Value = DataManager.HasiriDotMablagh;

                        // جمع
                        wsBEP.Cells["A5"].Value = "جمع";
                        wsBEP.Cells["A5"].Style.Font.Bold = true;
                        wsBEP.Cells["E5"].Value = DataManager.ArdAll;

                        wsBEP.Cells["B2:H4"].Style.Numberformat.Format = "#,##0.00";
                        wsBEP.Cells["E5"].Style.Numberformat.Format = "#,##0.00";
                        wsBEP.Cells["A:H"].AutoFitColumns();

                        // ============================================================
                        // شیت 5: هزینه‌های ثابت
                        // ============================================================
                        ExcelWorksheet wsFixed = package.Workbook.Worksheets.Add("هزینه‌های ثابت");

                        wsFixed.Cells["A1"].Value = "شرح";
                        wsFixed.Cells["B1"].Value = "مقدار (ریال)";
                        wsFixed.Cells["A1:B1"].Style.Font.Bold = true;
                        wsFixed.Cells["A1:B1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        wsFixed.Cells["A1:B1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                        wsFixed.Cells["A2"].Value = "حقوق و دستمزد";
                        wsFixed.Cells["B2"].Value = DataManager.Salary;

                        wsFixed.Cells["A3"].Value = "آب";
                        wsFixed.Cells["B3"].Value = DataManager.Water;

                        wsFixed.Cells["A4"].Value = "برق";
                        wsFixed.Cells["B4"].Value = DataManager.Elect;

                        wsFixed.Cells["A5"].Value = "گاز";
                        wsFixed.Cells["B5"].Value = DataManager.Gaz;

                        wsFixed.Cells["A6"].Value = "جمع کل";
                        wsFixed.Cells["A6"].Style.Font.Bold = true;
                        wsFixed.Cells["B6"].Value = DataManager.FixedSum;
                        wsFixed.Cells["B6"].Style.Font.Bold = true;

                        wsFixed.Cells["B2:B6"].Style.Numberformat.Format = "#,##0";
                        wsFixed.Cells["A:B"].AutoFitColumns();

                        // ============================================================
                        // شیت 6: جمع کل
                        // ============================================================
                        ExcelWorksheet wsTotal = package.Workbook.Worksheets.Add("جمع کل");

                        wsTotal.Cells["A1"].Value = "شرح";
                        wsTotal.Cells["B1"].Value = "مقدار";
                        wsTotal.Cells["A1:B1"].Style.Font.Bold = true;
                        wsTotal.Cells["A1:B1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        wsTotal.Cells["A1:B1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);

                        wsTotal.Cells["A2"].Value = "جمع هزینه متغیر";
                        wsTotal.Cells["B2"].Value = DataManager.SumVariableAll;

                        wsTotal.Cells["A3"].Value = "جمع هزینه ثابت";
                        wsTotal.Cells["B3"].Value = DataManager.SumFixedAll;

                        wsTotal.Cells["A4"].Value = "جمع کل هزینه‌ها";
                        wsTotal.Cells["B4"].Value = DataManager.SumAll;
                        wsTotal.Cells["B4"].Style.Font.Bold = true;

                        wsTotal.Cells["B2:B4"].Style.Numberformat.Format = "#,##0";
                        wsTotal.Cells["A:B"].AutoFitColumns();

                        // ============================================================
                        // ذخیره فایل
                        // ============================================================
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fileInfo);

                        MessageBox.Show($"اطلاعات با موفقیت در فایل زیر ذخیره شد:\n{saveFileDialog.FileName}",
                                      "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره فایل:\n{ex.Message}",
                               "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // متد کمکی برای پیدا کردن همه تکست‌باکس‌ها
        private void GetAllTextBoxes(Control parent, ExcelWorksheet ws, ref int row)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txt && !string.IsNullOrEmpty(txt.Text))
                {
                    ws.Cells[$"A{row}"].Value = txt.Name;
                    ws.Cells[$"B{row}"].Value = txt.Text;
                    row++;
                }

                if (control.HasChildren)
                {
                    GetAllTextBoxes(control, ws, ref row);
                }
            }
        }

        // دکمه خروج

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}