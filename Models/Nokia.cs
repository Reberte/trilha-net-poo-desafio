namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero) : base(numero)
        {
            Numero = numero;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Intalando o aplicativo:" + nomeApp);
        }

        public void Apresentar(string modelo, string imei, int memoria)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Console.WriteLine("--------------------");
            Console.WriteLine($"Marca: Nokia \n Número: {Numero} \n Modelo: {Modelo} \n Imei: {Imei} \n Memória: {Memoria}");
            Console.WriteLine("--------------------");
        }
    }
}