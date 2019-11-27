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
                if (result == DialogResult.OK)
                {
                    var path = fileDialog.FileName;
                    map = new TmxMap(path);

                    // clear listview
                    lsvObject.Clear();

                    if (path.Length > 40) lblFileName.Text = "\\\\..." + path.Substring(path.Length - 40, 40);
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

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (map == null)
            {
                MessageBox.Show(" --=== Chưa load dc file tmx mà ===--", " -__- ");
                return;
            }

            List<string> linesObj = new List<string>();
            List<string> linesTile = new List<string>();

            #region TILE txt 
            // Dong dau la idTexture
            linesTile.Add(String.Format("{0}", idTexture.ToString()));

            int idUnit = 1;

            // Duyet
            for (int y = 0; y < mapHeight; y += tileHeight)
            {
                for (int x = 0; x < mapWidth; x += tileWidth)
                {
                    // id 
                    linesTile.Add(String.Format("{0}\t{1}\t{2}\t{3}\t{4}", idUnit, x, y, x + tileWidth, y + tileHeight));
                    idUnit += 1;
                }
            }
            #endregion

            #region OBJ txt
            var listObjectGroups = map.ObjectGroups;

            foreach (var group in listObjectGroups)
            {
                foreach (var obj in group.Objects)
                {
                    // Kiem tra typeObj 
                    // Mac dinh typeObj >= 4500 && < 5000 
                    int typeObj = Convert.ToInt32(group.Name);

                    if (typeObj >= 4500 && typeObj < 5000)
                    {
                        // Them 2 truong w, h =_=
                        //
                        // idTypeObj - idObj - x - y - w - h
                        //
                        double left = Math.Round(obj.X);
                        double top = Math.Round(obj.Y);
                        double right = Math.Round(obj.X + obj.Width);
                        double bottom = Math.Round(obj.Y + obj.Height);


                        linesObj.Add(String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", group.Name, obj.Name, left.ToString(), top.ToString(), right.ToString(), bottom.ToString()));
                    }
                    else
                    {
                        //
                        // idTypeObj - idObj - x - y
                        //
                        linesObj.Add(String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", group.Name, obj.Name, Math.Round(obj.X).ToString(), Math.Round(obj.Y).ToString(), "0", "0"));
                    }
                }
            }

            #endregion

            string pathFileObj;
            saveFileDialog.Title = "OBJ Éc éc";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFileObj = saveFileDialog.FileName;
                System.IO.File.WriteAllLines(pathFileObj, linesObj);
                MessageBox.Show("Done >.<", "Done >.<");
            }

            string pathFileTile;
            saveFileDialog.Title = "TILE Éc éc";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFileTile = saveFileDialog.FileName;
                System.IO.File.WriteAllLines(pathFileTile, linesTile);
                MessageBox.Show("Done >.<", "Done >.<");
            }

        }

        private void LsvObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objSelected = lsvObject.FocusedItem.Text;

            var listObjectGroups = map.ObjectGroups;

            foreach (var group in listObjectGroups)
            {
                var data = group.Objects.FirstOrDefault(m => m.Name == objSelected);
                if (data != null)
                {
                    lblObjID_Selected.Text = data.Name;
                    lblObjName_Selected.Text = group.Name;
                    lblObjX_Selected.Text = Math.Floor(data.X).ToString();
                    lblObjY_Selected.Text = Math.Floor(data.Y).ToString();
                    return;
                }
            }


        }

    }
}
