namespace Tmx_Converter_Tool
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnImport = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMapTexture = new System.Windows.Forms.Label();
            this.lblTileWidth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblTileHeight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lsvObject = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMapAboveTexture = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblObjY_Selected = new System.Windows.Forms.Label();
            this.lblObjX_Selected = new System.Windows.Forms.Label();
            this.lblObjName_Selected = new System.Windows.Forms.Label();
            this.lblObjID_Selected = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ckbMapAbove = new System.Windows.Forms.CheckBox();
            this.ckbObj = new System.Windows.Forms.CheckBox();
            this.ckbMap = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnImport.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(33, 207);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(170, 54);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "iMp0rT";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(109, 38);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(42, 20);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "XXX";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Patch :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Map Width :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Map Height :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tile Width :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tile Height :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Texture ID MAP :";
            // 
            // lblMapTexture
            // 
            this.lblMapTexture.AutoSize = true;
            this.lblMapTexture.Location = new System.Drawing.Point(173, 76);
            this.lblMapTexture.Name = "lblMapTexture";
            this.lblMapTexture.Size = new System.Drawing.Size(46, 20);
            this.lblMapTexture.TabIndex = 8;
            this.lblMapTexture.Text = " XXX";
            // 
            // lblTileWidth
            // 
            this.lblTileWidth.AutoSize = true;
            this.lblTileWidth.Location = new System.Drawing.Point(116, 191);
            this.lblTileWidth.Name = "lblTileWidth";
            this.lblTileWidth.Size = new System.Drawing.Size(46, 20);
            this.lblTileWidth.TabIndex = 9;
            this.lblTileWidth.Text = " XXX";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(116, 149);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 20);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = " XXX";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(389, 149);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 20);
            this.lblHeight.TabIndex = 11;
            this.lblHeight.Text = " XXX";
            // 
            // lblTileHeight
            // 
            this.lblTileHeight.AutoSize = true;
            this.lblTileHeight.Location = new System.Drawing.Point(389, 191);
            this.lblTileHeight.Name = "lblTileHeight";
            this.lblTileHeight.Size = new System.Drawing.Size(46, 20);
            this.lblTileHeight.TabIndex = 12;
            this.lblTileHeight.Text = " XXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "List Object :";
            // 
            // lsvObject
            // 
            this.lsvObject.HideSelection = false;
            this.lsvObject.Location = new System.Drawing.Point(32, 321);
            this.lsvObject.Name = "lsvObject";
            this.lsvObject.Size = new System.Drawing.Size(511, 156);
            this.lsvObject.TabIndex = 14;
            this.lsvObject.UseCompatibleStateImageBehavior = false;
            this.lsvObject.View = System.Windows.Forms.View.SmallIcon;
            this.lsvObject.SelectedIndexChanged += new System.EventHandler(this.LsvObject_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblMapAboveTexture);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTileHeight);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTileWidth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblMapTexture);
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 239);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Texture ID MAP ABOVE:";
            // 
            // lblMapAboveTexture
            // 
            this.lblMapAboveTexture.AutoSize = true;
            this.lblMapAboveTexture.Location = new System.Drawing.Point(227, 113);
            this.lblMapAboveTexture.Name = "lblMapAboveTexture";
            this.lblMapAboveTexture.Size = new System.Drawing.Size(46, 20);
            this.lblMapAboveTexture.TabIndex = 20;
            this.lblMapAboveTexture.Text = " XXX";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblObjY_Selected);
            this.groupBox2.Controls.Add(this.lblObjX_Selected);
            this.groupBox2.Controls.Add(this.lblObjName_Selected);
            this.groupBox2.Controls.Add(this.lblObjID_Selected);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(564, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 133);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object Selected";
            // 
            // lblObjY_Selected
            // 
            this.lblObjY_Selected.AutoSize = true;
            this.lblObjY_Selected.Location = new System.Drawing.Point(214, 88);
            this.lblObjY_Selected.Name = "lblObjY_Selected";
            this.lblObjY_Selected.Size = new System.Drawing.Size(46, 20);
            this.lblObjY_Selected.TabIndex = 20;
            this.lblObjY_Selected.Text = " XXX";
            // 
            // lblObjX_Selected
            // 
            this.lblObjX_Selected.AutoSize = true;
            this.lblObjX_Selected.Location = new System.Drawing.Point(47, 88);
            this.lblObjX_Selected.Name = "lblObjX_Selected";
            this.lblObjX_Selected.Size = new System.Drawing.Size(46, 20);
            this.lblObjX_Selected.TabIndex = 19;
            this.lblObjX_Selected.Text = " XXX";
            // 
            // lblObjName_Selected
            // 
            this.lblObjName_Selected.AutoSize = true;
            this.lblObjName_Selected.Location = new System.Drawing.Point(130, 29);
            this.lblObjName_Selected.Name = "lblObjName_Selected";
            this.lblObjName_Selected.Size = new System.Drawing.Size(46, 20);
            this.lblObjName_Selected.TabIndex = 18;
            this.lblObjName_Selected.Text = " XXX";
            // 
            // lblObjID_Selected
            // 
            this.lblObjID_Selected.AutoSize = true;
            this.lblObjID_Selected.Location = new System.Drawing.Point(71, 59);
            this.lblObjID_Selected.Name = "lblObjID_Selected";
            this.lblObjID_Selected.Size = new System.Drawing.Size(46, 20);
            this.lblObjID_Selected.TabIndex = 17;
            this.lblObjID_Selected.Text = " XXX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Type Obj ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Y :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "X :";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnExport.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(209, 207);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(170, 54);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "3Xp0rt";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPath);
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.ckbMapAbove);
            this.groupBox3.Controls.Add(this.ckbObj);
            this.groupBox3.Controls.Add(this.ckbMap);
            this.groupBox3.Controls.Add(this.btnImport);
            this.groupBox3.Location = new System.Drawing.Point(564, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 282);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Info Map";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(73, 32);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(299, 77);
            this.txtPath.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Path :";
            // 
            // ckbMapAbove
            // 
            this.ckbMapAbove.AutoSize = true;
            this.ckbMapAbove.Location = new System.Drawing.Point(169, 115);
            this.ckbMapAbove.Name = "ckbMapAbove";
            this.ckbMapAbove.Size = new System.Drawing.Size(189, 24);
            this.ckbMapAbove.TabIndex = 9;
            this.ckbMapAbove.Text = "Export map_above.txt";
            this.ckbMapAbove.UseVisualStyleBackColor = true;
            // 
            // ckbObj
            // 
            this.ckbObj.AutoSize = true;
            this.ckbObj.Location = new System.Drawing.Point(15, 156);
            this.ckbObj.Name = "ckbObj";
            this.ckbObj.Size = new System.Drawing.Size(127, 24);
            this.ckbObj.TabIndex = 8;
            this.ckbObj.Text = "Export obj.txt";
            this.ckbObj.UseVisualStyleBackColor = true;
            // 
            // ckbMap
            // 
            this.ckbMap.AutoSize = true;
            this.ckbMap.Location = new System.Drawing.Point(15, 115);
            this.ckbMap.Name = "ckbMap";
            this.ckbMap.Size = new System.Drawing.Size(137, 24);
            this.ckbMap.TabIndex = 6;
            this.ckbMap.Text = "Export map.txt";
            this.ckbMap.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(981, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsvObject);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tmx Converter Tool Developers By maslhiro (\")>";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMapTexture;
        private System.Windows.Forms.Label lblTileWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblTileHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lsvObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblObjID_Selected;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblObjY_Selected;
        private System.Windows.Forms.Label lblObjX_Selected;
        private System.Windows.Forms.Label lblObjName_Selected;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbObj;
        private System.Windows.Forms.CheckBox ckbMap;
        private System.Windows.Forms.CheckBox ckbMapAbove;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMapAboveTexture;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label16;
    }
}