namespace Common.Lab
{
    public class ChildClass : BaseClass
    {
        public new string MethodeReguliere()
        {
            return "ChildClass.MethodeReguliere";
        }

        public override string MethodeVirtual()
        {
            return "ChildClass.MethodeVirtual";
        }

        public override string ToString()
        {
            return "ChildClass.ToString()";
        }
    }
}
