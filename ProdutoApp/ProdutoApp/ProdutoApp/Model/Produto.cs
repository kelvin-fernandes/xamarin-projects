﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoApp.Model {
	public class Produto {
		public int Codigo { get; set; }
		public string Nome { get; set; }
		public double Preco { get; set; }
		public string Fabricante { get; set; }
	}
}
