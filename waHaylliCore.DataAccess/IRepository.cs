using System.Collections.Generic;

namespace waHaylliCore.DataAccess
{
    public interface IRepository<TEntity> where TEntity : class
    {
        bool Insert ( TEntity entity );
        bool Update ( TEntity entity );
        bool DeleteById ( int id);
        TEntity SelectById(int id);
        List<TEntity> SelectAll();

    }
}
