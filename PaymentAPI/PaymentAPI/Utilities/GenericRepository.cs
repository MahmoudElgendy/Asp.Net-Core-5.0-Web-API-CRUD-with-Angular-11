  public interface IBaseRepository<T> where T : class
    {
        #region GetById
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        #endregion

        #region GetAll
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        #endregion

        #region Find
        T Find(Expression<Func<T, bool>> criteria, string[] includes = null);
        Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);
        #endregion

        #region FindAll
        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, int? take, int? skip,
            Expression<Func<T, object>> orderBy = null, string orderByDirection = OrderBy.Ascending);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int? skip, int? take,
            Expression<Func<T, object>> orderBy = null, string orderByDirection = OrderBy.Ascending);
        #endregion

        #region Count
        int Count();
        int Count(Expression<Func<T, bool>> criteria);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> criteria);
        #endregion

        #region Add
        T Add(T entity);
        Task<T> AddAsync(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        Task<IEnumerable<T>> AddRangeAsync();
        #endregion

        #region Update
        T Update(T entity);
        IEnumerable<T> UpdateRange(IEnumerable<T> entities);
        #endregion

        #region Delete
        void Delete(T entity);
        void Delete(object id);
        void DeleteRange(IEnumerable<T> entities);
        #endregion
    }
