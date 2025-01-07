/*
 * Created by SharpDevelop.
 * User: BERK
 * Date: 20.11.2023
 * Time: 22:31
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
			this.label1.Location = new System.Drawing.Point(31, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "portno";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "baud";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(133, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(96, 22);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "COM4";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(133, 93);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "9600";
			// 
			// btnportac
			// 
			this.btnportac.Location = new System.Drawing.Point(296, 42);
			this.btnportac.Name = "btnportac";
			this.btnportac.Size = new System.Drawing.Size(87, 26);
			this.btnportac.TabIndex = 4;
			this.btnportac.Text = "portac";
			this.btnportac.UseVisualStyleBackColor = true;
			this.btnportac.Click += new System.EventHandler(this.BtnportacClick);
			// 
			// btnportkapat
			// 
			this.btnportkapat.Location = new System.Drawing.Point(424, 42);
			this.btnportkapat.Name = "btnportkapat";
			this.btnportkapat.Size = new System.Drawing.Size(89, 26);
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
			this.textBox3.Location = new System.Drawing.Point(133, 166);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "mehmet";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(35, 216);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(266, 22);
			this.textBox4.TabIndex = 7;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(133, 275);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 9;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(133, 320);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 22);
			this.textBox6.TabIndex = 10;
			// 
			// textlcdsaatgonder
			// 
			this.textlcdsaatgonder.Location = new System.Drawing.Point(343, 226);
			this.textlcdsaatgonder.Name = "textlcdsaatgonder";
			this.textlcdsaatgonder.Size = new System.Drawing.Size(169, 22);
			this.textlcdsaatgonder.TabIndex = 11;
			this.textlcdsaatgonder.Text = "02:56:05";
			// 
			// btnsaatgonder
			// 
			this.btnsaatgonder.Location = new System.Drawing.Point(376, 260);
			this.btnsaatgonder.Name = "btnsaatgonder";
			this.btnsaatgonder.Size = new System.Drawing.Size(119, 37);
			this.btnsaatgonder.TabIndex = 12;
			this.btnsaatgonder.Text = "saatgönder";
			this.btnsaatgonder.UseVisualStyleBackColor = true;
			this.btnsaatgonder.Click += new System.EventHandler(this.BtnsaatgonderClick);
			// 
			// textBoxadc
			// 
			this.textBoxadc.Location = new System.Drawing.Point(133, 366);
			this.textBoxadc.Name = "textBoxadc";
			this.textBoxadc.Size = new System.Drawing.Size(100, 22);
			this.textBoxadc.TabIndex = 13;
			// 
			// gelenadcverisi
			// 
			this.gelenadcverisi.Location = new System.Drawing.Point(27, 369);
			this.gelenadcverisi.Name = "gelenadcverisi";
			this.gelenadcverisi.Size = new System.Drawing.Size(100, 21);
			this.gelenadcverisi.TabIndex = 14;
			this.gelenadcverisi.Text = "adcgelen";
			// 
			// btnmtngndr
			// 
			this.btnmtngndr.Location = new System.Drawing.Point(308, 165);
			this.btnmtngndr.Name = "btnmtngndr";
			this.btnmtngndr.Size = new System.Drawing.Size(117, 30);
			this.btnmtngndr.TabIndex = 15;
			this.btnmtngndr.Text = "metin gönder";
			this.btnmtngndr.UseVisualStyleBackColor = true;
			this.btnmtngndr.Click += new System.EventHandler(this.BtnmtngndrClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 428);
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
			this.Name = "MainForm";
			this.Text = "isimyazma";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
