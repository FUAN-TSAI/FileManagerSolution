using NTUB.FileManager.Site.Models.EFModels;
using NTUB.FileManager.Site.Models.Entities;
using NTUB.FileManager.Site.Models.Infrastructures.ExtMethods;
using NTUB.FileManager.Site.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTUB.FileManager.Site.Models.Infrastructures.Repositories
{
	public class DocRepository : IDocRepository
	{
		private AppDbContext db = new AppDbContext();
		public void Create(DocEntity entity)
		{
			//Doc model = new Doc  //第一種
			//{
			//	Title = entity.Title,
			//	Description = entity.Description,
			//	FileName = entity.FileName,
			//	ModifiedTime = DateTime.Now
			//};

			//Doc model = entity.ToDoc(); //第二種 擴充方法ToDoc()

			db.Docs.Add(entity.ToDoc());  //第三種 直接帶入擴充方法entity.ToDoc()
			db.SaveChanges();
		}

		public void Delete(int docId)
		{
			var model = db.Docs.Find(docId);
			if (model == null) return;

			db.Docs.Remove(model);
			db.SaveChanges();
		}

		public DocEntity Get(int docId)
		{
			throw new NotImplementedException();
		}

		public DocEntity Load(int docId)
		{
			//var model = db.Docs.Find(docId);

			//if (model == null) //第一種 使用擴充方法
			//{
			//	return null;
			//}
			//return model.ToEntity(); 

			//return model == null ? null : model.ToEntity(); //第二種 使用三元運算式

			return db.Docs.Find(docId).ToEntity(); //第三種 值是 null 寫在擴充方法
		}

		public IEnumerable<DocEntity> Search(string title, string description)
		{
			var query = db.Docs.AsQueryable();
			if (!string.IsNullOrEmpty(title))
			{
				query = query.Where(x => x.Title.Contains(title));
			}
			if (!string.IsNullOrEmpty(description))
			{
				query = query.Where(x => x.Description.Contains(description));
			}
			var data = query.OrderBy(x => x.Title).ToList();
			var result = data.Select(x=> x.ToEntity());
			return result;
		}

		public void Update(DocEntity entity)
		{
			Doc model = db.Docs.Find(entity.Id);
			if (model == null)
			{
				return;
			}
			model.Title = entity.Title;
			model.Description = entity.Description;
			model.FileName = entity.FileName;
			model.ModifiedTime = entity.ModifiedTime;
		}
	}
}