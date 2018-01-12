/*
 * Created by SharpDevelop.
 * User: Ol
 * Date: 12/01/2018
 * Time: 10:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CalCuladora2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tela;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button buttonSoma;
		private System.Windows.Forms.Button buttonSub;
		private System.Windows.Forms.Button buttonDiv;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button buttonMulti;
		private System.Windows.Forms.Button buttonPonto;
		private System.Windows.Forms.Button buttonIgual;
		private System.Windows.Forms.Button buttonC;
		private System.Windows.Forms.Button button10;
		
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
			this.tela = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.buttonSoma = new System.Windows.Forms.Button();
			this.buttonSub = new System.Windows.Forms.Button();
			this.buttonDiv = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.buttonMulti = new System.Windows.Forms.Button();
			this.buttonPonto = new System.Windows.Forms.Button();
			this.buttonIgual = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tela
			// 
			this.tela.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.tela.Enabled = false;
			this.tela.Location = new System.Drawing.Point(19, 29);
			this.tela.Name = "tela";
			this.tela.Size = new System.Drawing.Size(249, 20);
			this.tela.TabIndex = 0;
			this.tela.TextChanged += new System.EventHandler(this.TelaTextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(19, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button2.Location = new System.Drawing.Point(70, 155);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 35);
			this.button2.TabIndex = 2;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(121, 155);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 35);
			this.button3.TabIndex = 3;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(19, 113);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(45, 35);
			this.button4.TabIndex = 4;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(70, 113);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(45, 35);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(121, 113);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(45, 35);
			this.button6.TabIndex = 7;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(19, 72);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(45, 35);
			this.button7.TabIndex = 6;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(70, 72);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(45, 35);
			this.button8.TabIndex = 8;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(121, 72);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(45, 35);
			this.button9.TabIndex = 9;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// buttonSoma
			// 
			this.buttonSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSoma.Location = new System.Drawing.Point(172, 154);
			this.buttonSoma.Name = "buttonSoma";
			this.buttonSoma.Size = new System.Drawing.Size(45, 35);
			this.buttonSoma.TabIndex = 10;
			this.buttonSoma.Text = "+";
			this.buttonSoma.UseVisualStyleBackColor = true;
			this.buttonSoma.Click += new System.EventHandler(this.ButtonSomaClick);
			// 
			// buttonSub
			// 
			this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSub.Location = new System.Drawing.Point(223, 114);
			this.buttonSub.Name = "buttonSub";
			this.buttonSub.Size = new System.Drawing.Size(45, 35);
			this.buttonSub.TabIndex = 11;
			this.buttonSub.Text = "-";
			this.buttonSub.UseVisualStyleBackColor = true;
			this.buttonSub.Click += new System.EventHandler(this.ButtonSubClick);
			// 
			// buttonDiv
			// 
			this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDiv.Location = new System.Drawing.Point(172, 113);
			this.buttonDiv.Name = "buttonDiv";
			this.buttonDiv.Size = new System.Drawing.Size(45, 35);
			this.buttonDiv.TabIndex = 12;
			this.buttonDiv.Text = "/";
			this.buttonDiv.UseVisualStyleBackColor = true;
			this.buttonDiv.Click += new System.EventHandler(this.ButtonDivClick);
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button0.Location = new System.Drawing.Point(19, 196);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(96, 35);
			this.button0.TabIndex = 13;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.Button13Click);
			// 
			// buttonMulti
			// 
			this.buttonMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMulti.Location = new System.Drawing.Point(223, 154);
			this.buttonMulti.Name = "buttonMulti";
			this.buttonMulti.Size = new System.Drawing.Size(45, 35);
			this.buttonMulti.TabIndex = 14;
			this.buttonMulti.Text = "X";
			this.buttonMulti.UseVisualStyleBackColor = true;
			this.buttonMulti.Click += new System.EventHandler(this.ButtonMultiClick);
			// 
			// buttonPonto
			// 
			this.buttonPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPonto.Location = new System.Drawing.Point(121, 196);
			this.buttonPonto.Name = "buttonPonto";
			this.buttonPonto.Size = new System.Drawing.Size(45, 35);
			this.buttonPonto.TabIndex = 15;
			this.buttonPonto.Text = ",";
			this.buttonPonto.UseVisualStyleBackColor = true;
			this.buttonPonto.Click += new System.EventHandler(this.ButtonPontoClick);
			// 
			// buttonIgual
			// 
			this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIgual.Location = new System.Drawing.Point(172, 196);
			this.buttonIgual.Name = "buttonIgual";
			this.buttonIgual.Size = new System.Drawing.Size(96, 35);
			this.buttonIgual.TabIndex = 16;
			this.buttonIgual.Text = "=";
			this.buttonIgual.UseVisualStyleBackColor = true;
			this.buttonIgual.Click += new System.EventHandler(this.ButtonIgualClick);
			// 
			// buttonC
			// 
			this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonC.Location = new System.Drawing.Point(223, 73);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(45, 35);
			this.buttonC.TabIndex = 17;
			this.buttonC.Text = "C";
			this.buttonC.UseVisualStyleBackColor = true;
			this.buttonC.Click += new System.EventHandler(this.ButtonCClick);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(172, 73);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(45, 35);
			this.button10.TabIndex = 18;
			this.button10.Text = "±";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(281, 236);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.buttonC);
			this.Controls.Add(this.buttonIgual);
			this.Controls.Add(this.buttonPonto);
			this.Controls.Add(this.buttonMulti);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.buttonDiv);
			this.Controls.Add(this.buttonSub);
			this.Controls.Add(this.buttonSoma);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tela);
			this.Name = "MainForm";
			this.Text = "CalCuladora2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
