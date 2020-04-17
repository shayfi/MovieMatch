using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MediaDataConfig
{
    class StarRatingControl : Control
    {
        private Rectangle[] m_starAreas;
        private int m_leftMargin = 2;
        private int m_rightMargin = 2;
        private int m_topMargin = 2;
        private int m_bottomMargin = 2;

        private int StarCount = 10;
        private int StarSpacing = 4;
        private int OutlineThickness = 1;
        Color OutlineColor = Color.Gray;
        Color SelectedColor = Color.Yellow;
        public int SelectedStar {get; set;}
        public StarRatingControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            Width = 180;
            Height = 18;

            m_starAreas = new Rectangle[StarCount];
            SelectedStar = 0;
        }

        public int LeftMargin
        {
            get
            {
                return m_leftMargin;
            }
            set
            {
                if (m_leftMargin != value)
                {
                    m_leftMargin = value;
                    Invalidate();
                }
            }
        }

        public int RightMargin
        {
            get
            {
                return m_rightMargin;
            }
            set
            {
                if (m_rightMargin != value)
                {
                    m_rightMargin = value;
                    Invalidate();
                }
            }
        }

        public int TopMargin
        {
            get
            {
                return m_topMargin;
            }
            set
            {
                if (m_topMargin != value)
                {
                    m_topMargin = value;
                    Invalidate();
                }
            }
        }

        public int BottomMargin
        {
            get
            {
                return m_bottomMargin;
            }
            set
            {
                if (m_bottomMargin != value)
                {
                    m_bottomMargin = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.Clear(BackColor);

            int starWidth = (Width - (LeftMargin + RightMargin +
                                    (StarSpacing * (StarCount - 1)))) / StarCount;
            int starHeight = (Height - (TopMargin + BottomMargin));

            Rectangle drawArea =
                    new Rectangle(LeftMargin, TopMargin, starWidth, starHeight);

            for (int i = 0; i < StarCount; ++i)
            {
                m_starAreas[i].X = drawArea.X - StarSpacing / 2;
                m_starAreas[i].Y = drawArea.Y;
                m_starAreas[i].Width = drawArea.Width + StarSpacing / 2;
                m_starAreas[i].Height = drawArea.Height;

                DrawStar(pe.Graphics, drawArea, i);

                drawArea.X += drawArea.Width + StarSpacing;
            }

            base.OnPaint(pe);
        }

        protected void DrawStar(Graphics g, Rectangle rect, int starAreaIndex)
        {
            Brush fillBrush;
            Pen outlinePen = new Pen(OutlineColor, OutlineThickness);

            if (SelectedStar > starAreaIndex)
            {
                fillBrush = new LinearGradientBrush(rect,
                       SelectedColor, BackColor, LinearGradientMode.ForwardDiagonal);
            }
            else
            {
                fillBrush = new SolidBrush(BackColor);
            }

            PointF[] p = new PointF[10];
            p[0].X = rect.X + (rect.Width / 2);
            p[0].Y = rect.Y;
            p[1].X = rect.X + (42 * rect.Width / 64);
            p[1].Y = rect.Y + (19 * rect.Height / 64);
            p[2].X = rect.X + rect.Width;
            p[2].Y = rect.Y + (22 * rect.Height / 64);
            p[3].X = rect.X + (48 * rect.Width / 64);
            p[3].Y = rect.Y + (38 * rect.Height / 64);
            p[4].X = rect.X + (52 * rect.Width / 64);
            p[4].Y = rect.Y + rect.Height;
            p[5].X = rect.X + (rect.Width / 2);
            p[5].Y = rect.Y + (52 * rect.Height / 64);
            p[6].X = rect.X + (12 * rect.Width / 64);
            p[6].Y = rect.Y + rect.Height;
            p[7].X = rect.X + rect.Width / 4;
            p[7].Y = rect.Y + (38 * rect.Height / 64);
            p[8].X = rect.X;
            p[8].Y = rect.Y + (22 * rect.Height / 64);
            p[9].X = rect.X + (22 * rect.Width / 64);
            p[9].Y = rect.Y + (19 * rect.Height / 64);

            g.FillPolygon(fillBrush, p);
            g.DrawPolygon(outlinePen, p);
        }

    }
}
