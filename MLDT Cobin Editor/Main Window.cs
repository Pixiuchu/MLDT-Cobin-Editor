using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDT_Cobin_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string savegame;

        public static byte[] ML4E_StringToByteArray(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void ML4E_get_openfile()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                savegame = openFD.FileName;
            }
        }

        private void ML4E_get_data()
        {
            {
                FileStream savegame_fs = new FileStream(savegame, FileMode.Open);
                BinaryReader savegame_br = new BinaryReader(savegame_fs);
                long length = savegame_fs.Length;

                /* Mario Boots */
                {
                    /* // Mario Starting Boots 1 byte
                    savegame_br.BaseStream.Position = 0x559002;
                    byte maxsyrupcount = (byte)savegame_fs.ReadByte();
                    numudMarioStartingBoots.Text = (maxsyrupcount.ToString());*/ // ---------------------------- THIS ONE WORKS FOR ONE BYTE

                    /* // Mario Starting Boots 4 bytes 
                    savegame_br.BaseStream.Position = 0x92D;
                    byte[] mStartingBoots = savegame_br.ReadBytes(4);
                    int mStartingBoots2 = BitConverter.ToInt32(mStartingBoots, 0);
                    numudMarioStartingBoots.Text = (mStartingBoots2.ToString());*/ // ------------------------- THIS ONE WORKS FOR FOUR BYTES

                    // Mario Starting Boots
                    {
                        savegame_br.BaseStream.Position = 0x559002;
                        byte mStartingBoots2 = (byte)savegame_fs.ReadByte();
                        roMStartingBootsTXT.Text = (mStartingBoots2.ToString()); // Sets the value to a hidden text box
                        if (mStartingBoots2 == 0)
                            cmbbxMStartingBoots.SelectedIndex = 0;
                        if (mStartingBoots2 == 1)
                            cmbbxMStartingBoots.SelectedIndex = 1;
                        if (mStartingBoots2 == 2)
                            cmbbxMStartingBoots.SelectedIndex = 2;
                        if (mStartingBoots2 == 3)
                            cmbbxMStartingBoots.SelectedIndex = 3;
                        if (mStartingBoots2 == 4)
                            cmbbxMStartingBoots.SelectedIndex = 4;
                        if (mStartingBoots2 == 5)
                            cmbbxMStartingBoots.SelectedIndex = 5;
                        if (mStartingBoots2 == 6)
                            cmbbxMStartingBoots.SelectedIndex = 6;
                        if (mStartingBoots2 == 7)
                            cmbbxMStartingBoots.SelectedIndex = 7;
                        if (mStartingBoots2 == 8)
                            cmbbxMStartingBoots.SelectedIndex = 8;
                        if (mStartingBoots2 == 9)
                            cmbbxMStartingBoots.SelectedIndex = 9;
                        if (mStartingBoots2 == 10)
                            cmbbxMStartingBoots.SelectedIndex = 10;
                        if (mStartingBoots2 == 11)
                            cmbbxMStartingBoots.SelectedIndex = 11;
                        if (mStartingBoots2 == 12)
                            cmbbxMStartingBoots.SelectedIndex = 12;
                        if (mStartingBoots2 == 13)
                            cmbbxMStartingBoots.SelectedIndex = 14;
                        if (mStartingBoots2 == 14)
                            cmbbxMStartingBoots.SelectedIndex = 15;
                        if (mStartingBoots2 == 15)
                            cmbbxMStartingBoots.SelectedIndex = 16;
                        if (mStartingBoots2 == 16)
                            cmbbxMStartingBoots.SelectedIndex = 17;
                        if (mStartingBoots2 == 17)
                            cmbbxMStartingBoots.SelectedIndex = 18;
                        if (mStartingBoots2 == 18)
                            cmbbxMStartingBoots.SelectedIndex = 19;
                        if (mStartingBoots2 == 19)
                            cmbbxMStartingBoots.SelectedIndex = 20;
                        if (mStartingBoots2 == 20)
                            cmbbxMStartingBoots.SelectedIndex = 21;
                        if (mStartingBoots2 == 21)
                            cmbbxMStartingBoots.SelectedIndex = 22;
                        if (mStartingBoots2 == 22)
                            cmbbxMStartingBoots.SelectedIndex = 23;
                        if (mStartingBoots2 == 23)
                            cmbbxMStartingBoots.SelectedIndex = 24;
                        if (mStartingBoots2 == 25)
                            cmbbxMStartingBoots.SelectedIndex = 25;
                        if (mStartingBoots2 == 26)
                            cmbbxMStartingBoots.SelectedIndex = 26;
                        if (mStartingBoots2 == 27)
                            cmbbxMStartingBoots.SelectedIndex = 27;
                        if (mStartingBoots2 == 28)
                            cmbbxMStartingBoots.SelectedIndex = 28;
                        if (mStartingBoots2 == 29)
                            cmbbxMStartingBoots.SelectedIndex = 29;
                        if (mStartingBoots2 == 30)
                            cmbbxMStartingBoots.SelectedIndex = 30;
                        if (mStartingBoots2 == 31)
                            cmbbxMStartingBoots.SelectedIndex = 31;
                        if (mStartingBoots2 == 32)
                            cmbbxMStartingBoots.SelectedIndex = 32;
                        if (mStartingBoots2 == 33)
                            cmbbxMStartingBoots.SelectedIndex = 33;
                        if (mStartingBoots2 == 34)
                            cmbbxMStartingBoots.SelectedIndex = 34;
                        if (mStartingBoots2 == 35)
                            cmbbxMStartingBoots.SelectedIndex = 35;
                    }


                    savegame_br.Close();
                }
            }
        }

        private void ML4E_set_data()
        {
            FileStream update_save_open = null;
            BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(savegame, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);

            #region data
            byte[] mStartingBoots = ML4E_StringToByteArray(byte.Parse(roMStartingBootsTXT.Text).ToString("X2"));
            Array.Reverse(mStartingBoots);
            update_save_open.Position = Convert.ToInt64("559002", 16);
            update_save_write.Write(mStartingBoots);

            #endregion

            update_save_open.Close();
        }

        private void openCodeBin_Click(object sender, EventArgs e)
        {
            ML4E_get_openfile();
            if (string.IsNullOrEmpty(savegame))
            {
                MessageBox.Show("No file selected");
            }
            else
            {
                ML4E_get_data();
                FileStream savegame_fs = new FileStream(savegame, FileMode.Open);
                BinaryReader savegame_br = new BinaryReader(savegame_fs);
                long length = savegame_fs.Length;
                savegame_br.Close();

                /*using (var FileStream = File.Open("code.bin", FileMode.Open))
                {
                    BinaryReader savegame_br = new BinaryReader(savegame_fs);
                    savegame_br.Close();
                }*/
                }

            }

        private void savedataButton_Click_1(object sender, EventArgs e)
        {
            ML4E_set_data();
            MessageBox.Show("Data saved");
        }

        private void cmbbxMStartingBoots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
