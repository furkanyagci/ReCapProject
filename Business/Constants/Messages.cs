using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ekleme işlemi başarılı.";//bir değişken olmasına rağmen büyük harfle yazdık. Nedeni Public olması publicler pascalcase ile yazılır.
        public static string ProductNotAdded = "Ekleme işlemi başarısız !";
        public static string ProductDeleted = "Silme işlemi başarılı.";
        public static string ProductNotDeleted = "Silme işlemi başarısız !";
        public static string ProductNameInvalid = "İsim geçersiz ! Araba ismi minimum 2 karakter olmalıdır.";
        public static string ProductPriceInvalid = "Araba günlük fiyatı 0'dan büyük olmalıdır.";
    }
}
