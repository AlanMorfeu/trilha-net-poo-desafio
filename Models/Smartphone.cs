namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        public string Numero 
        { 
            get => _numero;
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("O número de celular não foi informado.");
                }

                _numero = value;
            } 
        }  
        //public string Numero { get; set; }      
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            Thread.Sleep(2000);
            Console.WriteLine("Alo mãe, estou estudando na Dio...");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Teste de ligação OK");
            Console.ResetColor();


        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            Thread.Sleep(2000);
            Console.WriteLine("Boa tarde estou entrando em contato para informar que você foi aprovado no processo seletivo da WEX, Parabéns!!...");
            Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Teste de receber ligação OK");
            Console.ResetColor();
        }

        public void ExibirDadosDoCelular()
        {
            Console.WriteLine($"Número {Numero} - Modelo {Modelo} - IMEI {IMEI} - Memoria {Memoria}");
            Console.WriteLine();
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}