using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetFramework.Components
{
    public class PopupControl : ToolStripDropDown
    {
        
        private ToolStripControlHost Host;

        public PopupControl()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            Capture             = true;
            DropShadowEnabled   = false;
            AutoSize            = false;  

            this.ResumeLayout(false);
        }

        public void AddItem()
        {
            var control = new CustomControl()
            {
                Name = "popupControl1",
                Size = new Size(304, 258)
            };   

            Host = new ToolStripControlHost(control)
            {

                Margin              = Padding.Empty,
                Padding             = Padding.Empty,
                AutoSize            = false,
                AutoToolTip         = false,
                DoubleClickEnabled  = true,
            };

            this.Size = new Size
            (
                control.Width,
                control.Height
            );

            Host.Size = new Size(control.Size.Width, control.Size.Height);
            control.Anchor = AnchorStyles.Bottom
                             | AnchorStyles.Left
                             | AnchorStyles.Right
                             | AnchorStyles.Top;

            this.Items.Clear();
            this.Items.Add(Host);
        }

    }
}
