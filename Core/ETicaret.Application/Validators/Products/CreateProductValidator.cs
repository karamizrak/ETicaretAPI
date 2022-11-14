using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.ViewModel.Products;
using FluentValidation;

namespace ETicaret.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(c => c.Name).NotEmpty().NotNull().WithMessage("Ürün adını boş geçmeyiniz.").MaximumLength(150)
                .MinimumLength(1).WithMessage("Minimum 1 Maximum 150 karakterdir.");
            RuleFor(p => p.Stock).NotNull().NotEmpty().WithMessage("Stok bilgisini boş geçmeyiniz.").Must(s => s >= 0)
                .WithMessage("Stok bilgisi negatif olamaz.");

            RuleFor(p => p.Price).NotNull().NotEmpty().WithMessage("Fiyat bilgisini boş geçmeyiniz.").Must(s => s >= 0)
                .WithMessage("Fiyat bilgisi negatif olamaz.");
        }
    }
}