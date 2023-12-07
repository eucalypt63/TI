using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace TI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string FileWay = "";
        public string FileSaveWay = "";

        string CreateString (string str)
        {
            int n = str.Length;
            char[] tempstr = new char[n];

            char[] Num = {'0','1','2','3','4','5','6','7','8','9'};
            char[] Sym = { '.', ',', '/', '!', '@', '#', '%', '?', '+', '-', '*', '&', '(', ')', '{','}', '[', ']', '|'};
            char[] En = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int i = 0;
            int j = 0;
            while (i < n)
            {
                if (IgNum.Checked && Num.Contains(str[i]))
                {
                    i++;
                }
                else if (IgSym.Checked && Sym.Contains(str[i]))
                {
                    i++;
                }
                else if (IgLan.Checked && En.Contains(str[i]))
                {
                    i++;
                }
                else if (str[i] == ' ')
                {
                    i++;
                }
                else
                {
                    tempstr[j] = str[i];
                    j++;
                    i++;
                }
            }
            string s = new string(tempstr);//
            return s;
        }

        string Iron(string str)
        {

            int m = 0;
            if (int.TryParse(Key.Text, out m) && m > 1)
            {
                //Истинный текст
                str = CreateString(str);
                str = str.Trim();
                int n = str.Length;

                //Создание массива шифрования
                char[,] mass = new char[m, n];
                int i = 0;
                int flag = 1;
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = str[j];
                    if (flag == 1)
                    {
                        i++;
                        if (i == m - 1)
                        {
                            flag = 0;
                        }
                    }
                    else
                    {
                        i--;
                        if (i == 0)
                        {
                            flag = 1;
                        };
                    }
                }

                //Чтение матрицы
                char[] tstr = new char[n];
                int tmpI = 0;
                for (i = 0; i < m; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (mass[i, j] != 0)
                        {
                            tstr[tmpI] = mass[i, j];
                            tmpI++;
                        }
                    }
                }
                string s = new string(tstr);
                return s;
            }
            else if (m == 1)
            {
                str = CreateString(str);
                return str;
            }
            else
            {
                Key.Text = "Incorrect Key";
                return str;
            }
        }
        string DeIron(string str)
        {
            int m = 0;
            if (int.TryParse(Key.Text, out m) && m > 1)
            {
                int n = str.Length;

                //Создание массивов дешифрования
                char[,] mass = new char[m, n];
                char[,] demass = new char[m, n];
                int i = 0;
                int flag = 1;
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = str[j];
                    demass[i, j] = str[j];
                    if (flag == 1)
                    {
                        i++;
                        if (i == m - 1)
                        {
                            flag = 0;
                        }
                    }
                    else
                    {
                        i--;
                        if (i == 0)
                        {
                            flag = 1;
                        };
                    }
                }

                //Востановление массива шифрования
                int tmpI = 0;
                int tmpJ = 0;
                flag = 1;
                for (i = 0; i < m; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (demass[i, j] != 0)
                        {
                            demass[i, j] = mass[tmpI, tmpJ];
                            
                            if (flag == 1)
                            {
                                tmpI++;
                                if (tmpI == m - 1)
                                {
                                    flag = 0;
                                }
                            }
                            else
                            {
                                tmpI--;
                                if (tmpI == 0)
                                {
                                    flag = 1;
                                };
                            }
                            tmpJ++;
                            
                        }
                    }
                }

                //Чтение массива
                char[] tstr = new char[n];
                i = 0;
                flag = 1;
                for (int j = 0; j < n; j++)
                {
                    tstr[j] = demass[i, j];
                    if (flag == 1)
                    {
                        i++;
                        if (i == m - 1)
                        {
                            flag = 0;
                        }
                    }
                    else
                    {
                        i--;
                        if (i == 0)
                        {
                            flag = 1;
                        }
                    }
                }
                string s = new string(tstr);
                return s;
                //
            }
            else if (m == 1)
            {
                return str;
            }
            else 
            {
                Key.Text = "Incorrect Key";
                return str;
            }
        }

        int symbls(char[] Symb, int h, char ch)
        {
            int i = 0;
            for (; i < 33 && Symb[i] != ch; i++)
            { }

            //26
            if (i < 33)
            {
                i = (i + h) % 33;

                return i;
            }
            else return -1;
        }
        string Vigen(string str, int Flag)
        {
            //char[] Symb = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; 26
            char[] Symb = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            if (Flag == 1) //Если шифруем
            {
                str = CreateString(str);
                str = str.Trim();
            }
            int n = str.Length;

            //Создание и проверка ключа
            string TKey = Key.Text;
            TKey = TKey.Trim();
            TKey = TKey.ToLower();

            int k = 0;

            for (;k < TKey.Length && symbls(Symb, 0, TKey[k]) != -1; k++ )
            {  }

            if (k == TKey.Length)
            {
                // Создание истенного ключа
                char[] VKey = new char[n];
                int tmpI = 0;
                int h = 0;
                for (int i = 0; i < n; i++)
                {
                    if (symbls(Symb, 0, str[i]) != -1)
                    {
                        char tmpCh = Symb[symbls(Symb, h, TKey[tmpI])];
                        VKey[i] = tmpCh;

                        tmpI++;
                        if (tmpI == TKey.Length)
                        {
                            tmpI = 0;
                            h++;
                        }
                    }
                }
                //Проверка шифра и дешифра
                int Sig = 1;
                if (Flag == 0)
                    Sig = -1;

                //Шифр/Дешифр текста
                char[] tmpStr = new char[n];
                for (int i = 0; i < n; i++)
                {
                    if (symbls(Symb, 0, str[i]) != -1)
                    {
                        int tmp = (symbls(Symb, 0, str[i]) + (symbls(Symb, 0, VKey[i])) * Sig + 33) % 33;
                        tmpStr[i] = Symb[tmp];
                    }
                    else tmpStr[i] = str[i];
                }
                string s = new string(tmpStr);//
                return s;
            }
            else
            {
                Key.Text = "Incorrect Key";
                return str;
            }
        }

        private void FirstFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileWay = openFileDialog1.FileName;
            }
        }
        private void FileSave_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                FileSaveWay = openFileDialog2.FileName;
            }
        }

        private void StartEnc_Click(object sender, EventArgs e)
        {
            if (FileWay != "" && FileSaveWay != "" && TypeEncrypt.Text != "" && Action.Text != "" && Key.Text != "")
            {
                if (TypeEncrypt.Text == "Railway Fence")
                {
                    string Temp = "";
                    if (Action.Text == "Encrypt")
                    {
                       
                        StreamReader reader = new StreamReader(FileWay);
                        StreamWriter sw = new StreamWriter(FileSaveWay, false);

                        for (string str; (str = reader.ReadLine()) != null; )
                        {
                            str = str.ToLower();
                            Temp += str;      
                        }
                        Temp = Iron(Temp);
                        sw.WriteLine(Temp);

                        reader.Close();
                        sw.Close();
                    }
                    else 
                    {
                        StreamReader reader = new StreamReader(FileWay);
                        StreamWriter sw = new StreamWriter(FileSaveWay, false);

                        for (string str; (str = reader.ReadLine()) != null;)
                        {
                            str = str.ToLower();
                            Temp += str;
                        }
                        Temp = DeIron(Temp);
                        sw.WriteLine(Temp);

                        reader.Close();
                        sw.Close();
                    }
                }
                else if (TypeEncrypt.Text == "Vigenere")
                {
                    string Temp = "";
                    if (Action.Text == "Encrypt")
                    {
                        StreamReader reader = new StreamReader(FileWay);
                        StreamWriter sw = new StreamWriter(FileSaveWay, false);

                        for (string str; (str = reader.ReadLine()) != null;)
                        {
                            str = str.ToLower();
                            Temp += str;
                        }
                        Temp = Vigen(Temp, 1);
                        sw.WriteLine(Temp);

                        reader.Close();
                        sw.Close();
                    }
                    else 
                    {
                        StreamReader reader = new StreamReader(FileWay);
                        StreamWriter sw = new StreamWriter(FileSaveWay, false);

                        for (string str; (str = reader.ReadLine()) != null;)
                        {
                            str = str.ToLower();
                            Temp += str; 
                        }
                        Temp = Vigen(Temp, 0);
                        sw.WriteLine(Temp);

                        reader.Close();
                        sw.Close();
                    }
                }
            }
        }
    }
}