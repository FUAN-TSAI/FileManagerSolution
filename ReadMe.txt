[V] add database and table
[V] create new asp.net project - " NTUB.FileManager.Site "

[V] add / Models / EFModels / AppDbContext
[V] 刪除語言包套件 / 重建專案 ( 建置 )

[V] add / Models / Entities / DocEntity class
[V] add / Models / Interfaces / IDocRepository
[V] add / Models / Infrastructures / Repositories / DocRepository
		[] 寫 Create
		[] 寫成擴充方法 / Models / Infrastructures / ExtMethods / DocEntityExts
		[] 改 Create(用擴充方法)
		[] 寫 Delete
		[] 寫 Update
		[] 寫 Load
		[] 寫成擴充方法 / Models / Infrastructures / ExtMethods / DocExts
		[] 改 Load(用擴充方法)
		[] 寫 Search

[working on]  add / Models / Services / DocService
		[] add / Models / DTOs / CreateDocRequest & EditDocRequest

[working on] add view models
[working on] modify layout page
[working on] add DocsController