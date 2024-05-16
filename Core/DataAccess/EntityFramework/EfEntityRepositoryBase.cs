using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of C#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);//git ve veri kaynağında benim gönderdiğim nesneyi eşleştir. (context. diye göstermemizin nedeni referansına ulaşabilmek için) //YANİ REFERANSI YAKALA
                                                        //ama bu ekleme olacağı için hiçbir şeyle eşeleştiremeyecek.
                addedEntity.State = EntityState.Added; //veri tabanına eklemek için //ASLINDA O EKLENECEK BİR NESNE
                context.SaveChanges();//VE ŞİMDİ EKLE //buradki işlemleri pıt pıt yapar =)

            }
        }

        public void Delete(TEntity entity)
        {
            //IDisposable pattern implementation of C#
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate,
              Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
              bool enableTracking = true)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> queryable = context.Set<TEntity>();
                if (!enableTracking) queryable.AsNoTracking();
                if (include is not null) queryable = include(queryable);
                return queryable.SingleOrDefault(predicate);
            }
        }
        // => c.productid = productid
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null,
                              Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = true)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> queryable = context.Set<TEntity>();
                if (!enableTracking) queryable.AsNoTracking();
                if (include is not null) queryable = include(queryable);
                return queryable.ToList();
            }
        }

        public void Update(TEntity entity)
        {
            //IDisposable pattern implementation of C#
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
