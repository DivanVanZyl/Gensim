using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim.Genders
{
    public class Man : IGender
    {
        public IGender.MainTypeEnum MainType { get; set; }
        public bool IsFertile { get; set; }
        public List<Type> RequiredParents { get; set; }
        public Man()
        {
            this.MainType = IGender.MainTypeEnum.male;
            this.IsFertile = true;
            this.RequiredParents = new List<Type>
            {
                typeof(Woman),
                typeof(Man)
            };
        }

    }
}
