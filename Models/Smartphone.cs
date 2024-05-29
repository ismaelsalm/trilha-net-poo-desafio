namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

         // DONE: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; private set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }

        // DONE: Passar os parâmetros do construtor para as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public override string ToString()
        {
            return $"{GetType().Name} - Numero: {Numero}, Modelo: {Modelo}, IMEI: {IMEI}, Memoria: {Memoria}";
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}