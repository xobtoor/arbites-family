﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbites4
{
    public partial class UCBoard : UserControl
    {
        public int x { get; set; }
        public int y { get; set; }
        public int maxLay { get; set; }
        public List<UCLayer> layers { get; set; }
        public UCBoard()
        {
            InitializeComponent();
        }

        public UCBoard(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.maxLay = z;
            InitializeComponent();
            layers = new List<UCLayer>();
            createLayers();
        }


        private void createLayers()
        {
            for (int i = 0; i < maxLay; i++)
            {
                UCLayer newl = new UCLayer(x, y, i);
                newl.Parent = flpMain;
                layers.Add(newl);
            }
        }

        public void updateLayers()
        {
            for (int i = 0; i < maxLay; i++)
            {
                layers[i].updateLayer();
            }
        }
    }
}
