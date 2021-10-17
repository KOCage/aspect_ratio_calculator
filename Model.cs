using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace aspect_ratio_calculator
{
    public class Model
    {
        private string localDirectory;
        private string configFilePath;
        struct WD_AWG
        {
            public int g;
            public decimal inches;
            public decimal mm;

            public WD_AWG(int g, decimal inches, decimal mm)
            {
                this.g = g;
                this.inches = inches;
                this.mm = mm;
            }
        }

        struct WD_SWG
        {
            public int g;
            public decimal inches;
            public decimal mm;

            public WD_SWG(int g, decimal inches, decimal mm)
            {
                this.g = g;
                this.inches = inches;
                this.mm = mm;
            }
        }

        struct ID
        {
            public string fraction;
            public decimal inches;
            public decimal mm;

            public ID(string fraction, decimal inches, decimal mm)
            {
                this.fraction = fraction;
                this.inches = inches;
                this.mm = mm;
            }
        }

        private WD_AWG[] WD_AWGConversions;

        private WD_SWG[] WD_SWGConversions;

        private ID[] IDConversions;

        public Model()
        {
            initializeWD_AWG();
            initializeID();
            localDirectory = Directory.GetCurrentDirectory();
            configFilePath = localDirectory + "\\config.txt";
        }

        private void initializeWD_AWG()
        {
            WD_AWGConversions = new WD_AWG[]
            {
                new WD_AWG(24, .02M, .5M),
                new WD_AWG(22, .025M, .6M),
                new WD_AWG(21, .029M, .737M),
                new WD_AWG(20, .032M, .812M),
                new WD_AWG(19, .036M, 0.914M),
                new WD_AWG(18, .04M, 1.0M),
                new WD_AWG(17, .045M, 1.15M),
                new WD_AWG(16, .048M, 1.2M),
                new WD_AWG(15, .057M, 1.45M),
                new WD_AWG(14, .062M, 1.6M),
                new WD_AWG(12, .08M, 2.0M),
                new WD_AWG(10, .102M, 2.59M),
            };
        }

        private void initializeWD_SWG()
        {
            WD_SWGConversions = new WD_SWG[]
            {
                new WD_SWG(24, .022M, .559M),
                new WD_SWG(23, .024M, .61M),
                new WD_SWG(22, .028M, .711M),
                new WD_SWG(21, .032M, .813M),
                new WD_SWG(20, .036M, .914M),
                new WD_SWG(19, .04M, 1.0M),
                new WD_SWG(18, .048M, 1.2M),
                new WD_SWG(16, .062M, 1.6M),
                new WD_SWG(14, .08M, 2.0M),
                new WD_SWG(12, .104M, 2.64M),
            };
        }

        private void initializeID()
        {
            IDConversions = new ID[]
            {
                new ID("1/16", .0625M, 1.6M),
                new ID("5/64", .0781M, 2.0M),
                new ID("3/32", .0938M, 2.4M),
                new ID("7/64", .1094M, 2.8M),
                new ID("1/8", .125M, 3.2M),
                new ID("9/64", .1406M, 3.6M),
                new ID("5/32", .1563M, 4.0M),
                new ID("11/64", .1719M, 4.4M),
                new ID("3/16", .1875M, 4.8M),
                new ID("7/32", .2188M, 5.6M),
                new ID("1/4", .25M, 6.4M),
                new ID("9/32", .281M, 7.1M),
                new ID("5/16", .3125M, 7.9M),
                new ID("3/8", .375M, 9.5M),
                new ID("7/16", .4375M, 11.1M),
                new ID("1/2", .5M, 12.7M)
            };
        }

        public decimal ConvertWDAWGGaugeToInches(int g)
        {
            if (WD_AWGConversions == null)
                initializeWD_AWG();

            foreach (WD_AWG c in WD_AWGConversions)
            {
                if (c.g == g)
                    return c.inches;
            }
            throw new Exception("Unable to match input guage " + g + " to any AWG value");
        }
        public int ConvertWDAWGInchesToGuage(decimal i)
        {
            if (WD_AWGConversions == null)
                initializeWD_AWG();

            foreach (WD_AWG c in WD_AWGConversions)
            {
                if (c.inches == i)
                    return c.g;
            }
            throw new Exception("Unable to match input guage " + i + " to any AWG value");
        }
        public decimal ConvertWDAWGGaugeToMM(int g)
        {
            if (WD_AWGConversions == null)
                initializeWD_AWG();

            foreach (WD_AWG c in WD_AWGConversions)
            {
                if (c.g == g)
                    return c.mm;
            }
            throw new Exception("Unable to match input guage " + g + " to any AWG value");
        }
        public decimal ConvertWDAWGInchesToMM(decimal i)
        {
            if (WD_AWGConversions == null)
                initializeWD_AWG();

            foreach (WD_AWG c in WD_AWGConversions)
            {
                if (c.inches == i)
                    return c.mm;
            }
            throw new Exception("Unable to match input guage " + i + " to any AWG value");
        }
        public decimal ConvertWDAWGMMToInches(decimal mm)
        {
            if (WD_AWGConversions == null)
                initializeWD_AWG();

            foreach (WD_AWG c in WD_AWGConversions)
            {
                if (c.mm == mm)
                    return c.inches;
            }
            throw new Exception("Unable to match input guage " + mm + " to any AWG value");
        }

        public decimal ConvertWDSWGGaugeToInches(int g)
        {
            if (WD_SWGConversions == null)
                initializeWD_SWG();

            foreach (WD_SWG c in WD_SWGConversions)
            {
                if (c.g == g)
                    return c.inches;
            }
            throw new Exception("Unable to match input guage " + g + " to any SWG value");
        }
        public int ConvertWDSWGInchesToGuage(decimal i)
        {
            if (WD_SWGConversions == null)
                initializeWD_SWG();

            foreach (WD_SWG c in WD_SWGConversions)
            {
                if (c.inches == i)
                    return c.g;
            }
            throw new Exception("Unable to match input guage " + i + " to any SWG value");
        }
        public decimal ConvertWDSWGGaugeToMM(int g)
        {
            if (WD_SWGConversions == null)
                initializeWD_SWG();

            foreach (WD_SWG c in WD_SWGConversions)
            {
                if (c.g == g)
                    return c.mm;
            }
            throw new Exception("Unable to match input guage " + g + " to any SWG value");
        }
        public decimal ConvertWDSWGInchesToMM(decimal i)
        {
            if (WD_SWGConversions == null)
                initializeWD_SWG();

            foreach (WD_SWG c in WD_SWGConversions)
            {
                if (c.inches == i)
                    return c.mm;
            }
            throw new Exception("Unable to match input guage " + i + " to any SWG value");
        }
        public decimal ConvertWDSWGMMToInches(decimal mm)
        {
            if (WD_SWGConversions == null)
                initializeWD_SWG();

            foreach (WD_SWG c in WD_SWGConversions)
            {
                if (c.mm == mm)
                    return c.inches;
            }
            throw new Exception("Unable to match input guage " + mm + " to any SWG value");
        }

        public decimal ConvertIDFractionToDecimal(string inFraction)
        {
            if (IDConversions == null)
                initializeID();

            foreach (ID c in IDConversions)
            {
                if (c.fraction.Equals(inFraction))
                    return c.inches;
            }
            throw new Exception("Unable to match input " + inFraction);
        }
        public decimal ConvertIDFractionToMM(string inFraction)
        {
            if (IDConversions == null)
                initializeID();

            foreach (ID c in IDConversions)
            {
                if (c.fraction.Equals(inFraction))
                    return c.mm;
            }
            throw new Exception("Unable to match input " + inFraction);
        }
        public string ConvertIDDecimalToFraction(decimal inInches)
        {
            if (IDConversions == null)
                initializeID();

            foreach (ID c in IDConversions)
            {
                if (c.inches == inInches)
                    return c.fraction;
            }
            throw new Exception("Unable to match input " + inInches);
        }
        public decimal ConvertIDDecimalToMM(decimal inInches)
        {
            if (IDConversions == null)
                initializeID();

            foreach (ID c in IDConversions)
            {
                if (c.fraction.Equals(inInches))
                    return c.inches;
            }
            throw new Exception("Unable to match input " + inInches);
        }
        public decimal ConvertIDMMToDecimal(decimal inMM)
        {
            if (IDConversions == null)
                initializeID();

            foreach (ID c in IDConversions)
            {
                if (c.mm == inMM)
                    return c.inches;
            }
            throw new Exception("Unable to match input " + inMM);
        }

        public string[] GetWDUnitsOfMeasure()
        {
            string[] WDUnits = new string[]
            {
                "SWG",
                "AWG",
                "Inches",
                "MM"
            };
            return WDUnits;
        }

        public string[] GetIDUnitsOfMeasure()
        {
            string[] IDUnits = new string[]
            {
                "Fraction Inches",
                "Decimal Inches",
                "MM"
            };
            return IDUnits;
        }

        public decimal getNearestID(decimal inID)
        {
            if (IDConversions == null)
                initializeID();

            decimal minValue = 0.0M;
            decimal maxValue = 0.0M;

            foreach(ID c in IDConversions)
            {
                if (c.inches == inID)
                    return c.inches;

                if (c.inches < inID)
                    minValue = c.inches;
                else if (c.inches > inID)
                {
                    maxValue = c.inches;
                    break;
                }
            }

            if ((inID - minValue) < (maxValue - inID))
                return minValue;
            else
                return maxValue;

        }

        public decimal getNearestWD_AWG(decimal inWD)
        {
            if (WD_AWGConversions == null)
                initializeWD_AWG();

            decimal minValue = 0.0M;
            decimal maxValue = 0.0M;

            foreach (WD_AWG c in WD_AWGConversions)
            {
                if (c.inches == inWD)
                    return c.inches;

                if (c.inches < inWD)
                    minValue = c.inches;
                else if (c.inches > inWD)
                {
                    maxValue = c.inches;
                    break;
                }
            }

            if ((inWD - minValue) < (maxValue - inWD))
                return minValue;
            else
                return maxValue;
        }
        public decimal getNearestWD_SWG(decimal inWD)
        {
            if (WD_SWGConversions == null)
                initializeWD_SWG();

            decimal minValue = 0.0M;
            decimal maxValue = 0.0M;

            foreach (WD_SWG c in WD_SWGConversions)
            {
                if (c.inches == inWD)
                    return c.inches;

                if (c.inches < inWD)
                    minValue = c.inches;
                else if (c.inches > inWD)
                {
                    maxValue = c.inches;
                    break;
                }
            }

            if ((inWD - minValue) < (maxValue - inWD))
                return minValue;
            else
                return maxValue;
        }

        public char loadLayout()
        {
            if (!File.Exists(configFilePath))
                createConfigFile();

            char layout = getConfigValue("layout")[0];

            return layout;
        }

        public void saveLayout(char layoutChar)
        {
            Dictionary<string, string> config = createConfig("layout", layoutChar.ToString());
            updateConfigFile(config);
        }

        private void createConfigFile()
        {
            
            string configFileText = defaultConfigFile();
            File.WriteAllText(configFilePath, configFileText);
        }

        private void updateConfigFile(Dictionary<string, string> config)
        {
            string[] fileText = File.ReadAllLines(configFilePath);

            fileText = updateConfigFileText(fileText, config);

            File.WriteAllLines(configFilePath, fileText);
        }

        private string getConfigValue(string key)
        {
            string[] fileText = File.ReadAllLines(configFilePath);
            foreach(string line in fileText)
            {
                if (line.Split('|')[0].Equals(key))
                {
                    return line.Split('|')[1];
                }
            }

            throw new Exception("configuration for key " + key + " was not found!");
        }

        private Dictionary<string, string> createConfig(string key, string value)
        {
            Dictionary<string, string> config = new Dictionary<string, string>();
            config.Add(key, value);

            return config;
        }

        private string defaultConfigFile()
        {
            string config = "layout|L";

            return config;
        }

        private string[] updateConfigFileText(string[] fileText, Dictionary<string, string> config)
        {
            for(int i = 0; i < fileText.Length; i++)
            {
                string[] pair = fileText[i].Split('|');
                if (config.TryGetValue(pair[0], out string value))
                { 
                    fileText[i] = pair[0] + "|" + value;
                    break;
                }
            }

            return fileText;
        }
    }
}
