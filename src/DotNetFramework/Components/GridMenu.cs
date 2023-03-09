using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DotNetFramework.Components
{
    public class GridMenu : ToolStripDropDown
    {
        private Size                    _tileSize           = new Size(50, 50);
        private TableLayoutSettings     _tableSettings      = null;
        private readonly int            _rows               = 5;
        private readonly int            _columns            = 3; 
        private readonly Padding        _margin             = new Padding(10, 6, 10, 6);
        private readonly Color          _transparentColor   = Color.Magenta;
        private readonly ToolStripItemDisplayStyle _displayStyle = ToolStripItemDisplayStyle.ImageAndText;

        public GridMenu ()
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
            toolStripItem.DisplayStyle      = _displayStyle;
            toolStripItem.Margin            = _margin;
            toolStripItem.Size              = _tileSize;
            toolStripItem.AutoSize          = false;
            toolStripItem.ImageAlign        = ContentAlignment.TopCenter;
            toolStripItem.TextAlign         = ContentAlignment.BottomCenter;
            toolStripItem.TextImageRelation = TextImageRelation.Overlay;
            toolStripItem.Dock              = DockStyle.Fill; 

            Items.Add(toolStripItem);
        }
        public void AddItem()
        {
            this.Size = new Size
            (
                (_columns * _tileSize.Width)  + (_margin.Left + _margin.Right)  * _columns + _margin.Right,
                (_rows    * _tileSize.Height) + (_margin.Top  + _margin.Bottom) * _rows + _margin.Bottom
            );

            //==========================
            var btnGoogle = new TdToolStripButton("Google", Properties.Resources.google, null, "btnGoogle");

            SetProperty(btnGoogle);
            
            var btnGoogleCellPos        = new TableLayoutPanelCellPosition(0, 0);
            _tableSettings.SetCellPosition(btnGoogle, btnGoogleCellPos);

            //=============================
            var btnCalendar = new TdToolStripButton("Calendar", Properties.Resources.calendar, null, "btnCalendar");

            SetProperty(btnCalendar);

            var btnCalendarCellPos = new TableLayoutPanelCellPosition(1, 0);
            _tableSettings.SetCellPosition(btnCalendar, btnCalendarCellPos);

            //=============================
            var btnChrome = new TdToolStripButton("Chrome", Properties.Resources.chrome, null, "btnChrome");

            SetProperty(btnChrome);

            var btnChromeCellPos = new TableLayoutPanelCellPosition(2, 0);
            _tableSettings.SetCellPosition(btnChrome, btnChromeCellPos);

            //=============================
            var btnDocs = new TdToolStripButton("Docs", Properties.Resources.Docs, null, "btnDocs");

            SetProperty(btnDocs);

            var btnDocsCellPos = new TableLayoutPanelCellPosition(0, 1);
            _tableSettings.SetCellPosition(btnDocs, btnDocsCellPos);

            //=============================
            var btnGmail = new TdToolStripButton("Gmail", Properties.Resources.gmail, null, "btnGmail");

            SetProperty(btnGmail);

            var btnGmailCellPos = new TableLayoutPanelCellPosition(1, 1);
            _tableSettings.SetCellPosition(btnGmail, btnGmailCellPos);

            //=============================
            var btnHome = new TdToolStripButton("Home", Properties.Resources.home, null, "btnHome");

            SetProperty(btnHome);

            var btnHomeCellPos = new TableLayoutPanelCellPosition(2, 1);
            _tableSettings.SetCellPosition(btnHome, btnHomeCellPos);

            //=============================
            var btnKeep = new TdToolStripButton("Keep", Properties.Resources.keep, null, "btnKeep");

            SetProperty(btnKeep);

            var btnKeepCellPos = new TableLayoutPanelCellPosition(0, 2);
            _tableSettings.SetCellPosition(btnKeep, btnKeepCellPos);

            //=============================
            var btnMap = new TdToolStripButton("Map", Properties.Resources.maps, null, "btnMap");

            SetProperty(btnMap);

            var btnMapCellPos = new TableLayoutPanelCellPosition(1, 2);
            _tableSettings.SetCellPosition(btnMap, btnMapCellPos);

            //=============================
            var btnMeet = new TdToolStripButton("Meet", Properties.Resources.meet, null, "btnMeet");

            SetProperty(btnMeet);

            var btnMeetCellPos = new TableLayoutPanelCellPosition(2, 2);
            _tableSettings.SetCellPosition(btnMeet, btnMeetCellPos);
            //=============================
            var btnPhotos = new TdToolStripButton("Photos", Properties.Resources.photos, null, "btnPhotos");

            SetProperty(btnPhotos);
            
            btnPhotos.TextAlign = ContentAlignment.MiddleCenter;
            btnPhotos.ImageAlign = ContentAlignment.MiddleCenter;
            btnPhotos.TextImageRelation = TextImageRelation.ImageBeforeText;


            var btnPhotosCellPos = new TableLayoutPanelCellPosition(0, 3);
            _tableSettings.SetCellPosition(btnPhotos, btnPhotosCellPos);
            _tableSettings.SetColumnSpan(btnPhotos, 2);
            

            //=============================
            var btnOK = new TdToolStripButton("OK",null, null, "btnPhotos");
            SetProperty(btnOK);
            btnOK.AutoSize   = false;
            btnOK.Dock       = DockStyle.Bottom;
            btnOK.TextAlign  = ContentAlignment.MiddleCenter;
            
            var btnOKCellPos = new TableLayoutPanelCellPosition(0,4);
            _tableSettings.SetCellPosition(btnOK, btnOKCellPos);
            _tableSettings.SetColumnSpan(btnOK, _columns);
            
        }

    }
}
