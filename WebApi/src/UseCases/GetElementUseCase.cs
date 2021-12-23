using System.Collections.Generic;
using WebApi.src.Models;
using WebApi.src.Persistence;

namespace WebApi.src.UseCases
{
    public class GetElementUseCase : IGetElementUseCase
    {
        private readonly IElementRepository _elementRepository;

        public GetElementUseCase(IElementRepository elementRepository)
        {
            _elementRepository = elementRepository;
        }

        public List<Element> GetAll()
        {
            return _elementRepository.FindAll();
        }
    }
}