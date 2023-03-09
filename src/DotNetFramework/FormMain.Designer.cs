using System.Drawing;

namespace DotNetFramework
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGridMenu1 = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnGridMenu2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gridMenu1 = new DotNetFramework.Components.GridMenu();
            this.gridMenu2 = new DotNetFramework.Components.GridMenu();
            this.gridMenuFun1 = new DotNetFramework.Components.GridMenuFun();
            this.gridMenuFun2 = new DotNetFramework.Components.GridMenuFun();
            this.popupControl1 = new DotNetFramework.Components.PopupControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gridMenu3 = new DotNetFramework.Components.GridMenu();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGridMenu1
            // 
            this.btnGridMenu1.BackgroundImage = global::DotNetFramework.Properties.Resources.grid;
            this.btnGridMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGridMenu1.Location = new System.Drawing.Point(111, 78);
            this.btnGridMenu1.Name = "btnGridMenu1";
            this.btnGridMenu1.Size = new System.Drawing.Size(28, 28);
            this.btnGridMenu1.TabIndex = 2;
            this.btnGridMenu1.UseVisualStyleBackColor = true;
            this.btnGridMenu1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(95, 19);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(98, 19);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // btnGridMenu2
            // 
            this.btnGridMenu2.BackgroundImage = global::DotNetFramework.Properties.Resources.grid;
            this.btnGridMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGridMenu2.Location = new System.Drawing.Point(271, 78);
            this.btnGridMenu2.Name = "btnGridMenu2";
            this.btnGridMenu2.Size = new System.Drawing.Size(28, 28);
            this.btnGridMenu2.TabIndex = 2;
            this.btnGridMenu2.UseVisualStyleBackColor = true;
            this.btnGridMenu2.Click += new System.EventHandler(this.btnGridMenu2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(443, 33);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = global::DotNetFramework.Properties.Resources.grid;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.Image = global::DotNetFramework.Properties.Resources.grid;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(99, 19);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(98, 19);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(99, 19);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 173);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DotNetFramework.Properties.Resources.grid;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(194, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gridMenu1
            // 
            this.gridMenu1.AutoSize = false;
            this.gridMenu1.DropShadowEnabled = false;
            this.gridMenu1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.gridMenu1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.gridMenu1.Name = "gridMenu1";
            this.gridMenu1.Padding = new System.Windows.Forms.Padding(3);
            this.gridMenu1.Size = new System.Drawing.Size(250, 250);
            // 
            // gridMenu2
            // 
            this.gridMenu2.AutoSize = false;
            this.gridMenu2.DropShadowEnabled = false;
            this.gridMenu2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.gridMenu2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.gridMenu2.Name = "gridMenu2";
            // 
            // gridMenuFun1
            // 
            this.gridMenuFun1.AutoSize = false;
            this.gridMenuFun1.DropShadowEnabled = false;
            this.gridMenuFun1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.gridMenuFun1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.gridMenuFun1.Name = "gridMenuFun1";
            // 
            // gridMenuFun2
            // 
            this.gridMenuFun2.AutoSize = false;
            this.gridMenuFun2.DropShadowEnabled = false;
            this.gridMenuFun2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.gridMenuFun2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.gridMenuFun2.Name = "gridMenuFun2";
            // 
            // popupControl1
            // 
            this.popupControl1.AutoSize = false;
            this.popupControl1.DropShadowEnabled = false;
            this.popupControl1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.popupControl1.Name = "popupControl1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            this.FileMenu.Click += new System.EventHandler(this.FileMenu_Click);
            // 
            // gridMenu3
            // 
            this.gridMenu3.AutoSize = false;
            this.gridMenu3.DropShadowEnabled = false;
            this.gridMenu3.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.gridMenu3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.gridMenu3.Name = "gridMenu3";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGridMenu2);
            this.Controls.Add(this.btnGridMenu1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.GridMenu gridMenu1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button btnGridMenu1;
        private System.Windows.Forms.Button btnGridMenu2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private Components.GridMenu gridMenu2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private Components.GridMenuFun gridMenuFun1;
        private Components.GridMenuFun gridMenuFun2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Components.PopupControl popupControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private Components.GridMenu gridMenu3;
    }
}

