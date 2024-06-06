namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
       
        public Iphone(string numero) : base(numero)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Intalando o aplicativo:" + nomeApp);
        }

        // Implementando o metodo sobreescrevendo o metodo da classe Smartfone
        public void Apresentar(string modelo, string imei, int memoria)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Console.WriteLine("--------------------");
            Console.WriteLine($"Marca: Apple \n Número: {Numero} \n Modelo: {Modelo} \n Imei: {Imei} \n Memória: {Memoria}");
            Console.WriteLine("--------------------");
        }
    }
}