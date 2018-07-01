using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzMotorsport.DAL
{
    
    public class Repository
    {
        quizzmotorsportEntities _context;

        public Repository()
        {
            _context = new quizzmotorsportEntities();

            _context.Database.Log = (message) => Debug.WriteLine(message);
            // A mettre en false la majeure partie du temps
            _context.Configuration.ProxyCreationEnabled = true;
            _context.Configuration.LazyLoadingEnabled = false;
        }

        public List<question> GetQuestions()
        {
            var lesQuestions = _context.questions.ToList();

            return lesQuestions;
        }

        public List<response> GetResponses(int idQuestion)
        {
            var resultat = _context.responses.Where(resp => resp.idquestion == idQuestion);
            return resultat.ToList();
        }

    }
}
