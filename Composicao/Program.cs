


public class Casa //Casa contém referências às classes Telhado e Alicerce expressando o relacionamento de Composição entre a classe Casa e as classes Telhado e Alicerce
{
    private readonly Telhado _telhado;
    private readonly Alicerce _alicerce;

    public Casa()
    {
        _telhado = new Telhado();
        _alicerce = new Alicerce();
    }
}

public class Telhado{}

public class Alicerce{}