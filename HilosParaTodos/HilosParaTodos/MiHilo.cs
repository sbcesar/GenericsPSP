namespace HilosParaTodos;

public class MiHilo
{
    private Thread hilo;
    private string text;
    private Wrapper<Action> terminar;
    
    public MiHilo(string text, Wrapper<Action> terminar)
    {
        this.text = text;
        this.terminar = terminar;
        hilo = new Thread(_process);
    }

    public void Start()
    {
        hilo.Start();
    }

    void _process()
    {
        for (int i = 0; i < 1000; i++) Console.Write (text);
        terminar.value?.Invoke();
        Console.WriteLine($"\nHa terminado: {text}");
    }
}
