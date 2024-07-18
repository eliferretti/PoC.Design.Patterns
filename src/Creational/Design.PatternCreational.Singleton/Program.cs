
using Design.PatternCreational.Singleton;

Singleton singleton1 = Singleton.Instance;
Singleton singleton2 = Singleton.Instance;

// Verifica se singleton1 e singleton2 são a mesma instância.
if (singleton1 == singleton2)
{
    Console.WriteLine("Both instances are the same.");
}

// Usa o método da instância do Singleton.
singleton1.DoSomething();  // Output: Singleton instance is doing something...