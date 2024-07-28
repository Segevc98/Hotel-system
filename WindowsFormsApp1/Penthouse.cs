using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Penthouse : Luxury
    {
        private bool _movieRoom { get; set; }

        public Penthouse(double cost, int amount, string pooltype, bool roomService, bool movieRoom)
      : base(cost, amount, pooltype, roomService)
        {
            this._movieRoom = movieRoom;
        }
        public override StringBuilder info()
        {
            string withMovie;
            if (this._movieRoom)
            {
                withMovie = "with";
            }
            else
            {
                withMovie = "without";
            }
            StringBuilder sb = base.info();
            sb.AppendLine($"Room comes {withMovie} a movie room");
            return sb;
        }
    }
}
