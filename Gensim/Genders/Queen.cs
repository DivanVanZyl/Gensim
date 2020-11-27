using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim.Genders
{
    public class Queen : IGender
    {
        public IGender.MainTypeEnum MainType { get; set; }
        public bool IsFertile { get; set; }
        public List<Type> RequiredParents { get; set; }

        public Queen()
        {
            this.MainType = IGender.MainTypeEnum.female;
            this.IsFertile = true;
            this.RequiredParents = new List<Type>
            {
                typeof(Queen),
                typeof(Drone)
            };
        }
    }
}
