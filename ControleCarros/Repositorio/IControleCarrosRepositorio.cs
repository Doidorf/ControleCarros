using ControleCarros.Models;

namespace ControleCarros
{
    internal interface IControleCarrosRepositorio
    {
        CarroModel ListarPorId(int id);
        List<CarroModel> BucarTodos();
        CarroModel Adicionar(CarroModel carro);
        CarroModel Atualizar(CarroModel carro);
        bool Apagar(int id);
    }
}