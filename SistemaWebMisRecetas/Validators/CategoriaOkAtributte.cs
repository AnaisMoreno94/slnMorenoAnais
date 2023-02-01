using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaWebMisRecetas.Validators
{
    public class CategoriaOkAtributte : ValidationAttribute
    {
        public CategoriaOkAtributte() 
        {
            ErrorMessage = "Solo se permite la categoria 'desayuno' ";
        }
        public override bool IsValid(object value)
        {
            string categoria = (String)value;
            if (categoria == "desayuno") return true; else return false;
        }
    }
}
