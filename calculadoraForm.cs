using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Win
{
  public partial class calculadoraForm : Form
  {
    private int resultado = 0;
    public calculadoraForm()
    {
      InitializeComponent();

      Bitmap bitMapCalc = new Bitmap(Properties.Resources.Calculadora);
      this.Icon = Icon.FromHandle(bitMapCalc.GetHicon());

      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;

      this.telaExibicao.ReadOnly = true;
    }

    #region Eventos Click
    private void botaoC_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Clear();
    }

    private void botao2_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "2";
    }

    private void botao3_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "3";
    }

    private void botaoSubtracao_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "-";
    }

    private void botao4_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "4";
    }

    private void botao5_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "5";
    }

    private void botao6_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "6";
    }

    private void botaoSoma_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "+";
    }

    private void botao7_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "7";
    }

    private void botao8_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "8";
    }

    private void botao9_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "9";
    }

    private void botaoMultiplicacao_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "*";
    }

    private void botao0_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "0";
    }

    private void botao1_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "1";
    }

    private void botaoDivisao_Click(object sender, EventArgs e)
    {
      this.telaExibicao.Text += "/";
    }

    private void botaoIgualdade_Click(object sender, EventArgs e)
    {
      string[] formulas = { "-", "+", "/", "*" };

      if (!this.telaExibicao.Text.Contains("="))
      {
        foreach (string formula in formulas)
        {
          if (this.telaExibicao.Text.Contains(formula))
          {
            switch (formula)
            {
              case "+":
                this.Soma(this.telaExibicao.Text);
                break;

              case "-":
                this.Subtracao(this.telaExibicao.Text);
                break;

              case "*":
                this.Multiplicacao(this.telaExibicao.Text);
                break;

              case "/":
                this.Divisao(this.telaExibicao.Text);
                break;

              default:
                this.telaExibicao.Clear();
                break;
            }
          }
        }

        this.telaExibicao.Text += string.Format(" = " + resultado);
        this.resultado = 0;
      }
      else
      {
        this.telaExibicao.Clear();
      }

    }

    #endregion

    #region Formulas
    private int Soma(string expressao)
    {
      string[] valores = expressao.Split('+');
      int indice = 0;

      foreach (string valor in valores)
      {
        if (indice == 0)
        {
          this.resultado = Convert.ToInt32(valor);
          indice++;
        }
        else
          this.resultado += Convert.ToInt32(valor);
      }
      return resultado;
    }

    private int Subtracao(string expressao)
    {
      string[] valores = expressao.Split('-');
      int indice = 0;

      foreach (string valor in valores)
      {
        if (indice == 0)
        {
          this.resultado = Convert.ToInt32(valor);
          indice++;
        }
        else
          this.resultado -= Convert.ToInt32(valor);
      }
      return resultado;
    }

    private int Divisao(string expressao)
    {
      string[] valores = expressao.Split('/');
      int indice = 0;

      foreach (string valor in valores)
      {
        if (indice == 0)
        {
          this.resultado = Convert.ToInt32(valor);
          indice++;
        }
        else
          this.resultado /= Convert.ToInt32(valor);
      }
      return resultado;
    }

    private int Multiplicacao(string expressao)
    {
      string[] valores = expressao.Split('*');
      int indice = 0;

      foreach (string valor in valores)
      {
        if (indice == 0)
        {
          this.resultado = Convert.ToInt32(valor);
          indice++;
        }
        else
          this.resultado *= Convert.ToInt32(valor);
      }
      return resultado;
    }
  #endregion
  }
}