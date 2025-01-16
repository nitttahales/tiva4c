/*
 * Created by SharpDevelop.
 * User: Selahattin Taha AYDIN
 * G200100012
 * Date: 12.01.2025
 * Time: 19:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace isimyazma
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnportac;
		private System.Windows.Forms.Button btnportkapat;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textlcdsaatgonder;
		private System.Windows.Forms.Button btnsaatgonder;
		private System.Windows.Forms.TextBox textBoxadc;
		private System.Windows.Forms.Label gelenadcverisi;
		private System.Windows.Forms.Button btnmtngndr;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnportac = new System.Windows.Forms.Button();
			this.btnportkapat = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textlcdsaatgonder = new System.Windows.Forms.TextBox();
			this.btnsaatgonder = new System.Windows.Forms.Button();
			this.textBoxadc = new System.Windows.Forms.TextBox();
			this.gelenadcverisi = new System.Windows.Forms.Label();
			this.btnmtngndr = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "portno";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(23, 76);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "baud";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(100, 37);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(73, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "COM3";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(100, 76);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(76, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "9600";
			// 
			// btnportac
			// 
			this.btnportac.Location = new System.Drawing.Point(177, 35);
			this.btnportac.Margin = new System.Windows.Forms.Padding(2);
			this.btnportac.Name = "btnportac";
			this.btnportac.Size = new System.Drawing.Size(65, 21);
			this.btnportac.TabIndex = 4;
			this.btnportac.Text = "portac";
			this.btnportac.UseVisualStyleBackColor = true;
			this.btnportac.Click += new System.EventHandler(this.BtnportacClick);
			// 
			// btnportkapat
			// 
			this.btnportkapat.Location = new System.Drawing.Point(180, 75);
			this.btnportkapat.Margin = new System.Windows.Forms.Padding(2);
			this.btnportkapat.Name = "btnportkapat";
			this.btnportkapat.Size = new System.Drawing.Size(67, 21);
			this.btnportkapat.TabIndex = 5;
			this.btnportkapat.Text = "portkapat";
			this.btnportkapat.UseVisualStyleBackColor = true;
			this.btnportkapat.Click += new System.EventHandler(this.BtnportkapatClick);
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(309, 63);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(76, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "selahattin";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.HotTrack;
			this.textBox4.Location = new System.Drawing.Point(20, 165);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(200, 20);
			this.textBox4.TabIndex = 7;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(1, 223);
			this.textBox5.Margin = new System.Windows.Forms.Padding(2);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(76, 20);
			this.textBox5.TabIndex = 9;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(81, 223);
			this.textBox6.Margin = new System.Windows.Forms.Padding(2);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(76, 20);
			this.textBox6.TabIndex = 10;
			// 
			// textlcdsaatgonder
			// 
			this.textlcdsaatgonder.BackColor = System.Drawing.SystemColors.HotTrack;
			this.textlcdsaatgonder.ForeColor = System.Drawing.SystemColors.Window;
			this.textlcdsaatgonder.Location = new System.Drawing.Point(282, 165);
			this.textlcdsaatgonder.Margin = new System.Windows.Forms.Padding(2);
			this.textlcdsaatgonder.Name = "textlcdsaatgonder";
			this.textlcdsaatgonder.Size = new System.Drawing.Size(128, 20);
			this.textlcdsaatgonder.TabIndex = 11;
			this.textlcdsaatgonder.Text = "02:56:05";
			// 
			// btnsaatgonder
			// 
			this.btnsaatgonder.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnsaatgonder.Location = new System.Drawing.Point(309, 119);
			this.btnsaatgonder.Margin = new System.Windows.Forms.Padding(2);
			this.btnsaatgonder.Name = "btnsaatgonder";
			this.btnsaatgonder.Size = new System.Drawing.Size(89, 30);
			this.btnsaatgonder.TabIndex = 12;
			this.btnsaatgonder.Text = "saatgönder";
			this.btnsaatgonder.UseVisualStyleBackColor = false;
			this.btnsaatgonder.Click += new System.EventHandler(this.BtnsaatgonderClick);
			// 
			// textBoxadc
			// 
			this.textBoxadc.Location = new System.Drawing.Point(161, 223);
			this.textBoxadc.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxadc.Name = "textBoxadc";
			this.textBoxadc.Size = new System.Drawing.Size(76, 20);
			this.textBoxadc.TabIndex = 13;
			// 
			// gelenadcverisi
			// 
			this.gelenadcverisi.Location = new System.Drawing.Point(98, 132);
			this.gelenadcverisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.gelenadcverisi.Name = "gelenadcverisi";
			this.gelenadcverisi.Size = new System.Drawing.Size(75, 17);
			this.gelenadcverisi.TabIndex = 14;
			this.gelenadcverisi.Text = "adcgelen";
			// 
			// btnmtngndr
			// 
			this.btnmtngndr.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnmtngndr.Location = new System.Drawing.Point(282, 35);
			this.btnmtngndr.Margin = new System.Windows.Forms.Padding(2);
			this.btnmtngndr.Name = "btnmtngndr";
			this.btnmtngndr.Size = new System.Drawing.Size(140, 24);
			this.btnmtngndr.TabIndex = 15;
			this.btnmtngndr.Text = "metin gonderme";
			this.btnmtngndr.UseVisualStyleBackColor = false;
			this.btnmtngndr.Click += new System.EventHandler(this.BtnmtngndrClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 348);
			this.Controls.Add(this.btnmtngndr);
			this.Controls.Add(this.gelenadcverisi);
			this.Controls.Add(this.textBoxadc);
			this.Controls.Add(this.btnsaatgonder);
			this.Controls.Add(this.textlcdsaatgonder);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.btnportkapat);
			this.Controls.Add(this.btnportac);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "isimyazma";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
