using NTUB.FileManager.Site.Models.DTOs;
using NTUB.FileManager.Site.Models.Entities;
using NTUB.FileManager.Site.Models.Infrastructures.Repositories;
using NTUB.FileManager.Site.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTUB.FileManager.Site.Models.Services
{
	public class DocService
	{
		private readonly IDocRepository _repo;

		public DocService() //建構子(沒有參數)Controller用
		{
			this._repo = new DocRepository();
		}
		public DocService(IDocRepository repo) //建構子(可以自行加參數)單元測試用
		{
			this._repo = repo;
		}
		public void Create(CreateDocRequest request)
		{
			DocEntity entity = new DocEntity
			{
				Title = request.Title,
				Description = request.Description,
				FileName = request.FileName,
				ModifiedTime = DateTime.Now,
			};
			_repo.Create(entity);

		}
		public void Update(EditDocRequest request) 
		{
			DocEntity entity = this._repo.Load(request.Id);/*把一筆抓出來一個一個改，因為DocRepository
			                                                * 裡的Update有FileName，現在沒有改動Id及
			                                                * FileName，資料會是原本的*/
			entity.Title = request.Title;
			entity.Description = request.Description;
			entity.ModifiedTime = DateTime.Now;

			_repo.Update(entity);
		}
		public void Delete(int docId)
		{
			this._repo.Delete(docId);
		}
	}
}