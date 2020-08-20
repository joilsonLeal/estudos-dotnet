using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using _02.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _02.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMapper _mapper;

        public IndexModel(ILogger<IndexModel> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public async Task OnGetAsync()
        {
            // different type mapping

            var source = new Source
            {
                Value1 = "5",
                Value2 = "20/08/2020",
                Value3 = "System.Linq"
            };
            
            Destination result = _mapper.Map<Source, Destination>( source );

            // custom value resolver mapping

            var sumSource = new SumSource
            {
                Value1 = 10,
                Value2 = 11,
            };

            SumDestination sumDestination = _mapper.Map<SumSource, SumDestination>( sumSource );

        }
    }
}
