namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var unibank = new Unibank("Faska", "Bahramov", 416973854 , 221 ,0.0m);
            unibank.Deposit(1000);
            unibank.withDraw(100);

            var accesbank = new AccessBank("Faska", "Bahramov", 416973854, 221, 0.0m);
            accesbank.Deposit(1000);
            accesbank.withDraw(100); 

            var pashabank = new PashaBank("Faska", "Bahramov", 416973854, 221, 0.0m);
            pashabank.Deposit(1000);
            pashabank.withDraw(100);

            var leobank = new LeoBank("Faska", "Bahramov", 416973854, 221, 0.0m);
            leobank.Deposit(1000);
            leobank.withDraw(100);




        }
    }
}