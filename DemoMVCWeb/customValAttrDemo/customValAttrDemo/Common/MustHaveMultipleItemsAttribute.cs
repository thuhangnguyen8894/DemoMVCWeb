using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace customValAttrDemo.Common
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class MustHaveMultipleItemsAttribute : ValidationAttribute
    {
        //Override IsValid method to run the validation test
        public override bool IsValid(object value)
        {
            bool result;
            var testVal = (string)value;
            if (testVal.IndexOf(',') == -1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}