using System.Windows.Forms;
using System.Drawing;

namespace aspect_ratio_calculator
{
    abstract class LayoutBase
    {
        protected string layoutLetter;
        protected Color activeButtonBackground;
        protected Color activeButtonText;
        protected Color inActiveButtonBackground;
        protected Color inActiveButtonText;
        protected Color backgroundColor;
        protected Color labelBackground;
        protected Color labelText;
        protected Color calculateBackground;
        protected Color calculateText;
        protected Color layoutBackground;
        protected Color layoutText;
        public void setActive(Button b)
        {
            b.BackColor = activeButtonBackground;
            b.ForeColor = activeButtonText;
        }
        public void setInactive(Button b)
        {
            b.BackColor = inActiveButtonBackground;
            b.ForeColor = inActiveButtonText;
        }
        public Color getBackgroundColor()
        {
            return backgroundColor;
        }
        public void updateLabel(Label l)
        {
            l.BackColor = labelBackground;
            l.ForeColor = labelText;
        }
        public void updateCalculate(Button b)
        {
            b.BackColor = calculateBackground;
            b.ForeColor = calculateText;
        }
        public void updateLayout(Button b)
        {
            b.BackColor = layoutBackground;
            b.ForeColor = layoutText;
            b.Text = layoutLetter;
        }
    }
}
