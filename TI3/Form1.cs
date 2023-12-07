using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool FlagG = true;
        string OpenFileName = "";
        string SaveFileName = "";

        //Нахождение g
        private int ModPow(int @base, int exponent, int modulus)
        {
            int result = 1;
            while (exponent > 0)
            {
                if ((exponent & 1) == 1)
                    result = (result * @base) % modulus;
                
                @base = (@base * @base) % modulus;
                exponent >>= 1;
            }
            return result;
        }

        private bool IsPrimitiveRoot(int a, int p)
        {
            HashSet<int> powers = new HashSet<int>();
            for (int i = 1; i <= p - 1; i++)
                powers.Add(ModPow(a, i, p));
            
            return powers.Count == p - 1;
        }

        //Проверка на простоту
        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;
                
            return true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;     
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Enabled = false;
                FlagG = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int p);
            if (IsPrime(p))
            {
                comboBox1.Enabled = true;
                FlagG = true;
                int i = 0;
                for (int a = 1; a < p; a++)
                    if (IsPrimitiveRoot(a, p))
                    {
                        comboBox1.Items.Add(a);
                        i++;
                    }
                textBox4.Text = i + "";
            }
            else
            {
                MessageBox.Show("P are not Prime!");
            }
        }

        private void TypeED_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeED.Text == "Encryption")
            {
                textBox3.Enabled = true;
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                button1.Enabled = true;

                if (FlagG)
                    comboBox1.Enabled = true;
            }
            else if (TypeED.Text == "Decryption")
            {
                textBox3.Enabled = true;
                textBox1.Enabled = true;

                textBox2.Enabled = false;
                button1.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                OpenFileName = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                SaveFileName = saveFileDialog1.FileName;
        }

        //Эвклид k p-1
        public static bool AreCoprime(int a, int b)
        {
            int x, y;
            int gcd = ExtendedEuclidean(a, b, out x, out y);
            if (gcd != 1) return false;
            return true;
        }

        public static int ExtendedEuclidean(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int x1, y1;
            int gcd = ExtendedEuclidean(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return gcd;
        }

        public static BigInteger Power(int x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;

            BigInteger t = Power(x, n / 2);
            if (n % 2 == 0) return t * t;
            else return t * t * x;
        }
        
        private int GetBytese (int p)
        {
            byte[] intBytes = BitConverter.GetBytes(p);
            int i = 3;
            for (; i > 0; i--)
                if (intBytes[i] != 0)
                    break;

            return i;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (TypeED.Text == "Encryption")
            {
                richTextBox1.Clear();
                richTextBox2.Clear();
                int.TryParse(textBox1.Text, out int x);
                int.TryParse(textBox2.Text, out int k);
                int.TryParse(textBox3.Text, out int p);
                int.TryParse(comboBox1.Text, out int g);

                int sizeB = GetBytese(p);

                BigInteger.DivRem(Power(g, x), p, out BigInteger temp);
                int y = (int)temp;
                textBox4.Text = y.ToString();
                if (AreCoprime(p - 1, k) && k > 1 && x > 1 && k < p - 1 && x < p - 1 && p > 256)
                {
                    BinaryReader f2 = new BinaryReader(File.Open(OpenFileName, FileMode.Open));
                    BinaryWriter f1 = new BinaryWriter(File.Open(SaveFileName, FileMode.OpenOrCreate));

                    byte[] bytes = f2.ReadBytes((int)f2.BaseStream.Length);

                    int b = 0;
                    BigInteger.DivRem(Power(g, k), p, out temp);
                    int a = (int)temp;
                    int s = 0;
                    foreach (byte by in bytes)
                    {
                        BigInteger.DivRem(Power(y, k) * by, p, out temp);
                        b = (int)temp;

                        if (s < 40)
                        {
                            richTextBox1.AppendText(a + " " + b + "\r\n");
                            richTextBox2.AppendText(by + "\r\n");
                            s++;
                        }

                        byte[] intBytes = BitConverter.GetBytes(a);

                        for (int i = 0; i <= sizeB; i++)
                            f1.Write(intBytes[i]);

                        intBytes = BitConverter.GetBytes(b);
                        for (int i = 0; i <= sizeB; i++)
                            f1.Write(intBytes[i]);
                    }
                    f1.Close();
                    f2.Close();
                }
                else
                {
                    MessageBox.Show("Error Input");
                }
            }
            else if (TypeED.Text == "Decryption")
            {
                int.TryParse(textBox1.Text, out int x);
                int.TryParse(textBox3.Text, out int p);

                if (IsPrime(p))
                {
                    int sizeB = GetBytese(p);

                    BinaryReader f2 = new BinaryReader(File.Open(OpenFileName, FileMode.Open));
                    BinaryWriter f1 = new BinaryWriter(File.Open(SaveFileName, FileMode.OpenOrCreate));

                    byte[] bytes = f2.ReadBytes((int)f2.BaseStream.Length);

                    int A = 0;
                    int B = 0;

                    byte[] intBytes = new byte[] { 0, 0, 0, 0 };

                    int tempI = 0;
                    BigInteger temp;
                    for (; tempI < bytes.Length;)
                    {
                        for (int k = 0; k < sizeB + 1; k++)
                        {
                            intBytes[k] = bytes[tempI];
                            tempI++;
                        }
                        A = BitConverter.ToInt32(intBytes, 0);

                        for (int k = 0; k < sizeB + 1; k++)
                        {
                            intBytes[k] = bytes[tempI];
                            tempI++;
                        }
                        B = BitConverter.ToInt32(intBytes, 0);

                        BigInteger.DivRem(B * Power(A, p - 1 - x), p, out temp);

                        byte b = (byte)temp;
                        
                        f1.Write(b);
                    }

                    f1.Close();
                    f2.Close();
                }
                else
                {
                    MessageBox.Show("P are not Prime!");
                }
            }
        }
    }
}