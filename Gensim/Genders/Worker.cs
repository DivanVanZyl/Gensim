using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim.Genders
{
    class Worker : IGender
    {
        public IGender.MainTypeEnum MainType { get; set; }
        public bool IsFertile { get; set; }
        public List<Type> RequiredParents { get; set; }

        public Worker()
        {
            this.MainType = IGender.MainTypeEnum.female;
            this.IsFertile = false;
            this.RequiredParents = new List<Type>
            {
                typeof(Queen)
            };
        }

    }
}
