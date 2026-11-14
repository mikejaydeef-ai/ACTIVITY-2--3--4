#nullable disable
using System.Drawing;

namespace Login_Sign_in
{
    public static class Thm
    {
        public static readonly Color Navy = Color.FromArgb(15, 45, 74);
        public static readonly Color NavyHover = Color.FromArgb(10, 32, 54);
        public static readonly Color Blue = Color.FromArgb(37, 125, 214);
        public static readonly Color BlueHover = Color.FromArgb(28, 102, 180);
        public static readonly Color Light = Color.FromArgb(234, 244, 253);
        public static readonly Color LightDeep = Color.FromArgb(208, 229, 249);
        public static readonly Color LightDeepHover = Color.FromArgb(190, 217, 244);
        public static readonly Color Muted = Color.FromArgb(84, 110, 138);
        public static readonly Color InputBack = Color.FromArgb(244, 249, 254);

        private const int CardRadius = 10;
        private const int ButtonRadius = 8;

        private static System.Drawing.Font F(string name, float size) =>
            new System.Drawing.Font(name, size);

        public static void Apply(Form form)
        {
            form.BackColor = Light;
            form.ForeColor = Navy;
            Style(form.Controls);
        }

        private static void Style(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                string tag = c.Tag as string;

                switch (c)
                {
                    case Button b:
                        StyleButton(b);
                        break;

                    case TextBox t:
                        t.BorderStyle = BorderStyle.FixedSingle;
                        t.BackColor = InputBack;
                        t.ForeColor = Navy;
                        t.Font = F("Segoe UI", 11F);
                        break;

                    case ComboBox cb:
                        cb.FlatStyle = FlatStyle.Flat;
                        cb.BackColor = InputBack;
                        cb.ForeColor = Navy;
                        break;

                    case LinkLabel l:
                        l.LinkColor = Blue;
                        l.ActiveLinkColor = BlueHover;
                        l.VisitedLinkColor = Blue;
                        l.LinkBehavior = LinkBehavior.HoverUnderline;
                        l.ForeColor = Muted;
                        break;

                    case Label l:
                        StyleLabel(l, tag);
                        break;

                    case Panel p:
                        if (tag == "card")
                        {
                            p.BackColor = Color.White;
                            if (CardRadius > 0) Round(p, CardRadius);
                        }
                        else if (tag == "cardOn") p.BackColor = Blue;
                        else if (tag == "header") p.BackColor = Navy;
                        break;
                }

                if (c.HasChildren) Style(c.Controls);
            }
        }

        private static void StyleLabel(Label l, string tag)
        {
            switch (tag)
            {
                case "title": l.Font = F("Segoe UI Semibold", 22F); l.ForeColor = Navy; break;
                case "section": l.Font = F("Segoe UI Semibold", 14F); l.ForeColor = Navy; break;
                case "muted": l.Font = F("Segoe UI", 10F); l.ForeColor = Muted; break;
                case "caption": l.Font = F("Segoe UI", 9F); l.ForeColor = Muted; break;
                case "headerText": l.Font = F("Segoe UI Semibold", 12F); l.ForeColor = Color.White; break;
                case "brand": l.Font = F("Segoe UI Semibold", 16F); l.ForeColor = Color.White; break;
                case "cardTitle": l.Font = F("Segoe UI Semibold", 10.5F); l.ForeColor = Muted; break;
                case "cardValue": l.Font = F("Segoe UI Semibold", 24F); l.ForeColor = Navy; break;
                case "cardTitleOn": l.Font = F("Segoe UI Semibold", 10.5F); l.ForeColor = Light; break;
                case "cardValueOn": l.Font = F("Segoe UI Semibold", 24F); l.ForeColor = Color.White; break;
                case "avatar":
                    l.Font = F("Segoe UI Semibold", 11F);
                    l.ForeColor = Color.White;
                    l.BackColor = Blue;
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    Round(l, 0); 
                    break;
            }
        }

        private static void StyleButton(Button b)
        {
            string kind = b.Tag as string;
            Color normal = Blue, hover = BlueHover, fore = Color.White;

            if (kind == "secondary") { normal = LightDeep; hover = LightDeepHover; fore = Navy; }
            else if (kind == "dark") { normal = Navy; hover = NavyHover; }

            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.UseVisualStyleBackColor = false;
            b.BackColor = normal;
            b.ForeColor = fore;
            b.Font = F("Segoe UI Semibold", 10.5F);
            b.Cursor = Cursors.Hand;
            b.MouseEnter += (s, e) => b.BackColor = hover;
            b.MouseLeave += (s, e) => b.BackColor = normal;
            if (ButtonRadius > 0) Round(b, ButtonRadius);
        }

        private static void Round(Control c, int radius)
        {
            void Reshape()
            {
                if (c.Width < 2 || c.Height < 2) return;
                int max = Math.Min(c.Width, c.Height) / 2;
                int r = radius > 0 ? Math.Min(radius, max) : max;
                int d = r * 2;

                using var path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(c.Width - d, 0, d, d, 270, 90);
                path.AddArc(c.Width - d, c.Height - d, d, d, 0, 90);
                path.AddArc(0, c.Height - d, d, d, 90, 90);
                path.CloseFigure();

                var old = c.Region;
                c.Region = new Region(path);
                old?.Dispose();
            }

            Reshape();
            c.SizeChanged += (s, e) => Reshape();
        }
    }
}