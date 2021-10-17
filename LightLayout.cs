using System.Drawing;

namespace aspect_ratio_calculator
{
    class LightLayout : LayoutBase
    {
        public LightLayout()
        {
            layoutLetter = "L";
            activeButtonBackground = Color.FromArgb(64, 64, 64);
            activeButtonText = Color.FromArgb(251, 249, 204);
            inActiveButtonBackground = Color.FromArgb(251, 249, 204);
            inActiveButtonText = Color.Black;
            backgroundColor = Color.FromArgb(255, 255, 236);
            labelBackground = Color.FromArgb(255, 255, 236);
            labelText = Color.Black;
            calculateBackground = Color.Black;
            calculateText = Color.FromArgb(251, 249, 204);
            layoutBackground = Color.FromArgb(255, 255, 236);
            layoutText = Color.Black;
        }
    }
}
