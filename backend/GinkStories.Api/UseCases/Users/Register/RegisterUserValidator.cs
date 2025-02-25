using FluentValidation;
using GinkStories.Communication.Requests;

namespace GinkStories.Api.UseCases.Users.Register;
//classe para validar as informações do cadastro
public class RegisterUserValidator : AbstractValidator<RequestUserJson>  //aplicando o validator para a classe RequestUserJson
{
    public RegisterUserValidator()  //regras 
    {
        RuleFor(user => user.Email).EmailAddress().WithMessage("Email inválido");   //objeto user para a propriedade user.email
        RuleFor(user => user.Name).NotEmpty().WithMessage("Nome não pode ser vazio");
        RuleFor(user => user.Password).MinimumLength(7).WithMessage("Nome deve ter 7 caracteres");
    }
}