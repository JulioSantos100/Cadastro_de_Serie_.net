using System.Collections.Generic;
namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
      List<T> Lista();
      T RetornaPorId(int id);

      void Insere(T entidade);

      void Excluir (int id, T entidade);

      void Atualizar(int id, T entidade);

      int ProximoId();

    }
}