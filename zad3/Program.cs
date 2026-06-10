using System;

namespace Zadanie3
{
    public class MagicWeaponImpl
    {
        public MagicWeaponImpl()
        {
        }

        public virtual void buyImp()
        {
            Console.WriteLine("MagicWeaponImpl: kupowanie broni");
        }

        public virtual void attackImp()
        {
            Console.WriteLine("MagicWeaponImpl: atakowanie bronia");
        }

        public virtual void sellImp()
        {
            Console.WriteLine("MagicWeaponImpl: sprzedawanie broni");
        }
    }

    public class FrostMagicWeaponImpl : MagicWeaponImpl
    {
        public FrostMagicWeaponImpl()
        {
        }

        public virtual void freezeImp()
        {
            Console.WriteLine("FrostMagicWeaponImpl: zamrazanie");
        }
    }

    public class LightningMagicWeaponImpl : MagicWeaponImpl
    {
        public LightningMagicWeaponImpl()
        {
        }

        public virtual void shockImp()
        {
            Console.WriteLine("LightningMagicWeaponImpl: porazenie pradem");
        }
    }

    public class FireMagicWeaponImpl : MagicWeaponImpl
    {
        public FireMagicWeaponImpl()
        {
        }

        public virtual void burnImp()
        {
            Console.WriteLine("FireMagicWeaponImpl: podpalanie");
        }
    }

    public class AstrtusWang : FrostMagicWeaponImpl
    {
        public AstrtusWang()
        {
        }

        public override void buyImp()
        {
            Console.WriteLine("AstrtusWang: kupiono AstrtusWang");
        }

        public override void sellImp()
        {
            Console.WriteLine("AstrtusWang: sprzedano AstrtusWang");
        }

        public override void freezeImp()
        {
            Console.WriteLine("AstrtusWang: AstrtusWang zamraza wroga!");
        }

        public override void attackImp()
        {
            Console.WriteLine("AstrtusWang: AstrtusWang atakuje!");
        }
    }

    public class ElectricShock : LightningMagicWeaponImpl
    {
        public ElectricShock()
        {
        }

        public override void sellImp()
        {
            Console.WriteLine("ElectricShock: sprzedano ElectricShock");
        }

        public override void attackImp()
        {
            Console.WriteLine("ElectricShock: ElectricShock atakuje!");
        }

        public override void shockImp()
        {
            Console.WriteLine("ElectricShock: ElectricShock poraza wroga pradem!");
        }

        public override void buyImp()
        {
            Console.WriteLine("ElectricShock: kupiono ElectricShock");
        }
    }

    public class NarArto : FireMagicWeaponImpl
    {
        public NarArto()
        {
        }

        public override void sellImp()
        {
            Console.WriteLine("NarArto: sprzedano NarArto");
        }

        public override void buyImp()
        {
            Console.WriteLine("NarArto: kupiono NarArto");
        }

        public override void attackImp()
        {
            Console.WriteLine("NarArto: NarArto atakuje!");
        }

        public override void burnImp()
        {
            Console.WriteLine("NarArto: NarArto podpala wroga!");
        }
    }

    public class MagicWeapon
    {
        protected MagicWeaponImpl imp;

        public MagicWeapon(MagicWeaponImpl imp)
        {
            this.imp = imp;
        }

        public virtual MagicWeaponImpl getImp()
        {
            return imp;
        }

        public virtual void attack()
        {
            imp.attackImp();
        }

        public virtual void sell()
        {
            imp.sellImp();
        }

        public virtual void buy()
        {
            imp.buyImp();
        }
    }

    public class LightningMagicWeapon : MagicWeapon
    {
        public LightningMagicWeapon(LightningMagicWeaponImpl imp) : base(imp)
        {
        }

        public new LightningMagicWeaponImpl getImp()
        {
            return (LightningMagicWeaponImpl)imp;
        }

        public override void sell()
        {
            getImp().sellImp();
        }

        public void shock()
        {
            getImp().shockImp();
        }

        public override void buy()
        {
            getImp().buyImp();
        }

        public override void attack()
        {
            getImp().attackImp();
        }
    }

    public class FrostMagicWeapon : MagicWeapon
    {
        public FrostMagicWeapon(FrostMagicWeaponImpl imp) : base(imp)
        {
        }

        public new FrostMagicWeaponImpl getImp()
        {
            return (FrostMagicWeaponImpl)imp;
        }

        public override void buy()
        {
            getImp().buyImp();
        }

        public override void attack()
        {
            getImp().attackImp();
        }

        public void freeze()
        {
            getImp().freezeImp();
        }

        public override void sell()
        {
            getImp().sellImp();
        }
    }

    public class FireMagicWeapon : MagicWeapon
    {
        public FireMagicWeapon(FireMagicWeaponImpl imp) : base(imp)
        {
        }

        public override void buy()
        {
            getImp().buyImp();
        }

        public void burn()
        {
            getImp().burnImp();
        }

        public new FireMagicWeaponImpl getImp()
        {
            return (FireMagicWeaponImpl)imp;
        }

        public override void attack()
        {
            getImp().attackImp();
        }

        public override void sell()
        {
            getImp().sellImp();
        }
    }


    public class App
    {
        public App()
        {
        }

        public static void Main(string[] args)
        {

            ElectricShock electricShock = new ElectricShock();
            LightningMagicWeapon lightningWeapon = new LightningMagicWeapon(electricShock);
            lightningWeapon.buy();
            lightningWeapon.attack();
            lightningWeapon.shock();
            lightningWeapon.sell();

            Console.WriteLine();
            AstrtusWang astrtusWang = new AstrtusWang();
            FrostMagicWeapon frostWeapon = new FrostMagicWeapon(astrtusWang);
            frostWeapon.buy();
            frostWeapon.attack();
            frostWeapon.freeze();
            frostWeapon.sell();

            Console.WriteLine();
            NarArto narArto = new NarArto();
            FireMagicWeapon fireWeapon = new FireMagicWeapon(narArto);
            fireWeapon.buy();
            fireWeapon.attack();
            fireWeapon.burn();
            fireWeapon.sell();
        }
    }
}