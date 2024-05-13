using Core.Entities.Concrete;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //###############Farklı dilde sayfalar içinde bunun implemantion ının oluşturabilirsin
    //Constants: Sabit demek. Proje sabitlerini bunun içine koyacağız. (AMA NORTHWINDE ÖZEL) yANİ O PROJEYE ÖZEL 
    public static class Messages //STATIC: Sürekli newlemek istemediğimiz de (çünkü bu basit bir mesaj, bir mesaj yazıcaksam onu iki saat newlemeyeyim diye)
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime="Sistem bakımda!";
        public static string ProductsListed="Ürünler listelendi.";
        public static string ProductDeleted="Ürün başarıyla silindi.";
        public static string ProductDeletionFailed="Ürün silme başarısız!";
        public static string ProductUpdateFailed="Ürün güncelleme başarısız!";
        public static string ProductUpdated="Ürün güncellendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün mevcut.";
        public static string CategoryLimitExceded = "En fazla 15 tane kategori ekleyebilirsin.";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered="Kayıt başarıyla oluşturuldu.";
        public static string UserNotFound="Kullanıcı bulunamadı!";
        public static string PasswordError="Hatalı parola!";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
