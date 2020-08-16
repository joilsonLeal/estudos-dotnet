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
            var baseAddress = new Uri("https://api.jikan.moe/v3/");

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                using (var response = await httpClient.GetAsync("season/2020/winter"))
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    var animes = JsonSerializer.Deserialize<Result>(responseData, null);
                    try
                    {
                        var animesDto = _mapper.Map<List<AnimeDto>>(animes.Animes);
                    }
                    catch (Exception e)
                    {

                        throw;
                    }
                }
            }
        }
    }
}
