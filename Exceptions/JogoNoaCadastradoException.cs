using System;


namespace APICatalogoJogos1.Exceptions
{
    public class JogoNoaCadastradoException : Exception
    {
        public JogoNoaCadastradoException()
            : base("Este jogo não esta cadastrado")
        { }
    }
}
