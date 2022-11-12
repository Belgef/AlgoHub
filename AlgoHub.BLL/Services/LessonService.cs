using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoHub.BLL.Services.Interfaces;
using AlgoHub.DAL.Entities;
using AlgoHub.DAL.Repository;

namespace AlgoHub.BLL.Services
{
    public class LessonService : ILessonService
    {
        private readonly IRepository<Lesson> _repository;

        public LessonService(IRepository<Lesson> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Lesson> GetTopPopularLessons(int n)
        {
            return _repository.AllIncluding(lesson => lesson.Author).OrderByDescending(l => l.Views).Take(n);
        }
    }
}
