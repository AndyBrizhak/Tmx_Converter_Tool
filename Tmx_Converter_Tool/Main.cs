using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TiledSharp;

namespace Tmx_Converter_Tool
{
    public partial class Main : Form
    {
        private string idTexture;
        private int mapWidth, mapHeight, tileWidth, tileHeight;
        private TmxMap map;

        public Main()
        {
            InitializeComponent();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = fileDialog.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    var path = fileDialog.FileName;
                    map = new TmxMap(path);

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


        private void btnExport_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            if (map == null)
            {
                MessageBox.Show(" --=== Chưa load dc file tmx mà ===--", "-__-");
                return;
            }

            var listObjectGroups = map.ObjectGroups;
            foreach (var group in listObjectGroups)
            {
                foreach (var obj in group.Objects)
                {
                    lines.Add(String.Format("{0}    {1}     {2}     {3}", obj.Id, obj.Name, obj.X.ToString(), obj.Y.ToString()));
                }
            }
            string pathFile;
            saveFileDialog.Title = "Éc éc";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFile = saveFileDialog.FileName;
                System.IO.File.WriteAllLines(pathFile, lines);
                MessageBox.Show("Done >.<", "Done >.<");
            }

        }

        private void lsvObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objSelected = lsvObject.FocusedItem.Text;

            var listObjectGroups = map.ObjectGroups;



            foreach (var group in listObjectGroups)
            {
                var data = group.Objects.FirstOrDefault(m => m.Name == objSelected);
                if (data != null)
                {
                    lblObjID_Selected.Text = data.Name;
                    lblObjName_Selected.Text = data.Name;
                    lblObjX_Selected.Text = Math.Floor(data.X).ToString();
                    lblObjY_Selected.Text = Math.Floor(data.Y).ToString();
                    return;
                }
            }


        }

    }
}
