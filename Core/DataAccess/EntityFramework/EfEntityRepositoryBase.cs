using Core.Entities;
using Microsoft.EntityFrameworkCore;
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

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            //TEK DATA VERECEK BU METOT
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);


            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())//İlgili tüm veriyi getir ama filtre vermişse o filtreyi uygula 
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();// null ise ilk kısım değilse ikini kısım çalışır
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
