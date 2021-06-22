using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086_Paweł_Kęska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AX1.Text = "0000";
            AX2.Text = "0000";
            BX1.Text = "0000";
            BX2.Text = "0000";
            CX1.Text = "0000";
            CX2.Text = "0000";
            DX1.Text = "0000";
            DX2.Text = "0000";
            SI1.Text = "0000";
            SI2.Text = "0000";
            DI1.Text = "0000";
            DI2.Text = "0000";
            BP1.Text = "0000";
            BP2.Text = "0000";
            DISP1.Text = "0000";
            DISP2.Text = "0000";
            SP1.Text = "0000";
            SP2.Text = "0000";

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = "00";
            }

            int liczbaMaksymalnaPol = 4;
            AX1.MaxLength = liczbaMaksymalnaPol;
            AX2.MaxLength = liczbaMaksymalnaPol;
            BX1.MaxLength = liczbaMaksymalnaPol;
            BX2.MaxLength = liczbaMaksymalnaPol;
            CX2.MaxLength = liczbaMaksymalnaPol;
            CX1.MaxLength = liczbaMaksymalnaPol;
            DX1.MaxLength = liczbaMaksymalnaPol;
            DX2.MaxLength = liczbaMaksymalnaPol;
            SI1.MaxLength = liczbaMaksymalnaPol;
            SI2.MaxLength = liczbaMaksymalnaPol;
            DI2.MaxLength = liczbaMaksymalnaPol;
            DI1.MaxLength = liczbaMaksymalnaPol;
            BP1.MaxLength = liczbaMaksymalnaPol;
            BP2.MaxLength = liczbaMaksymalnaPol;
            DISP1.MaxLength = liczbaMaksymalnaPol;
            DISP2.MaxLength = liczbaMaksymalnaPol;
            SP1.MaxLength = liczbaMaksymalnaPol;
            SP2.MaxLength = liczbaMaksymalnaPol;




        }
        int wskaznikLiczba = 0;
        string[] tablica = new string[65535];
        Stack<string> stos = new Stack<string>();
        


        public void Wskaznik()
        {
            string wskaznikStosu2 = wskaznikLiczba.ToString("X");


            if (wskaznikStosu2.Length == 3)
            {
                SP1.Text = "0" + wskaznikStosu2;
            }
            if (wskaznikStosu2.Length == 2)
            {
                SP1.Text = "00" + wskaznikStosu2;
            }
            if (wskaznikStosu2.Length == 1)
            {
                SP1.Text = "000" + wskaznikStosu2;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            AX1.Text = "0000";
            BX1.Text = "0000";
            CX1.Text = "0000";
            DX1.Text = "0000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SI1.Text = "0000";
            DI1.Text = "0000";
            BP1.Text = "0000";
            DISP1.Text = "0000";
            SP1.Text = "0000";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BX1.Text = AX1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CX1.Text = AX1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DX1.Text = AX1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AX1.Text = BX1.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CX1.Text = BX1.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DX1.Text = BX1.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AX1.Text = CX1.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BX1.Text = CX1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DX1.Text = CX1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AX1.Text = DX1.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            BX1.Text = DX1.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CX1.Text = DX1.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string zamiana = BX1.Text;
            BX1.Text = AX1.Text;
            AX1.Text = zamiana;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string zamiana = CX1.Text;
            CX1.Text = AX1.Text;
            AX1.Text = zamiana;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string zamiana = DX1.Text;
            DX1.Text = AX1.Text;
            AX1.Text = zamiana;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string zamiana = AX1.Text;
            AX1.Text = BX1.Text;
            BX1.Text = zamiana;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string zamiana = CX1.Text;
            CX1.Text = BX1.Text;
            BX1.Text = zamiana;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string zamiana = DX1.Text;
            DX1.Text = BX1.Text;
            BX1.Text = zamiana;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string zamiana = AX1.Text;
            AX1.Text = CX1.Text;
            CX1.Text = zamiana;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string zamiana = BX1.Text;
            BX1.Text = CX1.Text;
            CX1.Text = zamiana;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string zamiana = DX1.Text;
            DX1.Text = CX1.Text;
            CX1.Text = zamiana;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string zamiana = AX1.Text;
            AX1.Text = DX1.Text;
            DX1.Text = zamiana;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string zamiana = BX1.Text;
            BX1.Text = DX1.Text;
            DX1.Text = zamiana;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string zamiana = CX1.Text;
            CX1.Text = DX1.Text;
            DX1.Text = zamiana;
        }



        private void AX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AX1.Text = AX2.Text;
        }

        private void BX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BX1.Text = BX2.Text;
        }

        private void CX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CX1.Text = CX2.Text;
        }

        private void DX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DX1.Text = DX2.Text;
        }

        private void SI2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SI1.Text = SI2.Text;
        }

        private void DI2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DI1.Text = DI2.Text;

        }

        private void BP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BP1.Text = BP2.Text;
        }

        private void SP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                

            wskaznikLiczba = Convert.ToInt32(SP2.Text,16);

            SP1.Text = wskaznikLiczba.ToString("X");
        }

        private void DISP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DISP1.Text = DISP2.Text;
        }

        private void AX2_TextChanged(object sender, EventArgs e)
        {
            string textbox = AX2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                AX2.Text = textbox.Remove(textbox.Length - 1, 1);
                AX2.SelectionStart = AX2.Text.Length;
            }
        }

        private void BX2_TextChanged(object sender, EventArgs e)
        {
            string textbox = BX2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                BX2.Text = textbox.Remove(textbox.Length - 1, 1);
                BX2.SelectionStart = BX2.Text.Length;
            }
        }

        private void CX2_TextChanged(object sender, EventArgs e)
        {
            string textbox = CX2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                CX2.Text = textbox.Remove(textbox.Length - 1, 1);
                CX2.SelectionStart = CX2.Text.Length;
            }
        }

        private void DX2_TextChanged(object sender, EventArgs e)
        {
            string textbox = DX2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                DX2.Text = textbox.Remove(textbox.Length - 1, 1);
                DX2.SelectionStart = DX2.Text.Length;
            }
        }

        private void SI2_TextChanged(object sender, EventArgs e)
        {
            string textbox = SI2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                SI2.Text = textbox.Remove(textbox.Length - 1, 1);
                SI2.SelectionStart = SI2.Text.Length;
            }
        }

        private void DI2_TextChanged(object sender, EventArgs e)
        {
            string textbox = DI2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                DI2.Text = textbox.Remove(textbox.Length - 1, 1);
                DI2.SelectionStart = DI2.Text.Length;
            }
        }

        private void BP2_TextChanged(object sender, EventArgs e)
        {
            string textbox = BP2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                BP2.Text = textbox.Remove(textbox.Length - 1, 1);
                BP2.SelectionStart = BP2.Text.Length;
            }
        }

        private void SP2_TextChanged(object sender, EventArgs e)
        {
            string textbox = SP2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                SP2.Text = textbox.Remove(textbox.Length - 1, 1);
                SP2.SelectionStart = SP2.Text.Length;
            }
        }

        private void DISP2_TextChanged(object sender, EventArgs e)
        {
            string textbox = DISP2.Text;
            int n = 0;
            if (!int.TryParse(textbox, System.Globalization.NumberStyles.HexNumber, System.Globalization.NumberFormatInfo.CurrentInfo, out n) &&
              textbox != String.Empty)
            {
                DISP2.Text = textbox.Remove(textbox.Length - 1, 1);
                DISP2.SelectionStart = DISP2.Text.Length;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string rejAX = "";
            string rejBX = "";
            string rejCX = "";
            string rejDX = "";

            int axWartosc = rnd.Next(0, 65535);
            rejAX = axWartosc.ToString("X");
            int bxWartosc = rnd.Next(0, 65535);
            rejBX = bxWartosc.ToString("X");
            int cxWartosc = rnd.Next(0, 65535);
            rejCX = cxWartosc.ToString("X");
            int dxWartosc = rnd.Next(0, 65535);
            rejDX = dxWartosc.ToString("X");

            if (rejAX.Length == 3)
                {
                    rejAX = "0" + rejAX;
                }
            if (rejAX.Length == 2)
                {
                    rejAX = "00" + rejAX;
                }
            if (rejAX.Length == 1)
            {
                rejAX = "000" + rejAX;
            }
            if (rejBX.Length == 3)
            {
                rejBX = "0" + rejBX;
            }
            if (rejBX.Length == 2)
            {
                rejBX = "00" + rejBX;
            }
            if (rejBX.Length == 1)
            {
                rejBX = "000" + rejBX;
            }
            if (rejCX.Length == 3)
            {
                rejCX = "0" + rejCX;
            }
            if (rejCX.Length == 2)
            {
                rejCX = "00" + rejCX;
            }
            if (rejCX.Length == 1)
            {
                rejCX = "000" + rejCX;
            }
            if (rejDX.Length == 3)
            {
                rejDX = "0" + rejDX;
            }
            if (rejDX.Length == 2)
            {
                rejDX = "00" + rejDX;
            }
            if (rejDX.Length == 1)
            {
                rejDX = "000" + rejDX;
            }


            AX1.Text = rejAX;
            AX2.Text = rejAX;
            BX1.Text = rejBX;
            BX2.Text = rejBX;
            CX1.Text = rejCX;
            CX2.Text = rejCX;
            DX1.Text = rejDX;
            DX2.Text = rejDX;
        }


        public void AdresowanieDla2(string x, string y,string z)
        {
            int adres1 = Convert.ToInt32(x, 16);
            int adres2 = Convert.ToInt32(y, 16);
            int adres = adres1 + adres2;
            

            if (adres < 65535)
            {
                tablica[adres] = DwaPierwsze(z);
                tablica[adres + 1] = DwaOstatnie(z);
            }
            else
            {
                tablica[65533] = DwaPierwsze(z);
                tablica[65534] = DwaOstatnie(z);
            }            

        }
        public void AdresowanieDla3(string a, string b, string c,string z)
        {
            int adres1 = Convert.ToInt32(a, 16);
            int adres2 = Convert.ToInt32(b, 16);
            int adres3 = Convert.ToInt32(c, 16);
            int adres = adres1 + adres2+adres3;


            if (adres < 65535)
            {
                tablica[adres] = DwaOstatnie(z);
                tablica[adres + 1] = DwaPierwsze(z);
            }
            else
            {
                tablica[65533] = DwaPierwsze(z);
                tablica[65534] = DwaOstatnie(z);
            }
        }
        public string DwaPierwsze(string x)
        {
            string y = x.Substring(0, 2);
            return y;
        }
        public string DwaOstatnie(string x)
        {
            string y = x.Substring(2, 2);
            return y;

        }
        public void AdresowanieOdwrotneDla2(string a,string b)
        {
            int adres1 = Convert.ToInt32(a, 16);
            int adres2 = Convert.ToInt32(b, 16);
            int adres = adres1 + adres2;
            if (adres < 65535)
            {
                string jeden = tablica[adres];
                string dwa = tablica[adres + 1];
                string oba = jeden + dwa;
                if(ax.Checked)
                {
                    AX1.Text = oba;
                }
                else if(bx.Checked)
                {
                    BX1.Text = oba;
                }
                else if(cx.Checked)
                {
                    CX1.Text = oba;
                }
                else if(dx.Checked)
                {
                    DX1.Text = oba;
                }
                

            }
            else
            {
                string jeden = tablica[65533];
                string dwa = tablica[65534];
                string oba = jeden + dwa;
                if (ax.Checked)
                {
                    AX1.Text = oba;
                }
                else if (bx.Checked)
                {
                    BX1.Text = oba;
                }
                else if (cx.Checked)
                {
                    CX1.Text = oba;
                }
                else if (dx.Checked)
                {
                    DX1.Text = oba;
                }
            }

        }
        

        

     
        public void AdresowanieOdwrotneDla3(string a,string b,string c)
        {
            int adres1 = Convert.ToInt32(a, 16);
            int adres2 = Convert.ToInt32(b, 16);
            int adres3 = Convert.ToInt32(c, 16);
            int adres = adres1 + adres2 + adres3;
            if (adres < 65535)
            {
                string jeden = tablica[adres] ;
                string dwa = tablica[adres+1] ;
                string oba = jeden + dwa;
                if (ax.Checked)
                {
                    AX1.Text = oba;
                }
                else if (bx.Checked)
                {
                    BX1.Text = oba;
                }
                else if (cx.Checked)
                {
                    CX1.Text = oba;
                }
                else if (dx.Checked)
                {
                    DX1.Text = oba;
                }

            }
            else
            {
                string jeden = tablica[65533];
                string dwa = tablica[65534];
                string oba = jeden + dwa;
                if (ax.Checked)
                {
                    AX1.Text = oba;
                }
                else if (bx.Checked)
                {
                    BX1.Text = oba;
                }
                else if (cx.Checked)
                {
                    CX1.Text = oba;
                }
                else if (dx.Checked)
                {
                    DX1.Text = oba;
                }
            }


        }
        public void XCHGPamiecDla2(string a, string b,string z)
        {
            
                int adres1 = Convert.ToInt32(a, 16);
                int adres2 = Convert.ToInt32(b, 16);
                int adres = adres1 + adres2;


                if (adres < 65535)
                {
                string jeden = tablica[adres];
                string dwa = tablica[adres + 1];
                string oba = jeden + dwa;
                tablica[adres] = DwaPierwsze(z);
                tablica[adres + 1] = DwaOstatnie(z);
                if (ax.Checked)
                {
                    AX1.Text = oba;
                }
                else if (bx.Checked)
                {
                    BX1.Text = oba;
                }
                else if (cx.Checked)
                {
                    CX1.Text = oba;
                }
                else if (dx.Checked)
                {
                    DX1.Text = oba;
                }
            }
                else
                {
                string jeden = tablica[65533];
                string dwa = tablica[65534];
                string oba = jeden + dwa;
                tablica[65533] = DwaPierwsze(z);
                tablica[65534] = DwaOstatnie(z);

                if (ax.Checked)
                {
                    AX1.Text = oba;
                }
                else if (bx.Checked)
                {
                    BX1.Text = oba;
                }
                else if (cx.Checked)
                {
                    CX1.Text = oba;
                }
                else if (dx.Checked)
                {
                    DX1.Text = oba;
                }
            }
        }
        public void XCHGPamiecDla3(string a, string b,string c,string z)
        {
            
                int adres1 = Convert.ToInt32(a, 16);
                int adres2 = Convert.ToInt32(b, 16);
                int adres3 = Convert.ToInt32(c, 16);
                int adres = adres1 + adres2+adres3;


                if (adres < 65535)
                {
                string jeden = tablica[adres];
                string dwa = tablica[adres + 1];
                string oba = jeden + dwa;
                tablica[adres] = DwaPierwsze(z);
                tablica[adres + 1] = DwaOstatnie(z);
                if (ax.Checked)
                {
                    AX1.Text = oba;
                }
                else if (bx.Checked)
                {
                    BX1.Text = oba;
                }
                else if (cx.Checked)
                {
                    CX1.Text = oba;
                }
                else if (dx.Checked)
                {
                    DX1.Text = oba;
                }
            }
                else
                {
                string jeden = tablica[65533];
                string dwa = tablica[65534];
                string oba = jeden + dwa;
                tablica[65533] = DwaPierwsze(z);
                tablica[65534] = DwaOstatnie(z);

                if (ax.Checked)
                {
                    AX1.Text = oba;
                }
                else if (bx.Checked)
                {
                    BX1.Text = oba;
                }
                else if (cx.Checked)
                {
                    CX1.Text = oba;
                }
                else if (dx.Checked)
                {
                    DX1.Text = oba;
                }
            }
        }

            

        
        

        private void button5_Click(object sender, EventArgs e)
        {
            {
                    if (rejestrpamiec.Checked && indeksowy.Checked && si.Checked && ax.Checked)
                {
                    AdresowanieDla2(SI1.Text, DISP1.Text, AX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowy.Checked && si.Checked && bx.Checked)
                {
                    AdresowanieDla2(SI1.Text, DISP1.Text, BX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowy.Checked && si.Checked && cx.Checked)
                {
                    AdresowanieDla2(SI1.Text, DISP1.Text, CX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowy.Checked && si.Checked && dx.Checked)
                {
                    AdresowanieDla2(SI1.Text, DISP1.Text, DX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowy.Checked && di.Checked && ax.Checked)
                {
                    AdresowanieDla2(DI1.Text, DISP1.Text, AX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowy.Checked && di.Checked && bx.Checked)
                {
                    AdresowanieDla2(DI1.Text, DISP1.Text, BX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowy.Checked && di.Checked && cx.Checked)
                {
                    AdresowanieDla2(DI1.Text, DISP1.Text, CX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowy.Checked && di.Checked && dx.Checked)
                {
                    AdresowanieDla2(DI1.Text, DISP1.Text, DX1.Text);
                }
                else if (rejestrpamiec.Checked && bazowy.Checked && bp.Checked && dx.Checked)
                {
                    AdresowanieDla2(BP1.Text, DISP1.Text, DX1.Text);
                }
                else if (rejestrpamiec.Checked && bazowy.Checked && bp.Checked && ax.Checked)
                {
                    AdresowanieDla2(BP1.Text, DISP1.Text, AX1.Text);
                }
                else if (rejestrpamiec.Checked && bazowy.Checked && bp.Checked && bx.Checked)
                {
                    AdresowanieDla2(BP1.Text, DISP1.Text, BX1.Text);
                }
                else if (rejestrpamiec.Checked && bazowy.Checked && bp.Checked && cx.Checked)
                {
                    AdresowanieDla2(BP1.Text, DISP1.Text, CX1.Text);
                }
                else if (rejestrpamiec.Checked && bazowy.Checked && bxdwa.Checked && cx.Checked)
                {
                    AdresowanieDla2(BX1.Text, DISP1.Text, CX1.Text);
                }
                else if (rejestrpamiec.Checked && bazowy.Checked && bxdwa.Checked && ax.Checked)
                {
                    AdresowanieDla2(BX1.Text, DISP1.Text, AX1.Text);
                }
                else if (rejestrpamiec.Checked && bazowy.Checked && bxdwa.Checked && dx.Checked)
                {
                    AdresowanieDla2(BX1.Text, DISP1.Text, DX1.Text);
                }
                else if (rejestrpamiec.Checked && bazowy.Checked && bxdwa.Checked && bx.Checked)
                {
                    AdresowanieDla2(BX1.Text, DISP1.Text, BX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && sibx.Checked && ax.Checked)
                {
                    AdresowanieDla3(BX1.Text,SI1.Text, DISP1.Text, AX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && sibx.Checked && bx.Checked)
                {
                    AdresowanieDla3(BX1.Text, SI1.Text, DISP1.Text, BX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && sibx.Checked && cx.Checked)
                {
                    AdresowanieDla3(BX1.Text, SI1.Text, DISP1.Text, CX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && sibx.Checked && dx.Checked)
                {
                    AdresowanieDla3(BX1.Text, SI1.Text, DISP1.Text, DX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && sibp.Checked && ax.Checked)
                {
                    AdresowanieDla3(BP1.Text, SI1.Text, DISP1.Text, AX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && sibp.Checked && bx.Checked)
                {
                    AdresowanieDla3(BP1.Text, SI1.Text, DISP1.Text, BX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && sibp.Checked && cx.Checked)
                {
                    AdresowanieDla3(BP1.Text, SI1.Text, DISP1.Text, CX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && sibp.Checked && dx.Checked)
                {
                    AdresowanieDla3(BP1.Text, SI1.Text, DISP1.Text, DX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && dibp.Checked && dx.Checked)
                {
                    AdresowanieDla3(BP1.Text, DI1.Text, DISP1.Text, DX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && dibp.Checked && ax.Checked)
                {
                    AdresowanieDla3(BP1.Text, DI1.Text, DISP1.Text, AX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && dibp.Checked && cx.Checked)
                {
                    AdresowanieDla3(BP1.Text, DI1.Text, DISP1.Text, CX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && dibp.Checked && bx.Checked)
                {
                    AdresowanieDla3(BP1.Text, DI1.Text, DISP1.Text, BX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && dibx.Checked && bx.Checked)
                {
                    AdresowanieDla3(BX1.Text, DI1.Text, DISP1.Text, BX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && dibx.Checked && ax.Checked)
                {
                    AdresowanieDla3(BX1.Text, DI1.Text, DISP1.Text, AX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && dibx.Checked && cx.Checked)
                {
                    AdresowanieDla3(BX1.Text, DI1.Text, DISP1.Text, CX1.Text);
                }
                else if (rejestrpamiec.Checked && indeksowobazowy.Checked && dibx.Checked && dx.Checked)
                {
                    AdresowanieDla3(BX1.Text, DI1.Text, DISP1.Text, DX1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowy.Checked && si.Checked && ax.Checked)
                {
                    AdresowanieOdwrotneDla2(SI1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowy.Checked && si.Checked && bx.Checked)
                {
                    AdresowanieOdwrotneDla2(SI1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowy.Checked && si.Checked && cx.Checked)
                {
                    AdresowanieOdwrotneDla2(SI1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowy.Checked && si.Checked && dx.Checked)
                {
                    AdresowanieOdwrotneDla2(SI1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowy.Checked && di.Checked && ax.Checked)
                {
                    AdresowanieOdwrotneDla2(DI1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowy.Checked && di.Checked && bx.Checked)
                {
                    AdresowanieOdwrotneDla2(DI1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowy.Checked && di.Checked && cx.Checked)
                {
                    AdresowanieOdwrotneDla2(DI1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowy.Checked && di.Checked && dx.Checked)
                {
                    AdresowanieOdwrotneDla2(DI1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && bazowy.Checked && bp.Checked && dx.Checked)
                {
                    AdresowanieOdwrotneDla2(BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && bazowy.Checked && bp.Checked && ax.Checked)
                {
                    AdresowanieOdwrotneDla2(BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && bazowy.Checked && bp.Checked && bx.Checked)
                {
                    AdresowanieOdwrotneDla2(BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && bazowy.Checked && bp.Checked && cx.Checked)
                {
                    AdresowanieOdwrotneDla2(BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && bazowy.Checked && bxdwa.Checked && cx.Checked) 
                {
                    AdresowanieOdwrotneDla2(BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && bazowy.Checked && bxdwa.Checked && ax.Checked)
                {
                    AdresowanieOdwrotneDla2(BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && bazowy.Checked && bxdwa.Checked && dx.Checked)
                {
                    AdresowanieOdwrotneDla2(BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && bazowy.Checked && bxdwa.Checked && bx.Checked)
                {
                    AdresowanieOdwrotneDla2(BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && sibx.Checked && ax.Checked)
                {
                    AdresowanieOdwrotneDla3(SI1.Text,BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && sibx.Checked && bx.Checked)
                {
                    AdresowanieOdwrotneDla3(SI1.Text, BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && sibx.Checked && cx.Checked)
                {
                    AdresowanieOdwrotneDla3(SI1.Text, BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && sibx.Checked && dx.Checked)
                {
                    AdresowanieOdwrotneDla3(SI1.Text, BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && sibp.Checked && ax.Checked)
                {
                    AdresowanieOdwrotneDla3(SI1.Text, BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && sibp.Checked && bx.Checked)
                {
                    AdresowanieOdwrotneDla3(SI1.Text, BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && sibp.Checked && cx.Checked)
                {
                    AdresowanieOdwrotneDla3(SI1.Text, BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && sibp.Checked && dx.Checked)
                {
                    AdresowanieOdwrotneDla3(SI1.Text, BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && dibp.Checked && dx.Checked)
                {
                    AdresowanieOdwrotneDla3(DI1.Text, BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && dibp.Checked && ax.Checked)
                {
                    AdresowanieOdwrotneDla3(DI1.Text, BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && dibp.Checked && cx.Checked)
                {
                    AdresowanieOdwrotneDla3(DI1.Text, BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && dibp.Checked && bx.Checked)
                {
                    AdresowanieOdwrotneDla3(DI1.Text, BP1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && dibx.Checked && bx.Checked)
                {
                    AdresowanieOdwrotneDla3(DI1.Text, BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && dibx.Checked && ax.Checked)
                {
                    AdresowanieOdwrotneDla3(DI1.Text, BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && dibx.Checked && cx.Checked)
                {
                    AdresowanieOdwrotneDla3(DI1.Text, BX1.Text, DISP1.Text);
                }
                else if (pamiecrejestr.Checked && indeksowobazowy.Checked && dibx.Checked && dx.Checked)
                {
                    AdresowanieOdwrotneDla3(DI1.Text, BX1.Text, DISP1.Text);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (indeksowy.Checked && si.Checked && ax.Checked)
            {
                XCHGPamiecDla2(SI1.Text, DISP1.Text, AX1.Text);
            }
            else if ( indeksowy.Checked && si.Checked && bx.Checked)
            {
                XCHGPamiecDla2(SI1.Text, DISP1.Text, BX1.Text);
            }
            else if (indeksowy.Checked && si.Checked && cx.Checked)
            {
                XCHGPamiecDla2(SI1.Text, DISP1.Text, CX1.Text);
            }
            else if ( indeksowy.Checked && si.Checked && dx.Checked)
            {
                XCHGPamiecDla2(SI1.Text, DISP1.Text, DX1.Text);
            }
            else if ( indeksowy.Checked && di.Checked && ax.Checked)
            {
                XCHGPamiecDla2(DI1.Text, DISP1.Text, AX1.Text);
            }
            else if (indeksowy.Checked && di.Checked && bx.Checked)
            {
                XCHGPamiecDla2(DI1.Text, DISP1.Text, BX1.Text);
            }
            else if ( indeksowy.Checked && di.Checked && cx.Checked)
            {
                XCHGPamiecDla2(DI1.Text, DISP1.Text, CX1.Text);
            }
            else if ( indeksowy.Checked && di.Checked && dx.Checked)
            {
                XCHGPamiecDla2(DI1.Text, DISP1.Text, DX1.Text);
            }
            else if ( bazowy.Checked && bp.Checked && dx.Checked)
            {
                XCHGPamiecDla2(BP1.Text, DISP1.Text, DX1.Text);
            }
            else if (bazowy.Checked && bp.Checked && ax.Checked)
            {
                XCHGPamiecDla2(BP1.Text, DISP1.Text, AX1.Text);
            }
            else if ( bazowy.Checked && bp.Checked && bx.Checked)
            {
                XCHGPamiecDla2(BP1.Text, DISP1.Text, BX1.Text);
            }
            else if ( bazowy.Checked && bp.Checked && cx.Checked)
            {
                XCHGPamiecDla2(BP1.Text, DISP1.Text, CX1.Text);
            }
            else if ( bazowy.Checked && bxdwa.Checked && cx.Checked)
            {
                XCHGPamiecDla2(BX1.Text, DISP1.Text, CX1.Text);
            }
            else if ( bazowy.Checked && bxdwa.Checked && ax.Checked)
            {
                XCHGPamiecDla2(BX1.Text, DISP1.Text, AX1.Text);
            }
            else if ( bazowy.Checked && bxdwa.Checked && dx.Checked)
            {
                XCHGPamiecDla2(BX1.Text, DISP1.Text, DX1.Text);
            }
            else if (bazowy.Checked && bxdwa.Checked && bx.Checked)
            {
                XCHGPamiecDla2(BX1.Text, DISP1.Text, BX1.Text);
            }
            else if ( indeksowobazowy.Checked && sibx.Checked && ax.Checked)
            {
                XCHGPamiecDla3(SI1.Text, BX1.Text, DISP1.Text, AX1.Text);
            }
            else if (indeksowobazowy.Checked && sibx.Checked && bx.Checked)
            {
                XCHGPamiecDla3(SI1.Text, BX1.Text, DISP1.Text, BX1.Text);
            }
            else if (indeksowobazowy.Checked && sibx.Checked && cx.Checked)
            {
                XCHGPamiecDla3(SI1.Text, BX1.Text, DISP1.Text, CX1.Text);
            }
            else if (indeksowobazowy.Checked && sibx.Checked && dx.Checked)
            {
                XCHGPamiecDla3(SI1.Text, BX1.Text, DISP1.Text, DX1.Text);
            }
            else if ( indeksowobazowy.Checked && sibp.Checked && ax.Checked)
            {
                XCHGPamiecDla3(SI1.Text, BP1.Text, DISP1.Text, AX1.Text);
            }
            else if ( indeksowobazowy.Checked && sibp.Checked && bx.Checked)
            {
                XCHGPamiecDla3(SI1.Text, BP1.Text, DISP1.Text, BX1.Text);
            }
            else if (indeksowobazowy.Checked && sibp.Checked && cx.Checked)
            {
                XCHGPamiecDla3(SI1.Text, BP1.Text, DISP1.Text, CX1.Text);
            }
            else if (indeksowobazowy.Checked && sibp.Checked && dx.Checked)
            {
                XCHGPamiecDla3(SI1.Text, BP1.Text, DISP1.Text, DX1.Text);
            }
            else if (indeksowobazowy.Checked && dibp.Checked && dx.Checked)
            {
                XCHGPamiecDla3(DI1.Text, BP1.Text, DISP1.Text, DX1.Text);
            }
            else if (indeksowobazowy.Checked && dibp.Checked && ax.Checked)
            {
                XCHGPamiecDla3(DI1.Text, BP1.Text, DISP1.Text, AX1.Text);
            }
            else if (indeksowobazowy.Checked && dibp.Checked && cx.Checked)
            {
                XCHGPamiecDla3(DI1.Text, BP1.Text, DISP1.Text, CX1.Text);
            }
            else if (indeksowobazowy.Checked && dibp.Checked && bx.Checked)
            {
                XCHGPamiecDla3(DI1.Text, BP1.Text, DISP1.Text, BX1.Text);
            }
            else if (indeksowobazowy.Checked && dibx.Checked && bx.Checked)
            {
                XCHGPamiecDla3(DI1.Text, BX1.Text, DISP1.Text, BX1.Text);
            }
            else if (indeksowobazowy.Checked && dibx.Checked && ax.Checked)
            {
                XCHGPamiecDla3(DI1.Text, BX1.Text, DISP1.Text, AX1.Text);
            }
            else if (indeksowobazowy.Checked && dibx.Checked && cx.Checked)
            {
                XCHGPamiecDla3(DI1.Text, BX1.Text, DISP1.Text, CX1.Text);
            }
            else if (indeksowobazowy.Checked && dibx.Checked && dx.Checked)
            {
                XCHGPamiecDla3(DI1.Text, BX1.Text, DISP1.Text, DX1.Text);
            }
            
        }

        private void button31_Click(object sender, EventArgs e)
        {

            stos.Push(DwaOstatnie(AX1.Text));
            stos.Push(DwaPierwsze(AX1.Text));
            wskaznikLiczba += 2;
            Wskaznik();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            
            stos.Push(DwaOstatnie(BX1.Text));
            stos.Push(DwaPierwsze(BX1.Text));
            wskaznikLiczba += 2;
            Wskaznik();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            
            stos.Push(DwaOstatnie(CX1.Text));
            stos.Push(DwaPierwsze(CX1.Text));
            wskaznikLiczba += 2;
            Wskaznik();
        }

        private void button33_Click(object sender, EventArgs e)
        {

            stos.Push(DwaOstatnie(DX1.Text));
            stos.Push(DwaPierwsze(DX1.Text));
            wskaznikLiczba += 2;
            Wskaznik();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                string mlodszy = stos.Pop();
                string starszy = stos.Pop();
                string laczenie = mlodszy + starszy;
                wskaznikLiczba -= 2;
                Wskaznik();
                AX1.Text = laczenie;
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Pusty stos");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                string mlodszy = stos.Pop();
                string starszy = stos.Pop();
                string laczenie = mlodszy + starszy;
                wskaznikLiczba -= 2;
                Wskaznik();
                BX1.Text = laczenie;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Pusty stos");
            }

        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                string mlodszy = stos.Pop();
                string starszy = stos.Pop();
                string laczenie = mlodszy + starszy;
                wskaznikLiczba -= 2;
                Wskaznik();
                CX1.Text = laczenie;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Pusty stos");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                string mlodszy = stos.Pop();
                string starszy = stos.Pop();
                string laczenie = mlodszy + starszy;
                wskaznikLiczba -= 2;
                Wskaznik();
                DX1.Text = laczenie;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Pusty stos");
            }
        }
    }
}
