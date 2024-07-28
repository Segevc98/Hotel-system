using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Suite:Luxury
    {
        private bool _cheffMeal { get; set; }

       public Suite(double cost, int amount, string pooltype, bool roomService, bool cheffMeal)
         : base(cost, amount, pooltype, roomService)
        {
            this._cheffMeal = cheffMeal;
        }
        public bool getCheffMeal()
        {
            return this._cheffMeal;
        }
        public override StringBuilder info()
        {
            string withChef;
            if (this._cheffMeal)
            {
                withChef = "with";
            }
            else
            {
                withChef = "without";
            }
            StringBuilder sb = base.info();
            sb.AppendLine($"Room comes {withChef} chef meal");
            return sb;
        }
    }
}
