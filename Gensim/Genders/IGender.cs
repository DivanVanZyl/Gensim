using System;
using System.Collections.Generic;

namespace Gensim
{
    public interface IGender
    {
        public enum MainTypeEnum
        {
            male,
            female
        }
        public MainTypeEnum MainType { get; set; }
        public bool IsFertile { get; set; }
        public List<Type> RequiredParents { get; set; }
    }
}