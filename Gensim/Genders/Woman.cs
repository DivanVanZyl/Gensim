using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim.Genders
{
    class Woman : IGender
    {
        public IGender.MainTypeEnum MainType { get; set; }
        public bool IsFertile { get; set; }
        public List<Type> RequiredParents { get; set; }
        public Woman()
        {
            this.MainType = IGender.MainTypeEnum.female;
            this.IsFertile = true;
            this.RequiredParents = new List<Type>
            {
                typeof(Woman),
                typeof(Man)
            };
        }

    }
}
