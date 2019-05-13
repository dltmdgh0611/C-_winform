using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study1
{
    // public : 클래스 내부/외부 모든곳 접근
    // private : 클래스 내부만 접근
    // protected : 외부에서 접근할 수 없지만, 파생 클래스는 가능
    // internal : 같은 어셈블리에 있는 코드에서만 public으로 접근 가능

    class WaterHeater
    {
        protected int temparature;

        public void SetTemperature(int temperaure)
        {
            if (temperaure < -5 || temperaure > 45)
            {
                throw new Exception("Out of temperature range");
            }

            this.temparature = temperaure;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temparature}");
        }
    }
    class A
    {
        public static void Main()
        {
            try
            {
                WaterHeater so = new WaterHeater();
                so.SetTemperature(20);
                so.TurnOnWater();

                so.SetTemperature(-2);
                so.TurnOnWater();

                so.SetTemperature(50);
                so.TurnOnWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
