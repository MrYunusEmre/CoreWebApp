using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {


            RuleFor(x => x.WriterName).NameSurname();
            RuleFor(x => x.WriterMail).Mail();
            RuleFor(x => x.WriterPassword).Password();
            RuleFor(x => x.WriterCity).NotEmpty().WithMessage("Şehir boş geçilemez.");


        }
    }
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength = 6,int maximumLength = 50)
        {
            var options = ruleBuilder
                .NotEmpty().WithMessage("Şifre boş geçilemez.")
                .MinimumLength(minimumLength).WithMessage($"Şifre en az {minimumLength} karakter uzunluğunda olmalıdır")
                .Matches("[A-Z]").WithMessage("Şifre en az 1 adet büyük harf içermelidir.")
                .Matches("[a-z]").WithMessage("Şifre en az 1 adet küçük harf içermelidir.")
                .Matches("[0-9]").WithMessage("Şifre en az 1 adet rakam içermelidir");
                //.Matches("[^a-zA-Z0-9]").WithMessage("");
            return options;
        }

        public static IRuleBuilder<T, string> NameSurname<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength = 2, int maximumLength = 50)
        {
            var options = ruleBuilder
                .NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.")
                .MinimumLength(minimumLength).WithMessage($"Yazar adı soyadı en az {minimumLength} karakter uzunluğunda olmalıdır.")
                .MaximumLength(maximumLength).WithMessage($"Yazar adı soyadı en fazla {maximumLength} karakter uzunluğunda olmalıdır.");
            //.Matches("[^a-zA-Z0-9]").WithMessage("");
            return options;
        }

        public static IRuleBuilder<T, string> Mail<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength = 2)
        {
            var options = ruleBuilder
                .NotEmpty().WithMessage("Yazar mail kısmı boş geçilemez.");
            return options;
        }
    }
}
