using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MessageManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Add(Message t)
        {
            await _unitOfWork.Messages.Create(t);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(Message t)
        {
             _unitOfWork.Messages.Delete(t);
             _unitOfWork.SaveAsync();
        }

        public async Task<Message> GetById(int id)
        {
            return await _unitOfWork.Messages.Get(x => x.MessageID == id);
        }

        public async Task<IEnumerable<Message>> GetList()
        {
            return await _unitOfWork.Messages.GetAll();
        }

        public async Task<IEnumerable<Message>> GetUnReadMessage()
        {
            return await _unitOfWork.Messages.GetAll(x => x.MessageStatus == false);
        }

        public void Update(Message t)
        {
            _unitOfWork.Messages.Update(t);
            _unitOfWork.SaveAsync();
        }
    }
}
