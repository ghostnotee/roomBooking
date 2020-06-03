using RoomBooking.Entites.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.DataAccess.Absract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()  //class olmalı, IEntity'den İmplemente edilmeli,new'lenebilmeli.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T,bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
