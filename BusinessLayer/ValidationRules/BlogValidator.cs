using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
		public BlogValidator()
		{
			RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı kısmı boş geçilemez!");
			RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği kısmı boş geçilemez!");
			RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görseli boş geçilemez!");
			RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen en az 150 karakter girişi yapınız!");
			RuleFor(x => x.BlogTitle).MinimumLength(10).WithMessage("Lütfen minimum 10 karakter girişi yapınız!");
		}
	}
}
