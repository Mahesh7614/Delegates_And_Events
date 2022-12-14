namespace Delegates_And_Events
{
    public class Program
    {
        public static event DelEventHandler Del;
        static void Main(string[] args)
        {
            Console.WriteLine("******************** Event Handling *****************************");
            EventHandling.ImplementEvent();

            Del += new DelEventHandler(EventProblem.India);
            Del += new DelEventHandler(EventProblem.USA);
            Del += new DelEventHandler(EventProblem.England);
            Del.Invoke();

            ArrayDelegates.ImplementDelegates();
        }
    }
}