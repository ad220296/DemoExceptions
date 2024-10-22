using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptions
{
    public class MyException : ApplicationException
    {
        private int _errorCode;

        public int Errorcode 
        {
            get
            {
                return _errorCode;
            } 
            set
            {
                _errorCode = value;
            }
        }
        public MyException(int errorCode)
        {
            _errorCode = errorCode;
        }
        public MyException(int errorCode, string message)
            :base(message)
        {
            _errorCode = errorCode;
        }
    }
}
