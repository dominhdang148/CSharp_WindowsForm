﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    enum TuyChon
    {
        MaSV,
        HoTen,
        NgaySinh
    }
    public partial class frmTuyChon : Form
    {
        public frmTuyChon()
        {
            InitializeComponent();
        }
        public string ChuoiTim = "";
        TuyChon kieu;

    }
}
