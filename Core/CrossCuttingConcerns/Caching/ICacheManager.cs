﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);//sana ben bir key vereyim sen bana o key e krşılık olan datayı ver
        object Get(string key);//yukarıdakinin generic olmayan versiyonu
        void Add(string key, object value, int duration);
        bool IsAdd(string key);//cache de var mı?
        void Remove(string key);
        void RemoveByPattern(string pattern);//isminde ... olanları sil
    }
}
