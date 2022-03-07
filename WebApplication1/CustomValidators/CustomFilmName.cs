using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.CustomValidators
{
    public class CustomFilmName : ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            
            if (value == null)
                return true;
            else
            {
                string str = value.ToString();
                return !str.Contains("@");
            }
        }
    }
}