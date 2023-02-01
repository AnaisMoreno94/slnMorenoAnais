using System.Text.RegularExpressions;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validators
{
    public class IsEdadOkAtributte : ValidationAttribute
    {
        public IsEdadOkAtributte()
        {
            ErrorMessage = "Debe ser Mayor de edad y la edad debe ser valida(no mayor a 120) ";
        }
        public override bool IsValid(object value)
        {
            int edad = (Int32)value;
            if (edad > 18 && edad<120) return true; else return false;
        }
    }
}
