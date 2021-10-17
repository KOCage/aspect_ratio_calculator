using System.Drawing;

namespace aspect_ratio_calculator
{
    class DarkLayout : LayoutBase
    {
        public DarkLayout()
        {
            layoutLetter = "D";
            activeButtonBackground = Color.FromArgb(200, 247, 249);
            activeButtonText = Color.FromArgb(0, 0, 0);
            inActiveButtonBackground = Color.FromArgb(64, 64, 64);
            inActiveButtonText = Color.FromArgb(200, 247, 249);
            backgroundColor = Color.FromArgb(0, 0, 0);
            labelBackground = Color.FromArgb(0, 0, 0);
            labelText = Color.FromArgb(200, 247, 249);
            calculateBackground = Color.Maroon;
            calculateText = Color.FromArgb(200, 247, 249);
            layoutBackground = Color.FromArgb(0, 0, 0);
            layoutText = Color.FromArgb(200, 247, 249);
        }
    }
}
