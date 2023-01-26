using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepositories<Category> repo = new GenericRepositories<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void CategoryAddBl(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length <= 51)
            {
                //hata mesajı
            }
            else
            {
                repo.insert(p);
            }
        }
    }
}
