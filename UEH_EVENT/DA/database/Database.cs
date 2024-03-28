using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class Database
{
    static Database()
    {
        DropDatabase();
        CreateDatabase();
    }
    public static void CreateDatabase()
    {
        using (var dbcontext = new UehEventContext())
        {
            string dbname = dbcontext.Database.GetDbConnection().Database;

            var kq = dbcontext.Database.EnsureCreated();
            if (kq)
            {
                Console.WriteLine($"created {dbname}");
            }
            else
            {
                Console.WriteLine("created fail");
            }
        }
    }
    public static void DropDatabase()
    {
        using (var dbcontext = new UehEventContext())
        {
            string dbname = dbcontext.Database.GetDbConnection().Database;

            var kq = dbcontext.Database.EnsureDeleted();
            if (kq)
            {
                Console.WriteLine($"dropped {dbname}");
            }
            else
            {
                Console.WriteLine($"drop {dbname} fail");
            }
        }
    }
    public static List<T> Query<T>(bool isLoadNav = false) where T : class
    {
        using (var dbcontext = new UehEventContext())
        {
            var dbset = Util.GetProp<DbSet<T>>(dbcontext, typeof(T).ToString());

            if (dbset == null) return new List<T>();

            if (!isLoadNav) return dbset.ToList();

            var navigationProps = dbcontext.Model.FindEntityType(typeof(T))?.GetNavigations();

            if (navigationProps == null) return dbset.ToList();

            var query = dbset.AsQueryable();
            foreach (var navigationProp in navigationProps)
            {
                query = query.Include(navigationProp.Name);
            }

            var resultList = query.ToList();

            return resultList;
        }
    }
    public static T? QueryByKey<T>(object key) where T : class
    {
        using (var dbcontext = new UehEventContext())
        {
            var entityType = dbcontext.Model.FindEntityType(typeof(T));
            if (entityType == null) { return null; }

            var pkName = entityType.FindPrimaryKey()?.Properties?.FirstOrDefault()?.Name;
            if (pkName == null) { return null; }

            //Create Expresion Lamda
            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, pkName);
            var constant = Expression.Constant(key);
            var equals = Expression.Equal(property, constant);
            var lambda = Expression.Lambda<Func<T, bool>>(equals, parameter);

            var navigationProps = entityType?.GetNavigations();
            var query = dbcontext.Set<T>().AsQueryable();

            var result = query.SingleOrDefault(lambda);

            if (result != null && navigationProps != null)
            {
                foreach (var item in navigationProps)
                {
                    dbcontext.Entry(result).Navigation(item.Name).Load();
                }
            }

            return result == null ? default : result;
        }
    }
    public static T? Query<T>(string filterer, string prop, bool isLoadNav = false) where T : class
    {
        using (var dbcontext = new UehEventContext())
        {
            var entityType = dbcontext.Model.FindEntityType(typeof(T));
            if (entityType == null) { return null; }

            var pkName = entityType.FindPrimaryKey()?.Properties?.FirstOrDefault()?.Name;
            if (pkName == null) { return null; }

            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, prop);
            var constant = Expression.Constant(filterer);
            var equals = Expression.Equal(property, constant);
            var lambda = Expression.Lambda<Func<T, bool>>(equals, parameter);

            var navigationProps = entityType?.GetNavigations();
            var query = dbcontext.Set<T>().AsQueryable();

            var result = query.SingleOrDefault(lambda);

            if (result != null && navigationProps != null && isLoadNav == true)
            {
                foreach (var item in navigationProps)
                {
                    dbcontext.Entry(result).Navigation(item.Name).Load();
                }
            }

            return result == null ? default : result;
        }
    }
    public static List<T>? Query<T>(Filterer filterer, bool multiSearch = false, bool isLoadNav = false) where T : class
    {
        using (var dbcontext = new UehEventContext())
        {
            var entityType = dbcontext.Model.FindEntityType(typeof(T));
            if (entityType == null) { return null; }

            Expression conditions = null!;
            var parameter = Expression.Parameter(typeof(T), "x");
            //(x)=>
            for (int i = 0; i < filterer.Count(); i++)
            {
                var property = Expression.Property(parameter, filterer.GetProp(i));
                //(x)=> x.type[i]  filterer
                var constant = Expression.Constant(filterer.GetValue(i));
                //(x)=> x.type[i] == filterer
                Expression condition = null!;
                switch (filterer.GetFilterType(i))
                {
                    case Filterer.FilterType.Equal:
                        condition = Expression.Equal(property, constant);
                        break;
                    case Filterer.FilterType.GreaterThan:
                        condition = Expression.GreaterThan(property, constant);
                        break;
                    case Filterer.FilterType.LessThan:
                        condition = Expression.LessThan(property, constant);
                        break;
                }

                if (conditions == null)
                {
                    conditions = condition;
                }
                else
                {
                    conditions = Expression.AndAlso(conditions, condition);
                }
            }
            if (conditions == null) return null;
            var lambda = Expression.Lambda<Func<T, bool>>(conditions, parameter);

            var navigationProps = entityType?.GetNavigations();
            var query = dbcontext.Set<T>().AsQueryable();

            var result = query.Where(lambda).ToList();
            if (result != null && navigationProps != null && !isLoadNav)
            {
                foreach (var item in result)
                {
                    foreach (var prop in navigationProps)
                    {
                        dbcontext.Entry(item).Navigation(prop.Name).Load();
                    }
                }
            }
            return result;
        }
    }
    public static void Insert<T>(T item) where T : class
    {
        InsertInternal(new List<T> { item });
    }
    public static void Insert<T>(List<T> items) where T : class
    {
        InsertInternal(items);
    }
    private static void InsertInternal<T>(List<T> items) where T : class
    {
        using (var dbcontext = new UehEventContext())
        {
            var dbset = Util.GetProp<DbSet<T>>(dbcontext, typeof(T).ToString());
            if (dbset == null) return;

            dbset.AddRange(items);
            dbcontext.SaveChanges();
        }
    }
    public static void Delete<T>(object itemId) where T : class
    {
        using (var dbcontext = new UehEventContext())
        {
            var dbset = Util.GetProp<DbSet<T>>(dbcontext, typeof(T).ToString());
            if (dbset == null) return;

            var item = dbset.Find(itemId);

            if (item == null) return;

            dbset.Remove(item);
            dbcontext.SaveChanges();
        }
    }
    public static void Delete<T>(T item) where T : class
    {
        using (var dbcontext = new UehEventContext())
        {
            var dbset = Util.GetProp<DbSet<T>>(dbcontext, typeof(T).ToString());
            if (dbset == null) return;

            dbset.Remove(item);
            dbcontext.SaveChanges();
        }
    }
    public static void Update<T>(T item) where T : class
    {
        using (var dbcontext = new UehEventContext())
        {
            dbcontext.Update(item);
            dbcontext.SaveChanges();
        }
    }
}