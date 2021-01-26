namespace Day5Homework.Abstract
{
    public interface IBaseService<TEntity>
    {
        public void Add(TEntity myEntity);
        public void Update(TEntity myEntity);
        public void Delete(TEntity myEntity);
    }
}
