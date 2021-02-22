using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi!";
        public static string CarNameInvalid = "Araç adı geçersiz!";
        public static string MaintenanceTime= "Sistem Bakımda!!!";
        public static string CarsListed= "Araçlar listelendi!";
        public static string CarUpdate = "Araç güncellendi!";
        public static string CarDeleted = "Araç silindi!";
        public static string CarPrice= "Aracın günlük fiyatı 0'dan büyük olmalıdır!";
        

        public static string BrandsListed = "Markalar listelendi!";
        public static string BrandAdded = "Marka eklendi!";
        public static string BrandNameInvalid = "Lütfen markayı en az 3 karakter olarak girin!";
        public static string BrandUpdate = "Marka güncellendi!";
        public static string BrandDeleted = "Marka silindi!";
        
        public static string ColorAdded = "Renk tonu eklendi!";
        public static string ColorUpdated = "Renk tonu güncellendi!";
        public static string ColorDeleted = "Renk tonu silindi";
        public static string ColorNameInvalid = "Lütfen rengi en az 3 karakter olarak girin!";
        public static string ColorsListed = "Renk tonları listelendi!";

        public static string UserAdded = "Yeni kullınıcı kaydı eklendi!";
        public static string UserUpdated = "Kullanıcı kaydı güncellendi!";
        public static string UserDeleted = "Kullanıcı kaydı silindi";
        public static string UsersListed = "Kullanıcılar listelendi!";

        public static string CustomerAdded = "Yeni müşteri kaydı eklendi!";
        public static string CustomerUpdated = "Müşteri kaydı güncellendi!";
        public static string CustomerDeleted = "Müşteri kaydı silindi";
        public static string CustomersListed = "Müşteriler listelendi!";

        public static string RentalAdded = "Kiralama işlemi başarılı!";
        public static string RentalAddedError = "Araç henüz bırakılmadı!";
        public static string RentalUpdated = "Kiralama zamanı uzatıldı!";
        public static string RentalDeleted = "Kiralama kaydı silindi";
        public static string RentalsListed = "Kiralanan araçlar listelendi!";
        public static string RentalReturnDate = "Araç bırakıldı!";
        public static string RentalReturndateError = "Araç zaten bırakılmış!";


    }
}
