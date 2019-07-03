using System;
using System.Runtime.Remoting;
using System.Windows.Forms;
using Common;

namespace DinningRoom
{
    public static class MainClass
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RemotingConfiguration.Configure("DinningRoom.exe.config", false);
            ICentralNode iCentralNode = (ICentralNode)RemoteNew.New(typeof(ICentralNode));
            DinningRoomTerminalGUI gui = new DinningRoomTerminalGUI();
            DinningRoom dinningRoom = new DinningRoom(iCentralNode, gui);
            gui.setDinningRoom(dinningRoom);
            gui.LoadProducts();
            Application.Run(gui);
        }
    }
}
