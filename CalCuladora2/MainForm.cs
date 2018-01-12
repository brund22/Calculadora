/*
 * Created by SharpDevelop.
 * User: Ol
 * Date: 12/01/2018
 * Time: 10:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalCuladora2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
		
	{
		double acumula = 0;
        string operacao = "";
        int count = 0;
      
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tela.Text = "0";
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void ButtonSomaClick(object sender, EventArgs e)
		{
			count = 0;
			
			if (operacao == "+"){operacao = "-";tela.Text = "";}
			// Corrige o problema de apertar mais de uma vez no mesmo botao de operaçao
			
			if (operacao == "*" || operacao=="-" || operacao == "/"  )
            {
                operacao = "+";
            }
            else
            {
                acumula = double.Parse(tela.Text);
                tela.Text = "";
                operacao = "+";
            }
			
		}
		
		void ButtonCClick(object sender, EventArgs e)
		{
			operacao = "";
			tela.Text = "0";
			acumula = 0;
			count = 0;
		}
		
		void ButtonDivClick(object sender, EventArgs e)
		{
			count = 0;
			if (operacao == "/"){operacao = "-";tela.Text = "";}
			// Corrige o problema de apertar mais de uma vez no mesmo botao de operaçao
			
	if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
            acumula = double.Parse(tela.Text);
            tela.Text = "";
            operacao = "/";}
		}
		
		void ButtonMultiClick(object sender, EventArgs e)
		{
			count = 0;
		if (operacao == "*"){operacao = "+";tela.Text = "";} 
			
// Corrige o problema de apertar mais de uma vez no mesmo botao de operaçao
	if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(tela.Text);
                tela.Text ="";
                operacao = "*";
            }
		}
		
		void ButtonSubClick(object sender, EventArgs e)
		{
			count = 0;
			
		
			if (operacao == "-"){operacao = "+";tela.Text = "";} 
			
// Corrige o problema de apertar mais de uma vez no mesmo botao de operaçao
	
			if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }  else {
                acumula = double.Parse(tela.Text);
                tela.Text = "";
                operacao = "-";
            }
			
		}
		
		void ButtonPontoClick(object sender, EventArgs e)
		{
			


			count = count + 1;
			if ( count < 2 ) {tela.Text += ","; }
			else {MessageBox.Show("Apenas uma vírgula");
			
			}
	
		}
		
		void ButtonIgualClick(object sender, EventArgs e)
		{
		
			if (operacao == "+")
            {
               acumula += double.Parse(tela.Text);
                tela.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(tela.Text);
                tela.Text = acumula.ToString();
            }
            else if (operacao=="*"){
                acumula *= double.Parse(tela.Text);
                tela.Text = acumula.ToString();
            }
            else if (operacao == "/") {
                if (double.Parse(tela.Text) != 0)
                {
                    acumula /= double.Parse(tela.Text);
                    tela.Text = acumula.ToString();
                }
                else {
                    tela.Text = "0";
                }
            }
			
		}
		
		void Button13Click(object sender, EventArgs e)
		{
	tela.Text += "0";
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (tela.Text == "0"){tela.Text = ("");}
	tela.Text += "1";
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (tela.Text == "0"){tela.Text = ("");}
	tela.Text += "2";
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (tela.Text == "0"){tela.Text = ("");}
	tela.Text += "3";
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (tela.Text == "0"){tela.Text = ("");}
	tela.Text += "4";
		}
		void Button5Click(object sender, EventArgs e)
		{
			if (tela.Text == "0"){tela.Text = ("");}
	tela.Text += "5";
		}
		void Button6Click(object sender, EventArgs e)
		{
			if (tela.Text == "0"){tela.Text = ("");}
			tela.Text += "6";
		}
		void Button7Click(object sender, EventArgs e)
		{
			if (tela.Text == "0"){tela.Text = ("");}
			tela.Text += "7";
		}
		
		
		void Button8Click(object sender, EventArgs e)
		{
			if (tela.Text == "0"){tela.Text = ("");}
			tela.Text += "8";
	
		}
		void Button9Click(object sender, EventArgs e)
		{
	if (tela.Text == "0"){tela.Text = ("");}
			tela.Text += "9";
		}
		void TelaTextChanged(object sender, EventArgs e)
		{
	
		}
		void Button10Click(object sender, EventArgs e)
		{
	double x = double.Parse(tela.Text)*(-1);
            tela.Text = x.ToString();
		}
		
		
		
		
		
		
	}
}
