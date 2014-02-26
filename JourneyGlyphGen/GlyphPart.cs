using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyGlyphGen
{
    /// <summary>
    /// Essentially a 3x3 bit matrix.
    /// </summary>
    public class GlyphPart : ICloneable
    {
        private Boolean[,] data;

        protected GlyphPart()
        {
            MainColor = Color.Black;
            BorderColor = Color.White;
            BorderWidth = 0.25F;
        }

        public GlyphPart(Boolean[,] raw) : this()
        {
            if (raw.GetLength(0) != 3 || raw.GetLength(1) != 3)
                throw new ArgumentException("Expecting a 3x3 boolean array");

            data = Rotate(raw);
        }

        public Boolean this[int x, int y]
        {
            get { return data[x, y]; }
            set { data[x, y] = value; }
        }

        public GlyphPart ApplyTransforms(params GlyphPartTransform[] transforms)
        {
            var gp = this;
            return transforms.Aggregate(gp, (current, t) => current.ApplyTransformInner(t));
        }

        private GlyphPart ApplyTransformInner(GlyphPartTransform transform)
        {
            switch (transform)
            {
                case GlyphPartTransform.Rotate:
                    return new GlyphPart {data = Rotate(data) };
                case GlyphPartTransform.FlipX:
                    return new GlyphPart { data = FlipX(data) };
                case GlyphPartTransform.FlipY:
                    return new GlyphPart { data = FlipY(data) };
            }

            throw new Exception();
        }

        public Bitmap GetBitmap(Int32 size)
        {
            if (size % 8 != 0)
                throw new ArgumentException("Size of the bitmap has to be a multiple of 8!");

            var cellSize = size / 4;
            var margin = cellSize / 2;
            var border = (int) Math.Ceiling(cellSize * BorderWidth);

            var bitmap = new Bitmap(size, size);
            using (var gfx = Graphics.FromImage(bitmap))
            {
                var rects = new List<Rectangle>();
                var borders = new List<Rectangle>();

                for (int x = 0; x < 3; x++)
                    for (int y = 0; y < 3; y++)
                    {
                        if (!this[x,y]) continue;

                        var rect = new Rectangle(
                            margin + x * cellSize,
                            margin + y * cellSize,
                            cellSize, cellSize);
                        rects.Add(rect);

                        borders.Add(new Rectangle(
                            margin + x * cellSize - border,
                            margin + y * cellSize - border,
                            cellSize + 2 * border, cellSize + 2 * border));
                    }
                
                using (var p = new SolidBrush(BorderColor))
                using (var b = new SolidBrush(MainColor))
                {
                    gfx.FillRectangles(p, borders.ToArray());
                    gfx.FillRectangles(b, rects.ToArray());
                }
            }

            return bitmap;
        }

        #region Properties

        public Color MainColor { get; set; }

        public Color BorderColor { get; set; }

        public Single BorderWidth { get; set; }

        #endregion

        #region Helpers

        static Boolean[,] Rotate(Boolean[,] data)
        {
            var result = new Boolean[3, 3];

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    result[i, j] = data[3 - j - 1, i];

            return result;
        }

        static Boolean[,] FlipY(Boolean[,] data)
        {
            var result = new Boolean[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    result[i, j] = data[2 - i, j];

            return result;
        }

        static Boolean[,] FlipX(Boolean[,] data)
        {
            var result = new Boolean[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    result[i, j] = data[i, 2 - j];

            return result;
        }

        public static Bitmap BuildGlyph(GlyphPart[] parts, Int32 size)
        {
            if (size % 16 != 0)
                throw new ArgumentException("Size of the bitmap has to be a multiple of 8!");

            var cellSize = size / 2;

            var bitmap = new Bitmap(size, size);
            using (var gfx = Graphics.FromImage(bitmap))
            {

                if (parts[0] != null)
                    gfx.DrawImageUnscaled(parts[0].GetBitmap(cellSize), 0, 0);
                if (parts[1] != null)
                    gfx.DrawImageUnscaled(parts[1].GetBitmap(cellSize), cellSize, 0);
                if (parts[2] != null)
                    gfx.DrawImageUnscaled(parts[2].GetBitmap(cellSize), 0, cellSize);
                if (parts[3] != null)
                    gfx.DrawImageUnscaled(parts[3].GetBitmap(cellSize), cellSize, cellSize);
            }

            return bitmap;
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new GlyphPart
            {
                data = data,
                BorderColor = BorderColor,
                BorderWidth = BorderWidth,
                MainColor = MainColor
            };
        }

        #endregion
    }
}
