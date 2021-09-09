using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneMarket
{
    public class PhoneData
    {
        public static List<PhoneInfo> Phones = new List<PhoneInfo>();

        public static void GenerateList()
        {
            Phones.Add(new PhoneInfo("Huawei", "P30", "6.47\" FHD + (2340x1080) OLED,\n Kirin 980 Octa - Core(2x Cortex - A76 2.6GHz + 2x Cortex - A76 1.92GHz + 4x Cortex - A55 1.8GHz),\n 8GB RAM, 128GB ROM, 40 + 20 + 8 + TOF / 32MP,\n Dual SIM,\n 4200mAh,\n Android 9.0 + EMUI 9.1", 697));
            Phones.Add(new PhoneInfo("Samsung", "Galaxy A52", "64 megapixel camera,\n 4k videokwaliteit6.5 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP67)", 399));
            Phones.Add(new PhoneInfo("Apple", "Iphone11", "Met de dubbele camera schiet je in elke situatie een perfecte foto of videoDe krachtige A13-chipset zorgt voor razendsnelle prestatiesMet Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelenHet toestel heeft een lange accuduur dankzij een energiezuinige processor", 619));
            Phones.Add(new PhoneInfo("Google", "Pixel 4a", "12.2 megapixel camera, 4k videokwaliteit5.81 inch OLED scherm128 GB opslaggeheugen 3140 mAh accucapaciteit", 411));
            Phones.Add(new PhoneInfo("Xiaomi", "Redmi Note 10 Pro", "108 megapixel camera, 4k videokwaliteit6.67 inch AMOLED scherm128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)Water-en stofbestendig (IP53)", 298));
        }
        public struct PhoneInfo
        {
            public string TMerk;
            public string TType;
            public string TDescription;
            public double TPrice;

            public PhoneInfo(string TMerk, string TType, string TDescription, double TPrice)
            {
                this.TMerk = TMerk;
                this.TType = TType;
                this.TDescription = TDescription;
                this.TPrice = TPrice;
            }
        }
    }
}
