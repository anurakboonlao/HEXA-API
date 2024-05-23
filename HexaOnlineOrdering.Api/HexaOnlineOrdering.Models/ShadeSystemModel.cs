﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
	public class ShadeSystemModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Order { get; set; }
		public List<ShadeModel> Shades { get; set; }
	}
}
