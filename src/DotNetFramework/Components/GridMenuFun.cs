using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetFramework.Components
{
    public class GridMenuFun : ToolStripDropDown
    {
        private Size                    _tileSize           = new Size(50, 50);
        private TableLayoutSettings     _tableSettings      = null;
        private readonly int            _rows               = 5;
        private readonly int            _columns            = 5; 
        private readonly Padding        _margin             = new Padding(10, 6, 10, 6);
        private readonly Color          _transparentColor   = Color.Magenta;
        private readonly ToolStripItemDisplayStyle _displayStyle = ToolStripItemDisplayStyle.ImageAndText;

        public GridMenuFun()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
           this.SuspendLayout();
             
            Capture             = true;
            DropShadowEnabled   = false;
            AutoSize            = false;
            DoubleBuffered      = true;
            ResizeRedraw        = true; 
            LayoutStyle         = ToolStripLayoutStyle.Table;

            _tableSettings                 = base.LayoutSettings as TableLayoutSettings;
            _tableSettings.ColumnCount     = _columns;
            _tableSettings.RowCount        = _rows;
            ImageScalingSize               = new Size(28, 28);

            this.ResumeLayout(false);
        }

        private void SetProperty(TdToolStripButton toolStripItem)
        {
            toolStripItem.ImageTransparentColor = _transparentColor;
            toolStripItem.DisplayStyle = _displayStyle;
            toolStripItem.Margin = _margin;
            toolStripItem.Size = _tileSize;
            toolStripItem.AutoSize = false;
            toolStripItem.ImageAlign = ContentAlignment.TopCenter;
            toolStripItem.TextAlign = ContentAlignment.BottomCenter;
            toolStripItem.TextImageRelation = TextImageRelation.Overlay;
            //toolStripItem.Dock = DockStyle.Fill;

            Items.Add(toolStripItem);
        }

        public void AddItem()
        {
            this.Size = new Size
            (
                (_columns * _tileSize.Width)  + (_margin.Left + _margin.Right)  * _columns + _margin.Right,
                (_rows    * _tileSize.Height) + (_margin.Top  + _margin.Bottom) * _rows    + _margin.Bottom
            );

            //============================
            var btnGoogle = new TdToolStripButton("Google", Properties.Resources.google, null, "btnGoogle");

            SetProperty(btnGoogle);

            btnGoogle.ImageAlign = ContentAlignment.MiddleCenter;
            btnGoogle.TextAlign = ContentAlignment.MiddleCenter;
            btnGoogle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoogle.Dock = DockStyle.Top; 

            var btnGoogleCellPos = new TableLayoutPanelCellPosition(0, 0);
            _tableSettings.SetCellPosition(btnGoogle, btnGoogleCellPos);
            _tableSettings.SetColumnSpan(btnGoogle, _columns -1);
            _tableSettings.SetRowSpan(btnGoogle, 1);

            //=============================
            var btnDocs = new TdToolStripButton("Docs", Properties.Resources.Docs, null, "btnDocs");

            SetProperty(btnDocs);

            btnDocs.ImageAlign        = ContentAlignment.MiddleCenter;
            btnDocs.TextAlign         = ContentAlignment.MiddleCenter;
            btnDocs.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDocs.Dock              = DockStyle.Right;

            var btnDocsCellPos        = new TableLayoutPanelCellPosition(_columns,0);

            _tableSettings.SetCellPosition  (btnDocs, btnDocsCellPos);
            _tableSettings.SetRowSpan       (btnDocs, _rows - 1);

            //=============================
            var btnGmail = new TdToolStripButton("Gmail", Properties.Resources.gmail, null, "btnGmail");

            SetProperty(btnGmail);
            btnGmail.Dock = DockStyle.None;

            var btnGmailCellPos = new TableLayoutPanelCellPosition(3, 2);
            _tableSettings.SetCellPosition(btnGmail, btnGmailCellPos);
            _tableSettings.SetColumnSpan(btnGmail, 1);

            //===========================
            var btnCalendar = new TdToolStripButton("Calendar", Properties.Resources.calendar, null, "btnCalendar");

            SetProperty(btnCalendar);

            btnCalendar.ImageAlign        = ContentAlignment.MiddleCenter;
            btnCalendar.TextAlign         = ContentAlignment.MiddleCenter;
            btnCalendar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCalendar.Dock              = DockStyle.Left;

            var btnCalendarCellPos        = new TableLayoutPanelCellPosition(0, 1);
            _tableSettings.SetCellPosition  (btnCalendar, btnCalendarCellPos); 
            _tableSettings.SetRowSpan       (btnCalendar, _rows - 1);

            //=============================
            var btnChrome = new TdToolStripButton("Chrome", Properties.Resources.chrome, null, "btnChrome");

            SetProperty(btnChrome);

            btnChrome.ImageAlign = ContentAlignment.MiddleCenter;
            btnChrome.TextAlign = ContentAlignment.MiddleCenter;
            btnChrome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChrome.Dock = DockStyle.Bottom;

            var btnChromeCellPos = new TableLayoutPanelCellPosition(1, _rows - 1);
            _tableSettings.SetCellPosition(btnChrome, btnChromeCellPos);
            _tableSettings.SetColumnSpan(btnChrome, _columns - 1);


        }
    }
}
