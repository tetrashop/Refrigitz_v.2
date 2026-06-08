using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Data.OleDb;
using System.Media;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationRefregitz
{
    public partial class WebFormRefregitz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Image2_Load(object sender, EventArgs e)
        {
                    Bitmap ChessTable = new Bitmap(400,400);
                    Graphics g = Graphics.FromImage(ChessTable);
                    g.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(0, 0, 400, 400));
                    Color a = Color.Gray;
                    for (int i = 0; i < 400; i += 400 / 8)
                        for (int j = 0; j < 400; j += 400 / 8)
                        {
                            if ((i + j) % 2 == 0)
                                 g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(i, j, 400 / 8, 400 / 8));
                             else
                                g.FillRectangle(new SolidBrush(Color.White), new Rectangle(i, j, 400 / 8, 400 / 8));
                        }
                    Response.ContentType = "image/jpeg";

                    ChessTable.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg); 
              
        }
    } 
}