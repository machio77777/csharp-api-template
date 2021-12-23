using System.Collections.Generic;
using WebApi.src.Models;

namespace WebApi.src.UseCases
{
    public interface IGetElementUseCase
    {
        List<Element> GetAll();
    }
}