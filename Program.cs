public class HaloGeneric
{
    // Method Generic SapaUser
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

public class DataGeneric<T>
{
    private T data;

    // Konstruktor
    public DataGeneric(T data)
    {
        this.data = data;
    }

    // Method PrintData
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // --- Output dari branch generic-method ---
        HaloGeneric halo = new HaloGeneric();
        // Input berupa nama panggilan praktikan (Poin 4.C)
        halo.SapaUser("Khalil");

        // --- Output dari branch generic-class ---
        // Input berupa NIM praktikan (Poin 6.C)
        DataGeneric<string> dataNIM = new DataGeneric<string>("103082400033");
        dataNIM.PrintData();
    }
}