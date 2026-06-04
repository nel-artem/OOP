using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb24
{
    public partial class Form1 : Form
    {
        Thread thread1, thread2, thread3;

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
        }
        void SafeStart(ref Thread t, ThreadStart method)
        {
            if (t == null || !t.IsAlive)
            {
                t = new Thread(method) { IsBackground = true };
                t.Start();
            }
        }

        //CAST 
        void RunCAST()
        {
            try
            {
                string input = "";
                richTextBox1.Invoke((MethodInvoker)(() => input = textBox1.Text));
                if (string.IsNullOrEmpty(input)) input = "Hello CAST";

                byte[] key = Encoding.UTF8.GetBytes("CAST16KEY12345AB");
                byte[] data = Encoding.UTF8.GetBytes(input);
                byte[] result = CastEncrypt(data, key);
                string hex = BitConverter.ToString(result).Replace("-", " ");

                richTextBox1.Invoke((MethodInvoker)(() =>
                {
                    richTextBox1.Clear();
                    richTextBox1.AppendText("CAST\n");
                    richTextBox1.AppendText($"Вхід: {input}\n");
                    richTextBox1.AppendText($"Зашифровано:\n{hex}\n");
                }));
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                richTextBox1.Invoke((MethodInvoker)(() =>
                    richTextBox1.AppendText("Помилка: " + ex.Message)));
            }
        }

        byte[] CastEncrypt(byte[] data, byte[] key)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
                result[i] = (byte)(data[i] ^ key[i % key.Length] ^ (byte)(i * 3 + 7));
            return result;
        }

        //MD-4
        void RunMD4()
        {
            try
            {
                string input = "";
                richTextBox2.Invoke((MethodInvoker)(() => input = textBox2.Text));
                if (string.IsNullOrEmpty(input)) input = "Hello MD4";

                byte[] hash = MD4Hash(Encoding.UTF8.GetBytes(input));
                string hashHex = BitConverter.ToString(hash).Replace("-", "").ToLower();

                richTextBox2.Invoke((MethodInvoker)(() =>
                {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("MD-4\n");
                    richTextBox2.AppendText($"Вхід: {input}\n");
                    richTextBox2.AppendText($"Хеш:\n{hashHex}\n");
                }));
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                richTextBox2.Invoke((MethodInvoker)(() =>
                    richTextBox2.AppendText("Помилка: " + ex.Message)));
            }
        }

        byte[] MD4Hash(byte[] input)
        {
            uint A = 0x67452301, B = 0xEFCDAB89, C = 0x98BADCFE, D = 0x10325476;
            int origLen = input.Length;
            int padLen = ((origLen % 64) < 56) ? (56 - origLen % 64) : (120 - origLen % 64);
            byte[] msg = new byte[origLen + padLen + 8];
            Array.Copy(input, msg, origLen);
            msg[origLen] = 0x80;
            BitConverter.GetBytes((ulong)(origLen * 8)).CopyTo(msg, msg.Length - 8);

            for (int i = 0; i < msg.Length / 64; i++)
            {
                uint[] X = new uint[16];
                for (int j = 0; j < 16; j++)
                    X[j] = BitConverter.ToUInt32(msg, i * 64 + j * 4);

                uint a = A, b = B, c = C, d = D;

                uint[] r1 = { 3, 7, 11, 19 };
                for (int j = 0; j < 16; j++)
                {
                    uint F = (b & c) | (~b & d);
                    uint tmp = a + F + X[j];
                    int s = (int)r1[j % 4];
                    a = d; d = c; c = b;
                    b = (tmp << s) | (tmp >> (32 - s));
                }

                uint[] r2 = { 3, 5, 9, 13 };
                uint[] idx2 = { 0, 4, 8, 12, 1, 5, 9, 13, 2, 6, 10, 14, 3, 7, 11, 15 };
                for (int j = 0; j < 16; j++)
                {
                    uint G = (b & c) | (b & d) | (c & d);
                    uint tmp = a + G + X[idx2[j]] + 0x5A827999;
                    int s = (int)r2[j % 4];
                    a = d; d = c; c = b;
                    b = (tmp << s) | (tmp >> (32 - s));
                }

                uint[] r3 = { 3, 9, 11, 15 };
                uint[] idx3 = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
                for (int j = 0; j < 16; j++)
                {
                    uint H = b ^ c ^ d;
                    uint tmp = a + H + X[idx3[j]] + 0x6ED9EBA1;
                    int s = (int)r3[j % 4];
                    a = d; d = c; c = b;
                    b = (tmp << s) | (tmp >> (32 - s));
                }

                A += a; B += b; C += c; D += d;
            }

            byte[] result = new byte[16];
            BitConverter.GetBytes(A).CopyTo(result, 0);
            BitConverter.GetBytes(B).CopyTo(result, 4);
            BitConverter.GetBytes(C).CopyTo(result, 8);
            BitConverter.GetBytes(D).CopyTo(result, 12);
            return result;
        }

        //SEAL 
        void RunSEAL()
        {
            try
            {
                string input = "";
                richTextBox3.Invoke((MethodInvoker)(() => input = textBox3.Text));
                if (string.IsNullOrEmpty(input)) input = "Hello SEAL";

                byte[] data = Encoding.UTF8.GetBytes(input);
                byte[] key = Encoding.UTF8.GetBytes("SEALKEY1");
                byte[] encrypted = SealEncrypt(data, key);
                string hex = BitConverter.ToString(encrypted).Replace("-", " ");

                richTextBox3.Invoke((MethodInvoker)(() =>
                {
                    richTextBox3.Clear();
                    richTextBox3.AppendText("SEAL\n");
                    richTextBox3.AppendText($"Вхід: {input}\n");
                    richTextBox3.AppendText($"Зашифровано:\n{hex}\n");
                }));
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                richTextBox3.Invoke((MethodInvoker)(() =>
                    richTextBox3.AppendText("Помилка: " + ex.Message)));
            }
        }

        private void buttonStart1_Click_1(object sender, EventArgs e)
        {
            SafeStart(ref thread1, RunCAST);
        }

        private void buttonStart2_Click_1(object sender, EventArgs e)
        {
            SafeStart(ref thread2, RunMD4);
        }

        private void buttonStart3_Click_1(object sender, EventArgs e)
        {
            SafeStart(ref thread3, RunSEAL);
        }

        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            SafeStart(ref thread1, RunCAST);
            SafeStart(ref thread2, RunMD4);
            SafeStart(ref thread3, RunSEAL);
        }

        byte[] SealEncrypt(byte[] data, byte[] key)
        {
            byte[] result = new byte[data.Length];
            uint state = 0;
            for (int i = 0; i < key.Length; i++)
                state = (state << 8) | key[i];

            for (int i = 0; i < data.Length; i++)
            {
                state ^= state << 13;
                state ^= state >> 17;
                state ^= state << 5;
                result[i] = (byte)(data[i] ^ (state & 0xFF));
            }
            return result;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1?.Abort();
            thread2?.Abort();
            thread3?.Abort();
        }
    }
}
