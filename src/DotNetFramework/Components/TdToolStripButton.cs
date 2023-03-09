using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetFramework.Components
{
    public class TdToolStripButton : ToolStripButton
    {
        public TdToolStripButton():base()
        {
            
        }

        public TdToolStripButton(string Text) : base(Text)
        {

        }
        public TdToolStripButton(Image Image) : base(Image)
        {

        }
        public TdToolStripButton(string Text,Image Image) : base(Text,Image)
        {

        }
        public TdToolStripButton(string Text, Image Image,EventHandler eventHandler) 
            : base(Text, Image, eventHandler)
        {

        }

        public TdToolStripButton(string Text, Image Image, EventHandler EventHandler, string Name)
            : base(Text, Image, EventHandler,Name)
        {

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(
                e.Graphics,
                new Rectangle(0, 0, this.Width, this.Height),
                Color.LightSkyBlue, ButtonBorderStyle.Solid
            );
        }
         
    }
}
