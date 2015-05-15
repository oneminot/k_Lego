using System.Threading.Tasks;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            get_motor_running();
        }

        private static async Task get_motor_running()
        {
            var brick = new Brick(new BluetoothCommunication("COM4"));
            await brick.DirectCommand.PlayToneAsync(100, 1000, 300);
        }
    }
}
