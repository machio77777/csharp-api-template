using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using WebApi.src.Models;

namespace WebApi.src.Persistence
{
    public class ElementRepository : IElementRepository
    {
        private readonly ILogger<ElementRepository> _logger;

        public ElementRepository(ILogger<ElementRepository> logger)
        {
            _logger = logger;
        }

        public List<Element> FindAll()
        {
            List<Element> elements = new List<Element>
            {
                new Element { ElementName = "部材名1", Type = "種別1", Volume = 100, Area = 110 },
                new Element { ElementName = "部材名2", Type = "種別2", Volume = 200, Area = 210 },
                new Element { ElementName = "部材名3", Type = "種別3", Volume = 300, Area = 310 },
                new Element { ElementName = "部材名4", Type = "種別4", Volume = 400, Area = 410 },
                new Element { ElementName = "部材名5", Type = "種別5", Volume = 500, Area = 510 },
            };
            return elements;
        }
    }
}