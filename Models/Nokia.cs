namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(
            string numero,
            string modelo,
            long iMEI,
            int memoria
               )
               : base(numero, modelo, iMEI, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Abrindo Play Store...");
            Thread.Sleep(300);
            Console.WriteLine($"Instalando aplicativo {nomeApp}");
        }
    }
}