using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Ekleme işlemi başarılı.";//bir değişken olmasına rağmen büyük harfle yazdık. Nedeni Public olması publicler pascalcase ile yazılır.
        public static string NotAdded = "Ekleme işlemi başarısız !";
        public static string Deleted = "Silme işlemi başarılı.";
        public static string NotDeleted = "Silme işlemi başarısız !";
        public static string NameInvalid = "İsim geçersiz ! İsim minimum 3 karakter olmalıdır.";
        public static string PriceInvalid = "Araba günlük fiyatı 0'dan büyük olmalıdır.";

        public static string UserPasswordInvalid = "Şifre en az 6 karakter olmalı";
        public static string CarNotRental = "Araç şuan kirada. Kiralama işlemi için başka araç seçiniz.";
        public static string CarRentalSuccess = "Araç kiralama işlemi başarılı";

        public static string CarImageLimit = "En fazla 5 resim eklenebilir. Ekleme işlemi başarısız !";

    }
}
