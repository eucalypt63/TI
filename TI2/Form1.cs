using System;
using System.IO;
using System.Windows.Forms;

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
        public string FileKey = "";

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
        private void KeyFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                FileKey = openFileDialog3.FileName;
            }
        }

        private Boolean[] KeyCreate(Boolean[] str, int Length)
        {
            int i = 0;
            Boolean[] tmp = new Boolean[Length];
            for (int j = 0; j < Length && j != 37; j++)
                tmp[j] = str[j]; 

            while (i + 38 < Length)
            {
                tmp[i + 38] = tmp[0 + i] ^ tmp[32 + i] ^ tmp[33 + i] ^ tmp[37 + i];
                i++;
            }
            return tmp;
        }

        private Boolean[] NewBitText(Boolean[] str, Boolean[] Key, int Length)
        {
            int i = 0;
            Boolean[] Tmp = new Boolean[Length];
            while (i < Length)
            {
                Tmp[i] = str[i] ^ Key[i];
                i++;
            }
            return Tmp;
        }

        private void StartEnc_Click(object sender, EventArgs e)
        {
            if (FileWay != "" && FileSaveWay != "" && FileKey != "")
            {
                StreamReader KeyRead = new StreamReader(FileKey);
                string Key = KeyRead.ReadLine();
                KeyRead.Close();

                TextBoxKey.Clear();
                TextBoxFirstText.Clear();
                TextBoxNewText.Clear();

                //Битовый ключ
                Boolean[] KeyFirstByte = new Boolean[38];
                for (int i = 37; i >= 0; i--)
                {
                    try
                    {
                        if (Key[i] == '0')
                            KeyFirstByte[i] = false;
                        else
                            KeyFirstByte[i] = true;
                    }
                    catch { break; }
                }

                //Битовый текст
                byte[] TextBytes;
                if (string.Equals(Path.GetExtension(FileWay), ".txt", StringComparison.OrdinalIgnoreCase))
                {
                    StreamReader te = new StreamReader(FileWay);

                    string tems = te.ReadToEnd();
                    TextBytes = new byte[tems.Length];
                    for (int he = 0; he < tems.Length; he++)
                        TextBytes[he] = (byte)tems[he];
                    te.Close();
                }
                else
                {
                    TextBytes = File.ReadAllBytes(FileWay);
                }

                int BitesLength = TextBytes.Length * 8;
                int BytesLength = TextBytes.Length;

                //Преоброзование в биты
                Boolean[] TextBite = new Boolean[BitesLength];
                for (int i = 0; i < TextBytes.Length; i++)
                {
                    byte b = TextBytes[i];
                    for (int j = 0; j < 8; j++)
                    {
                        TextBite[j + (i * 8)] = (b & (1 << j)) != 0;
                    }
                }

                //Создание конечного ключа
                Boolean[] KeyBite = new Boolean[BitesLength];
                KeyBite = KeyCreate(KeyFirstByte, BitesLength);

                //Создание конечного текста
                Boolean[] NewTextBite = new Boolean[BitesLength];
                NewTextBite = NewBitText(TextBite, KeyBite, BitesLength);

                //Вывод
                for (int i = 0; i < BitesLength && i < 300; i++)
                {
                    if (KeyBite[i] == false)
                        TextBoxKey.Text += '0';
                    else TextBoxKey.Text += '1';

                    if (TextBite[i] == false)
                        TextBoxFirstText.Text += '0';
                    else TextBoxFirstText.Text += '1';

                    if (NewTextBite[i] == false)
                        TextBoxNewText.Text += '0';
                    else TextBoxNewText.Text += '1';
                }


                if (!string.Equals(Path.GetExtension(FileWay), ".txt", StringComparison.OrdinalIgnoreCase))
                {
                    BinaryWriter NewTextFileByte = new BinaryWriter(File.Open(FileSaveWay, FileMode.OpenOrCreate));

                    byte byt;
                    for (int i = 0; i < BytesLength; i++)
                    {
                        int[] bits = new int[8];
                        for (int T = 0; T < 8; T++)
                        {
                            if (NewTextBite[i * 8 + T] == false)
                                bits[T] = 0;
                            else bits[T] = 1;
                        }
                        byt = (byte)((bits[7] << 7)
                                   | (bits[6] << 6)
                                   | (bits[5] << 5)
                                   | (bits[4] << 4)
                                   | (bits[3] << 3)
                                   | (bits[2] << 2)
                                   | (bits[1] << 1)
                                   | (bits[0] << 0));

                        NewTextFileByte.Write(byt);
                    }
                    NewTextFileByte.Close();

                }
                else
                {
                    StreamWriter NewTextFileText = new StreamWriter(FileSaveWay);
                    byte byt;
                    for (int i = 0; i < BytesLength; i++)
                    {
                        int[] bits = new int[8];
                        for (int T = 0; T < 8; T++)
                        {
                            if (NewTextBite[i * 8 + T] == false)
                                bits[T] = 0;
                            else bits[T] = 1;
                        }
                        byt = (byte)((bits[7] << 7)
                                   | (bits[6] << 6)
                                   | (bits[5] << 5)
                                   | (bits[4] << 4)
                                   | (bits[3] << 3)
                                   | (bits[2] << 2)
                                   | (bits[1] << 1)
                                   | (bits[0] << 0));

                        NewTextFileText.Write((char)byt);
                    }
                    NewTextFileText.Close();
                }
                MessageBox.Show("Done");
            }
        }
    }
}