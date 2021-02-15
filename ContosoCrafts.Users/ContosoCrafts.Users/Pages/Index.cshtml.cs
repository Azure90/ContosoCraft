using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Users.Models;
using ContosoCrafts.Users.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.Users.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileUserService UserService { get; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileUserService userService)
        {
            _logger = logger;
            UserService = userService;
        }
        public IEnumerable<User> Users { get; private set; }
        public void OnGet()
        {
            Users = UserService.GetUsers();
        }
    }
}
