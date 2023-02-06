namespace Ch11DeepCopyDemo
{
    class Cloner
    {
        public Content MyContent = new();

        public Cloner(int newVal) => MyContent.Val = newVal;

        public object GetCopy() => MemberwiseClone();

    }
}