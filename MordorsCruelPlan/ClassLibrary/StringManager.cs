using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StringManager
    {
        private const char separator = ' ';

        public List<string> StringTeiler(string stringInput)
        {
            var stringList = stringInput.Split(separator).ToList();

            return stringList;
        }
    }
}
