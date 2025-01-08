/*
 * Created by SharpDevelop.
 * User: Selahattin Taha AYDIN
 * Date: 08.01.2025
 * Time: 22:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace isimyazma
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string gelenveri = string.Empty;
		int gelenchar;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnportacClick(object sender, EventArgs e)
		{
			if (!serialPort1.IsOpen) {
				serialPort1.PortName=textBox1.Text;
				serialPort1.BaudRate=Convert.ToInt32(textBox2.Text);
				serialPort1.Open();
				
				serialPort1.DiscardInBuffer();
				serialPort1.DiscardOutBuffer();
				serialPort1.DtrEnable = true;
			}
		}
		void BtnportkapatClick(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen) {
				serialPort1.Close();
			}
		}
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			//gelenchar = serialPort1.ReadChar();
			//this.Invoke(new EventHandler(ekrandagoster));
			gelenveri = serialPort1.ReadExisting();
			this.Invoke(new EventHandler(test));
		}
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			if (serialPort1.IsOpen) {
				serialPort1.Close();
			}
		}
		/*void ekrandagoster(object sender, EventArgs e) {
			textBox4.Text=textBox4.Text+(char)gelenchar;
		}*/
		
		void test(object sender, EventArgs e) {
			if (gelenveri[0]=='*') {
				textBox5.Text=gelenveri.Remove(0,1);
			}
			else if (gelenveri[0]=='#') {
				textBox6.Text=gelenveri.Remove(0,1);
			}
			else if (gelenveri[0]=='(') {
				textBoxadc.Text=gelenveri.Remove(0,1);
			}
		}
		void BtnsaatgonderClick(object sender, EventArgs e)
		{
			serialPort1.Write("%"+textlcdsaatgonder.Text);
		}
		void BtnmtngndrClick(object sender, EventArgs e)
		{
			serialPort1.Write("/"+textBox3.Text);
		}
	}
}
