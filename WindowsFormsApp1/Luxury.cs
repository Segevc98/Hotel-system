using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class Luxury : Room
    {
        private string _pooltype { get; set; }
        private bool _roomService { get; set; }

        protected Luxury(double cost, int amount, string pooltype, bool roomService) : base(cost, amount)
        {
            this._pooltype = pooltype;
            this._roomService = roomService;
        }
        public override StringBuilder info()
        {
            string withroom;
            if (this._roomService)
            {
                withroom = "With";
            }
            else
            {
                withroom = "without";
            }
            StringBuilder sb = base.info();
            sb.AppendLine($"The room has a {this._pooltype} pool.");
            sb.AppendLine($"This room orderd {withroom} room service");
            return sb;
        }
    } 
}
