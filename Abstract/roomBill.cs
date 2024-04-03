using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    
    public abstract class roomBill
    {
        string id;
        int people;
        double waterP, electricP;
        public roomBill(string id, int people, double waterP, double electricP)
        {
            this.Id = id;
            this.People = people;
            this.WaterP = waterP;
            this.ElectricP = electricP;
        }

        public string Id { get => id; set => id = value; }
        public int People { get => people; set => people = value; }
        public double WaterP { get => waterP; set => waterP = value; }
        public double ElectricP { get => electricP; set => electricP = value; }
        public abstract double getRoomCost();

    }
    public class RoomA : roomBill
    {
        int relatives;
        public RoomA(string id, int people, double waterP, double electricP, int relative) : base(id, people, waterP, electricP)
        {
            this.relatives = relative;
        }

        public int Relatives { get => relatives; set => relatives = value; }

        public override double getRoomCost()
        {
            return (double)(1400 + 2 * ElectricP + 8 * WaterP + 50 * Relatives);
        }
    }
    public class RoomB : roomBill
    {
        double dry, devices;
        public RoomB(string id, int people, double waterP, double electricP, double dry, double devices) : base(id, people, waterP, electricP)
        {
            this.dry = dry;
            this.devices = devices;
        }

        public double Dry { get => dry; set => dry = value; }
        public double Devices { get => devices; set => devices = value; }

        public override double getRoomCost()
        {
            return (double)(2000 + 2 * ElectricP + 8 * WaterP + Dry * 5 + Devices * 100);
        }
    }
}
