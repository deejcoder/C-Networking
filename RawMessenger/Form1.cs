using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RawMessenger.Networking;

namespace RawMessenger
{
    public partial class MessengerWindow : Form
    {
        public MessengerWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Server s = new Server(this);
            s.StartListening();

            Client c = new Client(this);
            c.Send("127.0.0.1", "Hello");
        }

        public void AppendToMessages(string msg)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendToMessages), new object[] { msg });
                return;
            }
            Text_Messages.AppendText(msg);
        }

        private void Text_Messages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
