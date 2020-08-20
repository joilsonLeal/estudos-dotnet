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

            var source = new Source
            {
                Value1 = "5",
                Value2 = "20/08/2020",
                Value3 = "System.Linq"
            };
            try
            {
                Destination result = _mapper.Map<Source, Destination>( source );

            }
            catch( Exception e )
            {

                throw;
            }
        }
    }
}
