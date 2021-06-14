using System.Data;

namespace cs_crud.Clases
{
    interface IntFunciones
    {
        int Registrar();
        bool Actualizar();
        bool Eliminar();
        DataTable Listar();
        DataTable BuscarPorCodigo(int id);
    }
}
