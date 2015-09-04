using System;

namespace LearnLINQ.Generics
{
    class MyGenericClass <T>
    {
        private readonly T _generocMemberVariable;

        public MyGenericClass(T value)
        {
            _generocMemberVariable = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof (T), genericParameter);
            Console.WriteLine("Return type: {0}, Value: {1}", typeof (T), _generocMemberVariable);

            return _generocMemberVariable;
        }
        public T GenericProperty { get; set; }
    }
}
