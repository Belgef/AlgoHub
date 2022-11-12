using AlgoHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoHub.BLL.Services.Interfaces
{
    public interface ILessonService
    {
        public IEnumerable<Lesson> GetTopPopularLessons(int n);
    }
}
