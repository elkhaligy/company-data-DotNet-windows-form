namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            X = new ToolStripStatusLabel();
            LineContextMenuStrip = new ContextMenuStrip(components);
            lineContextMenuToolStripMenuItem = new ToolStripMenuItem();
            lineColorContextMenuToolStripMenuItem = new ToolStripMenuItem();
            lineRedContextMenuToolStripMenuItem = new ToolStripMenuItem();
            lineGreenContextMenuToolStripMenuItem = new ToolStripMenuItem();
            lineBlueContextMenuToolStripMenuItem = new ToolStripMenuItem();
            lineStyleContextMenuToolStripMenuItem = new ToolStripMenuItem();
            solidToolStripMenuItem = new ToolStripMenuItem();
            dashToolStripMenuItem = new ToolStripMenuItem();
            dottedToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            lineParentToolStripMenuItem = new ToolStripMenuItem();
            lineColorToolStripMenuItem = new ToolStripMenuItem();
            lineRedToolStripMenuItem = new ToolStripMenuItem();
            lineGreenToolStripMenuItem = new ToolStripMenuItem();
            lineBlueToolStripMenuItem = new ToolStripMenuItem();
            lineStyleToolStripMenuItem = new ToolStripMenuItem();
            lineSolidToolStripMenuItem = new ToolStripMenuItem();
            lineDashedToolStripMenuItem = new ToolStripMenuItem();
            lineDottedToolStripMenuItem = new ToolStripMenuItem();
            rectangleParentToolStripMenuItem = new ToolStripMenuItem();
            rectangleColorToolStripMenuItem = new ToolStripMenuItem();
            rectangleRedToolStripMenuItem = new ToolStripMenuItem();
            rectangleGreenToolStripMenuItem = new ToolStripMenuItem();
            rectangleBlueToolStripMenuItem = new ToolStripMenuItem();
            rectangleStyleToolStripMenuItem = new ToolStripMenuItem();
            rectangleRightToolStripMenuItem = new ToolStripMenuItem();
            rectangleLeftToolStripMenuItem = new ToolStripMenuItem();
            rectangleCrossToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            companyNameToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            RectangleContextMenuStrip = new ContextMenuStrip(components);
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            rectangleColorCMToolStripMenuItem = new ToolStripMenuItem();
            RectangleRedCMToolStripMenuItem = new ToolStripMenuItem();
            RectangleGreenCMToolStripMenuItem = new ToolStripMenuItem();
            RectangleBlueCMToolStripMenuItem = new ToolStripMenuItem();
            rectangleStyleCMToolStripMenuItem = new ToolStripMenuItem();
            rectangleCrossedCMToolStripMenuItem = new ToolStripMenuItem();
            rectangleRightCMToolStripMenuItem = new ToolStripMenuItem();
            rectangleLeftCMToolStripMenuItem = new ToolStripMenuItem();
            rectangleBlueContextMenuToolStripMenuItem = new ToolStripMenuItem();
            rectangleStyleContextMenuToolStripMenuItem = new ToolStripMenuItem();
            rectangleRightContextMenuToolStripMenuItem = new ToolStripMenuItem();
            rectangleLeftContextMenuToolStripMenuItem = new ToolStripMenuItem();
            rectangleCrossContextMenuToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            LineContextMenuStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            RectangleContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { X });
            statusStrip1.Location = new Point(0, 626);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(1136, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // X
            // 
            X.Name = "X";
            X.Size = new Size(18, 20);
            X.Text = "X";
            // 
            // LineContextMenuStrip
            // 
            LineContextMenuStrip.ImageScalingSize = new Size(20, 20);
            LineContextMenuStrip.Items.AddRange(new ToolStripItem[] { lineContextMenuToolStripMenuItem });
            LineContextMenuStrip.Name = "contextMenuStrip1";
            LineContextMenuStrip.ShowImageMargin = false;
            LineContextMenuStrip.Size = new Size(81, 28);
            // 
            // lineContextMenuToolStripMenuItem
            // 
            lineContextMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lineColorContextMenuToolStripMenuItem, lineStyleContextMenuToolStripMenuItem });
            lineContextMenuToolStripMenuItem.Name = "lineContextMenuToolStripMenuItem";
            lineContextMenuToolStripMenuItem.Size = new Size(80, 24);
            lineContextMenuToolStripMenuItem.Text = "Line";
            // 
            // lineColorContextMenuToolStripMenuItem
            // 
            lineColorContextMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lineRedContextMenuToolStripMenuItem, lineGreenContextMenuToolStripMenuItem, lineBlueContextMenuToolStripMenuItem });
            lineColorContextMenuToolStripMenuItem.Name = "lineColorContextMenuToolStripMenuItem";
            lineColorContextMenuToolStripMenuItem.Size = new Size(128, 26);
            lineColorContextMenuToolStripMenuItem.Text = "Color";
            lineColorContextMenuToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // lineRedContextMenuToolStripMenuItem
            // 
            lineRedContextMenuToolStripMenuItem.Name = "lineRedContextMenuToolStripMenuItem";
            lineRedContextMenuToolStripMenuItem.Size = new Size(131, 26);
            lineRedContextMenuToolStripMenuItem.Text = "Red";
            lineRedContextMenuToolStripMenuItem.Click += ChangeLineGraphPenColorGUI;
            // 
            // lineGreenContextMenuToolStripMenuItem
            // 
            lineGreenContextMenuToolStripMenuItem.Name = "lineGreenContextMenuToolStripMenuItem";
            lineGreenContextMenuToolStripMenuItem.Size = new Size(131, 26);
            lineGreenContextMenuToolStripMenuItem.Text = "Green";
            lineGreenContextMenuToolStripMenuItem.Click += ChangeLineGraphPenColorGUI;
            // 
            // lineBlueContextMenuToolStripMenuItem
            // 
            lineBlueContextMenuToolStripMenuItem.Name = "lineBlueContextMenuToolStripMenuItem";
            lineBlueContextMenuToolStripMenuItem.Size = new Size(131, 26);
            lineBlueContextMenuToolStripMenuItem.Text = "Blue";
            lineBlueContextMenuToolStripMenuItem.Click += ChangeLineGraphPenColorGUI;
            // 
            // lineStyleContextMenuToolStripMenuItem
            // 
            lineStyleContextMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { solidToolStripMenuItem, dashToolStripMenuItem, dottedToolStripMenuItem });
            lineStyleContextMenuToolStripMenuItem.Name = "lineStyleContextMenuToolStripMenuItem";
            lineStyleContextMenuToolStripMenuItem.Size = new Size(128, 26);
            lineStyleContextMenuToolStripMenuItem.Text = "Style";
            // 
            // solidToolStripMenuItem
            // 
            solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            solidToolStripMenuItem.Size = new Size(139, 26);
            solidToolStripMenuItem.Text = "Solid";
            solidToolStripMenuItem.Click += ChangeLineGraphPenStyleGUI;
            // 
            // dashToolStripMenuItem
            // 
            dashToolStripMenuItem.Name = "dashToolStripMenuItem";
            dashToolStripMenuItem.Size = new Size(139, 26);
            dashToolStripMenuItem.Text = "Dash";
            dashToolStripMenuItem.Click += ChangeLineGraphPenStyleGUI;
            // 
            // dottedToolStripMenuItem
            // 
            dottedToolStripMenuItem.Name = "dottedToolStripMenuItem";
            dottedToolStripMenuItem.Size = new Size(139, 26);
            dottedToolStripMenuItem.Text = "Dotted";
            dottedToolStripMenuItem.Click += ChangeLineGraphPenStyleGUI;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { lineParentToolStripMenuItem, rectangleParentToolStripMenuItem, formatToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1136, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // lineParentToolStripMenuItem
            // 
            lineParentToolStripMenuItem.Checked = true;
            lineParentToolStripMenuItem.CheckState = CheckState.Checked;
            lineParentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lineColorToolStripMenuItem, lineStyleToolStripMenuItem });
            lineParentToolStripMenuItem.Name = "lineParentToolStripMenuItem";
            lineParentToolStripMenuItem.Size = new Size(50, 24);
            lineParentToolStripMenuItem.Text = "Line";
            // 
            // lineColorToolStripMenuItem
            // 
            lineColorToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lineColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lineRedToolStripMenuItem, lineGreenToolStripMenuItem, lineBlueToolStripMenuItem });
            lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            lineColorToolStripMenuItem.Size = new Size(128, 26);
            lineColorToolStripMenuItem.Text = "Color";
            // 
            // lineRedToolStripMenuItem
            // 
            lineRedToolStripMenuItem.Name = "lineRedToolStripMenuItem";
            lineRedToolStripMenuItem.Size = new Size(131, 26);
            lineRedToolStripMenuItem.Text = "Red";
            lineRedToolStripMenuItem.Click += ChangeLineGraphPenColorGUI;
            // 
            // lineGreenToolStripMenuItem
            // 
            lineGreenToolStripMenuItem.Name = "lineGreenToolStripMenuItem";
            lineGreenToolStripMenuItem.Size = new Size(131, 26);
            lineGreenToolStripMenuItem.Text = "Green";
            lineGreenToolStripMenuItem.Click += ChangeLineGraphPenColorGUI;
            // 
            // lineBlueToolStripMenuItem
            // 
            lineBlueToolStripMenuItem.Checked = true;
            lineBlueToolStripMenuItem.CheckState = CheckState.Checked;
            lineBlueToolStripMenuItem.Name = "lineBlueToolStripMenuItem";
            lineBlueToolStripMenuItem.Size = new Size(131, 26);
            lineBlueToolStripMenuItem.Text = "Blue";
            lineBlueToolStripMenuItem.Click += ChangeLineGraphPenColorGUI;
            // 
            // lineStyleToolStripMenuItem
            // 
            lineStyleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lineSolidToolStripMenuItem, lineDashedToolStripMenuItem, lineDottedToolStripMenuItem });
            lineStyleToolStripMenuItem.Name = "lineStyleToolStripMenuItem";
            lineStyleToolStripMenuItem.Size = new Size(128, 26);
            lineStyleToolStripMenuItem.Text = "Style";
            // 
            // lineSolidToolStripMenuItem
            // 
            lineSolidToolStripMenuItem.Name = "lineSolidToolStripMenuItem";
            lineSolidToolStripMenuItem.Size = new Size(142, 26);
            lineSolidToolStripMenuItem.Text = "Solid";
            lineSolidToolStripMenuItem.Click += ChangeLineGraphPenStyleGUI;
            // 
            // lineDashedToolStripMenuItem
            // 
            lineDashedToolStripMenuItem.Name = "lineDashedToolStripMenuItem";
            lineDashedToolStripMenuItem.Size = new Size(142, 26);
            lineDashedToolStripMenuItem.Text = "Dashed";
            lineDashedToolStripMenuItem.Click += ChangeLineGraphPenStyleGUI;
            // 
            // lineDottedToolStripMenuItem
            // 
            lineDottedToolStripMenuItem.Name = "lineDottedToolStripMenuItem";
            lineDottedToolStripMenuItem.Size = new Size(142, 26);
            lineDottedToolStripMenuItem.Text = "Dotted";
            lineDottedToolStripMenuItem.Click += ChangeLineGraphPenStyleGUI;
            // 
            // rectangleParentToolStripMenuItem
            // 
            rectangleParentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleColorToolStripMenuItem, rectangleStyleToolStripMenuItem });
            rectangleParentToolStripMenuItem.Name = "rectangleParentToolStripMenuItem";
            rectangleParentToolStripMenuItem.Size = new Size(89, 24);
            rectangleParentToolStripMenuItem.Text = "Rectangle";
            // 
            // rectangleColorToolStripMenuItem
            // 
            rectangleColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleRedToolStripMenuItem, rectangleGreenToolStripMenuItem, rectangleBlueToolStripMenuItem });
            rectangleColorToolStripMenuItem.Name = "rectangleColorToolStripMenuItem";
            rectangleColorToolStripMenuItem.Size = new Size(128, 26);
            rectangleColorToolStripMenuItem.Text = "Color";
            // 
            // rectangleRedToolStripMenuItem
            // 
            rectangleRedToolStripMenuItem.Name = "rectangleRedToolStripMenuItem";
            rectangleRedToolStripMenuItem.Size = new Size(131, 26);
            rectangleRedToolStripMenuItem.Text = "Red";
            rectangleRedToolStripMenuItem.Click += ChangeRectangleColorGUI;
            // 
            // rectangleGreenToolStripMenuItem
            // 
            rectangleGreenToolStripMenuItem.Name = "rectangleGreenToolStripMenuItem";
            rectangleGreenToolStripMenuItem.Size = new Size(131, 26);
            rectangleGreenToolStripMenuItem.Text = "Green";
            rectangleGreenToolStripMenuItem.Click += ChangeRectangleColorGUI;
            // 
            // rectangleBlueToolStripMenuItem
            // 
            rectangleBlueToolStripMenuItem.Name = "rectangleBlueToolStripMenuItem";
            rectangleBlueToolStripMenuItem.Size = new Size(131, 26);
            rectangleBlueToolStripMenuItem.Text = "Blue";
            rectangleBlueToolStripMenuItem.Click += ChangeRectangleColorGUI;
            // 
            // rectangleStyleToolStripMenuItem
            // 
            rectangleStyleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleRightToolStripMenuItem, rectangleLeftToolStripMenuItem, rectangleCrossToolStripMenuItem });
            rectangleStyleToolStripMenuItem.Name = "rectangleStyleToolStripMenuItem";
            rectangleStyleToolStripMenuItem.Size = new Size(128, 26);
            rectangleStyleToolStripMenuItem.Text = "Style";
            // 
            // rectangleRightToolStripMenuItem
            // 
            rectangleRightToolStripMenuItem.Name = "rectangleRightToolStripMenuItem";
            rectangleRightToolStripMenuItem.Size = new Size(127, 26);
            rectangleRightToolStripMenuItem.Text = "Right";
            rectangleRightToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // rectangleLeftToolStripMenuItem
            // 
            rectangleLeftToolStripMenuItem.Name = "rectangleLeftToolStripMenuItem";
            rectangleLeftToolStripMenuItem.Size = new Size(127, 26);
            rectangleLeftToolStripMenuItem.Text = "Left";
            rectangleLeftToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // rectangleCrossToolStripMenuItem
            // 
            rectangleCrossToolStripMenuItem.Name = "rectangleCrossToolStripMenuItem";
            rectangleCrossToolStripMenuItem.Size = new Size(127, 26);
            rectangleCrossToolStripMenuItem.Text = "Cross";
            rectangleCrossToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { companyNameToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "Format";
            // 
            // companyNameToolStripMenuItem
            // 
            companyNameToolStripMenuItem.Name = "companyNameToolStripMenuItem";
            companyNameToolStripMenuItem.Size = new Size(224, 26);
            companyNameToolStripMenuItem.Text = "Company";
            companyNameToolStripMenuItem.Click += companyNameToolStripMenuItem_Click;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1136, 25);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // RectangleContextMenuStrip
            // 
            RectangleContextMenuStrip.ImageScalingSize = new Size(20, 20);
            RectangleContextMenuStrip.Items.AddRange(new ToolStripItem[] { rectangleToolStripMenuItem });
            RectangleContextMenuStrip.Name = "RectangleContextMenuStrip";
            RectangleContextMenuStrip.Size = new Size(145, 28);
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleColorCMToolStripMenuItem, rectangleStyleCMToolStripMenuItem });
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(144, 24);
            rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // rectangleColorCMToolStripMenuItem
            // 
            rectangleColorCMToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            rectangleColorCMToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RectangleRedCMToolStripMenuItem, RectangleGreenCMToolStripMenuItem, RectangleBlueCMToolStripMenuItem });
            rectangleColorCMToolStripMenuItem.Name = "rectangleColorCMToolStripMenuItem";
            rectangleColorCMToolStripMenuItem.Size = new Size(128, 26);
            rectangleColorCMToolStripMenuItem.Text = "Color";
            // 
            // RectangleRedCMToolStripMenuItem
            // 
            RectangleRedCMToolStripMenuItem.Name = "RectangleRedCMToolStripMenuItem";
            RectangleRedCMToolStripMenuItem.Size = new Size(131, 26);
            RectangleRedCMToolStripMenuItem.Text = "Red";
            RectangleRedCMToolStripMenuItem.Click += ChangeRectangleColorGUI;
            // 
            // RectangleGreenCMToolStripMenuItem
            // 
            RectangleGreenCMToolStripMenuItem.Name = "RectangleGreenCMToolStripMenuItem";
            RectangleGreenCMToolStripMenuItem.Size = new Size(131, 26);
            RectangleGreenCMToolStripMenuItem.Text = "Green";
            RectangleGreenCMToolStripMenuItem.Click += ChangeRectangleColorGUI;
            // 
            // RectangleBlueCMToolStripMenuItem
            // 
            RectangleBlueCMToolStripMenuItem.Name = "RectangleBlueCMToolStripMenuItem";
            RectangleBlueCMToolStripMenuItem.Size = new Size(131, 26);
            RectangleBlueCMToolStripMenuItem.Text = "Blue";
            RectangleBlueCMToolStripMenuItem.Click += ChangeRectangleColorGUI;
            // 
            // rectangleStyleCMToolStripMenuItem
            // 
            rectangleStyleCMToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleCrossedCMToolStripMenuItem, rectangleRightCMToolStripMenuItem, rectangleLeftCMToolStripMenuItem });
            rectangleStyleCMToolStripMenuItem.Name = "rectangleStyleCMToolStripMenuItem";
            rectangleStyleCMToolStripMenuItem.Size = new Size(128, 26);
            rectangleStyleCMToolStripMenuItem.Text = "Style";
            // 
            // rectangleCrossedCMToolStripMenuItem
            // 
            rectangleCrossedCMToolStripMenuItem.Name = "rectangleCrossedCMToolStripMenuItem";
            rectangleCrossedCMToolStripMenuItem.Size = new Size(144, 26);
            rectangleCrossedCMToolStripMenuItem.Text = "Crossed";
            rectangleCrossedCMToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // rectangleRightCMToolStripMenuItem
            // 
            rectangleRightCMToolStripMenuItem.Name = "rectangleRightCMToolStripMenuItem";
            rectangleRightCMToolStripMenuItem.Size = new Size(144, 26);
            rectangleRightCMToolStripMenuItem.Text = "Right";
            rectangleRightCMToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // rectangleLeftCMToolStripMenuItem
            // 
            rectangleLeftCMToolStripMenuItem.Name = "rectangleLeftCMToolStripMenuItem";
            rectangleLeftCMToolStripMenuItem.Size = new Size(144, 26);
            rectangleLeftCMToolStripMenuItem.Text = "Left";
            rectangleLeftCMToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // rectangleBlueContextMenuToolStripMenuItem
            // 
            rectangleBlueContextMenuToolStripMenuItem.Name = "rectangleBlueContextMenuToolStripMenuItem";
            rectangleBlueContextMenuToolStripMenuItem.Size = new Size(224, 26);
            rectangleBlueContextMenuToolStripMenuItem.Text = "Blue";
            rectangleBlueContextMenuToolStripMenuItem.Click += ChangeRectangleColorGUI;
            // 
            // rectangleStyleContextMenuToolStripMenuItem
            // 
            rectangleStyleContextMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleRightContextMenuToolStripMenuItem, rectangleLeftContextMenuToolStripMenuItem, rectangleCrossContextMenuToolStripMenuItem });
            rectangleStyleContextMenuToolStripMenuItem.Name = "rectangleStyleContextMenuToolStripMenuItem";
            rectangleStyleContextMenuToolStripMenuItem.Size = new Size(224, 26);
            rectangleStyleContextMenuToolStripMenuItem.Text = "Style";
            // 
            // rectangleRightContextMenuToolStripMenuItem
            // 
            rectangleRightContextMenuToolStripMenuItem.Name = "rectangleRightContextMenuToolStripMenuItem";
            rectangleRightContextMenuToolStripMenuItem.Size = new Size(127, 26);
            rectangleRightContextMenuToolStripMenuItem.Text = "Right";
            rectangleRightContextMenuToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // rectangleLeftContextMenuToolStripMenuItem
            // 
            rectangleLeftContextMenuToolStripMenuItem.Name = "rectangleLeftContextMenuToolStripMenuItem";
            rectangleLeftContextMenuToolStripMenuItem.Size = new Size(127, 26);
            rectangleLeftContextMenuToolStripMenuItem.Text = "Left";
            rectangleLeftContextMenuToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // rectangleCrossContextMenuToolStripMenuItem
            // 
            rectangleCrossContextMenuToolStripMenuItem.Name = "rectangleCrossContextMenuToolStripMenuItem";
            rectangleCrossContextMenuToolStripMenuItem.Size = new Size(127, 26);
            rectangleCrossContextMenuToolStripMenuItem.Text = "Cross";
            rectangleCrossContextMenuToolStripMenuItem.Click += ChangeRectangleStyleGUI;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 652);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Company Report";
            WindowState = FormWindowState.Maximized;
            MouseClick += Form1_MouseClick;
            MouseMove += MainForm_MouseMove;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            LineContextMenuStrip.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            RectangleContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel X;
        private ContextMenuStrip LineContextMenuStrip;

        /* Tool Strip */
        private ToolStripMenuItem lineContextMenuToolStripMenuItem;
        private ToolStripMenuItem lineColorContextMenuToolStripMenuItem;
        private ToolStripMenuItem lineRedContextMenuToolStripMenuItem;
        private ToolStripMenuItem lineGreenContextMenuToolStripMenuItem;
        private ToolStripMenuItem lineBlueContextMenuToolStripMenuItem;
        private ToolStripMenuItem lineStyleContextMenuToolStripMenuItem;
        private ToolStripMenuItem solidToolStripMenuItem;
        private ToolStripMenuItem dashToolStripMenuItem;
        private ToolStripMenuItem dottedToolStripMenuItem;


        private MenuStrip menuStrip;
        private ToolStripMenuItem lineParentToolStripMenuItem;
        private ToolStripMenuItem lineColorToolStripMenuItem;
        private ToolStripMenuItem lineRedToolStripMenuItem;
        private ToolStripMenuItem lineGreenToolStripMenuItem;
        private ToolStripMenuItem lineBlueToolStripMenuItem;
        private ToolStripMenuItem lineStyleToolStripMenuItem;
        private ToolStripMenuItem lineSolidToolStripMenuItem;
        private ToolStripMenuItem lineDashedToolStripMenuItem;
        private ToolStripMenuItem lineDottedToolStripMenuItem;

        private ToolStripMenuItem rectangleParentToolStripMenuItem;
        private ToolStripMenuItem rectangleColorToolStripMenuItem;
        private ToolStripMenuItem rectangleStyleToolStripMenuItem;
        private ToolStripMenuItem rectangleRightToolStripMenuItem;
        private ToolStripMenuItem rectangleLeftToolStripMenuItem;
        private ToolStripMenuItem rectangleCrossToolStripMenuItem;
        private ToolStripMenuItem rectangleRedToolStripMenuItem;
        private ToolStripMenuItem rectangleGreenToolStripMenuItem;
        private ToolStripMenuItem rectangleBlueToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStrip toolStrip2;
        private ContextMenuStrip RectangleContextMenuStrip;
        private ToolStripMenuItem rectangleToolStripMenuItem1;
        private ToolStripMenuItem colorToolStripMenuItem3;
        private ToolStripMenuItem redToolStripMenuItem3;
        private ToolStripMenuItem greenToolStripMenuItem3;
        private ToolStripMenuItem rectangleBlueContextMenuToolStripMenuItem;
        private ToolStripMenuItem rectangleStyleContextMenuToolStripMenuItem;
        private ToolStripMenuItem rectangleRightContextMenuToolStripMenuItem;
        private ToolStripMenuItem rectangleLeftContextMenuToolStripMenuItem;
        private ToolStripMenuItem rectangleCrossContextMenuToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem rectangleColorCMToolStripMenuItem;
        private ToolStripMenuItem RectangleRedCMToolStripMenuItem;
        private ToolStripMenuItem RectangleGreenCMToolStripMenuItem;
        private ToolStripMenuItem RectangleBlueCMToolStripMenuItem;
        private ToolStripMenuItem rectangleStyleCMToolStripMenuItem;
        private ToolStripMenuItem rectangleCrossedCMToolStripMenuItem;
        private ToolStripMenuItem rectangleRightCMToolStripMenuItem;
        private ToolStripMenuItem rectangleLeftCMToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem companyNameToolStripMenuItem;
    }
}
