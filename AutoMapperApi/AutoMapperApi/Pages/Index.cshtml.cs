using AutoMapper;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoMapperApi.Pages
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

        public void OnGet()
        {
            var project = new Project();
            var projectDTO = _mapper.Map<ProjectDTO>(project); //convert project object to projectDTO;
        }
    }
}