using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2kVMK_2023_02_17
{
    public class MyClass : Object
    {
        private int _aField = -5;
        private int _b = 5;
        private int cField = default;

        private Enumeration eVal;

        private byte? byteVal = 10;

        public int Property { get; set; }

        public int A
        {
            get
            {
                return _aField >= 0 ? _aField : -_aField;
            }
            set
            {
                _aField = value;
            }
        }

        public int B
        {
            get => _b;
            init => _b = value;
        }

        public int C => B * B;

        public int Calc()
        {
            A = 6;
            //byteVal = (byte)((byteVal ?? 0) + 1);
            //byteVal?.ToString();
            return A * A * A;
        }

        public MyClass()
        {
            B = 67;
            eVal = Enumeration.Four;
        }

        public MyClass(int property, int a, int b)
        {
            Property = property;
            A = a;
            B = b;
            eVal = Enumeration.Three;
        }

        public MyClass(int property, int a) : this()
        {
            Property = property;
            A = a;
        }

        public void Method(int cField)
        {
            this.cField = cField;
        }

        public override string ToString()
        {
            return $"{_aField} {B} {cField} {byteVal} {eVal} {(int)eVal}";
        }
    }
}
