﻿namespace GbsoDev.TechTest.Library.Mol
{
	public class LibroModel
	{
		public int Id { get; set; }
		public string? Titulo { get; set; }
		public int EditorialId { get; set; }
		public string? Sinopsis { get; set; }
		public string? NPaginas { get; set; }
		public List<AutorModel> Autores { get; set; }

		public LibroModel()
		{
			Autores = new List<AutorModel>();
		}
	}
}