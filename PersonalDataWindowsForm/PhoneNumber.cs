using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataWindowsForm
{
    internal  static class PhoneNumber
    {
        public static bool IsValid(string input)
        {
            return input.Length >= 11;
        }
    }
}
