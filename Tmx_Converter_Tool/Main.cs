using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TiledSharp;

namespace Tmx_Converter_Tool
{
    public partial class Main : Form
    {
        private string idTexture, idTextureAbove;
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

                    // Mac dinh tileset cua map roi moi den tileset map above :)))
                    idTexture = map.Tilesets[0].Name;
                    lblMapTexture.Text = idTexture;

                    if (map.Tilesets.Count() > 1)
                    {
                        idTextureAbove = map.Tilesets[1].Name;
                        lblMapAboveTexture.Text = idTextureAbove;
                    }

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

            if (!CheckInfo())
            {
                MessageBox.Show(" --=== Nhập đủ info vào ===--", " -__- ");
                return;
            }

            if (!CheckExport())
            {
                MessageBox.Show(" --=== CHECKKKKKK BOXXXXXX ===--", " -__- ");
                return;
            }

            List<string> linesObj = new List<string>();
            List<string> linesTile = new List<string>();
            List<string> linesTileAbove = new List<string>();
            List<string> linesMap = new List<string>();
            List<string> linesMapAbove = new List<string>();

            #region TILE txt 
            // Dong dau la idTexture

            var tileSet = map.Tilesets.FirstOrDefault();

            linesTile.Add(String.Format("{0}\t{1}", idTexture.ToString(), tileSet.TileCount));

            int idUnit = 1;

            // Duyet tung RECT 
            for (int y = 0; y < tileSet.Image.Height; y += tileHeight)
            {
                for (int x = 0; x < tileSet.Image.Width; x += tileWidth)
                {
                    // id 
                    linesTile.Add(String.Format("{0}\t{1}\t{2}\t{3}\t{4}", idUnit, x, y, x + tileWidth, y + tileHeight));
                    idUnit += 1;
                }
            }
            #endregion

            #region TILE ABOVE txt 
            // Dong dau la idTexture
            if (map.Tilesets.Count > 1)
            {
                var tileSet_ = map.Tilesets[1];

                linesTileAbove.Add(String.Format("{0}\t{1}", idTextureAbove.ToString(), tileSet_.TileCount));

                int idUnit_ = 1;

                // Duyet tung RECT 
                for (int y = 0; y < tileSet_.Image.Height; y += tileHeight)
                {
                    for (int x = 0; x < tileSet_.Image.Width; x += tileWidth)
                    {
                        // id 
                        linesTileAbove.Add(String.Format("{0}\t{1}\t{2}\t{3}\t{4}", idUnit_, x, y, x + tileWidth, y + tileHeight));
                        idUnit_ += 1;
                    }
                }
            }
            #endregion

            #region OBJ txt
            var listObjectGroups = map.ObjectGroups;
            int totalObject = 0;

            // Dem so luong obj
            foreach (var group in listObjectGroups)
            {
                foreach (var obj in group.Objects)
                {
                    totalObject += 1;
                }

            }

            // Dong dau la so obj
            linesObj.Add(String.Format("{0}\t{1}\t{2}", totalObject.ToString(), mapWidth.ToString(), mapHeight.ToString()));

            foreach (var group in listObjectGroups)
            {
                foreach (var obj in group.Objects)
                {
                    // Kiem tra typeObj 
                    // Mac dinh typeObj >= 4500 && < 5000 
                    int typeObj = Convert.ToInt32(group.Name);
                    if (typeObj == 6000)
                    {
                        linesObj.Add(String.Format("{0}\t{1}", Math.Round(obj.X).ToString(), Math.Round(obj.Y).ToString()));
                    }
                    else if (typeObj >= 4500 && typeObj < 5000)
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

            #region MAP txt

            var _tiles = map.Layers.FirstOrDefault().Tiles;

            // Dong dau la thong tin map - numTileX - numTileY
            linesMap.Add(String.Format("{0}\t{1}", map.Width, map.Height));

            string row = "";

            foreach (var tile in _tiles)
            {

                row += String.Format("\t{0}", tile.Gid);

                if (tile.X == map.Width - 1)
                {
                    linesMap.Add(row.Trim());
                    row = "";
                }

            }

            #endregion

            #region MAP ABOVE txt

            var _tiles_above = map.Layers[1].Tiles;

            // Dong dau la thong tin map - numTileX - numTileY
            linesMapAbove.Add(String.Format("{0}\t{1}", map.Width, map.Height));

            string row_ = "";

            // Mac dinh tileset thu 2 la cua mapAbove
            int fristIndex = map.Tilesets[1].FirstGid;

            foreach (var tile in _tiles_above)
            {

                row_ += String.Format("\t{0}", tile.Gid - fristIndex);

                if (tile.X == map.Width - 1)
                {
                    linesMapAbove.Add(row_.Trim());
                    row_ = "";
                }

            }

            #endregion

            #region EXPORT TXT

            if (ckbObj.Checked)
            {
                string pathFileObj = txtPath.Text;
                pathFileObj += "/obj.txt";
                System.IO.File.WriteAllLines(pathFileObj, linesObj);
            }

            if (ckbMap.Checked)
            {

                string pathFileTile = txtPath.Text;
                pathFileTile += "/tile.txt";
                System.IO.File.WriteAllLines(pathFileTile, linesTile);

                string pathFileMap = txtPath.Text;
                pathFileMap += "/map.txt";
                System.IO.File.WriteAllLines(pathFileMap, linesMap);

            }

            if (ckbMapAbove.Checked)
            {

                string pathFileTileAbove = txtPath.Text;
                pathFileTileAbove += "/tile_above.txt";
                System.IO.File.WriteAllLines(pathFileTileAbove, linesTileAbove);

                string pathFileMapAbove = txtPath.Text;
                pathFileMapAbove += "/map_above.txt";
                System.IO.File.WriteAllLines(pathFileMapAbove, linesMapAbove);

            }

            MessageBox.Show("Done >.<", "Done >.<");
            #endregion

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

        private bool CheckInfo()
        {
            string path = txtPath.Text.Trim();
            return !(path == "");
        }

        private bool CheckExport()
        {
            return (ckbMap.Checked || ckbMapAbove.Checked || ckbObj.Checked);
        }
    }
}
