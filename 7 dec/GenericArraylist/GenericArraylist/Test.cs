using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericArraylist
{
    public class Test<T>
    {
        private T data;
        public Test(T data)
        {
            this.data = data;
        }

        public T Print()
        {
            return data;
        }
    }
}
