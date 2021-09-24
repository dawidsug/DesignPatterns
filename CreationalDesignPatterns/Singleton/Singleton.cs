namespace CreationalDesignPatterns.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        protected Singleton() {} //constructor is protected, so can't do in code the new instance of this class

        public static Singleton Instance()
        {
            return _instance ?? (_instance = new Singleton()); //if instance don't exist then it's create
        }
    }
}