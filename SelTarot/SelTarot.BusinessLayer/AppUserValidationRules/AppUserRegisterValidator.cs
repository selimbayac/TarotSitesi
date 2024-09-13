using FluentValidation;
using SelTarot.DtoLayer.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.BusinessLayer.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator() { 
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Boş bırakma işte");
        }
      
    }
}
