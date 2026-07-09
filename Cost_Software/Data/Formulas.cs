using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Software.Data
{
    public class Formulas
    {
        // ========== هزینه آرد ==========

        // هزینه آرد قیفی
        public static decimal Ard_Gheifi()
        {
            return DataManager.NerkhArd * DataManager.GheifiVaznMasrafArd;
        }

        // هزینه آرد برشی
        public static decimal Ard_Boreshi()
        {
            return DataManager.NerkhArd * DataManager.BoreshiVaznMasrafArd;
        }

        // هزینه آرد حصیری
        public static decimal Ard_Hasiri()
        {
            return DataManager.NerkhArd * DataManager.HasiriVaznMasrafArd;
        }

        // ========== هزینه متغیر ==========

        // جمع هزینه متغیر قیفی
        public static decimal GheifiVariableTotal()
        {
            return Ard_Gheifi() + DataManager.GheifiAB + DataManager.GheifiVanil +
                   DataManager.GheifiNailon + DataManager.GheifiKarton + DataManager.GheifiSaier;
        }

        // جمع هزینه متغیر برشی
        public static decimal BorshiVariableTotal()
        {
            return Ard_Boreshi() + DataManager.BorshiAb + DataManager.BorshiVanil +
                   DataManager.BorshiNailon + DataManager.BorshiKarton + DataManager.BorshiSaier;
        }

        // جمع هزینه متغیر حصیری
        public static decimal HasiriVariableTotal()
        {
            return Ard_Hasiri() + DataManager.HasiriAb + DataManager.HasiriVanil +
                   DataManager.HasiriNailon + DataManager.HasiriKarton + DataManager.HasiriSaier;
        }

        // جمع کل هزینه متغیر
        public static decimal TotalVariableCost()
        {
            return SumArdAll() + SumABAll() + SumVanilAll() + SumNailonAll() + SumKartonAll() + SumSaierAll();
        }

        // ========== هزینه ثابت ==========

        // جمع هزینه ثابت
        public static decimal TotalFixedCost()
        {
            return DataManager.Salary + DataManager.Water + DataManager.Elect + DataManager.Gaz;
        }

        // ========== جمع کل ==========

        // جمع کل هزینه‌ها
        public static decimal TotalCost()
        {
            return TotalVariableCost() + TotalFixedCost();
        }

        // ========== فروش ==========
        public static decimal GheifiSingleProductBEP()
        {
            decimal margin = DataManager.GheifiGheymatForosh - DataManager.GheifiSum;
            if (margin > 0)
            {
                decimal Javab = ((DataManager.FixedSum * DataManager.GheifiDarsadMasrafArd) / (DataManager.GheifiGheymatForosh - DataManager.GheifiSum)) / 100;
                return Javab;
            }
            else { return 0; }
        }
        public static decimal BoreshiSingleProductBEP()
        {
            decimal margin = DataManager.BoreshiGheymatForosh - DataManager.BorshiSum;
            if (margin > 0)
            {
                decimal Javab = ((DataManager.FixedSum * DataManager.BoreshiDarsadMasrafArd) / (DataManager.BoreshiGheymatForosh - DataManager.BorshiSum)) / 100;
                return Javab;
            }
            else { return 0; }
        }
        public static decimal HasiriSingleProductBEP()
        {
            decimal margin = DataManager.HasiriGheymatForosh - DataManager.HasiriSum;
            if (margin > 0)
            {
                decimal Javab = ((DataManager.FixedSum * DataManager.HasiriDarsadMasrafArd) / (DataManager.HasiriGheymatForosh - DataManager.HasiriSum)) / 100;
                return Javab;
            }
            else { return 0; }
        }
        public static decimal SumSingleProductBEP()
        {
            return HasiriSingleProductBEP() + BoreshiSingleProductBEP() + GheifiSingleProductBEP();
        }
        public static decimal GheifiSahmHazineSabet()
        {
            return DataManager.FixedSum * DataManager.GheifiDarsadMasraf;
        }
        public static decimal BoreshiSahmHazineSabet()
        {
            return DataManager.FixedSum * DataManager.BoreshiDarsadMasraf;
        }
        public static decimal HasiriSahmHazineSabet()
        {
            return DataManager.FixedSum * DataManager.HasiriDarsadMasraf;
        }
        public static decimal SumSahmHazineSabet()
        {
            return HasiriSahmHazineSabet() + BoreshiSahmHazineSabet() + GheifiSahmHazineSabet();
        }
        // فروش واقعی قیفی
        public static decimal GheifiSales()
        {
            return DataManager.GheifiGheymatForosh * DataManager.GheifiTedadForosh;
        }

        // فروش واقعی برشی
        public static decimal BorshiSales()
        {
            return DataManager.BoreshiGheymatForosh * DataManager.BoreshiTedadForosh;
        }

        // فروش واقعی حصیری
        public static decimal HasiriSales()
        {
            return DataManager.HasiriGheymatForosh * DataManager.HasiriTedadForosh;
        }

        // جمع کل فروش
        public static decimal TotalSales()
        {
            return GheifiSales() + BorshiSales() + HasiriSales();
        }
        public static decimal GheifiHazineMotaghayreKol()
        {
            return DataManager.GheifiSum * DataManager.GheifiTedadForosh;
        }
        public static decimal BoreshiHazineMotaghayreKol()
        {
            return DataManager.BorshiSum * DataManager.BoreshiTedadForosh;
        }
        public static decimal HasiriHazineMotaghayreKol()
        {
            return DataManager.HasiriSum * DataManager.HasiriTedadForosh;
        }
        public static decimal SumHazineMotaghayreKol()
        {
            return GheifiHazineMotaghayreKol() + BoreshiHazineMotaghayreKol() + HasiriHazineMotaghayreKol();
        }
        public static decimal GheifiHashieNakhales()
        {
            return DataManager.GheifiForoshVaghei - DataManager.GheifiHazineMotaghaierKol;
        }
        public static decimal BoreshiHashieNakhales()
        {
            return DataManager.BoreshiForoshVaghei - DataManager.BoreshiHazineMotaghayerKol;
        }
        public static decimal HasiriHashieNakhales()
        {
            return DataManager.HasiriForoshVaghei - DataManager.HasiriHazineMotaghayerKol;
        }
        public static decimal SumHashieNakhales()
        {
            return HasiriHashieNakhales() + BoreshiHashieNakhales() + GheifiHashieNakhales();
        }
        public static decimal GheifiSodOrZian()
        {
            return DataManager.GheifiHashieNakhales - DataManager.GheifiSahmHazineSabet;
        }
        public static decimal BoreshiSodOrZian()
        {
            return DataManager.BoreshiHashieNakhales - DataManager.BoreshiSahmHazineSabet;
        }
        public static decimal HasiriSodOrZian()
        {
            return DataManager.HasiriHashieNaKales - DataManager.HasiriHashieNaKales;
        }
        public static decimal SumSodOrZian()
        {
            return HasiriSodOrZian() + BoreshiSodOrZian() + GheifiSodOrZian();
        }
        public static decimal GheifiGheymatForosh()
        {
            return DataManager.GheifiGheymatForosh;
        }
        public static decimal BoreshiGheymatForosh()
        {
            return DataManager.BoreshiGheymatForosh;
        }
        public static decimal HasiriGheymatForosh()
        {
            return DataManager.HasiriGheymatForosh;
        }
        public static decimal GheifiHashieHarVahed()
        {
            return DataManager.GheifiGheymatForosh - DataManager.GheifiHazineMotaghyerHarVahed;
        }
        public static decimal BoreshiHashieHarVahed()
        {
            return DataManager.BoreshiGheymatForosh - DataManager.BoreshiHazineMotaghayerHarVahed;
        }
        public static decimal HasiriHashieHarVahed()
        {
            return DataManager.HasiriGheymatForosh - DataManager.HasiriHazineMotaghayerHarVahed;
        }
        public static decimal GheifiVaznMasrafiArd()
        {
            return 40m / 14m;
        }
        public static decimal BoreshiVaznMasrafiArd()
        {
            return 40m / 7m;
        }
        public static decimal HasiriVaznMasrafiArd()
        {
            return 40m / 37m;
        }
        public static decimal GheifiDarsadMasrafiArd()
        {
            decimal Kol = GheifiVaznMasrafiArd()+ BoreshiVaznMasrafiArd()+HasiriVaznMasrafiArd();
            return (GheifiVaznMasrafiArd() / Kol)*100 ;
        }
        public static decimal BoreshiDarsadMasrafiArd()
        {
            decimal Kol = GheifiVaznMasrafiArd() + BoreshiVaznMasrafiArd() + HasiriVaznMasrafiArd();
            return (BoreshiVaznMasrafiArd() / Kol) * 100;
        }
        public static decimal HasiriDarsadMasrafiArd()
        {
            decimal Kol = GheifiVaznMasrafiArd() + BoreshiVaznMasrafiArd() + HasiriVaznMasrafiArd();
            return (HasiriVaznMasrafiArd() / Kol) * 100;
        }
        public static decimal GheifiDotMablagh()
        {
            return DataManager.GheifiGheymatForosh * DataManager.GheifiDotTedad;
        }
        public static decimal BoreshiDotMablagh()
        {
            return DataManager.BoreshiGheymatForosh * DataManager.BoreshiDotTedad;
        }
        public static decimal HasiriDotMablagh()
        {
            return DataManager.HasiriGheymatForosh * DataManager.HasiriDotTedad;
        }
        public static decimal GheifiArdAll()
        {
            return DataManager.GheifiArd * DataManager.GheifiTedadForosh;
        }
        public static decimal BoreshiArdAll()
        {
            return DataManager.BorshiArd * DataManager.BoreshiTedadForosh;
        }
        public static decimal HasiriArdAll()
        {
            return DataManager.HasiriArd * DataManager.HasiriTedadForosh;
        }
        public static decimal SumArdAll()
        {
            return HasiriArdAll() + BoreshiArdAll() + GheifiArdAll();
        }
        public static decimal GheifiABAll()
        {
            return DataManager.GheifiAB * DataManager.GheifiTedadForosh;
        }
        public static decimal BoreshiABAll()
        {
            return DataManager.BorshiAb * DataManager.BoreshiTedadForosh;
        }
        public static decimal HasiriABAll()
        {
            return DataManager.HasiriAb * DataManager.HasiriTedadForosh;
        }
        public static decimal SumABAll()
        {
            return HasiriABAll() + BoreshiABAll() + GheifiABAll();
        }
        public static decimal GheifiVanilAll()
        {
            return DataManager.GheifiVanil * DataManager.GheifiTedadForosh;
        }
        public static decimal BoreshiVanilAll()
        {
            return DataManager.BorshiVanil * DataManager.BoreshiTedadForosh;
        }
        public static decimal HasiriVanilAll()
        {
            return DataManager.HasiriVanil * DataManager.HasiriTedadForosh;
        }
        public static decimal SumVanilAll()
        {
            return HasiriVanilAll() + BoreshiVanilAll() + GheifiVanilAll();
        }
        public static decimal GheifiKartonAll()
        {
            return DataManager.GheifiKarton * DataManager.GheifiTedadForosh;
        }
        public static decimal BoreshiKartonAll()
        {
            return DataManager.BorshiKarton * DataManager.BoreshiTedadForosh;
        }
        public static decimal HasiriKartonAll()
        {
            return DataManager.HasiriKarton * DataManager.HasiriTedadForosh;
        }
        public static decimal SumKartonAll()
        {
            return HasiriKartonAll() + BoreshiKartonAll() + GheifiKartonAll();
        }
        public static decimal GheifiNailonAll()
        {
            return DataManager.GheifiNailon * DataManager.GheifiTedadForosh;
        }
        public static decimal BoreshiNailonAll()
        {
            return DataManager.BorshiNailon * DataManager.BoreshiTedadForosh;
        }
        public static decimal HasiriNailonAll()
        {
            return DataManager.HasiriNailon * DataManager.HasiriTedadForosh;
        }
        public static decimal SumNailonAll()
        {
            return HasiriNailonAll() + BoreshiNailonAll() + GheifiNailonAll();
        }
        public static decimal GheifiSaierAll()
        {
            return DataManager.GheifiSaier * DataManager.GheifiTedadForosh;
        }
        public static decimal BoreshiSaierAll()
        {
            return DataManager.BorshiSaier * DataManager.BoreshiTedadForosh;
        }
        public static decimal HasiriSaierAll()
        {
            return DataManager.HasiriSaier * DataManager.HasiriTedadForosh;
        }
        public static decimal SumSaierAll()
        {
            return HasiriSaierAll() + BoreshiSaierAll() + GheifiSaierAll();
        }
        public static decimal VazneArdKol()
        {
            decimal Kol = GheifiVaznMasrafiArd() + BoreshiVaznMasrafiArd() + HasiriVaznMasrafiArd();
            return Kol;
        }
    }
}