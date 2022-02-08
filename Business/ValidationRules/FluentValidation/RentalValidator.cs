using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{//Bu class ürüm giriş kurallarını barındıyor. Önr: isim en az 2 karakter olabilir.
    public class RentalValidator : AbstractValidator<Rental>//AbstractValidator class FluentValidation dan geliyor
    {
        public RentalValidator()
        {
            RuleFor(ra => ra.CarId).NotEmpty();
            RuleFor(ra => ra.CustomerId).NotEmpty();
            RuleFor(ra => ra.RentDate).NotEmpty();
            //RuleFor(ra => ra.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");//Kendi oluşturduğun metodu bu şekilde kullanabilirsin. WithMessage ile istediğimiz mesajı kullanıcıya gösterebiliriz.
        }

        //private bool StartWithA(string arg)//buradaki arg ProductName. Eğer A ile başlıyorsa true döner eğer A ile başlamıyorsa false döner 
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
