namespace Lecture_InheritancePolymorphismOverridingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDerived tb = new TestDerived();
            
            //BaseClass baseObj = new BaseClass();
            //BaseClass derivedObj = new BaseClass();

            DerivedClass derivedObj = new DerivedClass();
            var i = (derivedObj as BaseClass).BaseProp;


            //DerivedClass derivedObj = new DerivedClass();
            //if (derivedObj is BaseClass) {
            //    /* code */
            //}



        }
    }
}