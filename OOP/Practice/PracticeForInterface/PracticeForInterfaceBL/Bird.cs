namespace PracticeForInterfaceBL
{
    interface Iflyable
    {
        void fly();
    }
    interface Iswimmable
    {
        void swim();
    }
    public class Bird:Iflyable, Iswimmable
    {
        public void fly()
        {
            Console.WriteLine("Flying");
        }
        public void swim()
        {
            Console.WriteLine("Swimmming");
        }
    }
}
