using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SistemaWebMisRecetas.Validators
{
    public class IsEmailAtributte : ValidationAttribute
    {
        public IsEmailAtributte()
        {
            ErrorMessage = "El Email que ingreso no es correcto ";
        }
        public override bool IsValid(object value)
        {
            string email = (String)value;
            if (email == null) return false;
            else
            {
                if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) return true; else return false;
            }
            

        }
    }
}
