namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {        
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (!string.IsNullOrWhiteSpace(nomeApp))
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia...");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Teste de instalação aplicativo OK");
                Console.ResetColor();
            }
            else
            {
                throw new Exception("Nome do aplicativo não foi informado");
            }
        }
    }
}