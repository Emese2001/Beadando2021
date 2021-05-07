using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadandokod
{
    class Szamla
    { 
        
     /// <summary>
     /// A számla tulajdonosa
     /// </summary>
        public string tulajdonos { get; set; }

        /// <summary>
        /// A számla egyenlege
        /// </summary>
        public int egyenleg { get; set; }

        /// <summary>
        /// Függvény a számlák egyenlegének feltöltéséhez
        /// </summary>
        /// <param name="osszeg">Az az összeg amennyivel tövelni szeretnénk a számlán levő összeget </param>
        /// <returns>A feltöltés utáni egyenleg!</returns>
        public string Feltoltes(int osszeg)
        {
            egyenleg = egyenleg + osszeg;
            return $"{egyenleg}";
        }

        /// <summary>
        /// Utalás egyik számláról a másik számlára 
        /// </summary>
        /// <param name="osszeg">Az összeg melyet szeretnénk átutalni</param>
        /// <param name="masikSzamla">A számla amelyre utalni szeretnénk!</param>
        /// 
        public void Utalas(int osszeg, Szamla masikSzamla)
        {
            egyenleg = egyenleg - osszeg;
            masikSzamla.egyenleg = masikSzamla.egyenleg + osszeg;
        }

        /// <summary>
        ///  Függvény ami a számláról való pénzkivétel funkciónál használunk
        /// </summary>
        /// <param name="osszeg"> Az adott összeg értéke amelyet ki szeretnénk venni a számláról!</param>
        /// <returns>A pénzkivétel uténi számlaegyenleg!</returns>
        public string Kivetel(int osszeg)
        {
            egyenleg = egyenleg - osszeg;
            return $"{egyenleg}";
        }


        /// <summary>
        /// Az a Függvény melyet a tulajdonosváltáskor használunk
        /// </summary>
        /// <param name="ujTulaj">Az új tulajdonos</param>
        /// <returns> Az új tulajdonost adja vissza </returns>
        public string Tulajvaltas(string ujTulaj)
        {
            tulajdonos = ujTulaj;
            return $"{tulajdonos}";
        }
    }
}
