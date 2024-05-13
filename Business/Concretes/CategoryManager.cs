using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            //ben categorymanager olarak veri erişim katmanına bağımlıyım
            //ama biraz zayıf bağımlılığım var
            //çünkü ben interface üzerinden, referans üzerinden, bağımlıyım
            //o yüzden sen DataAccess katmanında istediğin kadar at koşturabilirsin =) yeter ki kurallarıma uy
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
