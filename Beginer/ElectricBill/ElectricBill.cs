using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginer
{
    internal class ElectricBill
    {
        private
        string id;
        string name;
        double sodiendauky, sodiencuoiky;
        char typeFamily;
        public ElectricBill(string id, string name, double sodiendauky, double sodiencuoiky, char typeFamily)
        {
            this.id = id;
            this.name = name;
            this.sodiendauky = sodiendauky;
            this.sodiencuoiky = sodiencuoiky;
            this.typeFamily = typeFamily;
        }
        public void getInfor()
        {
            Console.WriteLine("Ma ho: " + id);
            Console.WriteLine("Ten chu ho: " + name);
            Console.WriteLine("So dien dau ky: " + sodiendauky);
            Console.WriteLine("So dien cuoi ky: " + sodiencuoiky);
            Console.WriteLine("Loai ho gia dinh: " + typeFamily);
        }
        public double electricityConsumed()
        {
            return (double)sodiendauky - sodiencuoiky;
        }
        public double payElectricity()
        {
            if (typeFamily == 'A')
            {
                return (double)(electricityConsumed() - 10) * 3000;
            }
            else if (typeFamily == 'B')
            {
                return (double)(electricityConsumed() - 5) * 3000;
            }
            else
            {
                return (double)electricityConsumed() * 3000;
            }

        }
    }
}
