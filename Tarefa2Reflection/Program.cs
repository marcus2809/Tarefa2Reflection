var reflection = new Reflection<Pessoa>();

reflection.Detalhar(new Pessoa());
var novaPessoa = reflection.Instanciar(new Pessoa());
Console.WriteLine(novaPessoa.GetType());

class Reflection<T>
{
    public void Detalhar(T obj)
    {
        var type = obj.GetType();

        var props = type.GetProperties();
        var methods = type.GetMethods();

        Console.WriteLine("Propriedades");
        foreach (var prop in props)
        {
            Console.WriteLine(prop);
        }

        Console.WriteLine("Métodos");
        foreach (var method in methods)
        {
            Console.WriteLine(method);
        }
    }

    public T Instanciar(T obj)
    {
        var novoObj = Activator.CreateInstance<T>();
        return novoObj;
    }
}

class Pessoa
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Pessoa()
    {

    }

    public bool ValidarPessoa()
    {
        return true;
    }
}