namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        public string IMEI { get; set; }
        public int Memory { get; set; }
        public string Model { get; set; }

        public Smartphone(string number, string imei, int memory, string model)
        {
            Number = number;
            IMEI = imei;
            Memory = memory;
            Model = model;
        }

        public void Call()
        {
            Console.WriteLine("Ligando.");
            Thread.Sleep(30);
            Console.WriteLine("Ligando..");
            Thread.Sleep(30);
            Console.WriteLine("Ligando...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Recebendo ligação.");
            Thread.Sleep(30);
            Console.WriteLine("Recebendo ligação..");
            Thread.Sleep(30);
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstallApp(string nameApp);
    }
}