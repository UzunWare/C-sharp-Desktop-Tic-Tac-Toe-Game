using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Tic_Tac_Toe
{
    enum TURN{RED,BLUE,EMPTY};
    
    class Cell : Button
    {
        public int ri, ci;
        public string ImgName;
        public TURN value = TURN.EMPTY;
        public Cell(int r,int c,int w,int h,int dim,string name)
        {
            this.ri = r;
            this.ci = c;
            this.Width = w / dim - 8;
            this.Height = h / dim - 8;
            this.ImgName = name;
        }

        public void Draw(string name)
        {
            this.Image = Image.FromFile("..\\..\\Resources\\" + name);
        }
    }
}
