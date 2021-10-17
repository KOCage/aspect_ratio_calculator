using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace aspect_ratio_calculator
{
    public class Controller
    {
        public enum Mode { AR, WD, ID };

        private Mode currentMode;

        private Model m;
        private View v;

        public Controller(Model inModel)
        {
            m = inModel;
        }

        public void setView(View inView)
        {
            v = inView;
        }

        private void calcAR()
        {
            string WDText = v.getInput1();
            string IDText = v.getInput2();

            string WDUnit = v.getUnit1();
            string IDUnit = v.getUnit2();

            decimal WD = getWDInches(WDText, WDUnit);
            decimal ID = getIDInches(IDText, IDUnit);

            decimal AR = Math.Round(ID / WD, 2);

            v.updateResult("Aspect Ratio: " + AR.ToString());
        }

        private void calcID()
        {
            string ARText = v.getInput1();
            string WDText = v.getInput2();

            string WDUnit = v.getUnit2();

            decimal WD_mm = getWDmm(WDText, WDUnit);
            decimal AR = Decimal.Parse(v.getInput1());

            decimal ID_mm = Math.Round(AR * WD_mm, 4);
            decimal ID_inches = Math.Round(ID_mm / 25.4m, 4);
            decimal nearestStandardID = m.getNearestID(ID_inches);
            string nearestStandardFraction = m.ConvertIDDecimalToFraction(nearestStandardID);

            v.updateResult("Actual Inner Diameter: " + ID_mm + "mm - " + ID_inches + "\"\n" +
                           "Nearest Standard: " + nearestStandardFraction + "\" - " + nearestStandardID + "\"");
        }

        private void calcWD()
        {
            string ARText = v.getInput1();
            string IDText = v.getInput2();

            string IDUnit = v.getUnit2();

            decimal ID = getIDInches(IDText, IDUnit);
            decimal AR = Decimal.Parse(v.getInput1());

            decimal WD = Math.Round(ID / AR, 3);
            decimal nearestStandardWD_AWG = m.getNearestWD_AWG(WD);
            decimal nearestStandardWD_SWG = m.getNearestWD_SWG(WD);
            int AWG_Guage = m.ConvertWDAWGInchesToGuage(nearestStandardWD_AWG);
            int SWG_Guage = m.ConvertWDSWGInchesToGuage(nearestStandardWD_SWG);

            v.updateResult("Actual Wire Diameter: " + WD + "\n" +
                           "Nearest common AWG: " + AWG_Guage + "G - " + nearestStandardWD_AWG + "\"\n" +
                           "Nearest common SWG: " + SWG_Guage + "G - " + nearestStandardWD_SWG + "\"");
        }

        public void switchMode(Mode newMode)
        {
            currentMode = newMode;
            updateLayout();
        }

        public Mode getCurrentMode()
        {
            return currentMode;
        }
        
        public void updateLayout()
        {
            v.clearLayout();

            switch (currentMode)
            {
                case Mode.AR:
                    changeToARMode();
                    break;
                case Mode.WD:
                    changeToWDMode();
                    break;
                case Mode.ID:
                    changeToIDMode();
                    break;
            }
        }

        public void changeToARMode()
        {
            v.enableARButton();
            v.disableWDButton();
            v.disableIDButton();
            v.setLabelInput1("Wire Diameter");
            v.enableUnit1();
            v.updateUnit1(m.GetWDUnitsOfMeasure());
            v.setLabelInput2("Inner Diameter");
            v.enableUnit2();
            v.updateUnit2(m.GetIDUnitsOfMeasure());
        }

        public void changeToWDMode()
        {
            v.enableWDButton();
            v.disableARButton();
            v.disableIDButton();
            v.setLabelInput1("Aspect Ratio");
            v.disableUnit1();
            v.setLabelInput2("Inner Diameter");
            v.enableUnit2();
            v.updateUnit2(m.GetIDUnitsOfMeasure());
        }

        public void changeToIDMode()
        {
            v.enableIDButton();
            v.disableARButton();
            v.disableWDButton();
            v.setLabelInput1("Aspect Ratio");
            v.disableUnit1();
            v.setLabelInput2("Wire Diameter");
            v.enableUnit2();
            v.updateUnit2(m.GetWDUnitsOfMeasure());
        }

        public void performCalculation()
        {
            switch (currentMode)
            {
                case Mode.AR:
                    calcAR();
                    break;
                case Mode.WD:
                    calcWD();
                    break;
                case Mode.ID:
                    calcID();
                    break;
            }
        }

        public decimal getWDInches(string inValue, string inUnit)
        {
            switch (inUnit)
            {
                case "SWG":
                    return m.ConvertWDSWGGaugeToInches(int.Parse(inValue));
                case "AWG":
                    return m.ConvertWDAWGGaugeToInches(int.Parse(inValue));
                case "Inches":
                    return Decimal.Parse(inValue);
                case "MM":
                    return m.ConvertWDSWGMMToInches(Decimal.Parse(inValue));
            }

            return 0.0M;
        }
        public decimal getWDmm(string inValue, string inUnit)
        {
            switch (inUnit)
            {
                case "SWG":
                    return m.ConvertWDSWGGaugeToMM(int.Parse(inValue));
                case "AWG":
                    return m.ConvertWDAWGGaugeToMM(int.Parse(inValue));
                case "Inches":
                    return Decimal.Parse(inValue) / 25.4m;
                case "MM":
                    return Decimal.Parse(inValue);
            }

            return 0.0M;
        }
        public decimal getIDInches(string inValue, string inUnit)
        {
            switch (inUnit)
            {
                case "Fraction Inches":
                    if (inValue.Contains('"'))
                        inValue = inValue.Remove('"');
                    return m.ConvertIDFractionToDecimal(inValue);
                case "Decimal Inches":
                    return Decimal.Parse(inValue);
                case "MM":
                    return m.ConvertIDMMToDecimal(Decimal.Parse(inValue));
            }

            return 0.0M;
        }

    }
}
