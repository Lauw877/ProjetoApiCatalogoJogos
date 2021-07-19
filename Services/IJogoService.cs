using APICatalogoJogos1.InputModel;
using APICatalogoJogos1.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICatalogoJogos1.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
