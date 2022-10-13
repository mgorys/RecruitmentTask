using FluentValidation;
using TaskMG.Models.DTOs;

namespace TaskMG.Validators
{
    public class ProcessTextValidator : AbstractValidator<SentenceDto>
    {
        public ProcessTextValidator()
        {
            RuleFor(x => x.InputSentence)
            .NotEmpty().WithMessage("Input text cannot be empty!");
        }
    }
}
