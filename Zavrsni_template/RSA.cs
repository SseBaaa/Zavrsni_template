using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zavrsni_template
{
    
    public partial class RSA : Form
    {
        private ToolTip helpToolTip;
        private TextBox helpTextBox;
       
        
        public RSA()
        {
            InitializeComponent();
            InitializeHelpButton();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RSA_Load(object sender, EventArgs e)
        {

        }

        private void buttonIzracun_Click(object sender, EventArgs e)
        {
            // Example RSA public key (n, e)
            BigInteger n = BigInteger.Parse("227010481295437363334259960947493668895875336466084780038173258247009162675779735389791151574049166747880487470296548479");
            BigInteger ee = BigInteger.Parse("4299603643464496340306803008986985033344727959816846309565441761356032680702812800989967589892257060614723463093217112213");

            // Use Wiener's attack to find d
            //BigInteger d = WienerAttack(ee, n);
            BigInteger d = BigInteger.Parse("123456789");

            
            textBoxD.Text = d.ToString();

            // Example RSA ciphertext (c)
            BigInteger c = BigInteger.Parse("26521380600526975339768376280067651581621560548292886854847816531185984217017541127330203022991725903859432176941650100774717850972611251762217510334778045492654098960924370847607781942516883870222321935770333031837231549408420167987316080264842031954097700095632715734399908142040045931192713083178294525147455");

            // Decrypt the ciphertext
            

            // Convert m to string
            string plaintext = Decrypt(c, d, n);

            textBoxRjesenje.Text = plaintext;

        }
        public static string Decrypt(BigInteger c, BigInteger d, BigInteger n)
        {
            // Decrypt the ciphertext
            BigInteger m = BigInteger.ModPow(c, d, n);

            // Convert m to a byte array
            byte[] bytes = m.ToByteArray();

            // BigInteger's byte order is reversed, so we need to reverse the array
            //Array.Reverse(bytes);

            // Convert the byte array to a string
            string plaintext = BytesToHexString(bytes);

            // Return the plaintext
            return plaintext;
        }
        public static string BytesToHexString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }
        



        public static Fraction[] ContinuedFractions(BigInteger e, BigInteger n)
        {
            BigInteger q;
            BigInteger r;
            BigInteger a = e;
            BigInteger b = n;
            List<Fraction> fractions = new List<Fraction>();

            while (b != 0)
            {
                q = a / b;
                r = a % b;
                fractions.Add(new Fraction(q, 1));
                a = b;
                b = r;
            }

            return fractions.ToArray();
        }

        public static Fraction Convergent(Fraction[] fractions, int k)
        {
            BigInteger numerator = fractions[k].numerator;
            BigInteger denominator = 1;

            for (int i = k - 1; i >= 0; --i)
            {
                BigInteger temp = numerator;
                numerator = fractions[i].numerator * numerator + denominator;
                denominator = temp;
            }

            return new Fraction(numerator, denominator);
        }

        public static BigInteger WienerAttack(BigInteger e, BigInteger n)
        {
            Fraction[] fractions = ContinuedFractions(e, n);
            Fraction k;
            BigInteger d;
            BigInteger phi;

            for (int i = 0; i < fractions.Length; ++i)
            {
                k = Convergent(fractions, i);
                if (k.denominator == 0) continue;
                d = k.numerator;

                // Skip if d is even or n <= d
                if (d % 2 == 0 || n <= d) continue;

                // Check if k.denominator divides (e*d - 1)
                if ((e * d - 1) % k.denominator != 0) continue;

                phi = (e * d - 1) / k.denominator;

                // Calculate b^2 - 4ac for the quadratic equation
                BigInteger discriminant = BigInteger.Pow(n - phi + 1, 2) - 4 * n;

                // Check if discriminant is perfect square
                if (IsPerfectSquare(discriminant))
                {
                    // The private key has been found
                    return d;
                    
                }
            }

            return 0;
        }

        private static bool IsPerfectSquare(BigInteger number)
        {
            if (number < 0) return false;

            BigInteger root = BigInteger.Zero;
            BigInteger bit = BigInteger.One << (BitLength(number) - 2);

            while (bit > 0)
            {
                root += bit;
                if (number < root)
                {
                    root -= bit;
                }
                bit >>= 2;
            }

            return root * root == number;
        }

        private static int BitLength(BigInteger value)
        {
            int bitLength = 0;
            while (value != 0)
            {
                bitLength++;
                value >>= 1;
            }

            return bitLength;
        }
        public class Fraction
        {
            public BigInteger numerator;
            public BigInteger denominator;

            public Fraction(BigInteger num, BigInteger den)
            {
                numerator = num;
                denominator = den;
            }
        }
        private void InitializeHelpButton()
        {
            // Create a round button
            RoundButton helpButton = new RoundButton
            {
                Location = new Point(17, 350), // Change the location based on your layout
                Size = new Size(80, 80), // Adjust the size as needed
                FlatStyle = FlatStyle.Flat,
                BackgroundImageLayout = ImageLayout.Stretch
            };

            // Set the button's background image
            helpButton.BackgroundImage = Properties.Resources.pictureForProgram;

            // Add the button to the form
            this.Controls.Add(helpButton);

            // Create a ToolTip
            helpToolTip = new ToolTip
            {
                // Set the tooltip properties, if needed
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true
            };
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about RSA.");
            // Add ButtonClick event handler
            helpButton.Click += ButtonClick;

            // Create a TextBox
            helpTextBox = new TextBox
            {
                Location = new Point(helpButton.Location.X, helpButton.Location.Y - 105), // Above the button
                Size = new Size(175, 100), // Adjust the size as needed
                Visible = false, // Initially hide the TextBox
                ReadOnly = true, // Make the TextBox read-only, so the text can be copied but not modified
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            // Add the TextBox to the form
            this.Controls.Add(helpTextBox);
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            
            // Set the TextBox text to the desired message
            helpTextBox.Text = "1." + "https://www.dcode.fr/rsa-cipher" + Environment.NewLine + Environment.NewLine +
                "2." + "https://www.devglan.com/online-tools/rsa-encryption-decryption" + Environment.NewLine + Environment.NewLine +
                "3." + "https://www.cs.drexel.edu/~jpopyack/Courses/CSP/Fa17/notes/10.1_Cryptography/RSA_Express_EncryptDecrypt_v2.html";

            helpTextBox.Visible = !helpTextBox.Visible;
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
