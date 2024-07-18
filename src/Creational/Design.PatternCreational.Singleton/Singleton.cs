namespace Design.PatternCreational.Singleton
{
    public sealed class Singleton
    {
        // Campo estático para armazenar a única instância do Singleton.
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        // Construtor privado para impedir a criação de instâncias fora da classe.
        private Singleton()
        {
            // Inicialização de recursos, se necessário.
        }

        // Propriedade pública para acessar a instância do Singleton.
        public static Singleton Instance
        {
            get
            {
                return instance.Value;
            }
        }

        // Método público para demonstrar o uso do Singleton.
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something...");
        }
    }
}
