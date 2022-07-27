using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class QuestionManager:IQuestionService
    {
         IQuestionDal _questionDal;
         public QuestionManager(IQuestionDal questionDal)
         {
             _questionDal = questionDal;
         }

         public IDataResult<List<Question>> GetAll()
         {
             return new SuccessDataResult<List<Question>>(_questionDal.GetAll());
         }

         public IResult Add(Question question)
         {
             _questionDal.Add(question);
             return new SuccessResult();
         }
    }
}
