using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Regular : Room
    {
        private string _viewType { get; set; }
        private bool _witHottub { get; set; }
        public Regular(double cost, int amount, string viewType, bool withHottub)
            :base(cost, amount)
        {
            this._viewType = viewType;
            this._witHottub = withHottub;
        }
        public override StringBuilder info()
        {
            string withHot;
            if (_witHottub)
            {
                withHot = "With";
            }
            else
            {
                withHot = "Without";
            }
            StringBuilder sb = base.info();
            sb.AppendLine($"The rooms has a {this._viewType}");
            sb.AppendLine($"The room is {withHot} hottub");
            return sb;
        }
    }
}
