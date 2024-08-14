using System.Reflection;

namespace Odev_6.Models
{
    public static class ZorunlulukKontrolu<T>
    {
        public static bool Dogrula(T dogrulanacakNesne)
        {
            Type dogrulanacakTur = typeof(T);
            FieldInfo[] dogrulanacakAlanlar = dogrulanacakTur.GetFields(BindingFlags.Instance | BindingFlags.Public);
            foreach (FieldInfo dogrulanacakAlan in dogrulanacakAlanlar)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakAlan.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = dogrulanacakAlan.GetValue(dogrulanacakNesne) as string;
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}
