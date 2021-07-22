using System;

namespace HardverApro.NET
{
    internal class Endpoints
    {
        public static Uri Base => new ($"https://hardverapro.hu/");
        public static Uri Auth => new ($"muvelet/hozzaferes/belepes.php");
        public static Uri Products => new ($"aprok");
        public static Uri ProductsSearch => new ($"aprok/keres.php");
        public static Uri SellerSearch => new ($"muvelet/tag/listaz.php");
        public static Uri User => new ($"tag");
        public static Uri PrivateMessages => new ($"privatok/listaz.php");
        public static Uri Ratings => new ($"ertekelesek/index.html");
    }
}