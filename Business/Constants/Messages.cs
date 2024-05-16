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

        public static string CategoryAdded="Yeni kategori eklendi.";
        public static string CategoryDeleted = "Kategori silindi!";
        public static string CategoryUpdated="Kategori güncellendi.";

        public static string CourierAdded= "Kurye eklendi.";
        public static string CourierDeleted="Kurye silindi!";
        public static string CourierUpdated="Kurye bilgileri güncellendi.";

        public static string CustomerAdded="Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi!";
        public static string CustomerUpdated="Müşteri bilgileri güncellendi.";

        public static string OperationClaimAdded="Operation Claim eklendi.";
        public static string OperationClaimUpdated="Operation Claim güncellendi.";
        public static string OperationClaimDeleted="Operation Claim silindi.";

        public static string OrderDetailAdded="Sipariş detayları eklendi.";
        public static string OrderDetailUpdated="Sipariş detayı güncellendi.";
        public static string OrderDetailDeleted="Sipariş detayı silindi!";

        public static string OrderAdded="Sipariş eklendi.";
        public static string OrderDeleted="Sipariş güncellendi.";
        public static string OrderUpdated="Sipariş silindi!";

        public static string ReceiptDetailAdded="Reçete detayı eklendi.";
        public static string ReceiptDetailUpdated="Reçete detayı güncellendi.";
        public static string ReceiptDetailDeleted="Reçete detayı silindi!";

        public static string ReceiptAdded="Reçete eklendi.";
        public static string ReceiptUpdated="Reçete güncellendi.";
        public static string ReceiptDeleted="Reçete silindi!";

        internal static string SellerAdded="Satıcı eklendi.";
        internal static string SellerUpdated="Satıcı güncellendi.";
        internal static string SellerDeleted="Satıcı silindi!";

        internal static string StatusAdded="Yeni durum eklendi.";
        internal static string StatusUpdated="Durum güncellendi.";
        internal static string StatusDeleted="Durum silindi!";

        internal static string UserAdded="Kullanıcı eklendi.";
        internal static string UserUpdated="Kullanıcı bilgileri güncellendi.";
        internal static string UserDeleted="Kullanıcı silindi!";

        internal static string UserOperationClaimAdded="User operation claim eklendi.";
        internal static string UserOperationClaimUpdated="User operation claim güncellendi.";
        internal static string UserOperationClaimDeleted="User operation claim silindi!";
    }
}
