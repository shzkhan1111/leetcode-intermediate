//using Model2;

//namespace ClassLibrary2
//{
//    public class ExternalDerivedClass : BaseClass
//    {
//        protected override void MyMethod()
//        {
//            base.MyMethod();
//        }
//        public void UseMethod()
//        {
//            MyMethod(); // Works: Inherited, accessible via protected
//        }
//        //can I override my method and call it inside UnrelatedClass
//    }
//    public class UnrelatedClass
//    {
//        public void TryAccess()
//        {
//            ExternalDerivedClass baseObj = new ExternalDerivedClass();
//            baseObj.MyMethod();
//            // baseObj.MyMethod(); // Error: Cannot access in different assembly (not derived)
//            //can I override the method UseMethod and call it here
//        }
//    }
//}
