using System;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard.ChildControl
{
    public partial class LicenseControl : UserControl
    {

        private static string validChars = "ACEFHJKMNPRSTUVWXYZ234579";
        private static Random rnd = new Random(Guid.NewGuid().GetHashCode());


        public LicenseControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generate a license code
        /// </summary>
        /// <param name="length">length of each phrase</param>
        /// <param name="number">number of phrases separated by a '-'</param>
        /// <returns></returns>
        public static string GetNewCode(int length, int number)
        {
            string license = string.Empty;

            for (int numberOfPhrases = 0; numberOfPhrases < number; numberOfPhrases++)
            {
                license += getPhrase(length);
                if (numberOfPhrases < number)
                    license += "-";
            }

            return license.TrimEnd('-');
        }

        /// <summary>
        /// generate a phrase
        /// </summary>
        /// <param name="length">length of phrase</param>
        /// <returns></returns>
        private static string getPhrase(int length)
        {
            string phrase = string.Empty;

            for (int loop = 0; loop < length; loop++)
            {
                phrase += validChars[rnd.Next(validChars.Length)];
            }

            return phrase;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            TbLicense.Text = GetNewCode(4, 6);

            //string macAddresses = string.Empty;

            //foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            //{


            //    if (nic.OperationalStatus == OperationalStatus.Up)
            //    {
            //        macAddresses += nic.GetPhysicalAddress().ToString();
            //        break;
            //        // salt : A4 BB 6D BD 96 54
            //    }
            //}




        }
    }
}
