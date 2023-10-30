namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{Modelo},instalando o aplicativo {nomeApp}, aguarde um instante....");
            
            Console.WriteLine($"O aplicativo {nomeApp} esta pronto para uso. :)");
        }
    }
}