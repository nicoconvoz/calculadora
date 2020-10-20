using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ArrayList tecla = new ArrayList();
        ArrayList formula = new ArrayList();
        int i = 0;
        int c = 0;
        bool reinicio = false;
        Boolean k = false;
        int cp = 0;
        int cuentap = 0;
        int cc = 0;
        int cuentac = 0;
        int cl = 0;
        int cuental = 0;
        int numero = 11;
        int pmax = 0;
        int pmin = -1;
        int p = 0;
        int pTotal = 0;
        int contadorTotal = 0;
        int contadorNumCom = 0;
        float numeroCompleto = 0;
        bool agregarComa = true;
        bool agregarSigno = true;
        bool agregarNumero = true;
        bool agregarParentesis = true;
        bool agregarCorchete = true;
        bool agregarLlave = true;
        int parcor = 0;
        int corlla = 0;
        ArrayList oldComa = new ArrayList();
        List<int> Parentesis = new List<int>();
        List<int> Corchete = new List<int>();
        List<int> Llave = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            Visor1.Text = "0";
            ChangeControlStyles(b1, ControlStyles.Selectable, false);
            ChangeControlStyles(b2, ControlStyles.Selectable, false);
            ChangeControlStyles(b3, ControlStyles.Selectable, false);
            ChangeControlStyles(b4, ControlStyles.Selectable, false);
            ChangeControlStyles(b5, ControlStyles.Selectable, false);
            ChangeControlStyles(b6, ControlStyles.Selectable, false);
            ChangeControlStyles(b7, ControlStyles.Selectable, false);
            ChangeControlStyles(b8, ControlStyles.Selectable, false);
            ChangeControlStyles(b9, ControlStyles.Selectable, false);
            ChangeControlStyles(b10, ControlStyles.Selectable, false);
            ChangeControlStyles(b11, ControlStyles.Selectable, false);
            ChangeControlStyles(b13, ControlStyles.Selectable, false);
            ChangeControlStyles(b14, ControlStyles.Selectable, false);
            ChangeControlStyles(b15, ControlStyles.Selectable, false);
            ChangeControlStyles(b16, ControlStyles.Selectable, false);
            ChangeControlStyles(b17, ControlStyles.Selectable, false);
            ChangeControlStyles(b18, ControlStyles.Selectable, false);
            ChangeControlStyles(b19, ControlStyles.Selectable, false);
            ChangeControlStyles(b20, ControlStyles.Selectable, false);
            ChangeControlStyles(b21, ControlStyles.Selectable, false);
            ChangeControlStyles(b22, ControlStyles.Selectable, false);
            ChangeControlStyles(b23, ControlStyles.Selectable, false);
            ChangeControlStyles(b24, ControlStyles.Selectable, false);
            ChangeControlStyles(b26, ControlStyles.Selectable, false);
            ChangeControlStyles(Visor1, ControlStyles.Selectable, false);
            ChangeControlStyles(Visor2, ControlStyles.Selectable, false);
            b25.Focus();
        }

        private void cargaVisor1(bool signos) {
            if (Visor1.Text == "0")
            {
                if (tecla[i].Equals(","))
                {
                    Visor1.Text = Visor1.Text + tecla[i].ToString();
                    agregarComa = false;
                }
                else
                {
                    if (tecla[i].Equals("-"))
                    {
                        Visor1.Text = tecla[i].ToString();
                        agregarComa = false;
                    }
                    else
                    {
                        switch (numero)
                        {
                            case 0:
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                                Visor1.Text = tecla[i].ToString();
                                agregarSigno = true;
                                agregarNumero = true;
                                agregarParentesis = true;
                                agregarCorchete = true;
                                agregarLlave = true;
                                break;
                            case 10:
                                if (agregarComa == true)
                                {
                                    Visor1.Text = Visor1.Text + tecla[i].ToString();
                                    agregarComa = false;
                                }
                                break;
                            case 12:
                                Visor1.Text = tecla[i].ToString();
                                agregarSigno = true;
                                agregarNumero = true;
                                agregarParentesis = true;
                                agregarCorchete = false;
                                agregarLlave = false;
                                break;
                            case 14:
                                Visor1.Text = tecla[i].ToString();
                                agregarSigno = true;
                                agregarNumero = true;
                                agregarCorchete = true;
                                agregarLlave = false;
                                break;
                            case 16:
                                Visor1.Text = tecla[i].ToString();
                                agregarSigno = true;
                                agregarNumero = true;
                                agregarLlave = true;
                                break;

                        }
                        numero = 11;
                    }
                }
            }
            else if (Visor1.Text != "0")
            {
                switch (numero)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Visor1.Text = Visor1.Text + tecla[i].ToString();
                        agregarSigno = true;
                        agregarNumero = true;
                        agregarParentesis = true;
                        agregarCorchete = true;
                        agregarLlave = true;
                        break;
                    case 10:
                        if (agregarComa == true)
                        {
                            Visor1.Text = Visor1.Text + tecla[i].ToString();
                            agregarComa = false;
                        }
                        break;
                    case 12:
                        Visor1.Text = Visor1.Text + tecla[i].ToString();
                        agregarSigno = true;
                        agregarNumero = true;
                        agregarParentesis = true;
                        agregarCorchete = false;
                        agregarLlave = false;
                        break;
                    case 13:
                        Visor1.Text = Visor1.Text + tecla[i].ToString();
                        agregarSigno = true;
                        agregarParentesis = false;
                        break;
                    case 14:
                        Visor1.Text = Visor1.Text + tecla[i].ToString();
                        agregarSigno = true;
                        agregarNumero = true;
                        agregarCorchete = true;
                        agregarLlave = false;
                        break;
                    case 15:
                        Visor1.Text = Visor1.Text + tecla[i].ToString();
                        agregarSigno = true;
                        agregarCorchete = false;
                        break;
                    case 16:
                        Visor1.Text = Visor1.Text + tecla[i].ToString();
                        agregarSigno = true;
                        agregarNumero = true;
                        agregarLlave = true;
                        break;
                    case 17:
                        Visor1.Text = Visor1.Text + tecla[i].ToString();
                        agregarSigno = true;
                        agregarLlave = false;
                        break;

                }
                numero = 11;
                if (signos == true)
                {
                    if (oldComa.Count != 0)
                    {
                        c = c + 1;
                    }
                    oldComa.Add(agregarComa);
                    agregarComa = true;
                    Visor1.Text = Visor1.Text + tecla[i].ToString();
                }
            }
            i = i + 1;
        }

        private void b10_Click(object sender, EventArgs e)
        {
            reiniciar();
            try
            {
                if (tecla[0].Equals("0") && tecla.Count == 1)
                {
                    return;
                }
            }
            catch (Exception j)
            {
                Console.WriteLine("{0} Exception caught.", j);
            }
                if (tecla.Count > 0)
                {
                    if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                    {
                        if (agregarSigno == true)
                        {
                            tecla.Add("*");
                            cargaVisor1(true);
                            agregarSigno = false;
                        }
                    }
                }
            tecla.Add("0");
            k = false;
            numero = 0;
            cargaVisor1(false);

        }

        private void b7_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("1");
            k = false;
            numero = 1;
            cargaVisor1(false);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("2");
            k = false;
            numero = 2;
            cargaVisor1(false);

        }

        private void b9_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("3");
            k = false;
            numero = 3;
            cargaVisor1(false);

        }

        private void b4_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("4");
            k = false;
            numero = 4;
            cargaVisor1(false);

        }

        private void b5_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("5");
            k = false;
            numero = 5;
            cargaVisor1(false);

        }

        private void b6_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("6");
            k = false;
            numero = 6;
            cargaVisor1(false);

        }
        void reiniciar()
        {
            if (reinicio)
            {
                borrar(true);
                reinicio = false;
            }
        }
        private void b1_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("7");
            k = false;
            numero = 7;
            cargaVisor1(false);

        }

        private void b2_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("8");
            k = false;
            numero = 8;
            cargaVisor1(false);

        }

        private void b3_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                if (tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}"))
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add("*");
                        cargaVisor1(true);
                        agregarSigno = false;
                    }
                }
            }
            tecla.Add("9");
            k = false;
            numero = 9;
            cargaVisor1(false);

        }

        private void b14_Click(object sender, EventArgs e)
        {
            String texto;
            if (i != 0)
            {
                texto = Visor1.Text;
                if (texto != "" && texto != "0")
                {
                    if (tecla.Count > 2 && (tecla[i - 2].Equals("(") || tecla[i - 2].Equals("[") || tecla[i - 2].Equals("{")))
                    {
                        k = true;
                    }
                    if (tecla.Count > 1 && (tecla[i - 1].Equals("+") || tecla[i - 1].Equals("-") || tecla[i - 1].Equals("*") || tecla[i - 1].Equals("/")))
                    {
                        agregarSigno = true;
                        agregarComa = (bool)oldComa[c];
                        oldComa.Remove(c);
                    }
                    if (Visor1.TextLength > 2)
                    {
                        if (tecla[i - 2].Equals("+") || tecla[i - 2].Equals("-") || tecla[i - 2].Equals("*") || tecla[i - 2].Equals("/"))
                        {
                            agregarSigno = false;
                        }
                    }
                    if (tecla[i - 1].Equals(","))
                    {
                        agregarComa = true;
                    }
                    if (tecla[i - 1].Equals("("))
                    {
                        cuentap = cuentap - 1;
                        Parentesis.Remove(cuentap);
                        cp--;
                        k = false;
                    }
                    if (tecla[i - 1].Equals(")"))
                    {
                        cuentap = cuentap - 1;
                        Parentesis.Remove(cuentap);
                        cp++;
                        k = true;
                    }
                    if (tecla[i - 1].Equals("[") )
                    {
                        cuentac = cuentac - 1;
                        Corchete.Remove(cuentac);
                        cc--;
                        k = false;
                    }
                    if ( tecla[i - 1].Equals("]"))
                    {
                        cuentac = cuentac - 1;
                        Corchete.Remove(cuentac);
                        cc++;
                        k = true;
                    }
                    if (tecla[i - 1].Equals("{") )
                    {
                        cuental = cuental - 1;
                        Llave.Remove(cuental);
                        cl--;
                        k = false;
                    }
                    if ( tecla[i - 1].Equals("}"))
                    {
                        cuental = cuental - 1;
                        Llave.Remove(cuental);
                        cl++;
                        k = true;
                    }
                    
                    tecla.RemoveAt(i - 1);
                    texto = texto.Substring(0, texto.Length - 1);
                    i = i - 1;
                    //if (tecla.Count == 2)
                    //{
                    //    if (tecla[0].Equals("-") && tecla[1].Equals("0"))
                    //    {
                    //        //MessageBox.Show("funciona");
                    //        //tecla.RemoveAt(0);
                    //        //i--;
                    //        //Visor1.Text = "";
                    //        //for (int m = 0; m < tecla.Count; m++)
                    //        //{
                    //        //    Visor1.Text += tecla[m].ToString();
                    //        //}
                    //        masMenos();
                    //    }
                    //}
                }
                if (texto == "" || texto=="-")
                {
                    texto = "0";
                }
                Visor1.Text = texto;
            }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            borrar(false);
        }

        void borrar(bool reinicio)
        {
            tecla.RemoveRange(0, tecla.Count);
            cuentac = 0;
            cuental = 0;
            cuentap = 0;
            cp = 0;
            cl = 0;
            cc = 0;
            i = 0;
            Parentesis.RemoveRange(0, Parentesis.Count());
            Corchete.RemoveRange(0, Corchete.Count());
            Llave.RemoveRange(0, Llave.Count());
            if (!reinicio)
            {
                Visor2.Text = "0";
            }
            agregarComa = true;
            Visor1.Text = "0";
        }
        private void b11_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                char l = Char.Parse(tecla[tecla.Count - 1].ToString());
                if (!Char.IsDigit(l) && !l.Equals(','))
                {
                    b10_Click(sender, e);
                }
                l = char.MinValue;
            }
            if (agregarComa == true)
            {
                if (Visor1.Text == "0")
                {
                    b10_Click(sender, e);
                }
                tecla.Add(",");
                numero = 10;
                agregarNumero = false;
                cargaVisor1(false);
            }
            
        }

        private void b17_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                char l = Char.Parse(tecla[tecla.Count - 1].ToString());
                if (!Char.IsDigit(l) && l.Equals(','))
                {
                    b10_Click(sender, e);
                }
                l = char.MinValue;
            }
            if (agregarSigno == true)
            {
                tecla.Add("+");
                cargaVisor1(true);
                agregarSigno = false;
            }
            else if(tecla[tecla.Count - 1].Equals("-"))
            {
                masMenos();
            }



        }

        private void b18_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                char l = Char.Parse(tecla[tecla.Count - 1].ToString());
                if (!Char.IsDigit(l) && l.Equals(','))
                {
                    b10_Click(sender, e);
                }
                l = char.MinValue;
            }
            try
            {
                if (tecla[tecla.Count - 1].Equals("+") || tecla[tecla.Count - 1].Equals("-"))
                {
                    masMenos();
                }
                else
                {
                    tecla.Add("-");
                    cargaVisor1(true);
                    agregarSigno = false;
                }
            }catch(Exception m)
            {
                Console.WriteLine(m);
            }

        }

        private void b15_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                char l = Char.Parse(tecla[tecla.Count - 1].ToString());
                if (!Char.IsDigit(l) && l.Equals(','))
                {
                    b10_Click(sender, e);
                }
                l = char.MinValue;
            }
            if (agregarSigno == true)
            {
                tecla.Add("*");
                cargaVisor1(true);
                agregarSigno = false;
            }

        }

        private void b16_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0)
            {
                char l = Char.Parse(tecla[tecla.Count - 1].ToString());
                if (!Char.IsDigit(l) && l.Equals(','))
                {
                    b10_Click(sender, e);
                }
                l = char.MinValue;
            }
            if (agregarSigno == true)
            {
                tecla.Add("/");
                cargaVisor1(true);
                agregarSigno = false;
            }

        }

        private void b19_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0 && k == false)
            {
                if (!tecla[tecla.Count - 1].Equals(","))
                {
                    if (tecla.Count > 0)
                    {
                        if ((tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}")) || (tecla[tecla.Count - 1].Equals("*") == false && tecla[tecla.Count - 1].Equals("+") == false && tecla[tecla.Count - 1].Equals("-") == false && tecla[tecla.Count - 1].Equals("/") == false && tecla[tecla.Count - 1].Equals(",") == false))
                        {
                            if (agregarSigno == true)
                            {
                                tecla.Add("*");
                                cargaVisor1(true);
                                agregarSigno = false;
                            }
                        }
                    }
                    tecla.Add("(");
                    numero = 12;
                    Parentesis.Add(cp);
                    agregarParentesis = true;
                    k = true;
                    agregarCorchete = false;
                    agregarLlave = false;
                    cp = cp + 1;
                    cuentap = cuentap + 1;
                    cargaVisor1(false);
                    agregarNumero = false;
                }
            }
            else
            {
                tecla.Add("(");
                numero = 12;
                Parentesis.Add(cp);
                agregarParentesis = true;
                agregarCorchete = false;
                agregarLlave = false;
                k = true;
                cp = cp + 1;
                cuentap = cuentap + 1;
                cargaVisor1(false);
                agregarNumero = false;
            }

        }

        private void b20_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (cp != 0)
            {
                if (agregarNumero == true)
                {
                    if (agregarSigno == true)
                    {
                        tecla.Add(")");
                        numero = 13;
                        k = false;
                        Parentesis.Add(cp);
                        cuentap = cuentap + 1;
                        cp = cp - 1;
                        if (cp == 0)
                        {
                            parcor = cp;
                        }else
                        {
                            parcor = -1;
                        }
                        cargaVisor1(false);
                        agregarParentesis = true;
                        if (cp == 0) { 
                            agregarCorchete = true;
                            agregarLlave = true;
                        }
                    }
                    agregarComa = true;
                }
            }
        }

        private void b21_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0 && k == false && cp==0)
            {
                if (!tecla[tecla.Count - 1].Equals(","))
                {
                    if (agregarCorchete == true)
                    {
                        if (tecla.Count > 0)
                        {
                            if ((tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}")) || (tecla[tecla.Count - 1].Equals("*") == false && tecla[tecla.Count - 1].Equals("+") == false && tecla[tecla.Count - 1].Equals("-") == false && tecla[tecla.Count - 1].Equals("/") == false && tecla[tecla.Count - 1].Equals(",") == false))
                            {
                                if (agregarSigno == true)
                                {
                                    tecla.Add("*");
                                    cargaVisor1(true);
                                    agregarSigno = false;
                                }
                            }
                        }
                        tecla.Add("[");
                        numero = 14;
                        Corchete.Add(cc);
                        k = true;
                        agregarParentesis = true;
                        agregarCorchete = true;
                        cuentac = cuentac + 1;
                        cc = cc + 1;
                        cargaVisor1(false);
                        agregarNumero = false;
                    }
                }
            }
            else
            {
                if (cp == 0)
                {
                    tecla.Add("[");
                    numero = 14;
                    Corchete.Add(cc);
                    k = true;
                    agregarCorchete = true;
                    agregarParentesis = true;
                    cuentac = cuentac + 1;
                    cc = cc + 1;
                    cargaVisor1(false);
                    agregarNumero = false;
                }
            }
        }

        private void b22_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (parcor == cp)
            {
                if (cc != 0)
                {
                    if (agregarNumero == true)
                    {
                        if (agregarSigno == true)
                        {
                            tecla.Add("]");
                            numero = 15;
                            Corchete.Add(cc);
                            cc = cc - 1;
                            k = false;
                            if (cc == 0 && cp == 0)
                            {
                                corlla = cc;
                            }
                            else
                            {
                                corlla = -1;
                            }
                            cuentac = cuentac + 1;
                            cargaVisor1(false);
                            agregarParentesis = true;
                            agregarCorchete = true;
                            if (cc == 0)
                            {
                                agregarLlave = true;
                            }
                        }
                        agregarComa = true;
                    }
                }
            }
        }

        private void b23_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (tecla.Count > 0 && k == false && cp==0 && cc==0)
            {
                if (!tecla[tecla.Count - 1].Equals(","))
                {
                    if (agregarCorchete == true && agregarLlave == true && cp == 0 & cc == 0)
                    {
                        if (tecla.Count > 0)
                        {
                            if ((tecla[tecla.Count - 1].Equals(")") || tecla[tecla.Count - 1].Equals("]") || tecla[tecla.Count - 1].Equals("}")) || (tecla[tecla.Count - 1].Equals("*") == false && tecla[tecla.Count - 1].Equals("+") == false && tecla[tecla.Count - 1].Equals("-") == false && tecla[tecla.Count - 1].Equals("/") == false && tecla[tecla.Count - 1].Equals(",") == false))
                            {
                                if (agregarSigno == true)
                                {
                                    tecla.Add("*");
                                    cargaVisor1(true);
                                    agregarSigno = false;
                                }
                            }
                        }
                        tecla.Add("{");
                        numero = 16;
                        Llave.Add(cl);
                        agregarLlave = true;
                        cuental = cuental + 1;
                        cl = cl + 1;
                        k = true;
                        cargaVisor1(false);
                        agregarNumero = false;
                    }
                }
            }
            else
            {
                if (cp == 0 && cc == 0)
                {
                    tecla.Add("{");
                    numero = 16;
                    Llave.Add(cl);
                    agregarLlave = true;
                    k = true;
                    cuental = cuental + 1;
                    cl = cl + 1;
                    cargaVisor1(false);
                    agregarNumero = false;
                }
            }
        }

        private void b24_Click(object sender, EventArgs e)
        {
            reiniciar();
            if (corlla == cc)
            { 
                if (parcor == cp)
                {
                    if (cl != 0)
                    {
                        if (agregarNumero == true)
                        {
                            if (agregarSigno == true)
                            {
                                tecla.Add("}");
                                numero = 17;
                                Llave.Add(cc);
                                cl = cl - 1;
                                cuental = cuental + 1;
                                cargaVisor1(false);
                                k = false;
                                agregarLlave = true;
                                agregarCorchete = true;
                                agregarParentesis = true;
                                agregarComa = true;
                            }
                        }
                    }
                }
            }
        }

        private void b25_Click(object sender, EventArgs e)
        {
            Dictionary<float, String> datosFinal = new Dictionary<float, String>();
            if (cp == 0 && cl == 0 && cc == 0)
            {
                datosFinal = cargarDatos();
                datosFinal = resolver(datosFinal, profundidad(datosFinal));

                foreach (var datos1 in datosFinal)
                {
                    Visor2.Text = datos1.Value.ToString();
                }
                reinicio = true;
            }else
            {
                MessageBox.Show("Debe completar la formula.");
            }
        }
        Dictionary<float, String> cargarDatos()
        {
            bool carga = true;
            int j = 0;
            int a = 0;
            int max = 0;
            String contenedor = "";
            String Formula = Visor1.Text;
            Dictionary<float, String> datos = new Dictionary<float, String>();
            char[] datosChar = new char[Formula.Length];
            datosChar = Formula.ToCharArray();
            i = 0;
            foreach (char dato in datosChar)
            {
                if (dato.Equals('(') == false && dato.Equals(')') == false && dato.Equals('{') == false && dato.Equals('}') == false && dato.Equals('[') == false && dato.Equals(']') == false && dato.Equals('+') == false && dato.Equals('-') == false && dato.Equals('*') == false && dato.Equals('/') == false)
                {
                    if (max <= 20)
                    {
                        contenedor += dato;
                        carga = false;
                    }
                    max++;
                    
                }
                if (carga == false && (dato.Equals('(') == true || dato.Equals('[') == true || dato.Equals('{') == true || dato.Equals(')') == true || dato.Equals(']') == true || dato.Equals('}') == true || dato.Equals('+') == true || dato.Equals('-') == true || dato.Equals('/') == true || dato.Equals('*') == true))
                {
                    datos.Add(a, contenedor.ToString());
                    contenedor = "";
                    max = 0;
                    carga = true;
                    a++;
                }
                if (dato.Equals('('))
                {
                    datos.Add(a, "(");
                    a++;
                }
                else
                {
                    if (dato.Equals(')'))
                    {

                        datos.Add(a, ")");
                        a++;
                    }
                    else
                    {
                        if (dato.Equals('['))
                        {
                            datos.Add(a, "[");
                            a++;
                        }
                        else
                        {
                            if (dato.Equals(']'))
                            {
                                datos.Add(a, "]");
                                a++;
                            }
                            else
                            {
                                if (dato.Equals('{'))
                                {
                                    datos.Add(a, "{");
                                    a++;
                                }
                                else
                                {
                                    if (dato.Equals('}'))
                                    {
                                        datos.Add(a, "}");
                                        a++;
                                    }
                                    else
                                    {
                                        if (dato.Equals('+'))
                                        {
                                            datos.Add(a, "+");
                                            a++;
                                        }
                                        else
                                        {
                                            if (dato.Equals('-'))
                                            {
                                                if (a > 0)
                                                {
                                                    if (datos[a - 1].Equals("*") || datos[a - 1].Equals("/") || datos[a - 1].Equals("+")
                                                     || datos[a - 1].Equals("(") || datos[a - 1].Equals("[") || datos[a - 1].Equals("{")
                                                     || datos[a - 1].Equals(")") || datos[a - 1].Equals("]") || datos[a - 1].Equals("}"))
                                                    {
                                                        contenedor += dato;
                                                    }
                                                    else
                                                    {
                                                        datos.Add(a, "-");
                                                        a++;
                                                    }
                                                }
                                                else
                                                {
                                                    contenedor += dato;
                                                }
                                            }
                                            else
                                            {
                                                if (dato.Equals('*'))
                                                {
                                                    datos.Add(a, "*");
                                                    a++;
                                                }
                                                else
                                                {
                                                    if (dato.Equals('/'))
                                                    {
                                                        datos.Add(a, "/");
                                                        a++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }             
                if (carga==false && i+1 == datosChar.Length)
                {
                    datos.Add(a, contenedor.ToString());
                    contenedor = "";
                    carga = true;
                    max = 0;
                    a++;
                }
                i++;
            }
            i = 0;
            a = 0;
            return datos;
        }
        List<float> profundidad(Dictionary<float,String> datos)
        {
            int p = 0;
            int pTemp = 0;
            pTotal = 0;
            List<float> profundidad = new List<float>();
            foreach (var datos1 in datos)
            {
                if (datos1.Value.Equals("(") == true || datos1.Value.Equals("[") == true || datos1.Value.Equals("{") == true)
                {
                    p++;
                    if (pmax < p)
                    {
                        pmax = p;
                    }
                }
                else
                {
                    if (datos1.Value.Equals(")") == true || datos1.Value.Equals("]") == true || datos1.Value.Equals("}") == true)
                    {
                        if (pTemp == 1)
                        {
                            p--;
                        }
                        pTemp = 1;
                    }else
                    {
                        if (pTemp == 1)
                        {
                            p--;
                        }
                        pTemp = 0;
                    }
                }
                if (p < pmin || pmin==-1)
                {
                    pmin = p;
                }
                profundidad.Add(p);
                pTotal++;
                
            }
            return profundidad;
        }
        Dictionary<float, string> resolver(Dictionary<float, String> datos,List<float> p)
        {
            int r = 0;
            int dPos = -1;
            ArrayList expTemp = new ArrayList();
            ArrayList Vacia = new ArrayList();
            Boolean op = false;
            float totalTemp = 0;
                while (r < p.Count()) 
                {
                
                if (p[r] == pmax)
                {
                    if (datos[r].Equals("(") == false && datos[r].Equals(")") == false && datos[r].Equals("[") == false && datos[r].Equals("]") == false && datos[r].Equals("{") == false && datos[r].Equals("}") == false)
                    {
                        
                        if (r == 0)
                        {
                            expTemp.Add(float.Parse(datos[r].ToString()));
                        }

                            if (r != 0 && datos[r - 1].Equals("+") == true && datos[r].Equals("?") == false)
                            {
                                expTemp.Add("+");
                                expTemp.Add(float.Parse(datos[r].ToString()));
                                
                            }

                            if (r != 0 && datos[r - 1].Equals("-") == true && datos[r].Equals("?") == false)
                            {
                                expTemp.Add("-");
                                expTemp.Add(float.Parse(datos[r].ToString()));
                                
                            }
                            if (r != 0 && datos[r - 1].Equals("*") == true && datos[r].Equals("?")==false)
                            {
                            expTemp.Add("*");
                                expTemp.Add(float.Parse(datos[r].ToString()));
                            }

                            if (r!=0 && datos[r - 1].Equals("/") == true && datos[r].Equals("?") == false)
                            {
                                expTemp.Add("/");
                                expTemp.Add(float.Parse(datos[r].ToString()));
                                
                            }

                        if ( expTemp.Count == 0 && (datos[r].Equals("+") == false && datos[r].Equals("-") == false && datos[r].Equals("*") == false && datos[r].Equals("/") == false && datos[r].Equals("?") == false))
                        {
                            expTemp.Add(float.Parse(datos[r].ToString()));
                        }
                        try
                        {
                            if (!float.IsNaN(float.Parse(datos[r-1].ToString())) && !float.IsNaN(float.Parse(datos[r].ToString())))
                            {
                                expTemp.Add("+");
                                expTemp.Add(float.Parse(datos[r].ToString()));
                            }
                        }
                        catch (Exception m)
                        {
                            Console.WriteLine(m);
                        }
                    }
                    else
                    {
                        if (datos[r].Equals(")") || datos[r].Equals("]") || datos[r].Equals("}"))
                        {
                            datos.Remove(r);
                        }
                        else
                        {
                            datos[r] = "?";
                            if (dPos == -1)
                            {
                                dPos = r;
                            }
                        }
                        }
                }
                else
                {
                    if (expTemp.Count > 0)
                    {
                        datos[r - 1] = resolverDentro(expTemp);
                        for (int j = dPos; j < r-1; j++)
                        {
                            datos.Remove(j);
                        }
                        totalTemp = 0;
                        for (int i = 0; i <= expTemp.Count; i++)
                        {
                            expTemp.Remove(i);
                        }
                        Dictionary<float, String> datosCopia = new Dictionary<float, String>();
                        int contador = 0;
                        foreach (var item in datos)
                        {
                            datosCopia.Add(contador, item.Value.ToString());
                            contador++;
                        }
                        contador = 0;
                        datos = datosCopia;
                        p = profundidad(datos);
                        expTemp = null;
                        expTemp = new ArrayList();
                        r = 0;
                        dPos = -1;
                    }
                }
                if ( expTemp.Count != 0 && p.Count==r+1)
                {
                    datos[r] = resolverDentro(expTemp);
                    for (int j = dPos; j < r; j++)
                    {
                        datos.Remove(j);
                    }
                    totalTemp = 0;
                    for (int i = 0; i <= expTemp.Count; i++)
                    {
                        expTemp.RemoveAt(i);
                    }
                    Dictionary<float, String> datosCopia = new Dictionary<float, String>();
                    int contador = 0;
                    foreach (var item in datos)
                    {
                        datosCopia.Add(contador, item.Value.ToString());
                        contador++;
                    }
                    contador = 0;
                    datos = datosCopia;
                    p = profundidad(datos);
                    expTemp = null;
                    expTemp = new ArrayList();
                    r = 0;
                    dPos = -1;
                }
                if (p.Count == r + 1 )
                {
                    Dictionary<float, String> datosCopia = new Dictionary<float, String>();
                    int contador = 0;
                    foreach (var item in datos)
                    {
                        datosCopia.Add(contador, item.Value.ToString());
                        contador++;
                    }
                    contador = 0;
                    datos = datosCopia;
                    p = profundidad(datos);
                    expTemp = null;
                    expTemp = new ArrayList();
                    if (pmax >= 1)
                    {
                        pmax--;
                    }
                    r = 0;
                }
                else
                {
                    r++;
                }
                if (datos.Count==1)
                {   
                    break;
                }
            }
            return datos;
        }
        String resolverDentro(ArrayList expTemp)
        {
            float total = 0;
            do
            {
                    for (int z = 0; z < expTemp.Count; z++)
                    {
                        if (expTemp.Count == 1)
                        {
                            break;
                        }
                        if (expTemp[z].Equals("/"))
                        {
                            total = float.Parse(expTemp[z - 1].ToString()) / float.Parse(expTemp[z + 1].ToString());
                            expTemp[z - 1] = total.ToString();
                            total = 0;
                            expTemp.RemoveAt(z + 1);
                            expTemp.RemoveAt(z);
                            z = 0;
                        }
                        if (expTemp.Count == 1)
                        {
                            break;
                        }
                        if (expTemp[z].Equals("*"))
                        {
                            total = float.Parse(expTemp[z - 1].ToString()) * float.Parse(expTemp[z + 1].ToString());
                            expTemp[z - 1] = total.ToString();
                            total = 0;
                            expTemp.RemoveAt(z + 1);
                            expTemp.RemoveAt(z);
                            z = 0;
                        }
                        if (expTemp.Count == z)
                        {
                            break;
                        }
                    }
                    for (int z = 0; z < expTemp.Count; z++)
                    {
                        if (expTemp.Count == 1)
                        {
                            break;
                        }
                        if (expTemp[z].Equals("+"))
                        {
                            total = float.Parse(expTemp[z - 1].ToString()) + float.Parse(expTemp[z + 1].ToString());
                            expTemp[z - 1] = total.ToString();
                            total = 0;
                            expTemp.RemoveAt(z + 1);
                            expTemp.RemoveAt(z);
                        z = 0;
                        }
                        if (expTemp.Count == 1)
                        {
                            break;
                        }
                        if (expTemp[z].Equals("-"))
                        {
                            total = float.Parse(expTemp[z - 1].ToString()) - float.Parse(expTemp[z + 1].ToString());
                            expTemp[z - 1] = total.ToString();
                            total = 0;
                            expTemp.RemoveAt(z + 1);
                            expTemp.RemoveAt(z);
                        z = 0;

                        }
                        if (expTemp.Count == z)
                        {
                            break;
                        }
                        
                    }

            } while (expTemp.Count != 1);

            return expTemp[0].ToString();
        }

        private void b26_Click(object sender, EventArgs e)
        {
            reiniciar();
            masMenos();
        }

        private void ChangeControlStyles(Control ctrl, ControlStyles flag, bool value)
        {
            MethodInfo method = ctrl.GetType().GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            if (method != null)
                method.Invoke(ctrl, new object[] { flag, value });
        }
        private void masMenos()
        {
            if (Visor1.Text != "0")
            {
                for (int h = tecla.Count - 1; h >= -1; h--)
                {

                    if (h >= 0)
                    {
                        char l = Char.Parse(tecla[h].ToString());
                        if (!Char.IsDigit(l) && !l.Equals(','))
                        {

                            if (l == '+')
                            {
                                tecla[h] = "-";
                                break;
                            }
                            else if (l == '-')
                            {
                                if (h > 0)
                                {
                                    char l2 = Char.Parse(tecla[h - 1].ToString());
                                    if (Char.IsDigit(l2))
                                    {
                                        tecla[h] = "+";
                                        break;
                                    }
                                    else
                                    {
                                        tecla.RemoveAt(h);
                                        agregarSigno = true;
                                        i -= 1;
                                        break;
                                    }
                                }
                                else
                                {
                                    tecla.RemoveAt(h);
                                    agregarSigno = true;
                                    i -= 1;
                                    break;
                                }
                            }
                            else
                            {
                                tecla.Insert(h + 1, "-");
                                i += 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        tecla.Insert(0, "-");
                        i += 1;
                        break;
                    }
                }
                Visor1.Text = "";
                for (int i = 0; i < tecla.Count; i++)
                {
                    Visor1.Text += tecla[i].ToString();
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    b10_Click(sender, e);
                    break;
                case '1':
                    b7_Click(sender, e);
                    break;
                case '2':
                    b8_Click(sender, e);
                    break;
                case '3':
                    b9_Click(sender, e);
                    break;
                case '4':
                    b4_Click(sender, e);
                    break;
                case '5':
                    b5_Click(sender, e);
                    break;
                case '6':
                    b6_Click(sender, e);
                    break;
                case '7':
                    b1_Click(sender, e);
                    break;
                case '8':
                    b2_Click(sender, e);
                    break;
                case '9':
                    b3_Click(sender, e);
                    break;
                case ',':
                    b11_Click(sender, e);
                    break;
                case '-':
                    b18_Click(sender, e);
                    break;
                case '+':
                    b17_Click(sender, e);
                    break;
                case '*':
                    b15_Click(sender, e);
                    break;
                case '/':
                    b16_Click(sender, e);
                    break;
                case '(':
                    b19_Click(sender, e);
                    break;
                case ')':
                    b20_Click(sender, e);
                    break;
                case '[':
                    b21_Click(sender, e);
                    break;
                case ']':
                    b22_Click(sender, e);
                    break;
                case '{':
                    b23_Click(sender, e);
                    break;
                case '}':
                    b24_Click(sender, e);
                    break;
                case '=':
                    b25_Click(sender, e);
                    break;
                case '\u0008':
                    b14_Click(sender, e);
                    break;
                case '\u001B':
                    b13_Click(sender, e);
                    break;
                default:
                    break;
            }
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Visor1_TextChanged(object sender, EventArgs e)
        {
            Visor1.SelectionStart = Visor1.Text.Length;

            Visor1.ScrollToCaret();
        }

        private void Visor1_Enter(object sender, EventArgs e)
        {
            Focus();
        }
    }
}