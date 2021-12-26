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
                    // Example codes
                    {
                        /* // Mario Starting Boots 1 byte
                        savegame_br.BaseStream.Position = 0x559002;
                        byte maxsyrupcount = (byte)savegame_fs.ReadByte();
                        numudMarioStartingBoots.Text = (maxsyrupcount.ToString()); ---------------------------- THIS ONE WORKS FOR ONE BYTE

                        // Mario Starting Boots 4 bytes 
                        savegame_br.BaseStream.Position = 0x92D;
                        byte[] mStartingBoots = savegame_br.ReadBytes(4);
                        int mStartingBoots2 = BitConverter.ToInt32(mStartingBoots, 0);
                        numudMarioStartingBoots.Text = (mStartingBoots2.ToString()); ------------------------- THIS ONE WORKS FOR FOUR BYTES*/
                    }

                    // Mario Starting Boots
                    {
                        savegame_br.BaseStream.Position = 0x559002;
                        byte mStartingBoots2 = (byte)savegame_fs.ReadByte();
                        roNumudMStartingBoots.Text = (mStartingBoots2.ToString()); // Sets the value to a hidden text box
                        cmbbxMStartingBoots.SelectedIndex = mStartingBoots2;
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
            /*byte[] mStartingBoots = ML4E_StringToByteArray(byte.Parse(roMStartingBootsTXT.Text).ToString("X2"));
            Array.Reverse(mStartingBoots);
            update_save_open.Position = Convert.ToInt64("559002", 16);
            update_save_write.Write(mStartingBoots);*/

            byte[] mStartingBoots = ML4E_StringToByteArray(byte.Parse(roNumudMStartingBoots.Text).ToString("X2"));
            Array.Reverse(mStartingBoots);
            update_save_open.Position = Convert.ToInt64("559002", 16);
            update_save_write.Write(mStartingBoots);

            #endregion

            update_save_open.Close();
        }

        private void openCobin_Click(object sender, EventArgs e)
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
                {
                    saveCobin.Enabled = true;
                }
                savegame_br.Close();
            }

        }

        private void saveCobin_Click(object sender, EventArgs e)
        {
            ML4E_set_data();
            MessageBox.Show("Data saved");
        }

        private void cmbbxMStartingBoots_SelectedIndexChanged(object sender, EventArgs e)
        {
            roNumudMStartingBoots.Value = cmbbxMStartingBoots.SelectedIndex;
        }
    }
}
