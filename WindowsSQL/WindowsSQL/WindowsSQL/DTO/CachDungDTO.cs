﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSQL.DTO
{
    class CachDungDTO
    {
        int id;
        string cachDung;

        public int Id { get => id; set => id = value; }
        public string CachDung { get => cachDung; set => cachDung = value; }
    }
}
