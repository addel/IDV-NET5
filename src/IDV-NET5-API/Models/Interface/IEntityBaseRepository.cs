using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IDV_NET5_API.Models.Repository
{
    // Voir le pattern factory 
    public interface IEntityBaseRepository<MyEntity> where MyEntity : class, IEntityBase, new()
    {
        // ici j'ai créer une interface pour tout les repository (je rappel qu'un interface est une sorte de guide ligne pour les classe implémenté A NE PAS CONFONDRE AVEC L'HERITAGE)
        // On vois ici pourquoi j'ai créer une interface de mes entity, cela va me permettre un gain de code donc de temps
        // Ainsi en créant mon propre type chaque repository pouura implémenté cette interface (MyEntity == UserRepository, MovieRepository, CommentRepository)

        IEnumerable<MyEntity> AllIncluding(params Expression<Func<MyEntity, object>>[] includeProperties);
        IEnumerable<MyEntity> GetAll();
        int Count();
        MyEntity GetSingle(int id);
        MyEntity GetSingle(Expression<Func<MyEntity, bool>> predicate);
        MyEntity GetSingle(Expression<Func<MyEntity, bool>> predicate, params Expression<Func<MyEntity, object>>[] includeProperties);
        IEnumerable<MyEntity> FindBy(Expression<Func<MyEntity, bool>> predicate);
        void Add(MyEntity entity);
        void Update(MyEntity entity);
        void Delete(MyEntity entity);
        void DeleteWhere(Expression<Func<MyEntity, bool>> predicate);
        void Commit();
    }
}
