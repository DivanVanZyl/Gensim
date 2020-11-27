using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim.Genders
{
    public class Drone : IGender
    {
        public IGender.MainTypeEnum MainType { get; set; }
        public bool IsFertile { get; set; }
        public List<Type> RequiredParents { get; set; }
        public Drone()
        {
            this.MainType = IGender.MainTypeEnum.male;
            this.IsFertile = true;
            this.RequiredParents = new List<Type>
            {
                typeof(Queen)
            };
        }

    }
}
