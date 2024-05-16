using Core.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ. EĞER ALIRSA BAĞIMLI OLMAK ZORUNDA KALIR AMA CORE UN BAĞIMSIZ OLMASI GEREKİR ÇÜNKÜ BAŞKA YAZILIMIN İÇİNDE DE KULLANABİLMEM İÇİN ÖNEMLİ
namespace Core.DataAccess
{//generic constraint (kısıtlama)
 //class=>referans tip olmalı 
 //Referans tipi olmalı ve Ya IEntiy olabilir ya da IEntity tarafından implement edilen nesne olabilir
 //new(): newlenebilir olmalı (IEntityi olmasını istemedik diyelim) (İnterfaceler newlenemediği için)

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>>? predicate = null,
                              Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = true);//linq gibi filtreeler yazabilmemizi sağlyor //filtre vermesen de olur
        T? Get(Expression<Func<T, bool>> predicate,
               Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
               bool enableTracking = true);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
