using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class Room
    {
        public string roominfo;
        private static int _roomNumberGanerator { get; set; } = 1;
        protected double _cost;
        private int _maxPeople;
        private bool _isAvailable;
        private int _roomNumber;

        public static void set_generator(int count)
        {
            _roomNumberGanerator = count;
        }
        protected Room(double cost, int amount)
        {
            roominfo = null;
            _roomNumber = _roomNumberGanerator++;
            this._cost = cost;
            this._maxPeople = amount;
            this._isAvailable = true;
        }
        public virtual StringBuilder info()
        {
            string Available;
            if (this._isAvailable)
            {
                Available = "Avilable";
            }
            else
            {
                Available = "Taken";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Room number: {this.roomNumber}");
            sb.AppendLine($"This room costs: {this.cost} NIS per night.");
            sb.AppendLine($"The maximum capacity for this room is {this._maxPeople} people.");
            sb.AppendLine($"Currently this room is {Available}");
            return sb;
        }
        public virtual void SetInfo(StringBuilder newInfo)
        {
            // Update the existing room information with the new information
             roominfo = newInfo.ToString();
        }
        public int roomNumber
        {
            get { return this._roomNumber; }
            set { this._roomNumber = value; }
        }
        public double cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }
        public int maxPeople
        {
            get { return this._maxPeople; }
            set { this._maxPeople = value; }
        }
        public bool isAvailable
        {
            get { return this._isAvailable; }
            set { this._isAvailable = value; }
        }
        public void setCost(double cost)
        {
            this._cost = cost;
        }
        
        public double getCost()
        {
            return this._cost;
        }
        public void setAmount(int maxPeople)
        {
            this._maxPeople = maxPeople;
        }
        public int getmaxPeople()
        {
            return this._maxPeople;
        }
        public int GetID()
        {
            return _roomNumber;
        }
        public void setAvailability(bool isAvailable)
        {
            this._isAvailable = isAvailable;
        }
        public bool getAvailability()
        {
            return this._isAvailable;
        }
    }
}