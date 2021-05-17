namespace Projeto_N2_POO.Interfaces
{
    interface IVeiculoMarinho
    {
        bool VeiculoEstaNoMar { get; }
        string Atracar();
        string Navegar();
    }
}
