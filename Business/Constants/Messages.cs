using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public class Messages
    {
        public static string CarAdded = "Ürün eklendi.";
        public static string CarDeleted = "Ürün eklendi.";
        public static string CarUpdated = "Ürün güncellendi.";
        public static string CarNameInvalid = "Ürün eklendi.";
        public static string MaintenanceTime = "Bakım var";
        public static string CarListed = "Ürün listelendi.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "MarkaÜrün eklendi.";
        public static string BrandUpdated = "Marka eklendi.";
        public static string BrandListed = "Marka eklendi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk eklendi.";
        public static string ColorUpdated = "Renk eklendi.";
        public static string ColorListed = "Renk eklendi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri eklendi.";
        public static string CustomerListed = "Müşteri eklendi.";

        public static string RentalAdded = "Kiralama eklendi.";
        public static string RentalDeleted = "Kiralama eklendi.";
        public static string RentalUpdated = "Kiralama eklendi.";
        public static string RentalListed = "Kiralama eklendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı eklendi.";
        public static string UserListed = "Kullanıcı eklendi.";
        public static string DeletedCarImage;
        public static string UpdatedCarImage;
        public static string FailedCarImageAdd;
        public static string AddedCarImage;
        public static string CarImagesLimitExceded;
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }                        
}
