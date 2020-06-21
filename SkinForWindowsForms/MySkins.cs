using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkinForWindowsForms
{
    public class MySkins
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Skin uygulanacak Form nesnesi. this</param>
        /// <param name="Type">"Hangi skin uygulanacak. Gray, Light, Blue"</param>
        public static void SetSkin(Form frm, string Type)
        {
            switch (Type)
            {
                case "Gray":
                    GraySkin(frm);
                    break;
                case "Light":
                    //LightSkin(frm);
                    break;
                case "Blue":
                    //BlueSkin(frm);
                    break;

            }
        }

        static void GraySkin(Form frm)
        {
            frm.BackColor = Color.DarkGray;
            frm.FormBorderStyle = FormBorderStyle.SizableToolWindow;

            foreach (Control item in frm.Controls)
            {
                item.BackColor = Color.DarkGray;
                item.ForeColor = Color.White;

                switch (item.GetType().Name)
                {
                    case "Button":
                        item.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                        break;
                    case "DataGridView":
                        DataGridView dgv = item as DataGridView;
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.DarkGray;
                        style.ForeColor = Color.White;
                        style.SelectionBackColor = Color.LightGray;
                        style.SelectionForeColor = Color.Black;
                        dgv.BorderStyle = BorderStyle.None;
                        dgv.GridColor = Color.Black;
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            foreach (DataGridViewCell item1 in row.Cells)
                            {
                                item1.Style = style;
                            }
                        }
                        break;
                    case "GroupBox":
                        break;
                    case "ComboBox":
                        break;
                    case "Label":
                        break;
                }
            }
        }
    }
}
