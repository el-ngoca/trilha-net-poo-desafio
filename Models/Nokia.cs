namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($" Andoid {Modelo},instalando o aplicativo {nomeApp}, aguarde um instante...");
            
            Console.WriteLine($"O aplicativo {nomeApp} esta pronto para uso. :)"); 
        }
    }
}