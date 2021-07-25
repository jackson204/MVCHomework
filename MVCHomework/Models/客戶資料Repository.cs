using System;
using System.Linq;
using System.Collections.Generic;
using MVCHomework.ViewModels;
using System.Linq.Dynamic.Core;
namespace MVCHomework.Models
{
    public class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
    {
        public override IQueryable<客戶資料> All()
        {
            return base.All().Where(p => !p.IsDeleted);
        }
        public IQueryable<客戶資料> Search(客戶資料Filter filter)
        {

            var data = this.All();

            if (!String.IsNullOrEmpty(filter.keyword))
            {
                data = data.Where(p => p.客戶名稱.Contains(filter.keyword));
            }

            data = data.OrderBy(filter.sortBy + " " + filter.sortDirection);

            return data;
        }

        public 客戶資料 FindOne(int id)
        {
            return this.All().FirstOrDefault(p => p.Id == id);
        }
        public override void Delete(客戶資料 entity)
        {
            entity.IsDeleted = true;
        }
    }

    public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}