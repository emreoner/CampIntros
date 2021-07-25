using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MevzuatBase mevzuatA = new MevzuatA();
            MevzuatManager mevzuatManager = new MevzuatManager();
            mevzuatManager.MevzuatIncele(mevzuatA);
        }
       
    }

    public abstract class MevzuatBase
    {
        public abstract void Degerlendir();
        public void Kaydet() {
            Console.WriteLine("Kaydedildi.....");
        }
    }

    public class MevzuatA : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("Mevzuat A degerlendirildi....");
        }
    }

    public class MevzuatB : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("Mevzuat B degerlendirildi....");
        }
    }

    public class MevzuatManager { 

        public void MevzuatIncele(MevzuatBase mevzuatBase)
        {
            ///
            mevzuatBase.Degerlendir();
            mevzuatBase.Kaydet();
        }
    
    }

}
