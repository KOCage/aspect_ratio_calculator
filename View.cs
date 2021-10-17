using System;
using System.Windows.Forms;

namespace aspect_ratio_calculator
{
    public partial class View : Form
    {
        private Controller c;
        private Model m;

        private LayoutBase layout;

        public View(Controller inController, Model inModel)
        {
            c = inController;
            c.setView(this);
            m = inModel;
            InitializeComponent();
            if (m.loadLayout().Equals('D'))
                layout = new DarkLayout();
            else
                layout = new LightLayout();
            c.changeToARMode();
            updateLayout();
        }

        private void clickAspectRatioButton(object sender, MouseEventArgs e)
        {
            c.switchMode(Controller.Mode.AR);
        }
        private void clickWireDiameterButton(object sender, MouseEventArgs e)
        {
            c.switchMode(Controller.Mode.WD);
        }
        private void clickInnerDiameterButton(object sender, MouseEventArgs e)
        {
            c.switchMode(Controller.Mode.ID);
        }

        public void enableARButton()
        {
            layout.setActive(ARButton);
            Text = "Aspect Ratio";
        }
        public void disableARButton()
        {
            layout.setInactive(ARButton);
        }

        public void enableWDButton()
        {
            layout.setActive(WDButton);
            Text = "Wire Diameter";
        }
        public void disableWDButton()
        {
            layout.setInactive(WDButton);
        }

        public void enableIDButton()
        {
            layout.setActive(IDButton);
            Text = "Inner Diameter";
        }
        public void disableIDButton()
        {
            layout.setInactive(IDButton);
        }

        public void setLabelInput1(string newText)
        {
            labelInput1.Text = newText;
        }
        public void setLabelInput2(string newText)
        {
            labelInput2.Text = newText;
        }

        public void updateUnit1(string[] units)
        {
            comboBoxUnit1.Items.Clear();
            comboBoxUnit1.Items.AddRange(units);
        }
        public void updateUnit2(string[] units)
        {
            comboBoxUnit2.Items.Clear();
            comboBoxUnit2.Items.AddRange(units);
        }

        public void disableUnit1()
        {
            comboBoxUnit1.Hide();
        }
        public void enableUnit1()
        {
            comboBoxUnit1.Show();
        }

        public void disableUnit2()
        {
            comboBoxUnit2.Hide();
        }
        public void enableUnit2()
        {
            comboBoxUnit2.Show();
        }

        public string getInput1()
        {
            return textBoxInput1.Text;
        }
        public string getInput2()
        {
            return textBoxInput2.Text;
        }

        public string getUnit1()
        {
            return comboBoxUnit1.SelectedItem.ToString();
        }
        public string getUnit2()
        {
            return comboBoxUnit2.SelectedItem.ToString();
        }

        public void clearLayout()
        {
            textBoxInput1.Text = "";
            textBoxInput2.Text = "";
            comboBoxUnit1.Text = "";
            comboBoxUnit2.Text = "";
            clearResults();
        }
        public void clearResults()
        {
            labelResult.Text = "";
        }

        public void updateResult(string result)
        {
            labelResult.Text = result;
        }

        private void clickCalculateButton(object sender, MouseEventArgs e)
        {   
            try
            {
                c.performCalculation();
            } catch {
                MessageBox.Show("One more more values are missing.", "Error", MessageBoxButtons.OK);
            }
        }
        private void clickSwitchLayout(object sender, EventArgs e)
        {
            char layoutChar = ' ';
            if (layout is DarkLayout)
            {
                layout = new LightLayout();
                layoutChar = 'L';
            }
            else
            {
                layout = new DarkLayout();
                layoutChar = 'D';
            }
            updateLayout();
            m.saveLayout(layoutChar);
        }
        public void updateLayout()
        {
            switch(c.getCurrentMode())
            {
                case Controller.Mode.AR:
                    layout.setActive(ARButton);
                    layout.setInactive(IDButton);
                    layout.setInactive(WDButton);
                    break;
                case Controller.Mode.WD:
                    layout.setInactive(ARButton);
                    layout.setInactive(IDButton);
                    layout.setActive(WDButton);
                    break;
                case Controller.Mode.ID:
                    layout.setInactive(ARButton);
                    layout.setActive(IDButton);
                    layout.setInactive(WDButton);
                    break;
            }
            layout.updateLabel(labelInput1);
            layout.updateLabel(labelInput2);
            layout.updateLabel(labelResult);
            layout.updateCalculate(CalculateButton);
            layout.updateLayout(layoutButton);
            BackColor = layout.getBackgroundColor();
        }

    }
}
