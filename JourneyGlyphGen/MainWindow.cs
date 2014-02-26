using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JourneyGlyphGen
{
    public partial class MainWindow : Form
    {
        const Int32 GlyphSize = 512;

        private List<GlyphPart> glyphParts = new List<GlyphPart>();
        private GlyphPart[] glyph = new GlyphPart[4];
        private GlyphPart selectedPart = null;

        

        public MainWindow()
        {
            InitializeComponent();
            
            // Load glyphs file
            if (!File.Exists("GlyphParts.txt")) {
                MessageBox.Show("Cannot find the GlyphParts.txt\nPlease download the default one from the project repository:\n\thttp://github.com/jluchiji/journey-glyph-generator");
                Application.Exit();
            }
#if !DEBUG
            try {
#endif
            var lines = new Queue<String>(File.ReadAllLines("GlyphParts.txt"));
            while (lines.Count > 0) {
                var str = lines.Peek();
                if (String.IsNullOrWhiteSpace(str) || str.StartsWith("//"))
                {
                    lines.Dequeue();
                    continue;
                }

                var data = new bool[3, 3];
                for (int i = 0; i < 3; i++) {
                    var dat = lines.Dequeue();
                    for (int j = 0; j < 3; j++)
                        data[i, j] = dat[j] == '#';
                }

                glyphParts.Add(new GlyphPart(data));
            }
#if !DEBUG
            }
            catch
            {
                MessageBox.Show(
                    "Failed to load GlyphParts.txt.\nPlease download the default one from the project repository:\n\thttp://github.com/jluchiji/journey-glyph-generator");
                Application.Exit();
            }
#endif

            LoadUi();
            AttachEventHandlers();

        }

        void LoadUi()
        {
            lvGlyphs.BeginUpdate();

            foreach (var g in glyphParts)
            {
                var guid = Guid.NewGuid().ToString();
                glyphList.Images.Add(guid, g.GetBitmap(48));
                lvGlyphs.Items.Add(new ListViewItem(".", guid) { Tag = g });
            }
            lvGlyphs.EndUpdate();
        }

        void AttachEventHandlers()
        {
            lvGlyphs.ItemSelectionChanged += (@s, e) =>
            {
                if (lvGlyphs.SelectedItems.Count == 0) {
                    selectedPart = null;
                    pbPartSelection.Image = null;
                    gbCustomization.Enabled = false;
                }
                else
                {
                    selectedPart = (GlyphPart)lvGlyphs.SelectedItems[0].Tag;
                    pbPartSelection.Image = selectedPart.GetBitmap(128);
                    UpdateColors();
                    gbCustomization.Enabled = true;
                }
            };

            btnRotCW.Click += (@s, e) =>
            {
                if (selectedPart == null)
                    return;

                selectedPart = selectedPart.ApplyTransforms(GlyphPartTransform.Rotate,
                    GlyphPartTransform.Rotate, GlyphPartTransform.Rotate);

                var old = pbPartSelection.Image;
                pbPartSelection.Image = selectedPart.GetBitmap(128);
                old.Dispose();
            };
            btnRotCCW.Click += (@s, e) =>
            {
                if (selectedPart == null)
                    return;

                selectedPart = selectedPart.ApplyTransforms(GlyphPartTransform.Rotate);

                var old = pbPartSelection.Image;
                pbPartSelection.Image = selectedPart.GetBitmap(128);
                old.Dispose();
            };
            btnFlipX.Click += (@s, e) =>
            {
                if (selectedPart == null)
                    return;

                selectedPart = selectedPart.ApplyTransforms(GlyphPartTransform.FlipX);

                var old = pbPartSelection.Image;
                pbPartSelection.Image = selectedPart.GetBitmap(128);
                old.Dispose();
            };
            btnFlipY.Click += (@s, e) =>
            {
                if (selectedPart == null)
                    return;

                selectedPart = selectedPart.ApplyTransforms(GlyphPartTransform.FlipY);

                var old = pbPartSelection.Image;
                pbPartSelection.Image = selectedPart.GetBitmap(128);
                old.Dispose();
            };

            btnNW.Click += (@s, e) =>
            {
                glyph[0] = selectedPart;
                UpdateGlyph();
                selectedPart = (GlyphPart)selectedPart.Clone();
            };
            btnNE.Click += (@s, e) =>
            {
                glyph[1] = selectedPart;
                UpdateGlyph();
                selectedPart = (GlyphPart)selectedPart.Clone();
            };
            btnSW.Click += (@s, e) =>
            {
                glyph[2] = selectedPart;
                UpdateGlyph();
                selectedPart = (GlyphPart)selectedPart.Clone();
            };
            btnSE.Click += (@s, e) =>
            {
                glyph[3] = selectedPart;
                UpdateGlyph();
                selectedPart = (GlyphPart)selectedPart.Clone();
            };

            lblMainColor.Click += (@s, e) =>
            {

                var dlg = new ColorDialog();
                if (dlg.ShowDialog() == DialogResult.OK) {
                    selectedPart.MainColor = dlg.Color;
                    pbPartSelection.Image = selectedPart.GetBitmap(128);
                    UpdateColors();
                }
            };
            lblBorderColor.Click += (@s, e) =>
            {

                var dlg = new ColorDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    selectedPart.BorderColor = dlg.Color;
                    pbPartSelection.Image = selectedPart.GetBitmap(128);
                    UpdateColors();
                }
            };
            nudBorderWidth.ValueChanged += (@s, e) =>
            {
                selectedPart.BorderWidth = (Single)nudBorderWidth.Value;
                pbPartSelection.Image = selectedPart.GetBitmap(128);
                UpdateColors();
            };
        }

        void UpdateGlyph()
        {
            foreach (var g in glyph.Where(t => t != null))
                g.BorderWidth = (Single) nudBorderWidth.Value;
            var gBitmap = GlyphPart.BuildGlyph(glyph, GlyphSize);
            var old = imageGlyph.Image;
            imageGlyph.Image = gBitmap;
            if (old != null) old.Dispose();
        }

        void UpdateColors()
        {
            if (selectedPart == null)
                return;

            lblMainColor.BackColor = selectedPart.MainColor;
            lblMainColor.ForeColor = Negate(selectedPart.MainColor);
            lblBorderColor.BackColor = selectedPart.BorderColor;
            lblBorderColor.ForeColor = Negate(selectedPart.BorderColor);
        }

        Color Negate(Color c)
        {
            return Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
        }

        private void saveGlyphImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int size;

            var sizeDlg = new SizeDialog();
            if (sizeDlg.ShowDialog(this) == DialogResult.OK)
                size = sizeDlg.Size;
            else
                return;

            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                using (var bmp = GlyphPart.BuildGlyph(glyph, size))
                    bmp.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        private void saveGlyphIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sizes = new[] { 16, 32, 48, 64, 128, 256 };

            var sfd = new FolderBrowserDialog();
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var s in sizes)
                {
                    using (var bmp = GlyphPart.BuildGlyph(glyph, s))
                        bmp.Save(Path.Combine(sfd.SelectedPath, s + ".png"), ImageFormat.Png);
                }

            }
        }

        private void generateRandomGlyphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            for (int i = 0; i < 4; i++) {
                var partIndex = rand.Next(0, glyphParts.Count);
                selectedPart = glyphParts[partIndex];

                var t = rand.Next(0, 8);
                for (int k = 0; k < t; k++) {
                    var transform = (GlyphPartTransform) rand.Next(0, 3);
                    selectedPart = selectedPart.ApplyTransforms(transform);
                }

                glyph[i] = selectedPart;
            }

            UpdateGlyph();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Made by Aragorn Wyvernzora (http://github.com/jluchiji)\n\nDo whatever you want with this software." +
                "For full license text, please see LICENSE.md in the project repository:\n\thttp://github.com/jluchiji/journey-glyph-generator",
                "Journey Glyph Generator",
                MessageBoxButtons.OK);
        }
    }
}
