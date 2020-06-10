using System;

namespace GMR.BLL
{
    public class LanguageModel : ICloneable
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public object Clone() => MemberwiseClone();
    }
}
