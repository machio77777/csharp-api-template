using System.Collections.Generic;
using WebApi.src.Models;

namespace WebApi.src.Persistence
{
    public interface IElementRepository
    {
        List<Element> FindAll();
    }
}