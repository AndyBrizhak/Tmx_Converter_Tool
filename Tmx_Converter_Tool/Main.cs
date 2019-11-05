using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiledSharp;

namespace Tmx_Converter_Tool
{
    public partial class Main : Form
    {
        private string idTexture;
        private int mapWidth, mapHeight, tileWidth, tileHeight;

        public Main()
        {
            InitializeComponent();

            //lsvObject.View = View.Details;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = fileDialog.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    var path = fileDialog.FileName;
                    var map = new TmxMap(path);

                    if (path.Length > 52) lblFileName.Text = "\\\\..." + path.Substring(path.Length - 52, 52);
                    else lblFileName.Text = path;

                    // map chi co 1 tileset duy nhat nen ko duyet het tileset lam gi :)))
                    idTexture = map.Tilesets[0].Name;
                    lblMapTexture.Text = idTexture;

                    tileWidth = map.TileWidth;
                    tileHeight = map.TileHeight;

                    mapWidth = map.Width * tileWidth;
                    mapHeight = map.Height * tileHeight;

                    lblTileWidth.Text = tileWidth.ToString();
                    lblTileHeight.Text = tileHeight.ToString();

                    lblWidth.Text = mapWidth.ToString();
                    lblHeight.Text = mapHeight.ToString();

                    // Duyet cac obj
                    var listObjectGroups = map.ObjectGroups;

                    foreach (var group in listObjectGroups)
                    {
                        foreach (var obj in group.Objects)
                        {
                            lsvObject.Items.Add(obj.Name);

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), " --=== Chọn cho đúng file vào ===--");
            }

        }
    }
}
