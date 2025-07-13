namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string imei, int memory, string model) : base(number, imei, memory, model)
        {
            Number = number;
            IMEI = imei;
            Memory = memory;
            Model = model;
        }

        public override void InstallApp(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}.");
            Thread.Sleep(30);
            Console.WriteLine($"Instalando {nomeApp}..");
            Thread.Sleep(30);
            Console.WriteLine($"Instalando {nomeApp}...");
            Thread.Sleep(30);
            Console.WriteLine($"{nomeApp} foi instalado com sucesso no Nokia {this.Model}");
        }
    }
}