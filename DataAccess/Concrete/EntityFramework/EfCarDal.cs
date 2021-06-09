using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using ReCapContext context = new ReCapContext(); //using bitince bellekten silinir. Performans için yapılır.
            if (entity.Description.Length >= 2 && entity.DailyPrice > 0)
            {
                var addedEntity = context.Entry(entity); //Veri kaynağından nesneyi eşleştir, referansı yakala.
                addedEntity.State = EntityState.Added; //Ne yapacağını belirtiyoruz.
                context.SaveChanges(); //İşlemi yap.
            }
        }

        public void Delete(Car entity)
        {
            using ReCapContext context = new ReCapContext(); //using bitince bellekten silinir. Performans için yapılır.
            var deletedEntity = context.Entry(entity); //Veri kaynağından nesneyi eşleştir, referansı yakala.
            deletedEntity.State = EntityState.Deleted; //Ne yapacağını belirtiyoruz.
            context.SaveChanges(); //İşlemi yap.
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using ReCapContext context = new ReCapContext();
            return context.Set<Car>().SingleOrDefault(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using ReCapContext context = new ReCapContext();
            //tablodaki bütün sütunları getirir.
            //Filtre null ise product tablosunun tamamı select * from product. Null değilse filtreyi uygular.
            return filter == null
                ? context.Set<Car>().ToList()
                : context.Set<Car>().Where(filter).ToList();
        }

        public void Update(Car entity)
        {
            using ReCapContext context = new ReCapContext(); //using bitince bellekten silinir. Performans için yapılır.
            var updatedEntity = context.Entry(entity); //Veri kaynağından nesneyi eşleştir, referansı yakala.
            updatedEntity.State = EntityState.Modified; //Ne yapacağını belirtiyoruz.
            context.SaveChanges(); //İşlemi yap.
        }
    }
}
