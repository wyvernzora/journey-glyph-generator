namespace JourneyGlyphGen
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbCustomization = new System.Windows.Forms.GroupBox();
            this.nudBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.lblBorderColor = new System.Windows.Forms.Label();
            this.lblMainColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRotCW = new System.Windows.Forms.Button();
            this.btnRotCCW = new System.Windows.Forms.Button();
            this.btnFlipX = new System.Windows.Forms.Button();
            this.btnFlipY = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNW = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.btnSW = new System.Windows.Forms.Button();
            this.btnSE = new System.Windows.Forms.Button();
            this.pbPartSelection = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvGlyphs = new System.Windows.Forms.ListView();
            this.glyphList = new System.Windows.Forms.ImageList(this.components);
            this.imageGlyph = new Cyotek.Windows.Forms.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGlyphImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGlyphIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateRandomGlyphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbCustomization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderWidth)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartSelection)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbCustomization);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageGlyph);
            this.splitContainer1.Size = new System.Drawing.Size(984, 597);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbCustomization
            // 
            this.gbCustomization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomization.Controls.Add(this.nudBorderWidth);
            this.gbCustomization.Controls.Add(this.lblBorderColor);
            this.gbCustomization.Controls.Add(this.lblMainColor);
            this.gbCustomization.Controls.Add(this.label3);
            this.gbCustomization.Controls.Add(this.label2);
            this.gbCustomization.Controls.Add(this.label1);
            this.gbCustomization.Controls.Add(this.tableLayoutPanel2);
            this.gbCustomization.Controls.Add(this.tableLayoutPanel1);
            this.gbCustomization.Controls.Add(this.pbPartSelection);
            this.gbCustomization.Location = new System.Drawing.Point(12, 208);
            this.gbCustomization.Name = "gbCustomization";
            this.gbCustomization.Size = new System.Drawing.Size(307, 377);
            this.gbCustomization.TabIndex = 1;
            this.gbCustomization.TabStop = false;
            this.gbCustomization.Text = "Customization";
            // 
            // nudBorderWidth
            // 
            this.nudBorderWidth.DecimalPlaces = 2;
            this.nudBorderWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudBorderWidth.Location = new System.Drawing.Point(107, 240);
            this.nudBorderWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudBorderWidth.Name = "nudBorderWidth";
            this.nudBorderWidth.Size = new System.Drawing.Size(161, 20);
            this.nudBorderWidth.TabIndex = 10;
            this.nudBorderWidth.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // lblBorderColor
            // 
            this.lblBorderColor.BackColor = System.Drawing.Color.White;
            this.lblBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBorderColor.Location = new System.Drawing.Point(107, 191);
            this.lblBorderColor.Name = "lblBorderColor";
            this.lblBorderColor.Size = new System.Drawing.Size(161, 20);
            this.lblBorderColor.TabIndex = 9;
            this.lblBorderColor.Text = "Click to change";
            this.lblBorderColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMainColor
            // 
            this.lblMainColor.BackColor = System.Drawing.Color.Black;
            this.lblMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMainColor.ForeColor = System.Drawing.Color.White;
            this.lblMainColor.Location = new System.Drawing.Point(107, 166);
            this.lblMainColor.Name = "lblMainColor";
            this.lblMainColor.Size = new System.Drawing.Size(161, 20);
            this.lblMainColor.TabIndex = 8;
            this.lblMainColor.Text = "Click to change";
            this.lblMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Border Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Border Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Main Color";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnRotCW, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRotCCW, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnFlipX, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFlipY, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(140, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(158, 128);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnRotCW
            // 
            this.btnRotCW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotCW.Location = new System.Drawing.Point(3, 3);
            this.btnRotCW.Name = "btnRotCW";
            this.btnRotCW.Size = new System.Drawing.Size(152, 26);
            this.btnRotCW.TabIndex = 0;
            this.btnRotCW.Text = "Rotate Clockwise";
            this.btnRotCW.UseVisualStyleBackColor = true;
            // 
            // btnRotCCW
            // 
            this.btnRotCCW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotCCW.Location = new System.Drawing.Point(3, 35);
            this.btnRotCCW.Name = "btnRotCCW";
            this.btnRotCCW.Size = new System.Drawing.Size(152, 26);
            this.btnRotCCW.TabIndex = 1;
            this.btnRotCCW.Text = "Rotate Counter Clockwise";
            this.btnRotCCW.UseVisualStyleBackColor = true;
            // 
            // btnFlipX
            // 
            this.btnFlipX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlipX.Location = new System.Drawing.Point(3, 67);
            this.btnFlipX.Name = "btnFlipX";
            this.btnFlipX.Size = new System.Drawing.Size(152, 26);
            this.btnFlipX.TabIndex = 2;
            this.btnFlipX.Text = "Flip along X-axis";
            this.btnFlipX.UseVisualStyleBackColor = true;
            // 
            // btnFlipY
            // 
            this.btnFlipY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlipY.Location = new System.Drawing.Point(3, 99);
            this.btnFlipY.Name = "btnFlipY";
            this.btnFlipY.Size = new System.Drawing.Size(152, 26);
            this.btnFlipY.TabIndex = 3;
            this.btnFlipY.Text = "Flip along Y-axis";
            this.btnFlipY.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnNW, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSW, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSE, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 274);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 97);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnNW
            // 
            this.btnNW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNW.Location = new System.Drawing.Point(3, 3);
            this.btnNW.Name = "btnNW";
            this.btnNW.Size = new System.Drawing.Size(141, 42);
            this.btnNW.TabIndex = 0;
            this.btnNW.Text = "Top Left";
            this.btnNW.UseVisualStyleBackColor = true;
            // 
            // btnNE
            // 
            this.btnNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNE.Location = new System.Drawing.Point(150, 3);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(142, 42);
            this.btnNE.TabIndex = 1;
            this.btnNE.Text = "Top Right";
            this.btnNE.UseVisualStyleBackColor = true;
            // 
            // btnSW
            // 
            this.btnSW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSW.Location = new System.Drawing.Point(3, 51);
            this.btnSW.Name = "btnSW";
            this.btnSW.Size = new System.Drawing.Size(141, 43);
            this.btnSW.TabIndex = 2;
            this.btnSW.Text = "Bottom Left";
            this.btnSW.UseVisualStyleBackColor = true;
            // 
            // btnSE
            // 
            this.btnSE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSE.Location = new System.Drawing.Point(150, 51);
            this.btnSE.Name = "btnSE";
            this.btnSE.Size = new System.Drawing.Size(142, 43);
            this.btnSE.TabIndex = 3;
            this.btnSE.Text = "Bottom Right";
            this.btnSE.UseVisualStyleBackColor = true;
            // 
            // pbPartSelection
            // 
            this.pbPartSelection.BackColor = System.Drawing.Color.White;
            this.pbPartSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPartSelection.Location = new System.Drawing.Point(6, 24);
            this.pbPartSelection.Name = "pbPartSelection";
            this.pbPartSelection.Size = new System.Drawing.Size(128, 128);
            this.pbPartSelection.TabIndex = 2;
            this.pbPartSelection.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvGlyphs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Glyph Parts";
            // 
            // lvGlyphs
            // 
            this.lvGlyphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGlyphs.LargeImageList = this.glyphList;
            this.lvGlyphs.Location = new System.Drawing.Point(3, 16);
            this.lvGlyphs.Name = "lvGlyphs";
            this.lvGlyphs.Size = new System.Drawing.Size(304, 171);
            this.lvGlyphs.TabIndex = 0;
            this.lvGlyphs.TileSize = new System.Drawing.Size(48, 48);
            this.lvGlyphs.UseCompatibleStateImageBehavior = false;
            this.lvGlyphs.View = System.Windows.Forms.View.Tile;
            // 
            // glyphList
            // 
            this.glyphList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.glyphList.ImageSize = new System.Drawing.Size(48, 48);
            this.glyphList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageGlyph
            // 
            this.imageGlyph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageGlyph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageGlyph.GridColor = System.Drawing.Color.LightGray;
            this.imageGlyph.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.Medium;
            this.imageGlyph.Location = new System.Drawing.Point(0, 0);
            this.imageGlyph.Name = "imageGlyph";
            this.imageGlyph.Size = new System.Drawing.Size(646, 597);
            this.imageGlyph.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.randomizeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGlyphImageToolStripMenuItem,
            this.saveGlyphIconToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveGlyphImageToolStripMenuItem
            // 
            this.saveGlyphImageToolStripMenuItem.Name = "saveGlyphImageToolStripMenuItem";
            this.saveGlyphImageToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.saveGlyphImageToolStripMenuItem.Text = "Save Glyph Image...";
            this.saveGlyphImageToolStripMenuItem.Click += new System.EventHandler(this.saveGlyphImageToolStripMenuItem_Click);
            // 
            // saveGlyphIconToolStripMenuItem
            // 
            this.saveGlyphIconToolStripMenuItem.Name = "saveGlyphIconToolStripMenuItem";
            this.saveGlyphIconToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.saveGlyphIconToolStripMenuItem.Text = "Save Glyph in typical Icon sizes...";
            this.saveGlyphIconToolStripMenuItem.Click += new System.EventHandler(this.saveGlyphIconToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateRandomGlyphToolStripMenuItem});
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            // 
            // generateRandomGlyphToolStripMenuItem
            // 
            this.generateRandomGlyphToolStripMenuItem.Name = "generateRandomGlyphToolStripMenuItem";
            this.generateRandomGlyphToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.generateRandomGlyphToolStripMenuItem.Text = "Generate Random Glyph";
            this.generateRandomGlyphToolStripMenuItem.Click += new System.EventHandler(this.generateRandomGlyphToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 660);
            this.Name = "MainWindow";
            this.Text = "Journey Glyph Generator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbCustomization.ResumeLayout(false);
            this.gbCustomization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderWidth)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPartSelection)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Cyotek.Windows.Forms.ImageBox imageGlyph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvGlyphs;
        private System.Windows.Forms.ImageList glyphList;
        private System.Windows.Forms.GroupBox gbCustomization;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbPartSelection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNW;
        private System.Windows.Forms.Button btnNE;
        private System.Windows.Forms.Button btnSW;
        private System.Windows.Forms.Button btnSE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRotCW;
        private System.Windows.Forms.Button btnRotCCW;
        private System.Windows.Forms.Button btnFlipX;
        private System.Windows.Forms.Button btnFlipY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBorderWidth;
        private System.Windows.Forms.Label lblBorderColor;
        private System.Windows.Forms.Label lblMainColor;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGlyphImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGlyphIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateRandomGlyphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}

