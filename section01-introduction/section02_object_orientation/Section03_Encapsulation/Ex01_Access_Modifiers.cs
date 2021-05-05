namespace Section03_Encapsulation
{
    public class Ex01_Access_Modifiers
    {
        /*
            The access modifiers are:
            
            Public => accessible from any class
            Protected => only its own class and any class that inherits from it
            Private => only its own class

            Note: C# does not have the Java default access modifier. If you omit the
            access modifier, the property will be private.
        */
        public static int Count = 0; // Public and static variable => accessed through class
        public const double PI = 3.14;
        protected string Type;
        private string Name;
    }
}