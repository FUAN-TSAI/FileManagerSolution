using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTUB.FileManager.Site.Models.Entities
{
	public class DocEntity
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string FileName { get; set; }

		public DateTime ModifiedTime { get; set; }
	}
	//public class DocEntity
	//{
	//	public DocEntity(string title, string fileName, string description = null)
	//	{
	//		if (string.IsNullOrEmpty(title))
	//		{
	//			throw new ArgumentNullException(nameof(title), "Title not allow null");
	//		}
	//		if (string.IsNullOrEmpty(fileName))
	//		{
	//			throw new ArgumentNullException(nameof(fileName), "File Name not allow null");
	//		}
	//		this.Title = title;
	//		this.FileName = fileName;

	//		ModifiedTime = DateTime.Now;
	//	}

	//	public DocEntity(int id, string title, string description, string fileName, DateTime modifiedTime) : this(title, fileName, description)
	//	{
	//		this.Id = id;
	//		this.ModifiedTime = modifiedTime;
	//	}

	//	public int Id { get; private set; }
	//	private string _Title;

	//}
}