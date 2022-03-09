namespace CapaPresentacion
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="controlsStates" />.
    /// </summary>
    internal class controlsStates
    {
        /// <summary>
        /// The entradanumeros.
        /// </summary>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        /// <returns>The <see cref="Boolean"/>.</returns>
        public Boolean EnterNumbers(KeyPressEventArgs e)
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
                    MessageBox.Show("Only numbers can be accepted", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); resultado = true;
                }
                return resultado;
            }

            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The Entradadecimales.
        /// </summary>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        /// <returns>The <see cref="Boolean"/>.</returns>
        public Boolean DecimalNumbers(KeyPressEventArgs e)
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
                    MessageBox.Show("Wrong character", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); resultado = true;
                }
                return resultado;
            }

            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// The fillComboboxes.
        /// </summary>
        /// <param name="control">The control<see cref="Control"/>.</param>
        public void fillComboBoxes(Control control)
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
            catch (Exception) { throw; }
        }

        /// <summary>
        /// The clearTextBox.
        /// </summary>
        /// <param name="control">The control<see cref="Control"/>.</param>
        public void clearTextBox(Control control)
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

        /// <summary>
        /// The BlockTextBox.
        /// </summary>
        /// <param name="control">The control<see cref="Control"/>.</param>
        /// <param name="status">The estado<see cref="Boolean"/>.</param>
        public void BlockTextBox(Control control, Boolean status)
        {
            try
            {
                foreach (Control txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Enabled = status;
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
                                ((TextBox)txtgb).Enabled = status;
                                if (txtgb.Name == "TXTcodusuario" || txtgb.Name == "TXTDESC" || txtgb.Name == "TXTidusuario" || txtgb.Name == "txtCodigou")
                                {
                                    ((TextBox)txtgb).Enabled = false;
                                }


                            }

                            if (txtgb is MaskedTextBox)
                            {
                                ((MaskedTextBox)txtgb).Enabled = status;
                            }

                        }
                    }
                }



            }
            catch (Exception) { throw; }
        }
    }
}
