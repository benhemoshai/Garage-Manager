using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    public class EnumValidator
    {
        public static bool ValidateEnum<T>(string i_Input, out T o_Result)
        {
            bool isValid = false;
            o_Result = default;

            if (Enum.IsDefined(typeof(T), i_Input))
            {
                o_Result = (T)Enum.Parse(typeof(T), i_Input);
                isValid = true;
            }

            return isValid;
        }

    }
}
