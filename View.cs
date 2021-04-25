using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aspect_ratio_calculator
{
    public partial class View : Form
    {
        private Controller c;
        public View(Controller inController)
        {
            c = inController;
            c.setView(this);
            InitializeComponent();
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
            ARButton.Image = Properties.Resources.ARActive;

        }
        public void disableARButton()
        {
            ARButton.Image = Properties.Resources.ARInactive;
        }

        public void enableWDButton()
        {
            WDButton.Image = Properties.Resources.WDActive;

        }
        public void disableWDButton()
        {
            WDButton.Image = Properties.Resources.WDInactive;
        }

        public void enableIDButton()
        {
            IDButton.Image = Properties.Resources.IDActive;

        }
        public void disableIDButton()
        {
            IDButton.Image = Properties.Resources.IDInactive;
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
            c.performCalculation();
        }
    }
}
