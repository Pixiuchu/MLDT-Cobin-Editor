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
                    savegame_br.BaseStream.Position = 0x559002;
                    byte mariostartingboots = (byte)savegame_fs.ReadByte();
                    numudMarioStartingBoots.Text = numudMarioStartingBoots.ToString();
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
            byte[] mariostartingboots = ML4E_StringToByteArray(int.Parse(numudMarioStartingBoots.Text).ToString("X2"));
            Array.Reverse(mariostartingboots);
            update_save_open.Position = Convert.ToInt64("559002", 16);
            update_save_write.Write(mariostartingboots);

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
                savegame_br.BaseStream.Position = 0x77F;
                byte[] rank = savegame_br.ReadBytes(4);
                int rank1 = BitConverter.ToInt32(rank, 0); savegame_br.Close();
            }
        }

    }
}
