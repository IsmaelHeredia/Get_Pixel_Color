// GetPixelColor 0.4
// © Ismael Heredia , Argentina , 2017
// Credits :
// Based on http://www.dotnetthoughts.net/creating-color-picker-application-in-c/
// Thanks to Anuraj P

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace GetPixelColor
{

    public partial class FormHome : Form
    {

        // DLL

        public static IntPtr HWND_TOPMOST = new IntPtr(-1);
        public const uint SWP_NOSIZE = 0x0001;
        public const uint SWP_NOMOVE = 0x0002;
        public const uint TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        //

        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(GetPixelColor.Properties.Resources.formcreate);
            sound.Play();
        }

        private void tmGetPixel_Tick(object sender, EventArgs e)
        {
            // Capture Pixel Color

            try
            {

                ColorConverter rgbnow = new ColorConverter();
                Point puntero = new Point();
                GetCursorPos(ref puntero);
                IntPtr ventana = GetDC(IntPtr.Zero);
                uint colornow = GetPixel(ventana, puntero.X, puntero.Y);
                ReleaseDC(IntPtr.Zero, ventana);
                Color tetengo = Color.FromArgb((int)(colornow & 0x000000FF), (int)(colornow & 0x0000FF00) >> 8, (int)(colornow & 0x00FF0000) >> 16);
                Color resultado = tetengo;
                string html = ColorTranslator.ToHtml(resultado);
                string rgb = rgbnow.ConvertToString(resultado);
                string copiahtml = html;
                string hex = copiahtml.Replace("#", "0x");

                pbPreview.BackColor = resultado;

                txtRGB.Text = rgb;
                txtHex.Text = hex;
                txtHTML.Text = html;

            }

            catch
            {
                //
            }
        }

        private void FormHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X && e.Modifiers == Keys.Control)
            {

                string color = txtHTML.Text;

                if (cmbSintax.Text == "")
                {
                    Clipboard.Clear();
                    Clipboard.SetText(color);
                }

                if (cmbSintax.Text == "None")
                {
                    Clipboard.Clear();
                    Clipboard.SetText(color);
                }

                if (cmbSintax.Text == "HTML")
                {
                    Clipboard.Clear();
                    Clipboard.SetText("<body style=\"background:" + color + "\">");
                }

                if (cmbSintax.Text == "CSS")
                {
                    Clipboard.Clear();
                    Clipboard.SetText("body {background-color:" + color + ";}");
                }

                if (cmbSintax.Text == "C#")
                {
                    Clipboard.Clear();
                    Clipboard.SetText("ColorTranslator.FromHtml(\"" + color + "\");");
                }

                if (cmbSintax.Text == "VB.NET")
                {
                    Clipboard.Clear();
                    Clipboard.SetText("ColorTranslator.FromHtml(\"" + color + "\");");
                }

                if (cmbSintax.Text == "Perl")
                {
                    Clipboard.Clear();
                    Clipboard.SetText("-background=>\"" + color + "\"");
                }

                if (cmbSintax.Text == "Python")
                {
                    Clipboard.Clear();
                    Clipboard.SetText("\"QWidget {background-color: " + color + ";color: " + color + "}\"");
                }

                SoundPlayer sound = new SoundPlayer(GetPixelColor.Properties.Resources.tenow);
                sound.Play();

            }
        }

        private void lblCopyRight_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ismaelheredia123.wordpress.com");
        }

    }
}
