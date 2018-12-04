using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
	public partial class m_frmHelloWorld : Form
	{
		public m_frmHelloWorld()
		{
			InitializeComponent();
		}

		private void m_btnSayHelloWorld_Click(object sender, EventArgs e)
		{
			m_tbGreeting.Text = "Hello, World!";
		}

		private void m_tbWhoToTarget_TextChanged(object sender, EventArgs e)
		{
			m_btnSayHelloWorld.Text = "Say \"Hello, " + m_tbWhoToTarget.Text + "\"!";
		}
	}
}
