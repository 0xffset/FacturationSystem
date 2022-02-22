using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using Entidades;
using System.Windows.Forms;

namespace CapaPresentacion
{
    class AccEnControles
    {
        #region convertirletras
        public string letras(string num)
        {
            string res, dec = "";
            Int64 ent;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch { return ""; }

            ent = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - ent) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }
            if (dec == "") dec = " CON 00/100 ";
            res = numenletras(Convert.ToDouble(ent)) + dec;
            return res;
        }
        private string numenletras(double valor)
        {
            string num2text = "";
            valor = Math.Truncate(valor);
            if (valor == 0) num2text = "CERO";
            else if (valor == 1) num2text = "UNO";
            else if (valor == 2) num2text = "DOS";
            else if (valor == 3) num2text = "TRES";
            else if (valor == 4) num2text = "CUATRO";
            else if (valor == 5) num2text = "CINCO";
            else if (valor == 6) num2text = "SEIS";
            else if (valor == 7) num2text = "SIETE";
            else if (valor == 8) num2text = "OCHO";
            else if (valor == 9) num2text = "NUEVE";
            else if (valor == 10) num2text = "DIES";
            else if (valor == 11) num2text = "ONCE";
            else if (valor == 12) num2text = "DOCE";
            else if (valor == 13) num2text = "TRECE";
            else if (valor == 14) num2text = "CATORCE";
            else if (valor == 15) num2text = "QUINCE";
            else if (valor < 20) num2text = " DIECI " + numenletras(valor - 10);
            else if (valor == 20) num2text = " VEINTE ";
            else if (valor < 30) num2text = " VEINTE " + numenletras(valor - 20);
            else if (valor == 30) num2text = "TREINTA";
            else if (valor == 40) num2text = "CUARENTA";
            else if (valor == 50) num2text = "CINCUENTA";
            else if (valor == 60) num2text = "SESENTA";
            else if (valor == 70) num2text = "SETENTA";
            else if (valor == 80) num2text = "OCHENTA";
            else if (valor == 90) num2text = "NOVENTA";
            else if (valor < 100) num2text = numenletras(Math.Truncate(valor / 10) * 10) + " Y " + numenletras(valor % 10);
            else if (valor == 100) num2text = "CIEN";
            else if (valor < 200) num2text = " CIENTO " + numenletras(valor - 100);
            else if ((valor == 200 || valor == 300 || valor == 400 || valor == 600 || valor == 800)) num2text = numenletras(Math.Truncate(valor / 100)) + "CIENTOS";
            else if (valor == 500) num2text = "QUINIENTOS";

            else if (valor == 700) num2text = "SETECIENTOS";
            else if (valor == 900) num2text = "NOVECIENTOS";
            else if (valor < 1000) num2text = num2text = numenletras(Math.Truncate(valor / 100) * 10) + " " + numenletras(valor % 100);
            else if (valor == 1000) num2text = " MIL";
            else if (valor < 2000) num2text = " MIL " + numenletras(valor % 1000);
            else if (valor < 1000000)
            {
                num2text = numenletras(Math.Truncate(valor / 1000)) + " MIL";
                if ((valor % 1000) > 0) num2text = num2text + "" + numenletras(valor % 1000);
            }
            else if (valor == 1000000) num2text = " UN MILLON ";
            else if (valor < 2000000) num2text = " UN MILLON " + numenletras(valor % 1000000);
            else if (valor < 1000000000000)
            {

                num2text = numenletras(Math.Truncate(valor / 1000000)) + " MILLONES ";
                if ((valor - Math.Truncate(valor / 1000000) * 1000000) > 0) num2text = num2text + " " + numenletras(Math.Truncate(valor / 1000000) * 1000000);

            }
            else if (valor == 1000000000000) num2text = "UN BILLON";
            else if (valor < 2000000000000) num2text = "UN BILLON " + numenletras(Math.Truncate(valor / 1000000000000) * 1000000000000);

            else
            {
                num2text = numenletras(Math.Truncate(valor / 1000000000000)) + "BILLONES";
                if (valor - Math.Truncate(valor / 1000000000000) * 1000000000000 > 0) num2text = num2text + " " + numenletras(Math.Truncate(valor / 10000000000000) * 10000000000000);
            }
            return num2text;

        }


        #endregion

        public Boolean entradanumeros(KeyPressEventArgs e)
        {
            try
            {
                Boolean resultado;
                String cadena = "1234567890" + (char)5;
                if (cadena.Contains(e.KeyChar) || e.KeyChar == 8)
                {
                    resultado = false;
                }
                else
                {
                    MessageBox.Show("Solo se pueden acceptar números", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); resultado = true;
                }
                return resultado;
            }

            catch (Exception)
            {
                throw;
            }

        }
        public Boolean Entradadecimales(KeyPressEventArgs e)
        {
            try
            {
                Boolean resultado;
                String cadena = "1234567890" + (char)5;
                if (cadena.Contains(e.KeyChar) || e.KeyChar == 8)
                {
                    resultado = false;
                }
                else
                {
                    MessageBox.Show("Caracter incorrecto", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); resultado = true;
                }
                return resultado;
            }

            catch (Exception)
            {
                throw;
            }

        }

        public void LlenarCboTipDoc(Control control)
        {
            try 
            {
                foreach (Control cbotipdoc in control.Controls)
                {
                    if (cbotipdoc is ComboBox)
                    {
                        if (cbotipdoc.Name == "CBOtipdoc")
                        {
                            //List<entTipoDocumento> Lista; /*negCliente.Instancia. /*AQUI NOMBRE DEL METODO*/
                            ((ComboBox)cbotipdoc).ValueMember = "Id_TipDoc";
                            ((ComboBox)cbotipdoc).DisplayMember = "Abreviatura_TipDoc";
                       //     ((ComboBox)cbotipdoc).DataSource = Lista;

                        }
                    }
                }
            }
            catch (ApplicationException) { throw; }
            catch (Exception) { throw;  }
        }

        public void limtext(Control control)
        {
            try
            {
                foreach (Control txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        if (txt.Name != "TXTcodusuario")
                        {
                            ((TextBox)txt).Clear();
                        }
                    }
                    else if (txt is GroupBox)
                    {
                        foreach (Control txtgb in txt.Controls)
                        {
                            if (txtgb is TextBox)
                            ((TextBox)txtgb).Clear();

                            if (txtgb is MaskedTextBox)
                                ((MaskedTextBox)txtgb).Clear();
                        }
                    }
                }
            }
            catch (Exception) { throw; }
        }

        public void bloqueartxt(Control control, Boolean estado)
        {
            try
            {
                foreach (Control txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Enabled = estado;
                        if (txt.Name == "TXTcodigop" || txt.Name == "txtidp" || txt.Name == "txtcodigocat" || txt.Name == "txtidcat" || txt.Name == "txtidprove" || txt.Name == "txtcodigopresent" || txt.Name == "txtidpresent" || txt.Name == "TXTcofigoc" || txt.Name == "TXTcodigoum" || txt.Name == "TXTcodigopr")
                        {
                            ((TextBox)txt).Enabled = false;
                        }
                    }
                    
                    else if (txt is GroupBox)
                    {
                        foreach (Control txtgb in txt.Controls)
                        {
                            if (txtgb is TextBox && txtgb.Name != "TXTSearch")
                            {
                                ((TextBox)txtgb).Enabled = estado;
                                if (txtgb.Name == "TXTcodusuario" || txtgb.Name == "TXTDESC" || txtgb.Name == "TXTidusuario" || txtgb.Name == "txtCodigou")
                                {
                                    ((TextBox)txtgb).Enabled = false;
                                }

                                
                            }

                            if (txtgb is MaskedTextBox)
                            {
                                ((MaskedTextBox)txtgb).Enabled = estado;
                            }

                        }
                    }
                }



            }
            catch (Exception) { throw; }
        }



    }
}
