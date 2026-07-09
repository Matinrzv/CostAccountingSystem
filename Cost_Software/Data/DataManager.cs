using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Software.Data
{
    public class DataManager
    {
        // ==================== هزینه‌های متغیر - قیفی ====================
        public static decimal GheifiArd { get; set; }
        public static decimal GheifiAB { get; set; }
        public static decimal GheifiVanil { get; set; }
        public static decimal GheifiNailon { get; set; }
        public static decimal GheifiKarton { get; set; }
        public static decimal GheifiSaier { get; set; }
        public static decimal GheifiSum { get; set; }

        // ==================== هزینه‌های متغیر - برشی ====================
        public static decimal BorshiArd { get; set; }
        public static decimal BorshiAb { get; set; }
        public static decimal BorshiVanil { get; set; }
        public static decimal BorshiNailon { get; set; }
        public static decimal BorshiKarton { get; set; }
        public static decimal BorshiSaier { get; set; }
        public static decimal BorshiSum { get; set; }

        // ==================== هزینه‌های متغیر - حصیری ====================
        public static decimal HasiriArd { get; set; }
        public static decimal HasiriAb { get; set; }
        public static decimal HasiriVanil { get; set; }
        public static decimal HasiriNailon { get; set; }
        public static decimal HasiriKarton { get; set; }
        public static decimal HasiriSaier { get; set; }
        public static decimal HasiriSum { get; set; }

        // ==================== نرخ آرد ====================
        public static decimal NerkhArd { get; set; }

        // ==================== وزن مصرف آرد ====================
        public static decimal GheifiVaznMasrafArd { get; set; }
        public static decimal BoreshiVaznMasrafArd { get; set; }
        public static decimal HasiriVaznMasrafArd { get; set; }

        // ==================== هزینه‌های متغیر - جمع کل (ردیف All) ====================
        public static decimal GheifiArdAll { get; set; }
        public static decimal GheifiAbAll { get; set; }
        public static decimal GheifiVanilAll { get; set; }
        public static decimal GheifiNailonAll { get; set; }
        public static decimal GheifiKartonAll { get; set; }
        public static decimal GheifiSaierAll { get; set; }

        public static decimal BorshiArdAll { get; set; }
        public static decimal BorshiAbAll { get; set; }
        public static decimal BorshiVanilAll { get; set; }
        public static decimal BorshiNailonAll { get; set; }
        public static decimal BorshiKartonAll { get; set; }
        public static decimal BorshiSaierAll { get; set; }

        public static decimal HasiriArdAll { get; set; }
        public static decimal HasiriAbAll { get; set; }
        public static decimal HasiriVanilAll { get; set; }
        public static decimal HasiriNailonAll { get; set; }
        public static decimal HasiriKartonAll { get; set; }
        public static decimal HasiriSaierAll { get; set; }

        public static decimal SumArd { get; set; }
        public static decimal SumAb { get; set; }
        public static decimal SumVanil { get; set; }
        public static decimal SumNailon { get; set; }
        public static decimal SumKarton { get; set; }
        public static decimal SumSaier { get; set; }

        // ==================== هزینه‌های ثابت ====================
        public static decimal Salary { get; set; }
        public static decimal Water { get; set; }
        public static decimal Elect { get; set; }
        public static decimal Gaz { get; set; }
        public static decimal FixedSum { get; set; }

        // ==================== فروش - قیفی ====================
        public static decimal GheifiGheymatForosh { get; set; }
        public static decimal GheifiTedadForosh { get; set; }
        public static decimal GheifiDarsadMasraf { get; set; }
        public static decimal GheifiDotSarBeSar { get; set; }
        public static decimal GheifiSahmHazineSabet { get; set; }
        public static decimal GheifiForoshVaghei { get; set; }
        public static decimal GheifiHazineMotaghaierKol { get; set; }
        public static decimal GheifiHashieNakhales { get; set; }
        public static decimal GheifiSodOrZian { get; set; }

        // ==================== فروش - برشی ====================
        public static decimal BoreshiGheymatForosh { get; set; }
        public static decimal BoreshiTedadForosh { get; set; }
        public static decimal BoreshiDarsadMasraf { get; set; }
        public static decimal BoreshiDotSarBeSar { get; set; }
        public static decimal BoreshiSahmHazineSabet { get; set; }
        public static decimal BoreshiForoshVaghei { get; set; }
        public static decimal BoreshiHazineMotaghayerKol { get; set; }
        public static decimal BoreshiHashieNakhales { get; set; }
        public static decimal BoreshiSodOrZian { get; set; }

        // ==================== فروش - حصیری ====================
        public static decimal HasiriGheymatForosh { get; set; }
        public static decimal HasiriTedadForosh { get; set; }
        public static decimal HasiriDarsadMasraf { get; set; }
        public static decimal HasiriDotSarBeSar { get; set; }
        public static decimal HasiriSahmHazineSabet { get; set; }
        public static decimal HasiriForoshVaghei { get; set; }
        public static decimal HasiriHazineMotaghayerKol { get; set; }
        public static decimal HasiriHashieNaKales { get; set; }
        public static decimal HasiriSodOrZian { get; set; }

        // ==================== فروش - جمع ====================
        public static decimal SumSodOrZian { get; set; }
        public static decimal SumHashieNakhales { get; set; }
        public static decimal SumHazineMotaghayerKol { get; set; }
        public static decimal SumForoshVaghei { get; set; }
        public static decimal SumSahmHazineSabet { get; set; }
        public static decimal SumDotSarBeSar { get; set; }

        // ==================== نقطه سر به سر - قیفی ====================
        public static decimal GheifiGheymat { get; set; }
        public static decimal GheifiHazineMotaghyerHarVahed { get; set; }
        public static decimal GheifiHashieHarVahed { get; set; }
        public static decimal GheifiDarsadMasrafArd { get; set; }
        public static decimal GheifiDotTedad { get; set; }
        public static decimal GheifiDotMablagh { get; set; }

        // ==================== نقطه سر به سر - برشی ====================
        public static decimal BoreshiGheymat { get; set; }
        public static decimal BoreshiHazineMotaghayerHarVahed { get; set; }
        public static decimal BoreshiHashieHarVahed { get; set; }
        public static decimal BoreshiDarsadMasrafArd { get; set; }
        public static decimal BoreshiDotTedad { get; set; }
        public static decimal BoreshiDotMablagh { get; set; }

        // ==================== نقطه سر به سر - حصیری ====================
        public static decimal HasiriGheymat { get; set; }
        public static decimal HasiriHazineMotaghayerHarVahed { get; set; }
        public static decimal HasiriHashieHarVahed { get; set; }
        public static decimal HasiriDarsadMasrafArd { get; set; }
        public static decimal HasiriDotTedad { get; set; }
        public static decimal HasiriDotMablagh { get; set; }

        // ==================== نقطه سر به سر - جمع ====================
        public static decimal ArdAll { get; set; }

        // ==================== جمع کل ====================
        public static decimal SumVariableAll { get; set; }
        public static decimal SumFixedAll { get; set; }
        public static decimal SumAll { get; set; }

        // ==================== متد دریافت همه مقادیر از فرم ====================
        public static void GetValuesFromForm(Form1 form)
        {
            // ---------- هزینه‌های متغیر - قیفی ----------
            GheifiArd = ToDecimal(form.txtGheifiArd.Text);
            GheifiAB = ToDecimal(form.txtGheifiAB.Text);
            GheifiVanil = ToDecimal(form.txtGheifiVanil.Text);
            GheifiNailon = ToDecimal(form.txtGheifiNailon.Text);
            GheifiKarton = ToDecimal(form.txtGheifiKarton.Text);
            GheifiSaier = ToDecimal(form.txtGheifiSaier.Text);
            GheifiSum = ToDecimal(form.txtGheifiSum.Text);

            // ---------- هزینه‌های متغیر - برشی ----------
            BorshiArd = ToDecimal(form.txtBorshiArd.Text);
            BorshiAb = ToDecimal(form.txtBorshiAb.Text);
            BorshiVanil = ToDecimal(form.txtBorshiVanil.Text);
            BorshiNailon = ToDecimal(form.txtBorshiNailon.Text);
            BorshiKarton = ToDecimal(form.txtBorshiKarton.Text);
            BorshiSaier = ToDecimal(form.txtBorshiSaier.Text);
            BorshiSum = ToDecimal(form.txtBorshiSum.Text);

            // ---------- هزینه‌های متغیر - حصیری ----------
            HasiriArd = ToDecimal(form.txtHasiriArd.Text);
            HasiriAb = ToDecimal(form.txtHasiriAb.Text);
            HasiriVanil = ToDecimal(form.txtHasiriVanil.Text);
            HasiriNailon = ToDecimal(form.txtHasiriNailon.Text);
            HasiriKarton = ToDecimal(form.txtHasiriKarton.Text);
            HasiriSaier = ToDecimal(form.txtHasiriSaier.Text);
            HasiriSum = ToDecimal(form.txtHasiriSum.Text);

            // ---------- نرخ آرد و وزن مصرف آرد ----------
            NerkhArd = ToDecimal(form.txtNerkheArd.Text);
            GheifiVaznMasrafArd = ToDecimal(form.txtGheifiVaznMasrafArd.Text);
            BoreshiVaznMasrafArd = ToDecimal(form.txtBoreshiVaznMasrafArd.Text);
            HasiriVaznMasrafArd = ToDecimal(form.txtHasiriVaznMasrafArd.Text);

            // ---------- هزینه‌های متغیر - جمع کل (All) ----------
            GheifiArdAll = ToDecimal(form.txtGheifiArdAll.Text);
            GheifiAbAll = ToDecimal(form.txtGheifiAbAll.Text);
            GheifiVanilAll = ToDecimal(form.txtGheifiVanilAll.Text);
            GheifiNailonAll = ToDecimal(form.txtGheifiNailonAll.Text);
            GheifiKartonAll = ToDecimal(form.txtGheifiKartonAll.Text);
            GheifiSaierAll = ToDecimal(form.txtGheifiSaierAll.Text);

            BorshiArdAll = ToDecimal(form.txtBorshiArdAll.Text);
            BorshiAbAll = ToDecimal(form.txtBorshiAbAll.Text);
            BorshiVanilAll = ToDecimal(form.txtBorshiVanilAll.Text);
            BorshiNailonAll = ToDecimal(form.txtBorshiNailonAll.Text);
            BorshiKartonAll = ToDecimal(form.txtBorshiKartonAll.Text);
            BorshiSaierAll = ToDecimal(form.txtBorshiSaierAll.Text);

            HasiriArdAll = ToDecimal(form.txtHasiriArdAll.Text);
            HasiriAbAll = ToDecimal(form.txtHasiriAbAll.Text);
            HasiriVanilAll = ToDecimal(form.txtHasiriVanilAll.Text);
            HasiriNailonAll = ToDecimal(form.txtHasiriNailonAll.Text);
            HasiriKartonAll = ToDecimal(form.txtHasiriKartonAll.Text);
            HasiriSaierAll = ToDecimal(form.txtHasiriSaierAll.Text);

            SumArd = ToDecimal(form.txtSumArd.Text);
            SumAb = ToDecimal(form.txtSumAb.Text);
            SumVanil = ToDecimal(form.txtSumVanil.Text);
            SumNailon = ToDecimal(form.txtSumNailon.Text);
            SumKarton = ToDecimal(form.txtSumKarton.Text);
            SumSaier = ToDecimal(form.txtSumSaier.Text);

            // ---------- هزینه‌های ثابت ----------
            Salary = ToDecimal(form.txtSalary.Text);
            Water = ToDecimal(form.txtWater.Text);
            Elect = ToDecimal(form.txtElect.Text);
            Gaz = ToDecimal(form.txtGaz.Text);
            FixedSum = ToDecimal(form.txtSum.Text);

            // ---------- فروش - قیفی ----------
            GheifiGheymatForosh = ToDecimal(form.txtGheifiGheymatForosh.Text);
            GheifiTedadForosh = ToDecimal(form.txtGheifiTedadForosh.Text);
            GheifiDarsadMasraf = ToDecimal(form.txtGheifiDarsadMasraf.Text);
            GheifiDotSarBeSar = ToDecimal(form.txtGheifiDotSarBeSar.Text);
            GheifiSahmHazineSabet = ToDecimal(form.txtGheifiSahmHazineSabet.Text);
            GheifiForoshVaghei = ToDecimal(form.txtGheifiForoshVaghei.Text);
            GheifiHazineMotaghaierKol = ToDecimal(form.txtGheifiHazineMotaghaierKol.Text);
            GheifiHashieNakhales = ToDecimal(form.txtGheifiHashieNakhales.Text);
            GheifiSodOrZian = ToDecimal(form.txtGheifiSodOrZian.Text);

            // ---------- فروش - برشی ----------
            BoreshiGheymatForosh = ToDecimal(form.txtBoreshiGheymatForosh.Text);
            BoreshiTedadForosh = ToDecimal(form.txtBoreshiTedadForosh.Text);
            BoreshiDarsadMasraf = ToDecimal(form.txtBoreshiDarsadMasraf.Text);
            BoreshiDotSarBeSar = ToDecimal(form.txtBoreshiDotSarBeSar.Text);
            BoreshiSahmHazineSabet = ToDecimal(form.txtBoreshiSahmHazineSabet.Text);
            BoreshiForoshVaghei = ToDecimal(form.txtBoreshiForoshVaghei.Text);
            BoreshiHazineMotaghayerKol = ToDecimal(form.txtBoreshiHazineMotaghayerKol.Text);
            BoreshiHashieNakhales = ToDecimal(form.txtBoreshiHashieNakhales.Text);
            BoreshiSodOrZian = ToDecimal(form.txtBoreshiSodOrZian.Text);

            // ---------- فروش - حصیری ----------
            HasiriGheymatForosh = ToDecimal(form.txtHasiriGheymatForosh.Text);
            HasiriTedadForosh = ToDecimal(form.txtHasiriTedadForosh.Text);
            HasiriDarsadMasraf = ToDecimal(form.txtHasiriDarsadMasraf.Text);
            HasiriDotSarBeSar = ToDecimal(form.txtHasiriDotSarBeSar.Text);
            HasiriSahmHazineSabet = ToDecimal(form.txtHasiriSahmHazineSabet.Text);
            HasiriForoshVaghei = ToDecimal(form.txtHasiriForoshVaghei.Text);
            HasiriHazineMotaghayerKol = ToDecimal(form.txtHasiriHazineMotaghayerKol.Text);
            HasiriHashieNaKales = ToDecimal(form.txtHasiriHashieNaKales.Text);
            HasiriSodOrZian = ToDecimal(form.txtHasiriSodOrZian.Text);

            // ---------- فروش - جمع ----------
            SumSodOrZian = ToDecimal(form.txtSumSodOrZian.Text);
            SumHashieNakhales = ToDecimal(form.txtSumHashieNakhales.Text);
            SumHazineMotaghayerKol = ToDecimal(form.txtSumHazineMotaghayerKol.Text);
            SumForoshVaghei = ToDecimal(form.txtSumForoshVaghei.Text);
            SumSahmHazineSabet = ToDecimal(form.txtSumSahmHazineSabet.Text);
            SumDotSarBeSar = ToDecimal(form.txtSumDotSarBeSar.Text);

            // ---------- نقطه سر به سر - قیفی ----------
            GheifiGheymat = ToDecimal(form.txtGheifiGheymat.Text);
            GheifiHazineMotaghyerHarVahed = ToDecimal(form.txtGheifiHazineMotaghyerHarVahed.Text);
            GheifiHashieHarVahed = ToDecimal(form.txtGheifiHashieHarVahed.Text);
            GheifiVaznMasrafArd = ToDecimal(form.txtGheifiVaznMasrafArd.Text);
            GheifiDarsadMasrafArd = ToDecimal(form.txtGheifiDarsadMasrafArd.Text);
            GheifiDotTedad = ToDecimal(form.txtGheifiDotTedad.Text);
            GheifiDotMablagh = ToDecimal(form.txtGheifiDotMablagh.Text);

            // ---------- نقطه سر به سر - برشی ----------
            BoreshiGheymat = ToDecimal(form.txtBoreshiGheymat.Text);
            BoreshiHazineMotaghayerHarVahed = ToDecimal(form.txtBoreshiHazineMotaghayerHarVahed.Text);
            BoreshiHashieHarVahed = ToDecimal(form.txtBoreshiHashieHarVahed.Text);
            BoreshiVaznMasrafArd = ToDecimal(form.txtBoreshiVaznMasrafArd.Text);
            BoreshiDarsadMasrafArd = ToDecimal(form.txtBoreshiDarsadMasrafArd.Text);
            BoreshiDotTedad = ToDecimal(form.txtBoreshiDotTedad.Text);
            BoreshiDotMablagh = ToDecimal(form.txtBoreshiDotMablagh.Text);

            // ---------- نقطه سر به سر - حصیری ----------
            HasiriGheymat = ToDecimal(form.txtHasiriGheymat.Text);
            HasiriHazineMotaghayerHarVahed = ToDecimal(form.txtHasiriHazineMotaghayerHarVahed.Text);
            HasiriHashieHarVahed = ToDecimal(form.txtHasiriHashieHarVahed.Text);
            HasiriVaznMasrafArd = ToDecimal(form.txtHasiriVaznMasrafArd.Text);
            HasiriDarsadMasrafArd = ToDecimal(form.txtHasiriDarsadMasrafArd.Text);
            HasiriDotTedad = ToDecimal(form.txtHasiriDotTedad.Text);
            HasiriDotMablagh = ToDecimal(form.txtHasiriDotMablagh.Text);

            // ---------- نقطه سر به سر - جمع ----------
            ArdAll = ToDecimal(form.txtArdAll.Text);

            // ---------- جمع کل ----------
            SumVariableAll = ToDecimal(form.txtSumVariableAll.Text);
            SumFixedAll = ToDecimal(form.txtSumFixedAll.Text);
            SumAll = ToDecimal(form.txtSumAll.Text);
        }

        // متد کمکی برای تبدیل به decimal
        private static decimal ToDecimal(string value)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            decimal result;
            if (decimal.TryParse(value, out result))
                return result;
            else
                return 0;
        }
    }
}