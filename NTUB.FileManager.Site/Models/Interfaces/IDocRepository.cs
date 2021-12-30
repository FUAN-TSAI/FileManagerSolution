using NTUB.FileManager.Site.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTUB.FileManager.Site.Models.Interfaces
{
	public interface IDocRepository //Ixxx I開頭的約定俗成是介面
	{
		void Create(DocEntity entity);
		void Update(DocEntity entity);
		void Delete(int docId);
		DocEntity Get(int docId);
		IEnumerable<DocEntity> Search(string title, string description);
		DocEntity Load (int docId);
	}
}
