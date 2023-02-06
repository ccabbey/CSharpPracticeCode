using System;
namespace Ch11DeepCopyDemo
{
    class Cloner : ICloneable
    {
        public Content MyContent = new();

        public Cloner(int newVal) => MyContent.Val = newVal;

        public object Clone()
        {
            Cloner clonedCloner = new Cloner(MyContent.Val);
            return clonedCloner;
        }

        public object GetCopy() => MemberwiseClone();

    }
}