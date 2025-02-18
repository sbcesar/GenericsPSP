using HilosParaTodos;
using EventHandler = System.EventHandler;

class Program
{
    static void Main()
    {
        // Creamos un Wrapper<Action> con una función vacía para evitar errores de referencia nula
        Wrapper<Action> finalEventWrapper = new Wrapper<Action>(() => { });

        // Creamos los hilos con la referencia al wrapper
        MiHilo t1 = new MiHilo("x", finalEventWrapper);
        MiHilo t2 = new MiHilo("y", finalEventWrapper);

        // Agregamos eventos a la acción dentro del wrapper
        finalEventWrapper.value += () => { Console.WriteLine("Suscriptor C"); };

        t1.Start();
        t2.Start();
    }
}
